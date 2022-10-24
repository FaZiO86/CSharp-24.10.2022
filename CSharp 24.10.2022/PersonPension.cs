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
                if (Gender == 0) {
                    if (age > 0 && age < 65) {
                        throw new Exception("не пенсионный возраст для мужчины");
                    }
                }
                else if (Gender == 1) {
                    if (age > 0 && age < 60) {
                        throw new Exception("не пенсионный возраст для женщины");
                    }
                    
                }
                else {
                    throw new Exception("не корректный возраст");
                }
            }
        }
        public int Gender { 
            get { return gender; }
            set {
                gender = value;
            }
        }
    }
}
