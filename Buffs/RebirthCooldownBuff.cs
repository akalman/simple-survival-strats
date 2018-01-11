using Terraria;
using Terraria.ModLoader;

namespace SimpleSurvivalStrats.Buffs
{
    public class RebirthCooldownBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Unfamiliar Presence Cooldown");
            Description.SetDefault("Your thoughts linger unanswered");

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
