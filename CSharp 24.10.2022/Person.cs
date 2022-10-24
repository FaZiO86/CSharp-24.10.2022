using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserExeption
{ 
    internal class Person_12Plus 
    {
        private int age;
        public string Name { get; set; } = "User" + DateTime.Now.ToString("yyyy.MM.dd-HH:mm:ss.fff");
        public int Age
        {
            get { return age; } // get => age;
            set
            {
                if (value < 0) // throw new Exception("Некорректный возраст");
                {
                    throw new Exception("Некорректный возраст");
                }
                else
                {
                    if (value < 12)
                    {
                        throw new Exception("Возрастное ограничение 12+");
                    }
                    else age = value;
                }
            }
        }
    }
}
