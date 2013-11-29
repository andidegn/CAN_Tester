using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using ECTunes.CAN;
using ECTunes.CAN.HCAN;
using ECTunes.CAN.Peak;
using ECTunes.Model;
using ECTunes.Util;

namespace ECTunes.H_CAN_tester {
	public partial class Form1 : Form {
		// !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
		// !!!!!!!!  ToDo fix search words:                   !!!!!!!!
		// !!!!!!!!     Volume offset: "OFFSET FIX"           !!!!!!!!
		// !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
		// !!!!!!!!  NOTE: Change "prefer 32-bit" depending   !!!!!!!!
		// !!!!!!!!  on which device should be used!!!        !!!!!!!!
		// !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

		/// <summary>
		/// Int determining which device is being used:
		///     0:  HCAN
		///     1:  PEAK
		///     
		/// NOTE: The setting:
		/// "Properties\Build\General\Platform Target\Prefer 32-Bit" 
		/// must be set according to the device chosen:
		///     HCAN: Ticket
		///     PEAK: Not-ticket
		/// </summary>
		private static int DEVICE = 0;
        private const String COM_PORT_IDENTIFIER = "Silicon Labs";

		/// <summary>
		/// Set true for debug
		/// </summary>
		public static bool DEBUG = false;

		private bool connected;
		private bool carSelected;
		private String car;
		private int offsetFront, offsetRear, offsetThrottle;
		private Indicator indicator;

		private IECT_CAN can;

		public Form1() {
			connected = false;
			carSelected = false;
			InitializeComponent();
			InitializeRest();
			ToggleAdvanced();
		}

		private void InitializeRest() {
			///---------------------
			///--- ComboBox Port ---
			///---------------------
			RefreshPort(COM_PORT_IDENTIFIER);

			///------------------------
			///--- ComboBox Baurate ---
			///------------------------
			BaudrateList.device = ECTunes.Util.BaudrateList.Device.HCAN;
			cbbCONBaudrate.Items.AddRange(BaudrateList.getInstance().getArray());
			int defaultIndex = 0;
			foreach (Baudrate item in cbbCONBaudrate.Items) {
				if (item.Value == 500)
					break;
				defaultIndex++;
			}
			cbbCONBaudrate.SelectedIndex = defaultIndex;

			///-----------------------
			///--- Combobox Device ---
			///-----------------------
			cbbCONDevice.SelectedIndex = DEVICE;

			///---------------------
			///--- ComboBox Type ---
			///---------------------
			cbbCONType.Items.AddRange(new String[3]{"0", "1", "2"});
			cbbCONType.SelectedIndex = 2;

			///---------------
			///--- Blinker ---
			///---------------
			indicator = new Indicator();

			///---------------
			///--- ToolTip ---
			///---------------
			ttCTRLTkb.SetToolTip(btnCTRLRpm0percent, "0%");
			ttCTRLTkb.SetToolTip(btnCTRLRpm10percent, "10%");
			ttCTRLTkb.SetToolTip(btnCTRLRpm90percent, "90%");
			ttCTRLTkb.SetToolTip(btnCTRLRpm100percent, "100%");
			ttCTRLTkb.SetToolTip(btnCTRLRpm110percent, "110%");
			ttCTRLTkb.SetToolTip(btnCTRLRpm200percent, "200%");
		}

		/// <summary>
		/// Opens a file dialog box to select the deisred xml file
		/// </summary>
		/// <returns></returns>
		private String GetLoadFilePath() {
			String path = "";

			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "XML Files (.xml;.txt)|*.xml;*.txt|All Files (*.*)|*.*";
			ofd.FilterIndex = 1;

			if (ofd.ShowDialog() == DialogResult.OK) {
				path = ofd.InitialDirectory + ofd.FileName;
			}
			return path;
		}

