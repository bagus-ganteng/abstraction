using System;
namespace abtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            elektronik elektronik;

            elektronik = new laptop();
            elektronik.barang();

            Console.WriteLine();
            elektronik = new hape();
            elektronik.barang();

            Console.ReadKey();
        }
    }
}

