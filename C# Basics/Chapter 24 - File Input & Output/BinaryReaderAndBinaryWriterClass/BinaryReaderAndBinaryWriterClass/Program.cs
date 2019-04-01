using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BinaryReaderAndBinaryWriterClass
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryWriter bw;
            BinaryReader br;
            int i = 25;
            double d = 3.14157;
            bool b = true;
            string s = "I am happy";

            //create the file
            try
            {
                bw = new BinaryWriter(new FileStream("binary.txt", FileMode.Create));
            }
            catch(IOException e)
            {
                Console.WriteLine("Cannot Create File : {0}", e.Message);
                return;
            }
            //writing into the file
            try
            {
                bw.Write(i);
                bw.Write(d);
                bw.Write(b);
                bw.Write(s);
            }
            catch (IOException e)
            {
                Console.WriteLine("Cannot Write To File : {0}", e.Message);
                return;
            }
            bw.Close();

            //reading from the file
            try
            {
                br = new BinaryReader(new FileStream("binary.txt", FileMode.Open));
            }
            catch (IOException e)
            {
                Console.WriteLine("Cannot Open File : {0}", e.Message);
                return;
            }
            try
            {
                i = br.ReadInt32();
                Console.WriteLine("Integer : {0}", i);
                d = br.ReadDouble();
                Console.WriteLine("Double : {0}", d);
                b = br.ReadBoolean();
                Console.WriteLine("Boolean : {0}", b);
                s = br.ReadString();
                Console.WriteLine("String : {0}", s);
            }
            catch (IOException e)
            {
                Console.WriteLine("Cannot Read From File : {0}", e.Message);
                return;
            }
            br.Close();
            Console.ReadKey();
        }
    }
}
