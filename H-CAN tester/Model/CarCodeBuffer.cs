using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECTunes.Model {
    public class CarStateBuffer {
        private Dictionary<String, CarState> dict;
        private static CarStateBuffer instance;

        #region Indexer
        public CarState this[String ID] {
            get { 
                if (dict.ContainsKey(ID))
                    return dict[ID];
                return null;
            }
            private set {
                dict[ID] = value;
            }
        }
        #endregion

        private CarStateBuffer() {
            dict = new Dictionary<string, CarState>();
        }

        public static CarStateBuffer getInstance() {
            if (instance == null)
                instance = new CarStateBuffer();
            return instance;
        }

        public void UpdateState(String id, int length, int value, int startbit, int size, String format) {
            if (dict.ContainsKey(id)) {
                dict[id].UpdateState(length, value, startbit, size, format);
            } else {
                dict[id] = new CarState(length, value, startbit, size, format);
            }
        }

        public void Clear() {
            instance = new CarStateBuffer();
        }

        public bool ContainsKey(String id) {
            return dict.ContainsKey(id);
        }

        public Dictionary<String, CarState> Copy() {
            return new Dictionary<string, CarState>(dict);
        }
    }

    public class CarState {
        private int _length;
        private BitArray _data;

        #region Get Set
        public int Length {
            get { return _length; }
            set { _length = value; }
        }

        public BitArray Data {
            get { return _data; }
            set { _data = value; }
        }

        public byte[] DataByteArray {
            get { return ToByteArray(_data); }
        }
        #endregion

        public CarState(int length, int value, int startbit, int size, String format) {
            this._data = new BitArray(64);
            UpdateState(length, value, startbit, size, format);
        }

        /// <summary>
        /// Convertes a BitArray to a byte array
        /// </summary>
        /// <param name="bits"></param>
        /// <returns></returns>
        public static byte[] ToByteArray(BitArray bits) {
            int numBytes = bits.Count / 8;
            if (bits.Count % 8 != 0) numBytes++;

            byte[] bytes = new byte[numBytes];
            int byteIndex = 0, bitIndex = 0;

            for (int i = 0; i < bits.Count; i++) {
                if (bits[i])
                    bytes[byteIndex] |= (byte)(1 << (bitIndex));

                bitIndex++;
                if (bitIndex == 8) {
                    bitIndex = 0;
                    byteIndex++;
                }
            }

            return bytes;
        }

        public void UpdateState(int length, int value, int startbit, int size, String format) {
            this.Length = length;
            BitArray data1 = new BitArray(new int[] { value });

            for (int i = 0, j = 0; i < size; i++) {
                _data[startbit + j] = data1[i];
                // Checking if format is motorola, if yes, reverses bytes
                j++;
                if (format.Equals(Param.MOTOROLA) && (startbit + j) % 8 == 0)
                    j -= 16;
            }
        }

        public override String ToString() {
            byte[] db = ToByteArray(_data);
            return String.Format("{0}  {1}-{2}-{3}-{4}-{5}-{6}-{7}-{8}", Length, db[0], db[1], db[2], db[3], db[4], db[5], db[6], db[7]);
        }
    }
}
