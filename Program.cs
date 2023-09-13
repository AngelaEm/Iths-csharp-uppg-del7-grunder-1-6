namespace Niclas_häfte_1_5
{
    internal class Program
    { 
      
        static void Main(string[] args)
        {
            // Uppgift 1 och 4

            // Ask user about name.
            Console.WriteLine("Vad heter du?");
            string name = Console.ReadLine();


            // Ask user about a number between 1-10.
            Console.WriteLine("Välj ett tal mellan 1 och 10.");
            int numberOfTimes = int.Parse(Console.ReadLine());

            // Runs for as many times as user choose.
            for (int i = 0; i < numberOfTimes; i++)
            {
                Greetings(name);
            }


            //Uppgift 2

            string password = "abc123";

            // Ask user about password.
            Console.WriteLine("Skriv in lösenord:");

            string userPassword = Console.ReadLine();

            // Compares userPassword with password to se if its correct.
            if (userPassword == "abc123")
            {
                Console.WriteLine("Det var rätt!");
            }
            else
            {
                Console.WriteLine("Det var fel!");
            }

            // Uppgift 3

            // Ask user to write an integer
            Console.WriteLine("Skriv ett heltal");

            int usersChoice = int.Parse(Console.ReadLine());

            // Checks if users integer is more, less or equal to 100.
            if (usersChoice == 100)
            {
                Console.WriteLine("Du valde 100!");
            }
            else if (usersChoice < 100)
            {
                Console.WriteLine("Ditt tal är mindre än 100!");
            }
            else
            {
                Console.WriteLine("Ditt tal är större än 100!");
            }

            // Uppgift 5

            int sum = 0;
            int numberOfTimes1 = 0;

            // Ask user to write a number

            try
            {
                while (true)
                {
                    Console.WriteLine("Skriv ett nummer.");
                    int number = int.Parse(Console.ReadLine());
                    sum += number;
                    numberOfTimes1++;
                }
                
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                Console.WriteLine("Tryck enter för att se medelvärdet av din tal.");
                Console.ReadKey();
            }

            finally
            {
                double averageValue = (double) sum/ (double) numberOfTimes1;
                Console.WriteLine($"Medelvärdet av dina tal blev {averageValue} och du skrev {numberOfTimes1} olika tal.");
            }

            // Uppgift 6

            Console.WriteLine("Skriv ett tal:");
            double tal1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Välj räknesätt: + - * /");
            char myChar = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Skriv ett tal till: ");
            double tal2 = int.Parse(Console.ReadLine());
            double resultat = 0;

            switch (myChar)
            {
                case '+':
                    resultat = tal1 + tal2;
                    break;

                case '-':
                    resultat = tal1 - tal2;
                    break;

                case '*':
                    resultat = tal1 * tal2;
                    break;

                case '/':
                    resultat = tal1 / tal2;                  
                    break;

                default:
                    Console.WriteLine("Ogiltigt tecken!");
                    break;
            }

            Console.WriteLine(Math.Round(resultat,2));

            Console.ReadKey();
        }
        static void Greetings(string name)
        {

            Console.WriteLine("Hej " + name + "!");

        }
    }
}