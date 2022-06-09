namespace Feed_the_Neighborhood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string response;
            do
            {
                Console.Clear();
                Console.WriteLine("How many people are you feeding?");
                int totalPeople = int.Parse(Console.ReadLine());

                int totalSlices = totalPeople * 2; // Slices
                int totalPeanutButter = totalPeople * 2; // Tablespoons
                int totalJelly = totalPeople * 4; // Teaspoons

                Console.WriteLine($"For {totalPeople} people, you will need:\n{totalSlices} - Slices of Bread\n{totalPeanutButter} - Tablespoons of Peanut Butter\n{totalJelly} - Teaspoons of Jelly\n");

                decimal totalLoavesNeeded = Math.Ceiling((decimal)totalSlices / 28); // Slices
                decimal totalPeanutButterJars = Math.Ceiling((decimal)totalPeanutButter / 32); // Jars
                decimal totalJellyJars = Math.Ceiling((decimal)totalJelly / 48); // Jars

                Console.WriteLine($"Which is...\n{totalLoavesNeeded} - Slices of Bread\n{totalPeanutButterJars} - Jars of Peanut Butter\n{totalJellyJars} - Jars of Jelly\n");

                Console.WriteLine("Would you like to run the program again? (If so, please type 'y' or 'yes' to continue.)");
                response = Console.ReadLine();
            } while (response == "y" || response == "yes");
            Console.WriteLine("\nGoodbye");
        }
    }
}