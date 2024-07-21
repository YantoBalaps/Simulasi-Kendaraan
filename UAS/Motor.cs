using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS
{
    class Motor : Kendaraan
    {
        public bool AdaBoncengan { get; set; }

        public override double HitungKecepatanMaksimum()
        {
            // Logika untuk menghitung kecepatan maksimum motor
            return 120;
        }
    }
}
