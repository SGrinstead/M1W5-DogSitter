using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogSitter
{
    public class Dog
    {
        public string Name;
        public string Breed;
        public string Birthday;
        public int WalksRequired;

        public Dog(string name, string breed, string birthday, int walksRequired)
        {
            Name = name;
            Breed = breed;
            Birthday = birthday;
            WalksRequired = walksRequired;
        }

        public void Walk()
        {
            Console.WriteLine($"Taking {Name} for a walk...");
            WalksRequired--;
            Console.WriteLine($"{Name} now needs {WalksRequired} walks.");
        }
    }
}
