namespace CSBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14;

            bool isLearningCSharp = true;

            string favFilm = "Lion King";

            favFilm = "High School Musical";

            int number = new int();

            string name = "Persephone"; 

            printGreeting(name);

            numberSubtract(10, 5);

            Console.WriteLine(isStringLonger("banana", 14));

            int additionResult = Sum(10, 5);
            Console.WriteLine(additionResult);

        }
        
        private static void printGreeting(string name)
        {
            Console.WriteLine($"Hello {name}!");

        }

        private static int numberSubtract(int numberOne, int numberTwo)
        {
            return numberOne - numberTwo; 
        }

        private static bool isStringLonger(string word, int number)
        {
            return word.Length > number; 
        }

        private static int Sum(int numberOne, int numberTwo)
        {
            return numberOne + numberTwo;
        }
    }
}
