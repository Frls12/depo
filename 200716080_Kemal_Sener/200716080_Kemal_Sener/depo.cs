using System;
using System.Collections.Generic;
using System.Text;

namespace _200716080_Kemal_Sener
{
    class depo
    {
        int _kapasite = 0;
        int mevcutkap = 0;
        string _imalat = "0.0.0";
        public string imalat { get { return _imalat; } }
        public int kapasite { get { return _kapasite; } }
        public int mevcutkapasite { get { return mevcutkap - _kapasite; } }



        public depo()
        {
            _kapasite = 50000;
            _imalat = "1.1.2020";

        }
    }
}