		/// <summary>
		/// Sets up the RPM trackbar scale
		/// </summary>
		private void SetTrackBarScales() {
			// -----------
			// --- RPM ---
			// -----------
			try {
				int max = Convert.ToInt32(CodeList.getInstance()[cbbCTRLSelCar.SelectedItem.ToString(), Signal.RPM, Param.MAX]);
				tkbCTRLRpm.Maximum = Convert.ToInt32(max * 2);
				btnCTRLRpm0percent.Text = "0";
				btnCTRLRpm10percent.Text = (max * 0.1).ToString();
				btnCTRLRpm90percent.Text = (max * 0.9).ToString();
				btnCTRLRpm100percent.Text = max.ToString();
				btnCTRLRpm110percent.Text = (max * 1.1).ToString();
				btnCTRLRpm200percent.Text = (max * 2).ToString();
			}
			catch (Exception) { }

			// --------------
			// --- Volume ---
			// --------------
			int maxFront = 0, maxRear = 0;
			offsetFront = 0; offsetRear = 0;
			if (chkVolFromXml.Checked) {// OFFSET FIX
				try {
					maxFront = Convert.ToInt32(CodeList.getInstance()[car, Signal.VOL_F, Param.MAX]);
					offsetFront = Convert.ToInt32(CodeList.getInstance()[car, Signal.VOL_F, Param.OFFSET]);
				}
				catch (Exception) { }

				try {
					maxRear = Convert.ToInt32(CodeList.getInstance()[car, Signal.VOL_R, Param.MAX]);
					offsetRear = Convert.ToInt32(CodeList.getInstance()[car, Signal.VOL_R, Param.OFFSET]);
				}
				catch (Exception) { }
			} else {
				maxFront = 255;
				offsetFront = 128;
				maxRear = 255;
				offsetRear = 128;
			}
				tkbCTRLVolFront.Maximum = maxFront - offsetFront; 
				tkbCTRLVolRear.Maximum = maxRear - offsetRear;

			// ----------------
			// --- Throttle ---
			// ----------------


			try {
				int maxThrottle = Convert.ToInt32(CodeList.getInstance()[car, Signal.THROTTLE, Param.MAX]);
				offsetThrottle = Convert.ToInt32(CodeList.getInstance()[car, Signal.THROTTLE, Param.OFFSET]);
				tkbCTRLThrottle.Maximum = maxThrottle - offsetThrottle;
			} catch (Exception) {}

			//if (DEBUG) MessageBox.Show(String.Format("max: {0} -> factor: {1}", max, factor));
		}

		/// <summary>
		/// Overloaded method of other Send method.
		/// ID has to be hex!
		/// </summary>
		/// <param name="id"></param>
		/// <param name="length"></param>
		/// <param name="data"></param>
		private void Send(String id, int length, String[] data) {
			if (id.Length > 0) {
				byte[] Databuff = new byte[8] { 0, 0, 0, 0, 0, 0, 0, 0 };

				Databuff[0] = Convert.ToByte(data[0], 16);
				Databuff[1] = Convert.ToByte(data[1], 16);
				Databuff[2] = Convert.ToByte(data[2], 16);
				Databuff[3] = Convert.ToByte(data[3], 16);
				Databuff[4] = Convert.ToByte(data[4], 16);
				Databuff[5] = Convert.ToByte(data[5], 16);
				Databuff[6] = Convert.ToByte(data[6], 16);
				Databuff[7] = Convert.ToByte(data[7], 16);
				Send(Convert.ToInt32(id, 16).ToString(), length, Databuff);
			}
		}

		private void Send(String id, CarState state) {
			Send(id, state.Length, state.DataByteArray);
		}

		/// <summary>
		/// Sends a CAN command to the HCAN based on the 3 parameters
		/// </summary>
		/// <param name="id"></param>
		/// <param name="length"></param>
		/// <param name="data"></param>
		private void Send(String id, int length, byte[] data) {
			if (connected) {
				int _id = Convert.ToInt32(id, 10);
				//Bytes = Convert.ToByte(length, 16); //This frame is 8 bytes
				can.Send(_id, length, data); //Call the send function examples
				String CanMsg = String.Format("{0}  {1:X2}  {2:X2}-{3:X2}-{4:X2}-{5:X2}-{6:X2}-{7:X2}-{8:X2}-{9:X2}",
					id, length, data[0], data[1], data[2], data[3], data[4], data[5], data[6], data[7]);
				tbxCanMsg.Text = CanMsg;
			}
		}

