namespace FileIOApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"C:\Users\Shadow\Documents\test.txt";

            List<Person> people = new List<Person>();
            List<string> lines = File.ReadAllLines(filepath).ToList();

            int lineNumber = 0;
            foreach (string line in lines)
            {
                lineNumber++;
                string[] entries = line.Split(',');

                //error handling for incorrect number of entries per line
                if (entries.Length != 3)
                {
                    Console.WriteLine($"Error: Expected 3 entries on line: {lineNumber}, but found {entries.Length}");
                    continue;
                }

                Person p = new Person();
                p.firstName = entries[0];
                p.lastName = entries[1];
                p.url = entries[2];

                people.Add(p);
            }

            List<string> outputLines = new List<string>();
            Console.WriteLine("Here is the list of people I have:");
            foreach (Person person in people)
            {
                Console.WriteLine("First Name: " + person.firstName + ", Last Name: " + person.lastName + ", URL: " + person.url);
                outputLines.Add("First Name: " + person.firstName + ", Last Name: " + person.lastName + ", URL: " + person.url);
            }

            string outPath = @"C:\Users\Shadow\Documents\peopleOut.txt";
            File.WriteAllLines(outPath, outputLines);
            Console.ReadLine();
        }
    }
}