using SimpleSurvivalStrats.Buffs;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SimpleSurvivalStrats.Items
{
    public class SoulImplant : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Soul Implant");
            Tooltip.SetDefault(@"
Infrequently prevents death.
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
            recipe.AddIngredient(ItemID.GuideVoodooDoll, 1);
            recipe.AddIngredient(ItemID.ClothierVoodooDoll, 1);
            recipe.AddIngredient(ItemID.Actuator, 1);
            recipe.AddTile(TileID.WorkBenches);
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
