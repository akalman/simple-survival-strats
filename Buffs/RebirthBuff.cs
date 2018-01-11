using Terraria;
using Terraria.ModLoader;

namespace SimpleSurvivalStrats.Buffs
{
    public class RebirthBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Rebirth");
            Description.SetDefault("Your soul feels overflowing with energy");

            Main.buffNoTimeDisplay[Type] = true;
            Main.persistentBuff[Type] = true;
            canBeCleared = false;
        }
    }
}
