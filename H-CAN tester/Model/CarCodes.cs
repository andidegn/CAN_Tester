using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;

namespace ECTunes.Model {

    /// <summary>
    /// Class holding constants for the signals inside each car
    /// </summary>
    public class Signal {
        public const String READY = "ready";
        public const String DRIVE = "drive";
        public const String NEUTRAL = "neutral";
        public const String REVERSE = "reverse";
        public const String IND_L = "left";
        public const String IND_R = "right";
        public const String IND_OFF = "noturn";
        public const String VOL_F = "front";
        public const String VOL_R = "rear";
        public const String SOUND_F = "soundfront";
        public const String SOUND_R = "soundrear";
        public const String THROTTLE = "throttle";
        public const String ICE = "ice";
        public const String RPM = "rpm";
    }

    /// <summary>
    /// Class holding constants for the parameters inside each signal
    /// </summary>
    public class Param {
        public const String TYPE = "type";
        public const String ID = "id";
        public const String STARTBIT = "startbit";
        public const String SIZE = "size";
        public const String FORMAT = "format";
        public const String SIGNED = "signed";
        public const String FACTOR = "factor";
        public const String OFFSET = "offset";
        public const String MIN = "min";
        public const String MAX = "max";
        public const String MATCH = "match";
        public const String MOTOROLA = "motorola";
        public const String INTEL = "intel";
    }

    /// <summary>
    /// List containing all the xml signal codes
    /// </summary>
    public class CodeList {

        private Dictionary<String, Dictionary<String, Dictionary<String, String>>> dict;
        private static CodeList codeList;

        private CodeList() {
            dict = new Dictionary<string, Dictionary<string, Dictionary<string, string>>>();
        }

        public static CodeList getInstance() {
            if (codeList == null)
                codeList = new CodeList();
            return codeList;
        }

        #region Indexer
        public String this[String car, String signal, String param] {
            get {
                if (dict.ContainsKey(car) && dict[car].ContainsKey(signal) && dict[car][signal].ContainsKey(param))
                    return dict[car][signal][param];
                return null;
            }
        }
        #endregion

        #region Add To List
        public void PopulateList(XmlNode manufacturer) {
            String _name;

            foreach (XmlNode node in manufacturer.ChildNodes) {

                _name = node.Name;
                if (_name.Length > 1) {
                    foreach (XmlNode model in node.ChildNodes) {
                    Dictionary<String, Dictionary<String, String>> cc = new Dictionary<string, Dictionary<string, string>>();

                        String _name_model = _name + " " + model.Name;
                        if (ECTunes.H_CAN_tester.Form1.DEBUG) System.Windows.Forms.MessageBox.Show(_name_model);
                        foreach (XmlNode paramType in model.ChildNodes) {

                            if (paramType.Name.Equals("Signals")) {
                                foreach (XmlNode signal_type in paramType.ChildNodes) {

                                    Dictionary<String, String> cv = new Dictionary<string, string>();
                                    foreach (XmlNode signal in signal_type) {
                                        cv[signal.Name] = signal.InnerText;
                                    }
                                    cc[Regex.Replace(signal_type.Name, @"\d", "")] = cv;
                                }
                            }
                        }
                        dict[_name_model] = cc;
                    }
                }
            } 
        }

        public void AddCode(String name, Dictionary<String, Dictionary<String, String>> code) {
            dict.Add(name, code);
        }
        #endregion

        public String[] GetHeaders() {
            return dict.Keys.ToArray<String>();
        }

        public override String ToString() {
            StringBuilder sb = new StringBuilder("CodeList:");
            foreach (KeyValuePair<String, Dictionary<String, Dictionary<String, String>>> item in dict) {
                sb.Append(String.Format("\r\nCar:\t{0}", item.Key));
                foreach (KeyValuePair<String, Dictionary<String, String>> i2 in item.Value) {
                    sb.Append(String.Format("\r\n\tvalues:\t{0}", i2.Key));
                    foreach (KeyValuePair<String, String> i3 in i2.Value) {
                        sb.Append(String.Format("\r\n\t\t{0}:\t{1}", i3.Key, i3.Value));
                    }
	            }
            }
            return sb.ToString();
        }
    }
}
