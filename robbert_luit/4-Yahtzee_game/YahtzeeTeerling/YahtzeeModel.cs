 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeTeerling
{
    public class YahtzeeModel
    {
        private int tijdelijkeMax = 3;
        public int TijdelijkeMax
        {
            get
            {
                return tijdelijkeMax;
            }

            set
            {
                tijdelijkeMax = value;
            }
        }

        private int aantalWorpen;
        public int AantalWorpen
        {
            get
            {
                return aantalWorpen;
            }
            set
            {
                aantalWorpen = value;
            }
        }

        private int aantal_worpen = 4;
        public int Aantal_worpen
        {
            get
            {
                return aantal_worpen;
            }

            set
            {
                aantal_worpen = value;
            }
        }

        private int maxWorpen = 3;
        public int MaxWorpen
        {
            get
            {
                return maxWorpen;
            }

            set
            {
                maxWorpen = value;
            }
        }
    }
}
