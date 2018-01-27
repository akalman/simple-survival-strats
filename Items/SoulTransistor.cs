using SimpleSurvivalStrats.Buffs;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SimpleSurvivalStrats.Items
{
    public class SoulTransistor : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Soul Transistor");
            Tooltip.SetDefault(@"
Infrequently prevents death.
Cooldown is reduced by dealing damage.
            ");
        }

        public override void SetDefaults()
        {
            item.width = 40;
            item.height = 40;
            item.value = 10000;
            item.rare = 2;
            item.accessory = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = null;
            if (Debug.On)
            {
                recipe = Debug.MakeDebugRecipe(mod, this);
                recipe.AddRecipe();
                recipe = null;
            }

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SoulofMight, 5);
            recipe.AddIngredient(ItemID.SoulofSight, 5);
            recipe.AddIngredient(ItemID.SoulofFright, 5);
            recipe.AddIngredient(mod.ItemType<SoulImplant>(), 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
            recipe = null;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            if (!player.HasBuff(mod.BuffType<RebirthCooldownBuff>()))
            {
                if (!player.HasBuff(mod.BuffType<RebirthBuff>()))
                {
                    player.AddBuff(mod.BuffType<RebirthBuff>(), 2 * Timing.Frames);
                }
                else
                {
                    player.buffTime[player.FindBuffIndex(mod.BuffType<RebirthBuff>())] = 2 * Timing.Frames;
                }
            }
        }
    }
}
