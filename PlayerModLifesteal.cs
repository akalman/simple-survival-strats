using System;
using System.Linq;
using SimpleSurvivalStrats.Buffs;
using SimpleSurvivalStrats.Items;
using Terraria;
using Terraria.ModLoader;

namespace SimpleSurvivalStrats
{
    public class PlayerModLifesteal : ModPlayer
    {
        private const decimal Lifesteal = .05m;
        private const decimal DebugLifesteal = 1m;

        private bool _overcharged = false;
        private int _overchargedTime = 0;

        public override void OnHitNPC(Item item, NPC target, int damage, float knockback, bool crit)
        {
            if (crit && player.armor.Any(equip => equip.type == mod.ItemType<BloodGodsPact>()))
            {
                _overcharged = true;
                _overchargedTime = 1 * Timing.Seconds;
            }

            ApplyLifesteal(damage);
        }

        public override void OnHitNPCWithProj(Projectile proj, NPC target, int damage, float knockback, bool crit)
        {
            ApplyLifesteal(damage);
        }

        public override void PostUpdate()
        {
            if (_overcharged)
            {
                _overchargedTime--;

                if (_overchargedTime <= 0)
                {
                    _overcharged = false;
                    _overchargedTime = 0;
                }
            }
        }

        private void ApplyLifesteal(int damage)
        {
            var rawLifesteal = Debug.On ? DebugLifesteal : Lifesteal;
            var lifesteal = _overcharged ? rawLifesteal * 2 : rawLifesteal;
            if (player.HasBuff(mod.BuffType<LifestealBuff>()))
            {
                Util.Heal(player, Convert.ToInt32(damage * lifesteal));
            }
        }
    }
}