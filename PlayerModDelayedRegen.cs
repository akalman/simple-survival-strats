using System.Linq;
using SimpleSurvivalStrats.Items;
using Terraria;
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
            if (_ticksSinceLastDamageOrAttack > 10 * Timing.Seconds)
            {
                Util.HealSilent(player, 2);
            }
        }

        public override void PostUpdate()
        {
            if (player.armor.Any(equip => equip.type == mod.ItemType<PestilenceDemonsPact>()))
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
 