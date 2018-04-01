using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeDMGCalc
{
    class PrimaryInnerChoice
    {
        public static void extensionChoice()
        {
            Console.WriteLine("Choose one of the following types:");
            Console.WriteLine("1: Rifles \n2: Shotgun \n3: Sniper \n4: Bow \n5: Launcher \n6: Speargun \n7: Go Back");

            int secondWepChoice = Convert.ToInt32(Console.ReadLine());
            switch (secondWepChoice)
            {
                case 1:
                    PrimaryRifle.chooseCalc();
                    
                    break;

                case 2:
                    PrimaryShotgun shotgun = new PrimaryShotgun();

                    break;

                case 3:
                    PrimarySniper sniper = new PrimarySniper();

                    break;

                case 4:
                    PrimaryBow bow = new PrimaryBow();
                    break;

                case 5:
                    PrimaryLauncher launcher = new PrimaryLauncher();
                    break;

                case 6:
                    PrimarySpeargun speargun = new PrimarySpeargun();
                    break;

                case 7:
                    Console.Clear();
                    Program mainWepChoice = new Program();
                    Program.weaponChoice();
                    break;

            }

        }
}
}
