using LINQ_Tutorial;

namespace LINQdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var scores = new[] { 50, 66, 90, 81, 77, 45, 0, 100, 99, 72, 87, 85, 81, 80, 77, 74, 95, 97 };
            var students = new List<Student>
            {
                new Student { name = "Alice", age = 16, grade = 89 },
                new Student { name = "Bob", age = 15, grade = 95 },
                new Student { name = "Charlie", age = 18, grade = 82 },
                new Student { name = "David", age = 12, grade = 79 },
                new Student { name = "Eva", age = 13, grade = 94 }
            };
            //all scores unsorted
            foreach (int score in scores)
            {
                Console.WriteLine("One of the scores was {0}", score);
            }

            Console.ReadLine();

            //all A scores unsorted
            var theBestStudents =
                from score in scores
                where score > 90
                select score;

            foreach (var score in theBestStudents)
            {
                Console.WriteLine("One of the BEST scores was {0}", score);
            }
            Console.ReadLine();

            //all scores sorted
            var sortedScores =
                from score in scores
                orderby score
                select score;

            foreach (var score in sortedScores)
            {
                Console.WriteLine("One of the scores was {0}", score);
            }
            Console.ReadLine();

            //Challenge 1: all B scores sorted
            var bScores =
                from score in scores
                where score > 79 && score < 90
                orderby score
                select score;

            foreach (var score in bScores)
            {
                Console.WriteLine("One of the B scores was {0}", score);
            }
            Console.ReadLine();

            //Challenge 2: sort students using CompareTo in class
            students.Sort();

            Console.WriteLine("Sorted students by Grade, Age, then Name:");
            foreach (var student in students)
            {
                Console.WriteLine($"Name: {student.name}, Age: {student.age}, Grade: {student.grade}");
            }
            Console.ReadLine();
        }
    }
}