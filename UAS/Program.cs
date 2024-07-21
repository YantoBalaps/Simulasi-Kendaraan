using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS
{
    class Program
    {
        static void Main(string[] args)
        {
            Mobil mobilku = new Mobil { Merek = "Toyota", Model = "Alphard", JumlahPintu = 4 };
            Motor motorku = new Motor { Merek = "Honda", Model = "Beat", AdaBoncengan = true };

            int pilihan;

            do
            {
                Console.WriteLine("Menu Kendaraan:");
                Console.WriteLine("1. Hitung kecepatan maksimum mobil");
                Console.WriteLine("2. Hitung kecepatan maksimum motor");
                Console.WriteLine("3. Hitung Konsumsi Bahan Bakar");
                Console.WriteLine("4. Simulasi Balapan");
                Console.WriteLine("5. Keluar");
                Console.Write("Pilih menu: ");

                if (int.TryParse(Console.ReadLine(), out pilihan))
                {
                    switch (pilihan)
                    {
                        case 1:
                            // Kode untuk menghitung kecepatan maksimum mobil
                            Console.WriteLine("Kecepatan maksimum mobilku: " + mobilku.HitungKecepatanMaksimum() + " km/jam");
                            break;
                        case 2:
                            // Kode untuk menghitung kecepatan maksimum motor
                            Console.WriteLine("Kecepatan maksimum motorku: " + motorku.HitungKecepatanMaksimum() + " km/jam");
                            break;
                        case 3:
                            try
                            {
                                Console.Write("Masukkan jarak tempuh (km): ");
                                double jarak = double.Parse(Console.ReadLine());
                                Console.Write("Masukkan kapasitas tangki (liter): ");
                                double kapasitasTangki = double.Parse(Console.ReadLine());

                                double konsumsiBB = HitungKonsumsiBB(jarak, kapasitasTangki);
                                Console.WriteLine("Konsumsi bahan bakar: " + konsumsiBB + " liter/100km");
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Input tidak valid. Masukkan angka.");
                            }
                            break;
                        case 4:
                            Console.WriteLine("Mulai Balapan!");
                            Balapan.MulaiBalapan(mobilku, motorku);
                            break;
                        default:
                            Console.WriteLine("Pilihan tidak valid.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Input tidak valid. Masukkan angka.");
                }
            } while (pilihan != 5);
        }

        static double HitungKonsumsiBB(double jarak, double kapasitasTangki)
        {
            // Asumsikan konsumsi rata-rata 10 km/liter
            double konsumsiPerLiter = 10;
            double konsumsi = jarak / konsumsiPerLiter;
            return konsumsi;
        }

        static double HitungJarakTempuh(Kendaraan kendaraan, double jarak, double waktu)
        {
            return kendaraan.HitungKecepatanMaksimum() * waktu;
        }
    }
}
