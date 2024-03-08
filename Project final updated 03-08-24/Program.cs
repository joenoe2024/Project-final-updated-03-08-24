/*
 * author: joseph sandoval
 * purpose: Dating app for final project.
 */

namespace final_project_dating_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Visual Studio dating pool, Please fill out the info below");

            Console.WriteLine("Please enter your desired first name: ");// takes user input
            string firstName = Console.ReadLine();//stores userinput

            Console.WriteLine("Please enter desired last name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Please enter your birth year:");// takes user input and stores it in a variable, then does a loop to calculate appropriate user resonse. 
            int birthYear;
            while (true)
            {
                if (Int32.TryParse(Console.ReadLine(), out birthYear))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a valid birth year:");
                }
            }

            string gender;
            do
            {
                Console.WriteLine("Please enter your gender (M/F/O): ");
                gender = Console.ReadLine()?.ToUpper();

                if (gender != "M" && gender != "F" && gender != "O")
                {
                    Console.WriteLine("Invalid gender. TRY AGAIN.");
                }
            } while (gender != "M" && gender != "F" && gender !="O");


            int currentYear = DateTime.Now.Year;
            int age = currentYear - birthYear;

            Console.WriteLine($"Thank you, {firstName}! Heres your information:");
            Console.WriteLine($"First and last name:{firstName}{lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {gender}");

            List<string> questions = new List<string>()
            {
                "Whats your favotire color?:",
                "Whats your favorite food?:",
                "Whats your favorite tvshow?:",
                "Whats your favorite candy?:",
                "Whats your origin of birth?:",
                "Whats your dream?: ",
                "What kind of animals do you have, write none if none:",
                "Do you partake in the devils lechuga?:,",
                "Do you prefer indoors or outdoors?:",
                "playstation or xbox? (warning: answer is susceptible to deal breakers:)",

            };

            List<string> responses = new List<string>();

            foreach (string question in questions)
            {
                Console.WriteLine(question);

                string response;
                do
                {
                    Console.WriteLine("Please respond quickly");
                    response = Console.ReadLine();

                    if (string.IsNullOrEmpty(response))
                    {
                        Console.WriteLine("Invalid response you");
                    }
                } while (string.IsNullOrEmpty(response));
                responses.Add(response);
            }




        }
    }
}