using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanClass
{
    class human
    {
        //Поле
        private string name;
        private int age;
        private string sex;

        //конструктор
        public human()
        {
            Console.Write("Создайте нового человека.\nИмя: ");
            name = Console.ReadLine();
            Console.Write("Возраст: ");
            Age = int.Parse(Console.ReadLine());
            Console.Write("Пол: ");
            sex = Console.ReadLine();

            Console.WriteLine("Новый человек создан.");         
        }

        //методы
        public void Speak()
        {
            Console.WriteLine("\nМеня зовут {0}, мне {1}, я {2}.", name, age, sex);
        }

        public static void SayHello()
        {
            Console.WriteLine("\nПривет.");
        }

        //свойства
        public int Age
        {
            set
            {
                for (;;)
                {
                    if (value > 0)
                    {
                        age = value;
                        break;
                    }
                    else
                    {
                        Console.Write("Неправильный ввод.\nВозраст: ");
                        value = int.Parse(Console.ReadLine());
                    }
                }
            }

            get { return age; }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var human1 = new human();

            Console.WriteLine("Нажмите 1, чтобы он рассказал о себе.");
            if (Console.ReadKey().KeyChar == '1')
            {
                human.SayHello();
                human1.Speak();
            }    

            Console.ReadLine();
        }
    }
}
