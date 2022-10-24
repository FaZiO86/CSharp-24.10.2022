using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_24._10._2022 {
    internal class PersonPension {
        private int age;
        private int gender;
        public string Name { get; set; } = "User" + DateTime.Now.ToString("yyyy.MM.dd-HH:mm:ss.fff");
        public int Age {
            get { return age; } // get => age;
            set {
                if (gender == 0) {
                    if (value > 0 && value < 65) {
                        throw new Exception($"не пенсионный возраст для мужчины {Name}");
                    }
                }
                else if (gender == 1) {
                    if (value > 0 && value < 60) {
                        throw new Exception($"не пенсионный возраст для женщины {Name}");
                    }
                    
                }
                else {
                    throw new Exception("не корректный возраст");
                }
                age = value;
            }
        }
        public int Gender { 
            get { return gender; }
            set {
                do {
                    if (value == 0 | value == 1) {
                        gender = value;
                    }
                    else {
                        //throw new Exception("не корректный ввод");
                        Console.WriteLine("не корректный ввод, попробуйте снова");
                        
                    }
                    value = int.Parse(Console.ReadLine());
                } while (value != 0 && value != 1);
                
            }
        }
    }
}
