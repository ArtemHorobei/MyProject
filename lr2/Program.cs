using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lr2
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0, num2 = 0, num3 = 0, num4 = 0;
            Console.Write("Введите реальнучаю часть 1 числа:");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите мнимую часть 1 числа:");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите реальнучаю часть 2 числа:");
            num3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите мнимую часть 2 числа:");
            num4 = Convert.ToDouble(Console.ReadLine());
            ComplexNUM a1 = new ComplexNUM(num1, num2);
            ComplexNUM a2 = new ComplexNUM(num3, num4);
            a1.setRealNUM(num1);
            a1.setImagNUM(num2);
            a2.setRealNUM(num3);
            a2.setImagNUM(num4);
            Console.WriteLine("Entering number one is {0}+({1}i)", a1.getRealNUM(), a1.getImagNUM());
            Console.WriteLine("Entering number two is {0}+({1}i)", a2.getRealNUM(), a2.getImagNUM());
            ComplexNUM.Add(a1, a2);
            ComplexNUM.Substract(a1, a2);
            ComplexNUM.Multipli(a1, a2);
            Console.ReadLine();
        }
    }
    class ComplexNUM
    {
        private double real;
        private double imaginary;
        public ComplexNUM()
        {
            real = 0;
            imaginary = 0;
        }
        public ComplexNUM(double num1, double num2)
        {
            real = num1;
            imaginary = num2;
        }
        public void setRealNUM(double number)
        {
            if (number > 1000)
                throw new Exception("This value is not valid!");
            this.real = number;
        }
        public double getRealNUM()
        {
            return real;
        }
        public void setImagNUM(double number)
        {
            if (number > 1000)
                throw new Exception("This value is not valid!");
            this.imaginary = number;
        }
        public double getImagNUM()
        {
            return imaginary;
        }
        public static void Add(ComplexNUM c1, ComplexNUM c2)
        {
            double SumReal = (c1.real + c2.real);
            double SumImag = (c1.imaginary + c2.imaginary);
            Console.WriteLine("Результа суммы:{0} + ({1}i)", SumReal, SumImag);
        }
        public static void Substract(ComplexNUM c1, ComplexNUM c2)
        {
            double SubstractReal = (c1.real - c2.real);
            double SubstractImag = (c1.imaginary - c2.imaginary);
            Console.WriteLine("Результа вычитания:{0} - ({1}i)", SubstractReal, SubstractImag);
        }
        public static void Multipli(ComplexNUM c1, ComplexNUM c2)
        {
            double MultReal = ((c1.real * c2.real) - (c1.imaginary * c2.imaginary));
            double MultImaginary = ((c1.real * c2.imaginary) + (c1.imaginary * c2.real));
            Console.WriteLine("Результат умножение:{0} + ({1}i)", MultReal, MultImaginary);
        }
        ~ComplexNUM()
        {
            System.Diagnostics.Trace.WriteLine("Destructor is called!");
        }

    }
}
