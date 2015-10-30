using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeTeerling
{
    public class TeerlingModel
    {
        private int maxAantal = 3;
        public int MaxAantal
        {
            get
            {
                return maxAantal;
            }

            set
            {
                maxAantal = value;
            }
        }

        private int aantalTeerlingen = 5;
        public int AantalTeerlingen
        {
            get
            {
                return aantalTeerlingen;
            }

            set
            {
                aantalTeerlingen = value;
            }
        }

        private int _aantalOgen;
        public int AantalOgen
        {
            get
            {
                return _aantalOgen;
            }
            set
            {
                _aantalOgen = value;
            }
        }

        private Boolean _click = true;
        public Boolean Click
        {
            get
            {
                return _click;
            }
            set
            {
                _click = value;
            }
        }
        
    }
}
