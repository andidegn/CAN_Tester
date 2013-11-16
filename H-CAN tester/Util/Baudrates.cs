using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECTunes.Util {
    public class BaudrateList {
        private static Baudrate[] rates;
        private static BaudrateList list;

        public static Device device = Device.NOT_SET;

        public enum Device {
            NOT_SET,
            HCAN
        };

        private BaudrateList(Device device) {
            if (device == Device.HCAN) {
                rates = new Baudrate[17] {
                    new Baudrate("5 kBit/Sec", 5), 
                    new Baudrate("10 kBit/Sec", 10), 
                    new Baudrate("15 kBit/Sec", 15), 
                    new Baudrate("20 kBit/Sec", 20), 
                    new Baudrate("25 kBit/Sec", 25), 
                    new Baudrate("40 kBit/Sec", 40), 
                    new Baudrate("50 kBit/Sec", 50), 
                    new Baudrate("80 kBit/Sec", 80), 
                    new Baudrate("100 kBit/Sec", 100), 
                    new Baudrate("125 kBit/Sec", 125), 
                    new Baudrate("200 kBit/Sec", 200), 
                    new Baudrate("250 kBit/Sec", 250), 
                    new Baudrate("400 kBit/Sec", 400), 
                    new Baudrate("500 kBit/Sec", 500), 
                    new Baudrate("666.7 kBit/Sec", 667), 
                    new Baudrate("800 kBit/Sec", 800), 
                    new Baudrate("1 MBit/Sec", 1000)
                };
            }
        }

        public static BaudrateList getInstance() {
            if (device == Device.NOT_SET)
                return null;
            if (list == null)
                list = new BaudrateList(device);
            return list;
        }

        public Baudrate[] getArray() {
            int length = rates.Length;
            Baudrate[] ret = new Baudrate[length];
            Array.Copy(rates, ret, length);
            return ret;
        }
    }



    public class Baudrate {
        private String _name;
        private int _value;

        public String Name {
            get { return _name; }
        }

        public int Value {
            get { return _value; }
        }

        public Baudrate(String name, int value) {
            _name = name;
            _value = value;
        }

        //public override bool Equals(object obj) {
        //    Baudrate o = obj as Baudrate;
        //    return _value == o.Value;
        //}

        public override String ToString() {
            return Name;
        }
    }
}
