using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanThiLeNa_31231027702
{
    internal class session05
    {
        static void IncreaseArrayValues(ref int[] array) //function
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] += 2;
            }
        }
        static void Main5(string[] args)
        {
            Console.Write("Nhap so phan tu cua day: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap gia tri cho day {i + 1}: ");
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"\nDay gia tri truoc khi dieu chinh: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();

            IncreaseArrayValues(ref a);
            Console.WriteLine("\nDay gia tri sau khi cong 2:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
    }
}
