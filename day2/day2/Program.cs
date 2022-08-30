using System;

namespace day2;

class Program
{
    static void Main(string[] args)
    {
        bool sniffsGlue = false;
        bool likesGrappling = false;


        double numCubed = cube(3.2);
        Console.WriteLine("Main Function Loaded");
        Console.WriteLine("Press any Key to continue");
        Console.ReadKey();
        Console.WriteLine("-----------------Calculator---------------");
        Console.WriteLine(numCubed);
        Console.WriteLine("Press any Key to continue");
        Console.ReadKey();
        Console.WriteLine("--------Retard---Qoute---Generator--------");
        saySomethingDumb("Chad");
        Console.WriteLine("Press any Key to continue");
        Console.ReadKey();
        Console.WriteLine("----------Guilty---Gear---Main------------");

        if (sniffsGlue == false)
        {
            Console.WriteLine("You do not like to sniff glue.");
        }
        else
        {
            Console.WriteLine("You like to sniff glue.");
        }
        if (likesGrappling == false)
        {
            Console.WriteLine("You do not like to Grapple.");
        }
        else
        {
            Console.WriteLine("You like to sniff glue.");
        }

        // and gate has to have both outcomes be true in order to execute if statement
        if (sniffsGlue && likesGrappling)
        {
            Console.WriteLine("You main POTEMKIN");
        }
        else if (!likesGrappling && sniffsGlue)
        {
            Console.WriteLine("You main GoldLewis.");
        }
        else if (likesGrappling && !sniffsGlue)
        {
            Console.WriteLine("You are out Confused my nigga.");
        }
        else
        {
            Console.WriteLine("You main KY");
        }

        Console.WriteLine("Press any Key to Continue");
        Console.ReadKey();
        Console.WriteLine("----------Dize---Size---Generator-----------");
        Console.WriteLine(dickRater(1, 2));
        Console.WriteLine("Press any Key to Continue");
        Console.ReadKey();
    }

    // Method -- Essentially a function allowing me to replay code to reuse enmasse
    // Void = No return function
    static void saySomethingDumb(string name)
    {

        Console.WriteLine(name + ": The moon landing was fake");

    }
    // return an integer value type
    // double is a hybrid of a normal and floating point
    static double cube(double num)
    {

        double result = num * num * num;
        return result;
    }




    static string dickRater(int dick1, int dick2)
    {
        string dickRating = "";
        string plural = "inch";
        

        if (dick1 > dick2)
        {
            if (dick1 - dick2 == 1)
            {
                plural = "inch";
            } else
            {
                plural = "inches";
            }
            dickRating = "Dick 1 is bigger than Dick 2 by " + (dick1 - dick2) + " " + plural;

        }
        else if (dick2 > dick1)
        {
            if (dick2 - dick1 == 1)
            {
                plural = "inch";
            }
            else
            {
                plural = "inches";
            }
            dickRating =  "Dick 2 is bigger then Dick 1 by " + (dick2 - dick1) + " " + plural;

        }
        else if (dick2 == dick1)
        {
            dickRating = "Both dicks are equally sized";
        }

        return dickRating;
    }
}