using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeDMGCalc
{
    class SecondarySingle
    {
        public struct Single
        {
            public string WeaponName;
            public const string WeaponType = "Pistol";
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
                        SecondarySingle.chooseCalc();
                        break;

                    default:
                        Console.WriteLine("Reverting you back to last menu.");
                        SecondaryInnerChoice.extensionChoice();
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
                        SecondaryInnerChoice.extensionChoice();
                        break;

                    case 3:

                        break;

                    default:
                        Console.WriteLine("Reverting back to previous menu");
                        SecondaryInnerChoice.extensionChoice();
                        break;
                }

            }
        }

        public static void chooseCalc()
        {
            Console.WriteLine("1. Acrid \n2. Angstrum \n3. Atomos \n4. Azima \n5. Ballistica \n6. Bolto \n7. Brakk \n8. Bronco \n9. Bronco Prime \n10. Castanas \n11. Cestra \n12. Despair \n13. Detron \n14. Embolist \n15. Euphona Prime \n16. Furis \n17. Gammacor \n18. Hikou \n19. Hikou Prime \n20. Kohmak \n21. Kraken \n22. Kulstar \n22. Kunai \n23. Lato \n24. Lato Prime \n25. Lato Vandal \n26. Lex \n27. Lex Prime \n28. Magnus \n29. Mara Detron \n30. Marelok \n31. MK1-Furis \n32. MK1-Kunai \n33. Nukor \n34. Pandero \n35. Pox \n36. Pyrana \n37. Rakta Ballistica \n38. Sancti Castanas \n39. Seer \n40. Sicarus \n41. Sicarus Prime \n42. Sonicor \n43. Spectra \n44. Spira \n45. Spira Prime \n46. Staticor \n47. Stug \n48. Synoid Gammacor \n49. Talons \n50. Telos Akbolto \n51. Tysis \n52. Vasto \n53. Vasto Prime \n54. Vaykor Marelok \n55. Viper");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Single Acrid = new Single();
                    Acrid.WeaponName = "Acrid";
                    Acrid.TriggerType = "Semi-Auto";
                    Acrid.impactDMG = 0;
                    Acrid.punctureDMG = 0;
                    Acrid.slashDMG = 0;
                    Acrid.coldDMG = 0;
                    Acrid.electricityDMG = 0;
                    Acrid.heatDMG = 0;
                    Acrid.toxinDMG = 33.0;
                    Acrid.statusChance = 10;
                    Acrid.critChance = 5;
                    Acrid.critMultiplier = 2.0;
                    Acrid.firstDisplay();
                    break;

                case 2:
                    Single Angstrum = new Single();
                    Angstrum.WeaponName = "Angstrum";
                    Angstrum.TriggerType = "Charge";
                    Angstrum.impactDMG = 0;
                    Angstrum.punctureDMG = 0;
                    Angstrum.slashDMG = 0;
                    Angstrum.coldDMG = 212.5;
                    Angstrum.electricityDMG = 0;
                    Angstrum.heatDMG = 212.5;
                    Angstrum.toxinDMG = 0;
                    Angstrum.statusChance = 10;
                    Angstrum.critChance = 5;
                    Angstrum.critMultiplier = 2;
                    Angstrum.firstDisplay();
                    break;

                case 3:
                    Single Atomos = new Single();
                    Atomos.WeaponName = "Atomos";
                    Atomos.TriggerType = "Held";
                    Atomos.impactDMG = 0;
                    Atomos.punctureDMG = 0;
                    Atomos.slashDMG = 0;
                    Atomos.coldDMG = 0;
                    Atomos.electricityDMG = 0;
                    Atomos.heatDMG = 50.0;
                    Atomos.toxinDMG = 0;
                    Atomos.statusChance = 10;
                    Atomos.critChance = 5;
                    Atomos.critMultiplier = 1.5;
                    Atomos.firstDisplay();
                    break;

                case 4:
                    Single Azima = new Single();
                    Azima.WeaponName = "Azima";
                    Azima.TriggerType = "Auto";
                    Azima.impactDMG = 2.0;
                    Azima.punctureDMG = 5.0;
                    Azima.slashDMG = 13.0;
                    Azima.coldDMG = 0;
                    Azima.electricityDMG = 0;
                    Azima.heatDMG = 0;
                    Azima.toxinDMG = 0;
                    Azima.statusChance = 10;
                    Azima.critChance = 10;
                    Azima.critMultiplier = 2;
                    Azima.firstDisplay();
                    break;

                case 5:
                    Single Ballistica = new Single();
                    Ballistica.WeaponName = "Ballistica";
                    Ballistica.TriggerType = "Charge";
                    Ballistica.impactDMG = 10.0;
                    Ballistica.punctureDMG = 80.0;
                    Ballistica.slashDMG = 10.0;
                    Ballistica.coldDMG = 0;
                    Ballistica.electricityDMG = 0;
                    Ballistica.heatDMG = 0;
                    Ballistica.toxinDMG = 0;
                    Ballistica.statusChance = 10;
                    Ballistica.critChance = 15;
                    Ballistica.critMultiplier = 1.5;
                    Ballistica.firstDisplay();
                    break;

                case 6:
                    Single Bolto = new Single();
                    Bolto.WeaponName = "Bolto";
                    Bolto.TriggerType = "Semi-Auto";
                    Bolto.impactDMG = 4.5;
                    Bolto.punctureDMG = 40.5;
                    Bolto.slashDMG = 0;
                    Bolto.coldDMG = 0;
                    Bolto.electricityDMG = 0;
                    Bolto.heatDMG = 0;
                    Bolto.toxinDMG = 0;
                    Bolto.statusChance = 7.5;
                    Bolto.critChance = 5;
                    Bolto.critMultiplier = 2;
                    Bolto.firstDisplay();
                    break;

                case 7:
                    Single Brakk = new Single();
                    Brakk.WeaponName = "Brakk";
                    Brakk.TriggerType = "Semi-Auto";
                    Brakk.impactDMG = 67.5;
                    Brakk.punctureDMG = 37.5;
                    Brakk.slashDMG = 45;
                    Brakk.coldDMG = 0;
                    Brakk.electricityDMG = 0;
                    Brakk.heatDMG = 0;
                    Brakk.toxinDMG = 0;
                    Brakk.statusChance = 10;
                    Brakk.critChance = 15;
                    Brakk.critMultiplier = 2;
                    Brakk.firstDisplay();
                    break;

                case 8:
                    Single Bronco = new Single();
                    Bronco.WeaponName = "Bronco";
                    Bronco.TriggerType = "Semi-Auto";
                    Bronco.impactDMG = 84.0;
                    Bronco.punctureDMG = 10.5;
                    Bronco.slashDMG = 10.2;
                    Bronco.coldDMG = 0;
                    Bronco.electricityDMG = 0;
                    Bronco.heatDMG = 0;
                    Bronco.toxinDMG = 0;
                    Bronco.statusChance = 14;
                    Bronco.critChance = 2.5;
                    Bronco.critMultiplier = 2;
                    Bronco.firstDisplay();
                    break;

                case 9:
                    Single BroncoP = new Single();
                    BroncoP.WeaponName = "Bronco Prime";
                    BroncoP.TriggerType = "Semi-Auto";
                    BroncoP.impactDMG = 112.0;
                    BroncoP.punctureDMG = 14.0;
                    BroncoP.slashDMG = 14.0;
                    BroncoP.coldDMG = 0;
                    BroncoP.electricityDMG = 0;
                    BroncoP.heatDMG = 0;
                    BroncoP.toxinDMG = 0;
                    BroncoP.statusChance = 17.5;
                    BroncoP.critChance = 2.5;
                    BroncoP.critMultiplier = 1.5;
                    BroncoP.firstDisplay();
                    break;

                case 10:
                    Single Castanas = new Single();
                    Castanas.WeaponName = "Castanas";
                    Castanas.TriggerType = "Active";
                    Castanas.impactDMG = 0;
                    Castanas.punctureDMG = 0;
                    Castanas.slashDMG = 0;
                    Castanas.coldDMG = 0;
                    Castanas.electricityDMG = 100;
                    Castanas.heatDMG = 0;
                    Castanas.toxinDMG = 0;
                    Castanas.statusChance = 10;
                    Castanas.critChance = 5;
                    Castanas.critMultiplier = 1.5;
                    Castanas.firstDisplay();
                    break;

                case 11:
                    Single Cestra = new Single();
                    Cestra.WeaponName = "Cestra";
                    Cestra.TriggerType = "Auto";
                    Cestra.impactDMG = 5.0;
                    Cestra.punctureDMG = 20.0;
                    Cestra.slashDMG = 0;
                    Cestra.coldDMG = 0;
                    Cestra.electricityDMG = 0;
                    Cestra.heatDMG = 0;
                    Cestra.toxinDMG = 0;
                    Cestra.statusChance = 5;
                    Cestra.critChance = 2.5;
                    Cestra.critMultiplier = 1.5;
                    Cestra.firstDisplay();
                    break;

                case 12:
                    Single Despair = new Single();
                    Despair.WeaponName = "Despair";
                    Despair.TriggerType = "Auto";
                    Despair.impactDMG = 2.8;
                    Despair.punctureDMG = 44.0;
                    Despair.slashDMG = 8.2;
                    Despair.coldDMG = 0;
                    Despair.electricityDMG = 0;
                    Despair.heatDMG = 0;
                    Despair.toxinDMG = 0;
                    Despair.statusChance = 2.5;
                    Despair.critChance = 2.5;
                    Despair.critMultiplier = 1.5;
                    Despair.firstDisplay();
                    break;

                case 13:
                    Single Detron = new Single();
                    Detron.WeaponName = "Detron";
                    Detron.TriggerType = "Semi-Auto";
                    Detron.impactDMG = 0;
                    Detron.punctureDMG = 0;
                    Detron.slashDMG = 0;
                    Detron.coldDMG = 0;
                    Detron.electricityDMG = 52.5;
                    Detron.heatDMG = 52.5;
                    Detron.toxinDMG = 0;
                    Detron.statusChance = 10;
                    Detron.critChance = 2.5;
                    Detron.critMultiplier = 1.5;
                    Detron.firstDisplay();
                    break;

                case 14:
                    Single Embolist = new Single();
                    Embolist.WeaponName = "Embolist";
                    Embolist.TriggerType = "Held";
                    Embolist.impactDMG = 0;
                    Embolist.punctureDMG = 0;
                    Embolist.slashDMG = 0;
                    Embolist.coldDMG = 0;
                    Embolist.electricityDMG = 0;
                    Embolist.heatDMG = 0;
                    Embolist.toxinDMG = 18.5;
                    Embolist.statusChance = 10;
                    Embolist.critChance = 2.5;
                    Embolist.critMultiplier = 2;
                    Embolist.firstDisplay();
                    break;

                case 15:
                    Console.WriteLine("Choose mode:\n1. Primary \n2. Alt-Fire");
                    int modeChoice = Convert.ToInt32(Console.ReadLine());
                    switch (modeChoice)
                    {
                        case 1:
                            Single EuphonaPrimeOne = new Single();
                            EuphonaPrimeOne.WeaponName = "Euphona Prime";
                            EuphonaPrimeOne.TriggerType = "Semi-Auto";
                            EuphonaPrimeOne.impactDMG = 292.5;
                            EuphonaPrimeOne.punctureDMG = 16.3;
                            EuphonaPrimeOne.slashDMG = 16.3;
                            EuphonaPrimeOne.coldDMG = 0;
                            EuphonaPrimeOne.electricityDMG = 0;
                            EuphonaPrimeOne.heatDMG = 0;
                            EuphonaPrimeOne.toxinDMG = 0;
                            EuphonaPrimeOne.statusChance = 2;
                            EuphonaPrimeOne.critChance = 30;
                            EuphonaPrimeOne.critMultiplier = 2.5;
                            EuphonaPrimeOne.firstDisplay();
                            break;

                        case 2:
                            Single EuphonaPrimeTwo = new Single();
                            EuphonaPrimeTwo.WeaponName = "Euphona Prime";
                            EuphonaPrimeTwo.TriggerType = "Semi-Auto";
                            EuphonaPrimeTwo.impactDMG = 44.0;
                            EuphonaPrimeTwo.punctureDMG = 176.0;
                            EuphonaPrimeTwo.slashDMG = 660.0;
                            EuphonaPrimeTwo.coldDMG = 0;
                            EuphonaPrimeTwo.electricityDMG = 0;
                            EuphonaPrimeTwo.heatDMG = 0;
                            EuphonaPrimeTwo.toxinDMG = 0;
                            EuphonaPrimeTwo.statusChance = 30;
                            EuphonaPrimeTwo.critChance = 2;
                            EuphonaPrimeTwo.critMultiplier = 2;
                            EuphonaPrimeTwo.firstDisplay();
                            break;
                    }
                    break;

                case 16:
                    Single Furis = new Single();
                    Furis.WeaponName = "Furis";
                    Furis.TriggerType = "Auto";
                    Furis.impactDMG = 2.3;
                    Furis.punctureDMG = 10.5;
                    Furis.slashDMG = 2.2;
                    Furis.coldDMG = 0;
                    Furis.electricityDMG = 0;
                    Furis.heatDMG = 0;
                    Furis.toxinDMG = 0;
                    Furis.statusChance = 1;
                    Furis.critChance = 5;
                    Furis.critMultiplier = 2;
                    Furis.firstDisplay();
                    break;

                case 17:
                    Single Gammacor = new Single();
                    Gammacor.WeaponName = "Gammacor";
                    Gammacor.TriggerType = "Held";
                    Gammacor.impactDMG = 0;
                    Gammacor.punctureDMG = 0;
                    Gammacor.slashDMG = 0;
                    Gammacor.coldDMG = 25;
                    Gammacor.electricityDMG = 25;
                    Gammacor.heatDMG = 0;
                    Gammacor.toxinDMG = 0;
                    Gammacor.statusChance = 5;
                    Gammacor.critChance = 5;
                    Gammacor.critMultiplier = 1.5;
                    Gammacor.firstDisplay();
                    break;

                case 18:
                    Single Hikou = new Single();
                    Hikou.WeaponName = "Hikou";
                    Hikou.TriggerType = "Auto";
                    Hikou.impactDMG = 2.5;
                    Hikou.punctureDMG = 15.0;
                    Hikou.slashDMG = 7.5;
                    Hikou.coldDMG = 0;
                    Hikou.electricityDMG = 0;
                    Hikou.heatDMG = 0;
                    Hikou.toxinDMG = 0;
                    Hikou.statusChance = 2.5;
                    Hikou.critChance = 2.5;
                    Hikou.critMultiplier = 1.5;
                    Hikou.firstDisplay();
                    break;

                case 19:
                    Single HikouP = new Single();
                    HikouP.WeaponName = "Hikou Prime";
                    HikouP.TriggerType = "Auto";
                    HikouP.impactDMG = 3.2;
                    HikouP.punctureDMG = 27.2;
                    HikouP.slashDMG = 1.6;
                    HikouP.coldDMG = 0;
                    HikouP.electricityDMG = 0;
                    HikouP.heatDMG = 0;
                    HikouP.toxinDMG = 0;
                    HikouP.statusChance = 15;
                    HikouP.critChance = 2.5;
                    HikouP.critMultiplier = 1.5;
                    HikouP.firstDisplay();
                    break;

                case 20:
                    Single Kohmak = new Single();
                    Kohmak.WeaponName = "Kohmak";
                    Kohmak.TriggerType = "Auto";
                    Kohmak.impactDMG = 3.2;
                    Kohmak.punctureDMG = 3.2;
                    Kohmak.slashDMG = 9.6;
                    Kohmak.coldDMG = 0;
                    Kohmak.electricityDMG = 0;
                    Kohmak.heatDMG = 0;
                    Kohmak.toxinDMG = 0;
                    Kohmak.statusChance = 10;
                    Kohmak.critChance = 5;
                    Kohmak.critMultiplier = 2;
                    Kohmak.firstDisplay();
                    break;

                default:

                    break;
            }

        }

    }
}
