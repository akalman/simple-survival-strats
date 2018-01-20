using System.Linq;
using SimpleSurvivalStrats.Buffs;
using SimpleSurvivalStrats.Items;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace SimpleSurvivalStrats
{
    public class PlayerModRebirth : ModPlayer
    {
        public bool IsRebirthing = false;

        private bool _readyToTeleport = false;

        public override void Kill(double damage, int hitDirection, bool pvp, PlayerDeathReason damageSource)
        {
            if (player.HasBuff(mod.BuffType<RebirthBuff>()))
            {
                IsRebirthing = true;

                player.respawnTimer = (Debug.On ? 1 : 5) * Timing.Seconds;
                player.AddBuff(mod.BuffType<RebirthCooldownBuff>(), 5 * Timing.Minutes, false);
                player.DelBuff(player.FindBuffIndex(mod.BuffType<RebirthBuff>()));
            }
        }

        public override void OnHitAnything(float x, float y, Entity victim)
        {
            if (player.armor.Any(equip => equip.type == mod.ItemType<SoulTransistor>())
                && player.HasBuff(mod.BuffType<RebirthCooldownBuff>()))
            {
                player.buffTime[player.FindBuffIndex(mod.BuffType<RebirthCooldownBuff>())] -= 1 * Timing.Seconds;
            }
        }

        public override void OnRespawn(Player player)
        {
            if (IsRebirthing)
            {
                IsRebirthing = false;
                _readyToTeleport = true;
            }
        }

        public override void PostUpdate()
        {
            if (_readyToTeleport)
            {
                player.Teleport(player.lastDeathPostion);
                _readyToTeleport = false;
            }
        }
    }
}