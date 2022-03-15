using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lab_2._1
{
    internal class Program
    {
       static void Create(int[] b,  int size)
       {
            Random x = new Random(); 
        
            for (int i = 0; i < size; i++)
                b[i] = Convert.ToInt32(x.Next(-40,50)) ;
        }
        static void Create2(int[] b, int size)
        { 
            for (int i = 0; i < size; i++)
            {
                Console.Write($"b[{i}] = " );
                b[i] = Convert.ToInt32(Console.ReadLine());
            }
                
        }
        static void Print(int[] b)
        {            
            Console.WriteLine("Array : [{0}]", string.Join(", ", b));
        }
         static int Sum(int[] b,int S)
        {
            for (int i = 0; i < b.Length; i++)
                if (!(b[i] > 0 && b[i] % 5 == 0))
                {
                    S += b[i];
                    b[i] = 0;
                }
            return S;
        }
        static int Count(int[] b, int k)
        {
            for (int i = 0; i < b.Length; i++)
                if (!(b[i] > 0 && b[i] % 5 == 0))
                {
                    k++;
                }
            return k;
        }

        static void Main(string[] args)
        {
            const int n = 22;
            int[] b =new int[n];
            Create(b, n);
            Print(b);
            int S = 0;
            int k = 0;
            
            Console.WriteLine($"Sum : {Sum(b,S)}");
            Console.WriteLine($"Number : {Count(b, k)}");
            Print(b);

            Console.ReadKey();
        }

    }
}
