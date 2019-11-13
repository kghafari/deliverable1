using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            //What kind of trip?
            Console.WriteLine("What kind of trip would you like to go on? Musical, tropical, or adventurous?");
            string vacationType = Console.ReadLine().ToLower();

            //how many guests?
            Console.WriteLine("How many are in your group?");
            int groupSize = int.Parse(Console.ReadLine());

            //logic for vacation type
            //TODO:
            //1) convert to lower case
            //2) use while loop (while musical||tropical||adventurous) to validate answers, and re-prompt user for a valid selection. Remove the final else statement.
            string destination = "";
            if (vacationType == "musical")
                {
                destination = "New Orleans";
                }
            else if (vacationType == "tropical")
                {
                destination = "a Beach Vacation in Mexico"; 
                }
            else if (vacationType == "adventurous") 
                {
                destination = "go Whitewater Rafting the Grand Canyon"; 
                }
            else { Console.WriteLine("Vacation type is invalid. Please enter 'musical', 'tropical', or 'adventurous'."); }

            //logic for group size
            //TODO:
            //1) use while loop (while > 0) to validate answers, and re-prompt user for a valid selection.
            string travelSuggestion = "";
            if (groupSize >= 1 && groupSize <= 3)
            {
                travelSuggestion = "First class flight";
            }
            else if (groupSize <= 3 && groupSize >= 5)
            {
                travelSuggestion = "Helecopter";
            }
            else if (groupSize >= 6)
            {
                travelSuggestion = "Charter flight";
            }
            else
            {
                travelSuggestion = "Group size invalid";
            }

            //print results
            string result = ($"Since you’re a group of {groupSize} going on a {vacationType} vacation, you should try a {travelSuggestion} to {destination}.");
            Console.WriteLine(result);
            //hold console window open
            Console.ReadLine();

        }
    }
}
