using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace WarframeDMGCalc
{
    class CreditPage
    {
        public static void credits()
        {
            Console.Clear();

            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\credits.wav";
            player.Play();

            Console.WriteLine("Credits");
            Console.WriteLine("~~~~~~~~~");
            Console.WriteLine("Made by: SirAstraeus_");
            Console.WriteLine("Feel free to follow me on Twitter: @SirAstraeus_");
            Console.WriteLine("Check out my work on GitHub: SirAstraeus_");
            Console.WriteLine("");
            Console.WriteLine("Helpers:");
            Console.WriteLine("ShadowTraitor");
            Console.WriteLine("Nanoskaa");
            Console.ReadKey(true);

            player.Stop();

            Console.Clear();
            Program main = new Program();
            Program.weaponChoice();


        }
    }
}
