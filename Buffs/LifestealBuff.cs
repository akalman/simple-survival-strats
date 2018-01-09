using Terraria;
using Terraria.ModLoader;

namespace SimpleSurvivalStrats.Buffs
{
    public class LifestealBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Lifesteal");
            Description.SetDefault("Dealing damage heals you");

            Main.buffNoTimeDisplay[Type] = true;
            canBeCleared = false;
        }
    }
}
