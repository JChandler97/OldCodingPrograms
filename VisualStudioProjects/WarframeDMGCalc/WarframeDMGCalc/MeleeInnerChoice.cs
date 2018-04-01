using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeDMGCalc
{
    class MeleeInnerChoice
    {
        public static void extensionChoice()
        {
            Console.WriteLine("Choose one of the following types:");
            Console.WriteLine("1: Blade Whip \n2: Claws \n3: Dagger \n4: Dual Dagger \n5: Dual Sword \n6: Fist \n7: Glaive \n8: GunBlade \n9: Hammer \n10: Heavy Blade \n11: Hybrid \n12: Machete \n13: Nikana \n14: Nunchaku \n15: Polearm \n16: Rapier \n17: Scythe \n18: Sparring \n19: Staff \n20: Sword \n21: Sword and Shield \n22: Tonfa \n23: Whip \n24: Go Back");

            int secondWepChoice = Convert.ToInt32(Console.ReadLine());
            switch (secondWepChoice)
            {
                case 1:
                    MeleeBladeWhip bladewhip = new MeleeBladeWhip();

                    break;

                case 2:
                    MeleeClaws claws = new MeleeClaws();

                    break;

                case 3:
                    MeleeDagger dagger = new MeleeDagger();

                    break;

                case 4:
                    MeleeDualDagger dualDagger = new MeleeDualDagger();

                    break;

                case 5:
                    MeleeDualSword dualSword = new MeleeDualSword();

                    break;

                case 6:
                    MeleeFist fist = new MeleeFist();

                    break;

                case 7:
                    MeleeGlaive glaive = new MeleeGlaive();

                    break;

                case 8:
                    MeleeGunBlade gunBlade = new MeleeGunBlade();

                    break;

                case 9:
                    MeleeHammer hammer = new MeleeHammer();

                    break;

                case 10:
                    MeleeHeavyBlade heavyBlade = new MeleeHeavyBlade();

                    break;

                case 11:
                    MeleeHybrid hybrid = new MeleeHybrid();

                    break;

                case 12:
                    MeleeMachete machete = new MeleeMachete();

                    break;

                case 13:
                    MeleeNikana nikana = new MeleeNikana();

                    break;

                case 14:
                    MeleeNunchaku nunchaku = new MeleeNunchaku();

                    break;

                case 15:
                    MeleePolearm polearm = new MeleePolearm();

                    break;

                case 16:
                    MeleeRapier rapier = new MeleeRapier();

                    break;

                case 17:
                    MeleeScythe scythe = new MeleeScythe();

                    break;

                case 18:
                    MeleeSparring sparring = new MeleeSparring();

                    break;

                case 19:
                    MeleeStaff staff = new MeleeStaff();

                    break;

                case 20:
                    MeleeSword sword = new MeleeSword();

                    break;

                case 21:
                    MeleeSwordShield swordShield = new MeleeSwordShield();

                    break;

                case 22:
                    MeleeTonfa tonfa = new MeleeTonfa();

                    break;

                case 23:
                    MeleeWhip whip = new MeleeWhip();

                    break;

                case 24:
                    Console.Clear();
                    Program mainWepChoice = new Program();
                    Program.weaponChoice();
                    break;

            }

        }
    }
}
