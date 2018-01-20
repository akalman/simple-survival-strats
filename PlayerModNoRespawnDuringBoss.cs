using System;
using System.Linq;
using Terraria;
using Terraria.ModLoader;

namespace SimpleSurvivalStrats
{
    public class PlayerModNoRespawnDuringBoss: ModPlayer
    {
        public override void PreUpdate()
        {
            if (Main.npc.Any(npc => npc.boss && npc.HasValidTarget))
            {
                if (player.dead)
                {
                    if (!player.GetModPlayer<PlayerModRebirth>().IsRebirthing)
                    {
                        player.respawnTimer = Math.Max(player.respawnTimer, 2);
                    }
                }
            }
        }
    }
}
 