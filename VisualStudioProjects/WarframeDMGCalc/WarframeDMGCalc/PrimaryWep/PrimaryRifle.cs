using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeDMGCalc
{
    class PrimaryRifle
    {
        public struct Rifle
        {
            public string WeaponName;
            public const string WeaponType = "Assault Rifle";
            public string TriggerType;
            public double impactDMG;
            public double slashDMG;
            public double punctureDMG;
            public double coldDMG;
            public double electricityDMG;
            public double heatDMG;
            public double toxinDMG;
            public double statusChance;
            public double critChance;
            public double critMultiplier;
            public double totalIPSDmg;
            public double totalElementDmg;
            public double totalSumDMG;

            public void firstDisplay()
            {
                Console.WriteLine("Weapon Name: {0}", WeaponName);
                Console.WriteLine("Weapon Type: {0}", WeaponType);
                Console.WriteLine("Trigger Type: {0}", TriggerType);
                Console.WriteLine("Impact Damage: {0}", impactDMG);
                Console.WriteLine("Slash Damage: {0}", slashDMG);
                Console.WriteLine("Puncture Damage: {0}", punctureDMG);
                Console.WriteLine("Cold Damage: {0}", coldDMG);
                Console.WriteLine("Electricity Damage: {0}", electricityDMG);
                Console.WriteLine("Heat Damage: {0}", heatDMG);
                Console.WriteLine("Toxin Damage: {0}", toxinDMG);
                Console.WriteLine("Status Chance: {0}", statusChance);
                Console.WriteLine("Critical Chance: {0}", critChance);
                Console.WriteLine("Critical Multiplier: {0}", critMultiplier);
                totalIPSDmg = impactDMG + slashDMG + slashDMG;
                totalElementDmg = coldDMG + electricityDMG + heatDMG + toxinDMG;
                totalSumDMG = totalIPSDmg + totalElementDmg;
                Console.WriteLine("Total Physical Damage: {0}", totalIPSDmg);
                Console.WriteLine("Total Elemental Damage: {0}", totalElementDmg);
                Console.WriteLine("Sum of all Damage (assuming no armor): {0}", totalSumDMG);

                Console.WriteLine("What would you like to do? \n1: Calculate own data \n2: Go Back");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        CalcEdit();
                        break;

                    case 2:
                        PrimaryRifle.chooseCalc();
                        break;

                    default:
                        Console.WriteLine("Reverting you back to last menu.");
                        PrimaryInnerChoice.extensionChoice();
                        break;
                }

            }

            public void CalcEdit()
            {
                Console.WriteLine("What is your impact damage?");
                impactDMG = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is your slash damage?");
                slashDMG = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is your puncture damage?");
                punctureDMG = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is your cold damage?");
                coldDMG = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is your electricity damage?");
                electricityDMG = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is your heat damage?");
                heatDMG = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is your toxin damage?");
                toxinDMG = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is your status chance?");
                statusChance = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is your crit chance?");
                critChance = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is your crit multiplier?");
                critMultiplier = Convert.ToInt32(Console.ReadLine());

                totalIPSDmg = impactDMG + slashDMG + slashDMG;
                totalElementDmg = coldDMG + electricityDMG + heatDMG + toxinDMG;
                totalSumDMG = totalIPSDmg + totalElementDmg;

                Console.WriteLine("Weapon Name: {0}", WeaponName);
                Console.WriteLine("Weapon Type: {0}", WeaponType);
                Console.WriteLine("Trigger Type: {0}", TriggerType);
                Console.WriteLine("Impact Damage: {0}", impactDMG);
                Console.WriteLine("Slash Damage: {0}", slashDMG);
                Console.WriteLine("Puncture Damage: {0}", punctureDMG);
                Console.WriteLine("Cold Damage: {0}", coldDMG);
                Console.WriteLine("Electricity Damage: {0}", electricityDMG);
                Console.WriteLine("Heat Damage: {0}", heatDMG);
                Console.WriteLine("Toxin Damage: {0}", toxinDMG);
                Console.WriteLine("Status Chance: {0}%", statusChance);
                Console.WriteLine("Critical Chance: {0}%", critChance);
                Console.WriteLine("Critical Multiplier: {0}", critMultiplier);
                Console.WriteLine("Total IPS Damage: {0}", totalIPSDmg);
                Console.WriteLine("Total Elemental Damage: {0}", totalElementDmg);
                Console.WriteLine("Sum of all Damage (assuming no armor): {0}", totalSumDMG);

                Console.WriteLine("");
                Console.WriteLine("Please choose one of the following:\n1. Calculate Again \n2. Go Back to Previous Menu \n3. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        CalcEdit();
                        break;

                    case 2:
                        PrimaryInnerChoice.extensionChoice();
                        break;

                    case 3:

                        break;

                    default:
                        Console.WriteLine("Reverting back to previous menu");
                        PrimaryInnerChoice.extensionChoice();
                        break;
                }

            }


        }
        
        
        //may RNG bless us with no problems
        public static void chooseCalc()
        {
            Console.WriteLine("Pick your weapon of choice:");
            Console.WriteLine("1. Amprex \n2. Boltor \n3. Boltor Prime \n4. Boltor Telos \n5. Braton MK-1 \n6. Braton Prime \n7. Braton Vandal \n8. Burston \n9. Burston Prime \n10. Buzlok \n11. Dera \n12. Dera Vandal \n13. Flux Rifle \n14. Glaxion \n15. Gorgon \n16. Gorgon Prisma \n17. Gorgon Wraith \n18. Grakata \n19. Grakata Prisma \n20. Grinlok \n21. Harpak \n22. Hema \n23. Hind \n24. Ignis \n25. Ignis Wraith \n26. Karak \n27. Karak Wraith \n28. Latron \n29. Latron Prime \n30. Latron Wraith \n31. Mutalist Quanta \n32. Opticor \n33. Paracyst \n34. Quanta\n35. Quanta Vandal \n36. Soma \n37. Soma Prime \n38. Stradavar \n39. Supra \n40.Sybaris \n41. Sybaris Dex \n42. Synapse\n43. Tenora \n44. Tetra\n45. Tetra Prisma \n46. Tiberon");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Rifle Amprex  = new Rifle();
                    Amprex.WeaponName = "Amprex";
                    Amprex.TriggerType = "Held";
                    Amprex.impactDMG= 0;
                    Amprex.slashDMG=0;
                    Amprex.punctureDMG=0;
                    Amprex.coldDMG=0;
                    Amprex.electricityDMG=7.5;
                    Amprex.heatDMG=0;
                    Amprex.toxinDMG=0;
                    Amprex.statusChance=20;
                    Amprex.critChance=50;
                    Amprex.critMultiplier=2;
                    Amprex.firstDisplay();
                    break;

                case 2:
                    Rifle Boltor = new Rifle();
                    Boltor.WeaponName = "Boltor";
                    Boltor.TriggerType = "Auto";
                    Boltor.impactDMG = 2.5;
                    Boltor.slashDMG = 20;
                    Boltor.punctureDMG = 2.5;
                    Boltor.coldDMG = 0;
                    Boltor.electricityDMG = 0;
                    Boltor.heatDMG = 0;
                    Boltor.toxinDMG = 0;
                    Boltor.statusChance = 10;
                    Boltor.critChance = 5;
                    Boltor.critMultiplier = 1.5;
                    Boltor.firstDisplay();
                    break;

                case 3:
                    Rifle BoltorP = new Rifle();
                    BoltorP.WeaponName = "Boltor";
                    BoltorP.TriggerType = "Auto";
                    BoltorP.impactDMG = 5.5;
                    BoltorP.slashDMG = 49.5;
                    BoltorP.punctureDMG = 0;
                    BoltorP.coldDMG = 0;
                    BoltorP.electricityDMG = 0;
                    BoltorP.heatDMG = 0;
                    BoltorP.toxinDMG = 0;
                    BoltorP.statusChance = 10;
                    BoltorP.critChance = 5;
                    BoltorP.critMultiplier = 2;
                    BoltorP.firstDisplay();
                    break;

                    // Change values after this point
                case 4:
                    Rifle BoltorT = new Rifle();
                    BoltorT.WeaponName = "Boltor Telos";
                    BoltorT.TriggerType = "Auto";
                    BoltorT.impactDMG = 5.5;
                    BoltorT.slashDMG = 49.5;
                    BoltorT.punctureDMG = 0;
                    BoltorT.coldDMG = 0;
                    BoltorT.electricityDMG = 0;
                    BoltorT.heatDMG = 0;
                    BoltorT.toxinDMG = 0;
                    BoltorT.statusChance = 10;
                    BoltorT.critChance = 5;
                    BoltorT.critMultiplier = 2;
                    BoltorT.firstDisplay();
                    break;

                case 5:
                    Rifle BratonMK = new Rifle();
                    BratonMK.WeaponName = "Braton MK-1";
                    BratonMK.TriggerType = "Auto";
                    BratonMK.impactDMG = 5.5;
                    BratonMK.slashDMG = 49.5;
                    BratonMK.punctureDMG = 0;
                    BratonMK.coldDMG = 0;
                    BratonMK.electricityDMG = 0;
                    BratonMK.heatDMG = 0;
                    BratonMK.toxinDMG = 0;
                    BratonMK.statusChance = 10;
                    BratonMK.critChance = 5;
                    BratonMK.critMultiplier = 2;
                    BratonMK.firstDisplay();
                    break;

                 case 6:
                    Rifle BratonP = new Rifle();
                    BratonP.WeaponName = "Braton Prime";
                    BratonP.TriggerType = "Auto";
                    BratonP.impactDMG = 5.5;
                    BratonP.slashDMG = 49.5;
                    BratonP.punctureDMG = 0;
                    BratonP.coldDMG = 0;
                    BratonP.electricityDMG = 0;
                    BratonP.heatDMG = 0;
                    BratonP.toxinDMG = 0;
                    BratonP.statusChance = 10;
                    BratonP.critChance = 5;
                    BratonP.critMultiplier = 2;
                    BratonP.firstDisplay();
                    break;


                default:
                    Console.WriteLine("Reverting you back to last menu.");
                    PrimaryInnerChoice.extensionChoice();
                    break;
            }


        }

    }
}