		/// <summary>
		/// Overload method for CheckAndSend
		/// Converts the string value to int and calls CheckAndSend
		/// </summary>
		/// <param name="signal"></param>
		/// <param name="length"></param>
		/// <param name="value"></param>
		private void CheckAndSend(String signal, int length, String value) {
			CheckAndSend(signal, length, Convert.ToInt32(value));
		}

		/// <summary>
		/// Checks for fellow ID's and sends the finished result
		/// !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
		/// !!!!!!!!!!   REMEMBER TO FIX VOL OFFSET ECT.  !!!!!!!!!!!!!!
		/// !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
		/// </summary>
		/// <param name="id"></param>
		/// <param name="length"></param>
		private void CheckAndSend(String signal, int length, int value) {
			try {
				String id = CodeList.getInstance()[car, signal, Param.ID];
				BitArray data = new BitArray(64);
				int startbit = Convert.ToInt32(CodeList.getInstance()[car, signal, Param.STARTBIT]);
				int size = Convert.ToInt32(CodeList.getInstance()[car, signal, Param.SIZE]);
				String format = CodeList.getInstance()[car, signal, Param.FORMAT];
				// Checking each signal for code-reuse
				CarStateBuffer.getInstance().UpdateState(id, length, value, startbit, size, format);
				Send(id, length, CarStateBuffer.getInstance()[id].DataByteArray);
				SetControlsState(signal, true);
			}
			catch (Exception) {
				SetControlsState(signal, false);
				//MessageBox.Show(String.Format("An error has occured while trying to\naccess the code from the XML file!\nSignal: {0}\tvalue: {1}", signal, value));
			}
		}

		/// <summary>
		/// Gets the appropriate XmlNode from an xml file
		/// </summary>
		/// <param name="filePath"></param>
		/// <returns></returns>
		private XmlNode GetXMLNodes(String filePath) {
			XmlDocument xd = new XmlDocument();
			xd.Load(filePath);
			return xd.SelectSingleNode("/Root/ConfigsFinal");
		}

		#region Connections

		/// <summary>
		/// Calling the LoadDLL and ConnectHCAN and setting the connected state accordingly
		/// </summary>
		private void Connect() {
			int port = int.Parse(cbbCONPort.SelectedItem.ToString().Substring(3));
			int baudrate = (cbbCONBaudrate.SelectedItem as Baudrate).Value;
			int type = int.Parse(cbbCONType.SelectedItem.ToString());

			String device = cbbCONDevice.SelectedItem.ToString();
			if (device == "H-CAN")
				can = new ECT_HCAN();
			else if (device == "PEAK")
				can = new ECT_Peak();

			try {
				can.Init(port, baudrate * 1000);
				SetConnectedState(true);
			} catch {
				SetConnectedState(false);
			} finally {
				SetControlPanelState();
				if (DEBUG) MessageBox.Show(String.Format("port: {0}  -> baudrate: {1}  -> type: {2}  -> connected: {3}", port, baudrate, type, (connected ? "OK" : "FAIL")));
			}
		}

		#endregion

		#region Update GUI

        /// <summary>
        /// Refreshing the COM ports and adding them to the combo box.
        /// identifier must be the first text of the COM port description
        /// </summary>
        /// <param name="identifier"></param>
        private void RefreshPort(String identifier) {
            string[] portNames = System.IO.Ports.SerialPort.GetPortNames();
            using (var searcher = new System.Management.ManagementObjectSearcher("SELECT * FROM WIN32_SerialPort")) {
                var prts = searcher.Get().Cast<System.Management.ManagementBaseObject>().ToList();
                var tList = (from n in portNames
                             join p in prts on n equals p["DeviceID"].ToString()
                             select p["Caption"] + ":" + n).ToList();
                foreach (string s in tList) {
                    if (s.Substring(0, identifier.Length).Equals(identifier)) {
                        cbbCONPort.Items.Add(s.Substring(s.LastIndexOf(':') + 1));
                    }
                }
                if (cbbCONPort.Items.Count > 0)
                    cbbCONPort.SelectedIndex = 0;
            }
        }

		/// <summary>
		/// Enabling or disabling the different components according to the connected state
		/// </summary>
		/// <param name="state"></param>
		private void SetConnectedState(bool state) {
			cbbCONPort.Enabled = !state;
			cbbCONBaudrate.Enabled = !state;
			cbbCONType.Enabled = !state;
			btnCONRefresh.Enabled = !state;
			btnCONInit.Enabled = !state;
			btnCONRelease.Enabled = state;
			cbbCONDevice.Enabled = false;

			connected = state;
		}

