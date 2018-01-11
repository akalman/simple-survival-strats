using System;
using SimpleSurvivalStrats.Buffs;
using Terraria;
using Terraria.ModLoader;

namespace SimpleSurvivalStrats
{
    public class PlayerModLifesteal : ModPlayer
    {
        private const decimal Lifesteal = .15m;
        private const decimal DebugLifesteal = 1m;

        public override void OnHitNPC(Item item, NPC target, int damage, float knockback, bool crit)
        {
            ApplyLifesteal(damage);
        }

        public override void OnHitNPCWithProj(Projectile proj, NPC target, int damage, float knockback, bool crit)
        {
            ApplyLifesteal(damage);
        }

        private void ApplyLifesteal(int damage)
        {
            var lifesteal = Debug.On ? DebugLifesteal : Lifesteal;
            if (player.HasBuff(mod.BuffType<LifestealBuff>()))
            {
                player.HealEffect(Convert.ToInt32(damage * lifesteal));
            }
        }
    }
}