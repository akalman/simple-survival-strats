using System;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace SimpleSurvivalStrats
{
    public class EffectiveHealthDefensePlayerMod : ModPlayer
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
            customDamage = true;

            var floatRawDamage = damage * 1.0;
            var numerator = 0.05 * player.statDefense;
            var scalingDenominatorPart = 0.05 * Math.Abs(player.statDefense);
            var denominator = 1 + scalingDenominatorPart;
            var damageMultiplier = 1 - (numerator / denominator);
            var floatDamage = floatRawDamage * damageMultiplier;

            damage = Convert.ToInt32(floatDamage);

            return true;
        }
    }
}