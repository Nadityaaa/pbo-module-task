//NAMA  : NADITYA PUTRI LESTARI 
//NIM   : 222410103003
//KELAS : C

using LAPTOP;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Laptop laptop1, laptop2;
        Predator predator;
  
        laptop1 = new Vivobook(new VGA.Nvidia(),new PROCESSOR.CoreI5());
        laptop2 = new IdeaPad(new VGA.AMD(), new PROCESSOR.Ryzen());
        predator = new Predator(new VGA.AMD(), new PROCESSOR.CoreI7());

        //Soal 1. Jalankan method LaptopDinyalakan() dan Laptop Dimatikan() pada laptop2. [SUCCEED]
        laptop2.laptopDinyalakan();
        laptop2.LaptopDimatikan();

        //Soal 2. Jalankan method Ngoding() pada laptop1. [ERROR]
        laptop1.Ngoding();

        //Soal 3. Tampilkan di console spesifikasi (merk vga, merk processor, tipe processor)apa yang digunakan laptop1. [SUCCEED]
        Console.WriteLine($"Merk VGA : {laptop1.vga.merk}");
        Console.WriteLine($"Merk Processor : {laptop1.processor.merk}");
        Console.WriteLine($"Tipe Processor : {laptop1.processor.tipe}");

        //Soal 4. Jalankan method BermainGame() pada predator. [SUCCEED]
        predator.BermainGame();

        //Soal 5. Buatlah sebuah variabel acer bertipe data ACER, kemudian masukkan objek Predator sebagai nilainya. Jalankan method BermainGame() pada acer. [ERROR]
        ACER acer = predator;
        acer.BermainGame();

    }
}

namespace PROCESSOR
{
    class Processor
    {
        public string merk;
        public string tipe;

        public string Merk
        {
            get { return merk; }
            set { merk = value; }
        }
        public string Tipe
        {
            get { return tipe; }
            set { tipe = value; }
        }
    }
    class Intel : Processor
    {
        public Intel()
        {
            Merk = "Intel";
        }
    }
    class AMD : Processor
    {
        public AMD()
        {
            Merk = "AMD";
        }
    }
    class CoreI3 : Intel
    {
        public CoreI3()
        {
            Tipe = "Core i3";
        }
    }
    class CoreI5 : Intel
    {
        public CoreI5()
        {
            Tipe = "Core i5";
        }
    }
    class CoreI7 : Intel
    {
        public CoreI7()
        {
            Tipe = "Core i7";
        }
    }
    class Ryzen : AMD
    {
        public Ryzen()
        {
            Tipe = "RYZON";
        }
    }
    class Athlon : AMD
    {
        public Athlon()
        {
            Tipe = "ATHLON";
        }
    }
}

namespace VGA
{
    class Vga
    {
        public string merk;

        public string Merk
        {
            get { return merk; }
            set { merk = value; }
        }
    }
    class Nvidia : Vga
    {
        public Nvidia()
        {
            Merk = "Nvidia";
        }
    }
    class AMD : Vga
    {
        public AMD()
        {
            Merk = "AMD";
        }
    }
}

namespace LAPTOP
{
    using PROCESSOR;
    using System;
    using VGA;
    class Laptop
    {
        public string merk;
        public string tipe;
        public Vga vga;
        public Processor processor;

        public Laptop(string merk, string tipe, Vga vga, Processor processor)
        {
            this.merk = merk;
            this.tipe = tipe;
            this.vga = vga;
            this.processor = processor;
        }
        public void laptopDinyalakan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} menyala");
        }
        public void LaptopDimatikan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} mati");
        }
    }
    class ASUS : Laptop
    {
        public ASUS(string tipe, Vga vga, Processor processor) : base("ASUS", tipe, vga, processor) { }
    }
    class ROG : ASUS
    {
        public ROG(Vga vga, Processor processor) : base("ROG", vga, processor) { }
    }
    class Vivobook : ASUS
    {
        public Vivobook(Vga vga, Processor processor) : base("Vivobook", vga, processor) { }
        public void Ngoding()
        {
            Console.WriteLine($"Ctak Ctak Ctak,error lagi!!");
        }
    }
    class ACER : Laptop
    {
        public ACER(string tipe, Vga vga, Processor processor) : base("ACER", tipe, vga, processor) { }
    }
    class Swift : ACER
    {
        public Swift(Vga vga, Processor processor) : base("Swift", vga, processor) { }
    }
    class Predator : ACER
    {
        public Predator(Vga vga, Processor processor) : base("Predator", vga, processor) { }
        public void BermainGame()
        {
            Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game");
        }
    }

    class Lenovo : Laptop
    {
        public Lenovo(string tipe, Vga vga, Processor processor) : base("Lenovo", tipe, vga, processor) { }
    }
    class IdeaPad : Lenovo
    {
        public IdeaPad(Vga vga, Processor processor) : base("IdeaPad", vga, processor) { }
    }
    class Legion : Lenovo
    {
        public Legion(Vga vga, Processor processor) : base("Legion", vga, processor) { }
    }
}