		/// <summary>
		/// Enabling or disabling the controls depending on if there is a car selected 
		/// and if the HCAN is connected
		/// </summary>
		private void SetControlPanelState() {
			pnlCTRLControls.Enabled = carSelected && connected;
		}

		/// <summary>
		/// Resets all the controls and sends those codes through the HCAN
		/// </summary>
		private void ClearCodesAndSend() {
            //if (!connected) return;
            CarStateBuffer.getInstance().Clear();
            btnCTRLDrive_Click(this, null);
            btnCTRLReverse_Click(this, null);
            btnCTRLNeutral_Click(this, null);
			//btnCTRLRpm0percent_Click(btnCTRLRpm0percent, null);
			//btnCTRLVolFront0percent_Click(btnCTRLVolFront0percent, null);
			//btnCTRLVolRear0percent_Click(btnCTRLVolRear0percent, null);
			//btnCTRLThrottle0percent_Click(btnCTRLThrottle0percent, null);
			tkbCTRLRpm.Value = 0;
			tkbCTRLRpm_ValueChanged(tkbCTRLRpm, null);
			tkbCTRLVolFront.Value = 0;
			tkbCTRLVolFront_ValueChanged(tkbCTRLVolFront, null);
			tkbCTRLVolRear.Value = 0;
			tkbCTRLVolRear_ValueChanged(tkbCTRLVolRear, null);
			tkbCTRLThrottle.Value = 0;
			tkbCTRLThrottle_ValueChanged(tkbCTRLThrottle, null);
			chkCTRLReady.Checked = false;
			chkCTRLReady_CheckedChanged(this, null);
			chkCTRLIce.Checked = false;
			chkCTRLIce_CheckedChanged(this, null);
			nudCTRLSIndexF.Value = 1;
			nudCTRLSIndexF_ValueChanged(this, null);
			nudCTRLSIndexR.Value = 1;
			nudCTRLSIndexR_ValueChanged(this, null);
            btnCTRLIndicatorL_Click(this, null);
            btnCTRLIndicatorR_Click(this, null);
			btnCTRLIndicatorOff_Click(this, null);
		}

		/// <summary>
		/// Disables the control for the specified signal
		/// </summary>
		/// <param name="signal"></param>
		/// <param name="state"></param>
		private void SetControlsState(String signal, bool state) {
			switch (signal) {
				case Signal.READY:      chkCTRLReady.Enabled = state;
					break;
				case Signal.ICE:        chkCTRLIce.Enabled = state;
					break;
				case Signal.DRIVE:      btnCTRLDrive.Enabled = state;
					break;
				case Signal.NEUTRAL:    btnCTRLNeutral.Enabled = state;
					break;
				case Signal.REVERSE:    btnCTRLReverse.Enabled = state;
					break;
				case Signal.RPM:        pnlCTRLRpm.Enabled = state;
					break;
				case Signal.VOL_F:      pnlCTRLVolFront.Enabled = state;
					break;
				case Signal.VOL_R:      pnlCTRLVolRear.Enabled = state;
					break;
				case Signal.THROTTLE:   pnlCTRLThrottle.Enabled = state;
					break;
				case Signal.IND_L:      btnCTRLIndicatorL.Enabled = state;
					break;
				case Signal.IND_OFF:    btnCTRLIndicatorOff.Enabled = state;
					break;
				case Signal.IND_R:      btnCTRLIndicatorR.Enabled = state;
					break;
				case Signal.SOUND_F:    pnlCTRLSIndexF.Enabled = state;
					break;
				case Signal.SOUND_R:    pnlCTRLSIndexR.Enabled = state;
					break;
				default:
					break;
			}
		}

		/// <summary>
		/// Updates the label and tooltip for the trackbars
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="lbl"></param>
		private void UpdateTrackBarLabelAndToolTip(object sender, Label lbl, bool percent) {
			int max = ((TrackBar)sender).Maximum;
			int value = ((TrackBar)sender).Value;
			if (max != 0) {
				String valueText;
				if (percent)
					valueText = (value * 100 / ((TrackBar)sender).Maximum).ToString() + "%";
				else
					valueText = value.ToString(); ;
				ttCTRLTkb.SetToolTip((TrackBar)sender, valueText);
				lbl.Text = valueText;
			}
		}

