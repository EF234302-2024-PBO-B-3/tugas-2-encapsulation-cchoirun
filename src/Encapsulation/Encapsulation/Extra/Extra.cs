using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Extras

/*
 * Tuliskan spesifikasi soal Anda disini. 
 * Kelas yang dibuat, atribut apa saja yang dibutuhkan, metode apa saja yang dibutuhkan, validasi atau aturan apa yang harus dilakukan.
 */
// Spesifikasi Soal:**

// Kelas: Extra

//Atribut:
//1. Brand (string) 
//2. Model (string) 
//3. FuelLevel (double)

//Metode:
//1. Constructor: Inisialisasi Brand, Model, dan FuelLevel dengan validasi.
//2. Refuel(double amount): Menambah bahan bakar, hanya jika amount > 0.
//3. Drive(double distance): Kurangi bahan bakar berdasarkan jarak (1 liter per 10 km), hanya jika bahan bakar cukup.
//4. DisplayStatus(): Menampilkan Brand, Model, dan FuelLevel.

//Aturan Validasi:
//- Brand dan Model harus valid string, default Unknown jika tidak.
//- FuelLevel tidak boleh negatif, default ke 0 jika negatif.


// Tulis disini


/*
 * Implementasikan solusi kelas dari soal Anda disini dan eksekusi implementasinya di Program.cs
 */

// Tulis disini

{
    public class Extra
    {
        private string _brand;
        private string _model;
        private double _fuelLevel;

        public string Brand
        {
            get { return _brand; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _brand = value;
                else
                    _brand = "Unknown";
            }
        }

        public string Model
        {
            get { return _model; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _model = value;
                else
                    _model = "Unknown";
            }
        }

        public double FuelLevel
        {
            get { return _fuelLevel; }
            private set
            {
                if (value >= 0)
                    _fuelLevel = value;
            }
        }

        public Extra(string brand, string model, double fuelLevel)
        {
            Brand = brand;
            Model = model;
            FuelLevel = fuelLevel >= 0 ? fuelLevel : 0;
        }

        public void Refuel(double amount)
        {
            if (amount > 0)
                FuelLevel += amount;
        }

        public bool Drive(double distance)
        {
            double fuelNeeded = distance / 10.0;
            if (FuelLevel >= fuelNeeded)
            {
                FuelLevel -= fuelNeeded;
                return true;
            }
            return false;
        }

        public void DisplayStatus()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}, Fuel Level: {FuelLevel} liters");
        }
    }
}
