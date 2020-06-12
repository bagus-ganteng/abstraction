using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
           Ielektronik elektronik;

            elektronik = new laptop();
            elektronik.barang();

            Console.WriteLine();
            elektronik = new hape();
            elektronik.barang();

            Console.ReadKey();
        }
    }
}
