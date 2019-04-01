using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    class Program
    {
        public class MyGenericArray<T>
        {
            private T[] array; // variable declaration of type T. array is a Array.
            public MyGenericArray(int size)
            {
                array = new T[size]; // creating array object and giving index of size which user gives.! i have removed [size + 1] because size works fine.
            }
            public T getItem(int index)
            {
                return array[index]; // return array index and it is equal to value in setItem, so we get value instead.
            }
            public void setItem(int index, T value)
            {
                array[index] = value; // set value at specified index.
            }
        }
        static void Main(string[] args)
        {
            //declaring an int array
            MyGenericArray<int> intArray = new MyGenericArray<int>(5);
            //setting values
            for(int c = 0; c < 5; c++)
            {
                intArray.setItem(c, c * 5); // c is the index which works like 0 1 2 3 4 & c* 5 is value which is 1 x 5 = 5, 2 x 5 = 10...
            }
            //retrieving the values
            for(int c = 0; c < 5; c++)
            {
                Console.WriteLine(intArray.getItem(c) + " ");
            }
            Console.WriteLine();

            //declaring a character array
            MyGenericArray<char> charArray = new MyGenericArray<char>(5);

            //setting values
            for(int c = 0; c < 5; c++)
            {
                charArray.setItem(c, (char)(c + 97));
            }
            //retrieving the values
            for(int c = 0; c < 5; c++)
            {
                Console.WriteLine(charArray.getItem(c) + " ");
            }
            Console.ReadKey();
        }
    }
}
