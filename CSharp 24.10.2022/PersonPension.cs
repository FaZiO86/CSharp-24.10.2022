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
    }
}
