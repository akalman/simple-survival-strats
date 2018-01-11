using Terraria;
using Terraria.ModLoader;

namespace SimpleSurvivalStrats.Buffs
{
    public class DamageBlockBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Angel's Favor");
            Description.SetDefault("A subtle warmth clings to you");

            Main.buffNoTimeDisplay[Type] = true;
            Main.persistentBuff[Type] = true;
            canBeCleared = false;
        }
    }
}
