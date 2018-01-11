using Terraria;
using Terraria.ModLoader;

namespace SimpleSurvivalStrats.Buffs
{
    public class RebirthBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Unfamiliar Presence");
            Description.SetDefault("Strangely foreign whispers echo in your mind");

            Main.buffNoTimeDisplay[Type] = true;
            Main.persistentBuff[Type] = true;
            canBeCleared = false;
        }
    }
}
