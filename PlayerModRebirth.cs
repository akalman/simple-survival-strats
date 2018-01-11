using SimpleSurvivalStrats.Buffs;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace SimpleSurvivalStrats
{
    public class PlayerModRebirth : ModPlayer
    {
        private bool _isRebirthing = false;
        private bool _readyToTeleport = false;

        public override void Kill(double damage, int hitDirection, bool pvp, PlayerDeathReason damageSource)
        {
            if (player.HasBuff(mod.BuffType<RebirthBuff>()))
            {
                _isRebirthing = true;

                player.respawnTimer = (Debug.On ? 1 : 5) * Timing.Seconds;
                player.AddBuff(mod.BuffType<RebirthCooldownBuff>(), 5 * Timing.Minutes, false);
                player.DelBuff(player.FindBuffIndex(mod.BuffType<RebirthBuff>()));
            }
        }

        public override void OnRespawn(Player player)
        {
            if (_isRebirthing)
            {
                _isRebirthing = false;
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