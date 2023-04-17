namespace DogSitter
{
    internal class Program
    {
        static void Main()
        {
            var nile = new Dictionary<string, string>
            {
                { "name", "Nile" },
                { "breed", "Golden Mix"},
                { "birthday", "2018-07-04"},
                { "walks required", "3" }
            };

            var sammy = new Dictionary<string, string>
            {
                { "name", "Sammy" },
                { "breed", "Wirehaired Pointing Griffon" },
                { "birthday", "2012-10-13" },
                { "walks required", "1" }
            };

            var dogs = new List<Dictionary<string, string>> { nile, sammy };

            // Take dogs on a walk
            foreach (var dog in dogs)
            {
                var currentWalksRequired = int.Parse(dog["walks required"]);
                Console.WriteLine($"Taking {dog["name"]} for a walk...");
                dog["walks required"] = (currentWalksRequired - 1).ToString();
            }

            Console.WriteLine($"{nile["name"]} now needs {nile["walks required"]} walks");
            Console.WriteLine($"{sammy["name"]} now needs {sammy["walks required"]} walks");
        }
    }
}