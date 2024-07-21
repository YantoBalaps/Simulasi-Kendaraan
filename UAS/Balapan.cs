using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS
{
    class Balapan
    {
        public static void MulaiBalapan(Kendaraan kendaraan1, Kendaraan kendaraan2)
        {
            Random random = new Random();
            double kecepatan1 = kendaraan1.HitungKecepatanMaksimum() * random.NextDouble() * 0.8 + kendaraan1.HitungKecepatanMaksimum() * 0.2;
            double kecepatan2 = kendaraan2.HitungKecepatanMaksimum() * random.NextDouble() * 0.8 + kendaraan2.HitungKecepatanMaksimum() * 0.2;

            Console.WriteLine($"Kecepatan {kendaraan1.GetType().Name}: {kecepatan1} km/jam");
            Console.WriteLine($"Kecepatan {kendaraan2.GetType().Name}: {kecepatan2} km/jam");

            if (kecepatan1 > kecepatan2)
            {
                Console.WriteLine($"{kendaraan1.GetType().Name} menang!");
            }
            else if (kecepatan2 > kecepatan1)
            {
                Console.WriteLine($"{kendaraan2.GetType().Name} menang!");
            }
            else
            {
                Console.WriteLine("Seri!");
            }
        }
    }
}