		/// <summary>
		/// Updates the car selection combo box
		/// </summary>
		private void UpdateCbbCTRLSelCar() {
			int index = cbbCTRLSelCar.SelectedIndex;
			cbbCTRLSelCar.Items.Clear();

			foreach (String s in CodeList.getInstance().GetHeaders()) {
				cbbCTRLSelCar.Items.Add(s);
			}

			cbbCTRLSelCar.SelectedIndex = index == -1 ? 0: index;
			carSelected = true;
		}

		/// <summary>
		/// Toggles the advanced features
		/// </summary>
		private void ToggleAdvanced() {
			if (btnSDAdvanced.Text == "Simple") {
				gbxSendData.Visible = false;
				gbxControls.Location = new System.Drawing.Point(12, 94);
				pnlCanMsg.Location = new System.Drawing.Point(12, 424);
				ClientSize = new System.Drawing.Size(682, 457);
				btnSDAdvanced.Text = "Advanced";
			} else {
				gbxSendData.Visible = true;
				gbxControls.Location = new System.Drawing.Point(12, 182);
				pnlCanMsg.Location = new System.Drawing.Point(12, 512);
				ClientSize = new System.Drawing.Size(682, 545);
				btnSDAdvanced.Text = "Simple";
			}
		}

		/// <summary>
		/// Sets the value of the TrackBar
		/// The factor is the value the scale is multiplied with
		/// </summary>
		/// <param name="tkb"></param>
		/// <param name="value"></param>
		/// <param name="factor"></param>
		private void SetTkbAndSend(TrackBar tkb, int value, int factor) {
			tkb.Value = value * tkb.Maximum / (factor * 100);
		}

		/// <summary>
		/// Overload method:
		/// Sets the value of the TrackBar
		/// </summary>
		/// <param name="tkb"></param>
		/// <param name="value"></param>
		private void SetTkbAndSend(TrackBar tkb, int value) {
			SetTkbAndSend(tkb, value, 1);
		}

		#endregion

		#region EventHandlers
		#region Connection Controls
		private void btnCONRefresh_Click(object sender, EventArgs e) {
			RefreshPort(COM_PORT_IDENTIFIER);
		}

		private void btnCONInit_Click(object sender, EventArgs e) {
			Connect();
		}

		private void btnCONRelease_Click(object sender, EventArgs e) {
			can.Release();
			SetConnectedState(false);
		}
		#endregion


		#region Gear Controls
		private void btnCTRLDrive_Click(object sender, EventArgs e) {
			tbxCTRLGearValue.Text = "D";
			CheckAndSend(Signal.DRIVE, (int)nudSDLength.Value, CodeList.getInstance()[car, Signal.DRIVE, Param.MATCH]);
		}

		private void btnCTRLNeutral_Click(object sender, EventArgs e) {
			tbxCTRLGearValue.Text = "N";
			CheckAndSend(Signal.NEUTRAL, (int)nudSDLength.Value, CodeList.getInstance()[car, Signal.NEUTRAL, Param.MATCH]);
		}

		private void btnCTRLReverse_Click(object sender, EventArgs e) {
			tbxCTRLGearValue.Text = "R";
			CheckAndSend(Signal.REVERSE, (int)nudSDLength.Value, CodeList.getInstance()[car, Signal.REVERSE, Param.MATCH]);
		}
		#endregion


		#region Sound Index Controls
		private void nudCTRLSIndexF_ValueChanged(object sender, EventArgs e) {
			CheckAndSend(Signal.SOUND_F, (int)nudSDLength.Value, (int)nudCTRLSIndexF.Value);
		}

		private void nudCTRLSIndexR_ValueChanged(object sender, EventArgs e) {
			CheckAndSend(Signal.SOUND_R, (int)nudSDLength.Value, (int)nudCTRLSIndexR.Value);
		}
		#endregion


