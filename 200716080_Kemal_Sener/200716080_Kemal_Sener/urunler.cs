using System;
using System.Collections.Generic;
using System.Text;

namespace _200716080_Kemal_Sener
{
    class urunler
    {
        int _en = 0;
        int _boy = 0;
        int _yuksek = 0;

        
        public int en { get { return _en; } set { _en = value; } }
        public int boy { get { return _boy; } set { _boy = value; } }
        public int yuksek { get { return _yuksek; } set { _yuksek = value; } }
        public int hacim { get { return _en * _boy * _yuksek; } }
        public bool gıda { get; }
    }
}
