using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;


namespace WarframeDMGCalc
{
    class Program
    {
        enum primaryChoice{Primary= 1, Secondary= 2, Melee= 3, Archwing= 4, Credits= 5, Exit= 6}

        static void Main(string[] args)
        {
            WelcomePage welcome = new WelcomePage();
            WelcomePage.splashWelcome();

            // This is to stop the intro from playing
            SoundPlayer player = new SoundPlayer();
            player.Stop();

            Console.Clear();
            weaponChoice();

        }

        public static void weaponChoice()
        {
            // It has to be constant for switch to work properly
            const int firstChoice = (int)primaryChoice.Primary;
            const int secondChoice = (int)primaryChoice.Secondary;
            const int thirdChoice = (int)primaryChoice.Melee;
            const int fourthChoice = (int)primaryChoice.Archwing;
            const int fifthChoice = (int)primaryChoice.Credits;
            const int sixthChoice = (int)primaryChoice.Exit;

            Console.WriteLine("Choose one of the following:");
            Console.WriteLine("1: Primary");
            Console.WriteLine("2: Secondary");
            Console.WriteLine("3: Melee");
            Console.WriteLine("4: Archwing");
            Console.WriteLine("5: Credits");
            Console.WriteLine("6: Exit");

            int wepChoice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            while (wepChoice > 6)
            {
                Console.WriteLine("Please enter a valid number");
                wepChoice = Convert.ToInt32(Console.ReadLine());
            }



            switch (wepChoice)
            {
                case firstChoice:
                    Console.WriteLine("You've chose Primary Weapons.");
                    PrimaryInnerChoice.extensionChoice();
                    Console.ReadKey(true);
                    break;

                case secondChoice:
                    Console.WriteLine("You've chose Secondary Weapons");
                    SecondaryInnerChoice.extensionChoice();
                    Console.ReadKey(true);
                    break;

                case thirdChoice:
                    Console.WriteLine("Bug24 is working on this -- contact him for more information");
                    Console.WriteLine("You've chose Melee Weapons");
                    MeleeInnerChoice.extensionChoice();
                    Console.ReadKey(true);
                    break;

                case fourthChoice:
                    Console.WriteLine("You've chose Archwing Weapons");
                    Console.WriteLine("Coming soon within a newer update!");
                    Console.WriteLine("We'll redirect back to the previous menu after clicking a key.");
                    Console.ReadKey(true);
                    Console.Clear();
                    weaponChoice();
                    break;

                case fifthChoice:
                    CreditPage.credits();
                    break;

                case sixthChoice:

                    break;
            }
           
        }

    }
}
