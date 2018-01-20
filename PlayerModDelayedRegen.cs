using System.Linq;
using SimpleSurvivalStrats.Buffs;
using SimpleSurvivalStrats.Items;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace SimpleSurvivalStrats
{
    public class PlayerModDelayedRegen: ModPlayer
    {
        private int _ticksSinceLastDamageOrAttack = 0;

        public override void PostHurt(bool pvp, bool quiet, double damage, int hitDirection, bool crit)
        {
            _ticksSinceLastDamageOrAttack = 0;
        }

        public override void OnHitAnything(float x, float y, Entity victim)
        {
            _ticksSinceLastDamageOrAttack = 0;
        }

        public override void PreUpdate()
        {
            if (_ticksSinceLastDamageOrAttack > 20 * Timing.Seconds)
            {
                player.lifeRegen += 10;
            }
        }

        public override void PostUpdate()
        {
            if (player.miscEquips.Any(equip => equip.type == mod.ItemType<PestilenceDemonsPact>()))
            {
                _ticksSinceLastDamageOrAttack++;
            }
            else
            {
                _ticksSinceLastDamageOrAttack = 0;
            }
        }
    }
}