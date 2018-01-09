using System;
using Terraria;
using Terraria.ModLoader;

namespace SimpleSurvivalStrats
{
    public class LifestealPlayerMod : ModPlayer
    {
        private const decimal Lifesteal = .15m;

        public override void OnHitNPC(Item item, NPC target, int damage, float knockback, bool crit)
        {
            player.HealEffect(Convert.ToInt32(damage * Lifesteal));
        }

        public override void OnHitNPCWithProj(Projectile proj, NPC target, int damage, float knockback, bool crit)
        {
            player.HealEffect(Convert.ToInt32(damage * Lifesteal));
        }
    }
}