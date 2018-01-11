using Terraria;
using Terraria.ModLoader;

namespace SimpleSurvivalStrats.Buffs
{
    public class RebirthCooldownBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Rebirth Cooldown");
            Description.SetDefault("Your soul burns like its never touched air before");

            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = true;
            Main.persistentBuff[Type] = true;
            canBeCleared = false;
        }
    }
}
