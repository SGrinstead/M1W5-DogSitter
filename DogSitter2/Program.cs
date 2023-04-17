namespace DogSitter
{
    internal class Program
    {
        static void Main()
        {
            var nile = new Dog("Nile", "Golden Mix", "2018-07-04", 3);
            var sammy = new Dog("Sammy", "Wirehaired Pointing Griffon", "2012-10-13", 1);

            var dogs = new List<Dog> { nile, sammy };

            // Take dogs on a walk
            foreach (var dog in dogs)
            {
                dog.Walk();
            }
        }
    }
}