		#region Indicator Controls
		private void btnCTRLIndicatorL_Click(object sender, EventArgs e) {
            Thread t = new Thread(() => indicator.Blink(btnCTRLIndicatorL, Color.DarkOrange, Color.Transparent, 400, Indicator.IndicatorSide.LEFT));
            t.Start();
			CheckAndSend(Signal.IND_L, (int)nudSDLength.Value, CodeList.getInstance()[car, Signal.IND_L, Param.MATCH]);
		}

		private void btnCTRLIndicatorR_Click(object sender, EventArgs e) {
            Thread t = new Thread(() => indicator.Blink(btnCTRLIndicatorR, Color.DarkOrange, Color.Transparent, 400, Indicator.IndicatorSide.RIGHT));
            t.Start();
			CheckAndSend(Signal.IND_R, (int)nudSDLength.Value, CodeList.getInstance()[car, Signal.IND_R, Param.MATCH]);
		}

		private void btnCTRLIndicatorOff_Click(object sender, EventArgs e) {
            Indicator.blinking = Indicator.IndicatorSide.OFF;
			btnCTRLIndicatorL.BackColor = Color.Transparent;
			btnCTRLIndicatorR.BackColor = Color.Transparent;
			CheckAndSend(Signal.IND_OFF, (int)nudSDLength.Value, CodeList.getInstance()[car, Signal.IND_OFF, Param.MATCH]);
		}
		#endregion


		#region RPM Controls
		private void tkbCTRLRpm_ValueChanged(object sender, EventArgs e) {
			UpdateTrackBarLabelAndToolTip(sender, lblCTRLRpmValue, false);
			double offset = double.Parse(CodeList.getInstance()[car, Signal.RPM, Param.OFFSET], CultureInfo.InvariantCulture.NumberFormat);
			double factor = double.Parse(CodeList.getInstance()[car, Signal.RPM, Param.FACTOR], CultureInfo.InvariantCulture.NumberFormat);

			int res = (int)((tkbCTRLRpm.Value - offset) / factor);

			CheckAndSend(Signal.RPM, (int)nudSDLength.Value, res);
		}

		private void btnCTRLRpm0percent_Click(object sender, EventArgs e) {
			SetTkbAndSend(tkbCTRLRpm, 0, 2);
		}

		private void btnCTRLRpm10percent_Click(object sender, EventArgs e) {
			SetTkbAndSend(tkbCTRLRpm, 10, 2);
		}

		private void btnCTRLRpm90percent_Click(object sender, EventArgs e) {
			SetTkbAndSend(tkbCTRLRpm, 90, 2);
		}

		private void btnCTRLRpm100percent_Click(object sender, EventArgs e) {
			SetTkbAndSend(tkbCTRLRpm, 100, 2);
		}

		private void btnCTRLRpm110percent_Click(object sender, EventArgs e) {
			SetTkbAndSend(tkbCTRLRpm, 110, 2);
		}

		private void btnCTRLRpm200percent_Click(object sender, EventArgs e) {
			SetTkbAndSend(tkbCTRLRpm, 200, 2);
		}
		#endregion


		#region Volume Front Controls
		private void tkbCTRLVolFront_ValueChanged(object sender, EventArgs e) {
			UpdateTrackBarLabelAndToolTip(sender, lblCTRLVolFrontValue, true);
			CheckAndSend(Signal.VOL_F, (int)nudSDLength.Value, tkbCTRLVolFront.Value + offsetFront);
		}

		private void btnCTRLVolFront0percent_Click(object sender, EventArgs e) {
			SetTkbAndSend(tkbCTRLVolFront, 0);
		}

		private void btnCTRLVolFront25percent_Click(object sender, EventArgs e) {
			SetTkbAndSend(tkbCTRLVolFront, 25);
		}

		private void btnCTRLVolFront50percent_Click(object sender, EventArgs e) {
			SetTkbAndSend(tkbCTRLVolFront, 50);
		}

		private void btnCTRLVolFront75percent_Click(object sender, EventArgs e) {
			SetTkbAndSend(tkbCTRLVolFront, 75);
		}

		private void btnCTRLVolFront100percent_Click(object sender, EventArgs e) {
			SetTkbAndSend(tkbCTRLVolFront, 100);
		}
		#endregion


