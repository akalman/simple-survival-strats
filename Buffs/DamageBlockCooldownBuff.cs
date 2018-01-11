using Terraria;
using Terraria.ModLoader;

namespace SimpleSurvivalStrats.Buffs
{
    public class DamageBlockCooldownBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Angel's Favor Cooldown");
            Description.SetDefault("The cold is crisp and biting");

            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = true;
            Main.persistentBuff[Type] = true;
            canBeCleared = false;

            if (Debug.On)
            {
                Main.debuff[Type] = false;
                canBeCleared = true;
            }
        }
    }
}
