using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileStreamClass
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream F = new FileStream("file.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            // Writing To File
            for(int i = 1; i <= 20; i++)
            {
                F.WriteByte((byte)i);
            }

            F.Position = 0;
            // Readinf From File
            for (int i = 0; i <= 20; i++)
            {
                Console.Write(F.ReadByte() + " ");
            }
            F.Close();
            Console.ReadKey();
        }
    }
}
