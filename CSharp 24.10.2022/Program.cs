using CSharp_24._10._2022;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserExeption
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            //var Misha = new Person_12Plus();
            //Console.WriteLine($"Создан пользователь {Misha.Name} введите его имя:");
            //Misha.Name = Console.ReadLine();

            //Console.WriteLine($"Задано имя пользователя {Misha.Name} введите возраст:");
            //Misha.Age = int.Parse(Console.ReadLine());
            var Misha = new PersonPension();
            Console.WriteLine($"Создан пользователь {Misha.Name} введите его пол\n [0] Мужчина\n [1] Женщина");
            Misha.Gender = int.Parse(Console.ReadLine());
            Console.WriteLine($"Введите его имя:");
            Misha.Name = Console.ReadLine();

            try
            {
                Console.WriteLine($"Задано имя пользователя {Misha.Name} введите возраст:");
                Misha.Age = int.Parse(Console.ReadLine());
            }
            catch (Exception e002)
            {
                Console.WriteLine("Пользовательские ошибки {0}", e002.Message);
            }
            Console.ReadKey();
        }
    }
}
