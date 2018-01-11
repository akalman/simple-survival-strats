using Terraria;
using Terraria.ModLoader;

namespace SimpleSurvivalStrats.Buffs
{
    public class DamageBlockBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Damage Block");
            Description.SetDefault("The next instance of damage will be blocked");

            Main.buffNoTimeDisplay[Type] = true;
            canBeCleared = false;
        }
    }
}