		#region Volume Rear Controls
		private void tkbCTRLVolRear_ValueChanged(object sender, EventArgs e) {
			UpdateTrackBarLabelAndToolTip(sender, lblCTRLVolRearValue, true);
			CheckAndSend(Signal.VOL_R, (int)nudSDLength.Value, tkbCTRLVolRear.Value + offsetRear);
		}

		private void btnCTRLVolRear0percent_Click(object sender, EventArgs e) {
			SetTkbAndSend(tkbCTRLVolRear, 0);
		}

		private void btnCTRLVolRear25percent_Click(object sender, EventArgs e) {
			SetTkbAndSend(tkbCTRLVolRear, 25);
		}

		private void btnCTRLVolRear50percent_Click(object sender, EventArgs e) {
			SetTkbAndSend(tkbCTRLVolRear, 50);
		}

		private void btnCTRLVolRear75percent_Click(object sender, EventArgs e) {
			SetTkbAndSend(tkbCTRLVolRear, 75);
		}

		private void btnCTRLVolRear100percent_Click(object sender, EventArgs e) {
			SetTkbAndSend(tkbCTRLVolRear, 100);
		}
		#endregion


		#region Throttle Controls
		private void tkbCTRLThrottle_ValueChanged(object sender, EventArgs e) {
			UpdateTrackBarLabelAndToolTip(sender, lblCTRLThrottleValue, true);
			CheckAndSend(Signal.THROTTLE, (int)nudSDLength.Value, tkbCTRLThrottle.Value + offsetThrottle);
		}

		private void btnCTRLThrottle0percent_Click(object sender, EventArgs e) {
			SetTkbAndSend(tkbCTRLThrottle, 0);
		}

		private void btnCTRLThrottle25percent_Click(object sender, EventArgs e) {
			SetTkbAndSend(tkbCTRLThrottle, 25);
		}

		private void btnCTRLThrottle50percent_Click(object sender, EventArgs e) {
			SetTkbAndSend(tkbCTRLThrottle, 50);
		}

		private void btnCTRLThrottle75percent_Click(object sender, EventArgs e) {
			SetTkbAndSend(tkbCTRLThrottle, 75);
		}

		private void btnCTRLThrottle100percent_Click(object sender, EventArgs e) {
			SetTkbAndSend(tkbCTRLThrottle, 100);
		}
		#endregion

		private void btnSDSend_Click(object sender, EventArgs e) {
			Send(tbxSDID.Text, (int)nudSDLength.Value, new String[] { tbxSDB0.Text, tbxSDB1.Text, tbxSDB2.Text, tbxSDB3.Text, tbxSDB4.Text, tbxSDB5.Text, tbxSDB6.Text, tbxSDB7.Text });
		}

		private void btnCTRLLoadFile_Click(object sender, EventArgs e) {
			String path = GetLoadFilePath();
			if (path.Length > 0) {
				CodeList.getInstance().PopulateList(GetXMLNodes(path));
				tbxCTRLXml.Text = CodeList.getInstance().ToString();
				UpdateCbbCTRLSelCar();
				SetControlPanelState();
			}
		}

		private void cbbCTRLSelCar_SelectedIndexChanged(object sender, EventArgs e) {
			car = cbbCTRLSelCar.SelectedItem.ToString();
			SetTrackBarScales();
			ClearCodesAndSend();
		}

		private void chkCTRLReady_CheckedChanged(object sender, EventArgs e) {
			CheckAndSend(Signal.READY, (int)nudSDLength.Value, chkCTRLReady.Checked ? CodeList.getInstance()[car, Signal.READY, Param.MATCH] : "0");
		}

		private void chkCTRLIce_CheckedChanged(object sender, EventArgs e) {
			CheckAndSend(Signal.ICE, (int)nudSDLength.Value, chkCTRLIce.Checked ? CodeList.getInstance()[car, Signal.ICE, Param.MATCH] : "0");
		}

		private void btnSDAdvanced_Click(object sender, EventArgs e) {
			ToggleAdvanced();
		}

		#endregion

		private void chkVolFromXml_CheckedChanged(object sender, EventArgs e) {
			SetTrackBarScales();
		}

		private void chkDebug_CheckedChanged(object sender, EventArgs e) {
			DEBUG = chkDebug.Checked;
		}
	}
}
