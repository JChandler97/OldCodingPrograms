using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeDMGCalc
{
    class SecondaryInnerChoice
    {
        public static void extensionChoice()
        {
            Console.WriteLine("Choose one of the following types:");
            Console.WriteLine("1: Single \n2: Dual \n3: Thrown \n4: Go Back");

            int secondWepChoice = Convert.ToInt32(Console.ReadLine());
            switch (secondWepChoice)
            {
                case 1:
                    SecondarySingle.chooseCalc();

                    break;

                case 2:
                    SecondaryDual secDual = new SecondaryDual();

                    break;

                case 3:
                    SecondaryThrown secThrown = new SecondaryThrown();

                    break;

                case 4:
                    Console.Clear();
                    Program mainWepChoice = new Program();
                    Program.weaponChoice();
                    break;

            }

        }


    }
}
