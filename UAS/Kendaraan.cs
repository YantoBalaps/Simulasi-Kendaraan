using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS
{
    abstract class Kendaraan
    {
        public string Merek { get; set; }
        public string Model { get; set; }

        // Metode abstrak untuk menghitung kecepatan maksimum
        public abstract double HitungKecepatanMaksimum();

        public double HitungJarakTempuh(double kecepatan, double waktu)
        {
            return kecepatan * waktu;
        }

        public double HitungKonsumsiBB(double jarak, double kapasitasTangki)
        {
            // Asumsikan konsumsi rata-rata 10 km/liter
            double konsumsiPerLiter = 10;
            return jarak / konsumsiPerLiter;
        }
    }
}
