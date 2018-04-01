using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace WarframeDMGCalc
{
    class WelcomePage
    {
       public static void splashWelcome()
        {
            Console.Title = "Warframe Damage Calculator";
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\intro.wav";
            player.Play();



            Console.WriteLine("                                        ,");
            Console.WriteLine("                                        B");
            Console.WriteLine("                                       BMB.");
            Console.WriteLine("                                     3BBBMBX");
            Console.WriteLine("                                  .PMBMBMBMBBD,");
            Console.WriteLine("                                7MBMBMBMBMBMBMBMs");
            Console.WriteLine("                             :EBMBMBMBMx`iMBMBMBMBO:");
            Console.WriteLine("                           7BMBMBBBMBJ     vBBBBBMBMBs");
            Console.WriteLine("                         xMBMBBBMBH,    .    .UBMBMBMBBF");
            Console.WriteLine("            .          .BMBBBMBX:      :Br      .FBMBMBBB:");
            Console.WriteLine("            LR;,.:rUOBMBMBMBM;       ;MBMBBr       :OBMBMBBBRSr:.,:EU");
            Console.WriteLine("             MBMBMBBBMBMBMM.      :053ND^NUD35:       WMBBBMBMBMBMBM");
            Console.WriteLine("             HMB.::.  BBMc     .HBMBMBK   FBBBMBZ,     ;BBB  .::.BBM");
            Console.WriteLine("             MBM      UMP    .BMBMBZ:       ,HBMBMB:    LBM      MBM");
            Console.WriteLine("             BBB   BMBMBr   cBMBW:     0BM     .0BMBF   .BMBMB   BMB:");
            Console.WriteLine("            WBBx   cBL.iB   BMR     cMBM1MBM3     PMB   M7,;BK   ;BMB");
            Console.WriteLine("            MBM    BM:  .J  BB    RBMB;   :RMBM    RM  c:   MB    MBM");
            Console.WriteLine("           :BM7    BB     , ,M   MBr         ;BM   Or .     BM:   :MBi");
            Console.WriteLine("           :MB,   7B7        .i  B             B  ::        :BS    BM");
            Console.WriteLine("            BMG    BK             :           .,            cM:   2MB");
            Console.WriteLine("             BMH   .Mi     : :                 E:          :M:   sMB");
            Console.WriteLine("                   Welcome to the Warframe Damage Calculator!");
            Console.WriteLine("                   Latest Warframe Update Supported: 20.1.0");
            Console.Write("                           Press any key to continue.");
            Console.WriteLine("");
            Console.ReadKey(true);
        }


    }
}
