using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
        internal int[] EnterArray()
        {
            Console.Write("Massivin uzunlugu:");
            int n=int.Parse(Console.ReadLine());
            int[] arr=new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"arr[{i}]=");
                arr[i] = int.Parse(Console.ReadLine()); 
            }

            return arr;
        }
        internal int[] GetSqrtElements(int[] arr)
        {
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (Math.Sqrt(arr[i]) == (int)Math.Sqrt(arr[i]))
                    count++;
            }
            int[] sqrtElements = new int[count];
            int index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (Math.Sqrt(arr[i]) == (int)Math.Sqrt(arr[i]))
                {
                    sqrtElements[index++] = arr[i];
                }
                
            }

            return sqrtElements;   
        }        
        internal void Print(int[] arr) 
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item + " ");
            }
        }
    }
}
