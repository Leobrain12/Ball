using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp11
{
    class Student
    {
        public Student(string name, string surename, int school, int ball)
        {
            this.Surename = surename;
            this.Name = name;
            this.School = school;
            this.Ball = ball;
        }
        public string Name { get; set; }
        public string Surename { get; set; }
        public int School { get; set; }
        public int Ball { get; set; }
        public void Display()
        {
            Console.WriteLine($"\n{Name} {Surename} {School} {Ball}");
        }
        public void result()
        {
            Console.WriteLine($"\n{Ball}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> student = new List<Student>();
            List<Student> winer = new List<Student>();
            double b;
            string a;
            int count = 1;
            int school;
            string name;
            string surename;
            int ball;
            int sum = 0;
            Random rand = new Random();
            Console.WriteLine("Введите чиcло студентов: ");
            b = Convert.ToDouble(Console.ReadLine());
            b = (int)b;
            while (b >= count)
            {
                while (b < 5)
                {
                    Console.WriteLine("Введите чиcло студентов: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    b = (int)b;
                }
                a = Console.ReadLine();
                surename = Convert.ToString(a.Split(' ')[0]);
                while (surename.Length >= 30)
                {
                    Console.WriteLine("Введите фамилию, в котром меньше 30 символов :");
                    surename = Console.ReadLine();
                }
                name = Convert.ToString(a.Split(' ')[1]);
                while (name.Length >= 20)
                {
                    Console.WriteLine("Введите имя, в котром меньше 20 символов :");
                    name = Console.ReadLine();
                }
                school = rand.Next(0, 99);//Convert.ToInt32(a.Split(' ')[2]);
                while (school > 99)
                {
                    Console.WriteLine("Введите шклолу (целое число от 1 до 99):");
                    school = Convert.ToInt32(Console.ReadLine());
                }
                ball = rand.Next(0, 100);//Convert.ToInt32(a.Split(' ')[3]);
                while (ball >= 100)
                {
                    Console.WriteLine("Введите балл (целое число от 1 до 100):");
                    ball = Convert.ToInt32(Console.ReadLine());

                }
                student.Add(new Student(name, surename, school, ball));
                count++;
            }
            student.Sort(delegate (Student us1, Student us2)
            { return us1.Ball.CompareTo(us2.Ball); });
            sum = (int)b * 80 / 100;
            student.RemoveRange(0, sum);
            var min = student[0];
            foreach (var item in student)
            {
                item.Display();
            }
            min.result();
        }
    }
}