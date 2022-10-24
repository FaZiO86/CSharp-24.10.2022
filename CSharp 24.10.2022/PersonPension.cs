using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_24._10._2022 {
    internal class PersonPension {
        private int age;
        public string Name { get; set; } = "User" + DateTime.Now.ToString("yyyy.MM.dd-HH:mm:ss.fff");
        public int Age {
            get { return age; } // get => age;
            set {
                if (value < 0) // throw new Exception("Некорректный возраст");
                {
                    throw new Exception("Некорректный возраст");
                }
                else {
                    if (value > 0 && value < 65) {
                        throw new Exception("Человек ещё не на пенсии");
                    }
                    else age = value;
                }
            }
        }
        public int gender { 
            get { return gender; }
            set {
                if(gender == 0) {
                    if (Age > 0 && Age < 65) {
                        throw new Exception("не пенсионный возраст для мужчины");
                    }
                }
                else if (gender == 1) { 
                    if(Age > 0 && Age < 60) {
                        throw new Exception("не пенсионный возраст для женщины");
                    }
                }
                else {
                    throw new Exception("не корректный возраст");
                }
            }
        }
    }
}
