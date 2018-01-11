using System;
using SimpleSurvivalStrats.Buffs;
using Terraria;
using Terraria.ModLoader;

namespace SimpleSurvivalStrats
{
    public class PlayerModLifesteal : ModPlayer
    {
        private const decimal Lifesteal = .15m;

        public override void OnHitNPC(Item item, NPC target, int damage, float knockback, bool crit)
        {
            if (player.HasBuff(mod.BuffType<LifestealBuff>()))
            {
                player.HealEffect(Convert.ToInt32(damage * Lifesteal));
            }
        }

        public override void OnHitNPCWithProj(Projectile proj, NPC target, int damage, float knockback, bool crit)
        {
            if (player.HasBuff(mod.BuffType<LifestealBuff>()))
            {
                player.HealEffect(Convert.ToInt32(damage * Lifesteal));
            }
        }
    }
}