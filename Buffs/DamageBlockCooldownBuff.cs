using Terraria;
using Terraria.ModLoader;

namespace SimpleSurvivalStrats.Buffs
{
    public class DamageBlockCooldownBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Damage Block Cooldown");
            Description.SetDefault("Damage has been recently blocked");

            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = true;
            canBeCleared = false;
        }
    }
}
