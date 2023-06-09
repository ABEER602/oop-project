using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            // task();
            // task1();
            // task2();
            //task3();
            // task4();
            //task5();
            //task6();
            // task7();

            //task8();
            //task9();
            // task10();
            //   task11();
            //task12();
            // task13();
            // task14();
            //task15();
            //  task16();

        }
        public static void task()
        {

            Console.WriteLine("Hello World");
            Console.WriteLine("Hello World");

            Console.ReadKey();
        }
        public static void task1()
        {
            int num = 1;
            Console.WriteLine(" variable: " + num);
            Console.ReadKey();
        }
        public static void task2()
        {
            string num = "I am string";
            Console.WriteLine("string :" + num);
            Console.ReadKey();
        }
        public static void task3()
        {

            char num = 'A';
            Console.WriteLine("CHARACTER :" + num);
            Console.ReadKey();
        }
        public static void task4()
        {
            float num = 1.1F;
            Console.WriteLine("Float :" + num);
            Console.ReadKey();
        }
        public static void task5()
        {
            string write;
            Console.WriteLine("Enter text: ");
            write = Console.ReadLine();
            Console.ReadKey();
        }
        public static void task6()
        {
            int write;
            Console.WriteLine("Enter number: ");
            write = int.Parse(Console.ReadLine());
            Console.WriteLine("Number: " + write);
            Console.ReadKey();
        }
        public static void task7()
        {
            float write;
            Console.WriteLine("Enter number: ");
            write = float.Parse(Console.ReadLine());
            Console.WriteLine("Number: " + write);
            Console.ReadKey();
        }
        public static void task8()
        {
            float length;
            float area;
            Console.WriteLine("Enter length");
            length = float.Parse(Console.ReadLine());
            area = length * length;
            Console.WriteLine("Area is: ");
            Console.Write(area);
            Console.ReadKey();
        }
        public static void task9()
        {
            float marks;
            Console.WriteLine("Enter marks");
            marks = Console.Read();
            if (marks >= 50)
            {
                Console.WriteLine("You are pass");
            }
            if (marks < 50)
            {
                Console.WriteLine("You are fail");
            }
            Console.ReadKey();
        }
        public static void task10()
        {
            for (int i = 1; i <= 10; i++)
                Console.WriteLine("Welcome Jack");


            Console.ReadKey();
        }
        public static void task11()
        {
            int num;
            int sum = 0;
            Console.WriteLine("Enter number:");
            num = int.Parse(Console.ReadLine());
            while (num != -1)
            {
                Console.WriteLine("Enter number:");
                num = int.Parse(Console.ReadLine());
                sum = sum + num;
            }
            Console.Write("The sum is" + sum);
            Console.ReadKey();
        }
        public static void task12()
        {
            int num;
            int sum = 0;
            do
            {
                Console.WriteLine("Enter number:");
                num = int.Parse(Console.ReadLine());
                sum = sum + num;
            }
            while (num != -1);
            {
                sum = sum + 1;
                Console.Write("The sum is" + sum);
                Console.ReadKey();
            }
        }
        public static void task13()
        {
            int[] numbers = new int[3];
            for (int idx = 0; idx < 3; idx++)
            {
                Console.Write("Enter the number" + idx);
                numbers[idx] = int.Parse(Console.ReadLine());
            }

            int largest = -1;
            for (int i = 0; i < 3; i++)
            {
                if (largest < numbers[i])
                {
                    largest = numbers[i];
                }
            }
            Console.WriteLine("The largest number is:" + largest);
            Console.ReadKey();
        }
        public static void task14()
        {
            int num1;
            int num2;
            Console.Write("Enter 1st number");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter 2nd number");
            num2 = int.Parse(Console.ReadLine());
            int result = add(num1, num2);
            Console.WriteLine("The number is " + result);
            Console.ReadKey();

        }
        static int add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static void task15()
        {
            string path = "C:/Users/abeer/OneDrive/Desktop/Semester 2/WEEK 1/data.txt";
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    Console.WriteLine(record);
                }
                fileVariable.Close();
            }
            else
            {
                Console.WriteLine("Not exists");

            }
            Console.Read();
        }
        public static void task16()
        {
            string path = "C:/Users/abeer/OneDrive/Desktop/Semester 2/WEEK 1/data.txt";
            StreamWriter filevariable = new StreamWriter(path, true);
            filevariable.WriteLine("Hello");
            filevariable.Flush();
            filevariable.Close();
            Console.Read();
        }
        static int menu()
        {
            int option;
            Console.WriteLine("1. SIGN IN ");
            Console.WriteLine("1. SIGN UP ");
            Console.WriteLine("Enter Option ");
            option = int.Parse(Console.ReadLine());
            return option;
        }
        static string parseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {

                if (record[x] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }
        static void readData(string path, string[] names, string[] password)
        {
            int x = 0;
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);

                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    names[x] = parseData(record, 1);
                    password[x] = parseData(record, 2);
                    x++;

                    if (x >= 5)
                    {
                        break;
                    }
                    fileVariable.Close();
                }
            }
            else
            {
                Console.WriteLine("Not Exists");
            }
            Console.ReadKey();
        }
         static void signIn (string n, string p, string[] names,string[] password)
        {
            bool flag = false;
            for (int x = 0; x < 5; x++)
            {
                if (n== names[x] && p == password[x])
                {
                    Console.WriteLine("Valid User");
                    flag = true;
                }
            }
            if (flag == false)
            {
                Console.WriteLine("Invalid User");
            }
            Console.ReadKey();
         }
        static void signUp(string path , string n , string p)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(n + "," + p);
            file.Flush();
            file.Close();
        }
    }
}

