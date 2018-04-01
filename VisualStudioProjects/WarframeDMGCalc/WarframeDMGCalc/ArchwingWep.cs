using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeDMGCalc
{
    class ArchwingWep
    {
        public struct ArchGun
        {
            public string WeaponName;
            public string WeaponType;
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
        }

        public struct ArchMelee
        {
            public string WeaponName;
            public string WeaponType;
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
        }
    }
}
