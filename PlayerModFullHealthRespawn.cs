using System.Linq;
using SimpleSurvivalStrats.Items;
using Terraria;
using Terraria.ModLoader;

namespace SimpleSurvivalStrats
{
    public class PlayerModFullHealthRespawn: ModPlayer
    {
        public override void OnRespawn(Player player)
        {
            if (player.armor.Any(equip => equip.type == mod.ItemType<SecondLife>()))
            {
                player.statLife = player.statLifeMax2;
            }
        }
    }
}
 