namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, what is your favorite subject in school?");
            string reply = Console.ReadLine();

            switch (reply.Trim().ToLower())
            {
                case "english":
                    Console.WriteLine("English is great! Books, stories, and poems let you explore new worlds ");
                    Console.WriteLine("without leaving your chair.");
                    break;
                case "science":
                    Console.WriteLine("Science is my favorite too! Science is all about discovering ");
                    Console.WriteLine("how and why things work—like magic, but real!");
                    break;
                case "history":
                    Console.WriteLine("Great choice, history is like time travel without needing a machine—you");
                    Console.WriteLine(" get to learn the incredible stories of people who shaped the world.");
                    break;
                case "math":
                    Console.WriteLine("How fun! Math is like a puzzle—when you solve a problem, it's super satisfying!");
                    break;
                case "music":
                    Console.WriteLine("Great choice, music is math you can dance to!");
                    break;
                case "art":
                    Console.WriteLine("Neat, you can't make mistakes in art, only 'happy accidents' (thanks, Bob Ross!)");
                    break;
                default:
                    Console.WriteLine("I hadn't even though of that subject. It sounds great!");
                    break;

            }

        }
    }
}