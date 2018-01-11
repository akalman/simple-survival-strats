using SimpleSurvivalStrats.Buffs;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace SimpleSurvivalStrats
{
    public class PlayerModDamageBlock : ModPlayer
    {
        public override bool PreHurt(
            bool pvp,
            bool quiet,
            ref int damage,
            ref int hitDirection,
            ref bool crit,
            ref bool customDamage,
            ref bool playSound,
            ref bool genGore,
            ref PlayerDeathReason damageSource)
        {
            if (player.HasBuff(mod.BuffType<DamageBlockBuff>()))
            {
                player.AddBuff(mod.BuffType<DamageBlockCooldownBuff>(), 30 * Timing.Seconds, false);

                customDamage = true;
                damage = 1;
            }

            return true;
        }
    }
}