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
            var activeBosses = Main.npc
                .Where(npc => npc.active)
                .Where(npc => npc.boss);

            if (activeBosses.Any())
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

    public class BossExists : GlobalNPC
    {
        public override void PostAI(NPC npc)
        {
            var playersAlive = Main.player
                .Where(player => !player.dead || player.GetModPlayer<PlayerModRebirth>().IsRebirthing);

            if (npc.boss && playersAlive.Any())
            {
                npc.active = false;
            }
        }
    }
}
 