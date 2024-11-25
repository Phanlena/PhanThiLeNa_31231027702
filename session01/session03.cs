﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanThiLeNa_31231027702
{
    internal class session03
    {
        public static void Main3()
        {
            //Question_01();
            //Question_02();
            //Question_03();
            //Question_04();
            //Question_05();
            //Question_06();
            //Question_07();
            //Question_08();
            //Question_09();
            //Question_10();
            //Question_11();
            Console.ReadKey();
        }
        public static void Question_01()
        {
            do
            {
                Random rnd = new Random();
                int comp_num = rnd.Next(0, 10) + 1;
                int count = 0;
                bool isContinue = true;
                do
                {
                    count++;
                    Console.Write("Ban doan so may? <1..10>: ");
                    int user_num = int.Parse(Console.ReadLine());
                    if (user_num == comp_num)
                    {
                        Console.Write($"Ban doan trung sau {count} lan");
                        isContinue = false;
                    }
                    else
                    {
                        if (user_num > comp_num)
                            Console.Write("so ban doan lon hon so may nghi");
                        else
                            Console.Write("so ban doan nho hon so may nghi");
                    }
                } while (isContinue);
                Console.WriteLine("============");
                Console.Write("choi nua khong?<C/K>:");
                string tl = Console.ReadLine();
                if (tl.ToUpper().Equals("K")) ;
                {
                    Console.Write("OK");
                    return;
                }
            } while (true);
        }

        public static void Question_02()
        {
            Console.Write("Nhap mot so: ");
            int i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.WriteLine($"{i} la so chan");
            }
            else
            {
                Console.WriteLine($"{i} la so le");
            }
        }
        public static void Question_03()
        {
            Console.Write("Nhap so 1: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so 2: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap so 3: ");
            int c = int.Parse(Console.ReadLine());
            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine($"{a} la so lon nhat");
                }
                else { Console.WriteLine($"{c} la so lon nhat"); }
            }
            else if (b > c) { Console.WriteLine($"{b} la so lon nhat"); }
            else { Console.WriteLine($"{c} la so lon nhat"); }
        }
        public static void Question_04()
        {
            Console.Write("Nhap toa do mot diem: \nX= "); ///"\n" toi X thi xuong dong
            int x = int.Parse(Console.ReadLine());
            Console.Write("Y= ");
            int y = int.Parse(Console.ReadLine());
            if (x > 0 && y > 0) { Console.WriteLine("Toa do thuoc phan tu thu nhat"); }
            else if (x < 0 && y > 0) { Console.WriteLine("Toa do thuoc phan tu thu hai"); }
            else if (x < 0 && y < 0) { Console.WriteLine("Toa do thuoc phan tu thu ba"); }
            else if (x > 0 && y < 0) { Console.WriteLine("Toa do thuoc phan tu thu tu"); }
        }
        public static void Question_05()
        {
            Console.Write("Input side 1 of triangle: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Input side 2 of triangle: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Input side 3 of triangle: ");
            int c = int.Parse(Console.ReadLine());

            // Kiem tra loai tam giac dua vao canh
            if (a == b && b == c)
            {
                Console.Write("This is an equilateral triangle.\n");
            }
            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("This is an isosceles triangle.");
            }
            else
            {
                Console.WriteLine("This is a scalene triangle.");
            }
        }
        public static void Question_06()
        {
            int i, sum = 0;  //i la bien dem
            double avg;
            Console.Write("Input the 10 numbers  \n");
            for (i = 1; i <= 10; i++)
            {
                Console.Write($"Number {i} : ");
                int n = int.Parse(Console.ReadLine());
                sum += n;  // cach viet khac cua sum=sum+n
            }

            avg = sum / 10.0;

            Console.WriteLine($"The sum of 10 numbers is : {sum}");
            Console.Write($"The average of 10 numbers is: {avg}");
        }
        public static void Question_07()
        {
            int i, j, k = 1; //i: stt hàng, j:stt cột
            Console.Write("Input number of rows : ");
            int row = int.Parse(Console.ReadLine());
            //kiểu 1
            for (i = 1; i <= row; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write($"{k++} ");
                }
                Console.Write("\n");
            }
            //Kiểu 2
            int i2, j2, k2 = 1;
            for (i2 = 1; i2 <= row; i2++)
            {
                for (j2 = 1; j2 <= i2; j2++)
                {
                    Console.Write($"{k2++}");
                }
                Console.Write("\n");
            }
            //kiểu 3
            int i3, j3, k3 = 1;
            for (i3 = 1; i3 <= row; i3++)
            {
                // In khoảng trắng để căn giữa
                for (j3 = 1; j3 <= row - i3; j3++)
                {
                    Console.Write(" ");
                }

                // In các số trong hàng
                for (j3 = 1; j3 <= i3; j3++)
                {
                    Console.Write($"{k3++} ");
                }

                Console.WriteLine();
            }
        }
        public static void Question_08()
        {
            Console.Write("Input the number of terms: ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0.0;

            Console.Write("Harmonic series: ");

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"1/{i} ");
                if (i < n)
                {
                    Console.Write("+ ");
                }

                sum += 1.0 / i;
            }

            Console.WriteLine($"\nSum of harmonic series up to {n} terms: {sum}");
        }
        public static void Question_09()
        {
            int n, i, sum;
            Console.Write("Nhap so bat dau: ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Nhap so ket thuc: ");
            int max = int.Parse(Console.ReadLine());
            Console.Write("Cac so hoan hao trong day la: ");
            for (n = min; n <= max; n++)
            {
                i = 1;
                sum = 0;
                while (i < n)  //Vòng lặp tính tổng ước số của mỗi số trong phạm vi
                {
                    if (n % i == 0)
                        sum += i;
                    i++;
                }
                if (sum == n)
                    Console.Write($" {n}");
            }
        }
        public static void Question_10()
        {
            Console.Write("Nhap mot so: ");
            int num = int.Parse(Console.ReadLine());
            bool isPrime = true;

            if (num <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            if (isPrime)
            {
                Console.WriteLine($"{num} la so nguyen to.");
            }
            else
            {
                Console.WriteLine($"{num} khong la so nguyen to.");
            }
        }
        public static void Question_11()
        {
            Console.Write("Nhap mot so: ");
            int a = int.Parse(Console.ReadLine());
            int b;
            Console.WriteLine($"Bang cuu chuong {a}: ");
            for (int i = 1; i <= 10; i++)
            {
                b = a * i;
                Console.WriteLine($"{a}*{i}={b}");
            }
        }
    }
}
