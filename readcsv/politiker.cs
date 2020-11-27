using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readcsv
{
    class politiker
    {
        public string navn;
        public string parti { get; set; }
        public string email;
        public string mobil;

        static int _antalinstancer = 0;

     
        public override string ToString() // skal overrides fra den arvede klasse - object.tostring()
        {
            return "lokal tostring () - hej fra instansen";
        }
        public politiker()
        {
            _antalinstancer++;
        }
        static public int getinstancer()
        {
            return _antalinstancer;
        }
        public static bool Afstemning()
        {
            Random random = new Random();
            int Random = random.Next(10);
            if (Random >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
