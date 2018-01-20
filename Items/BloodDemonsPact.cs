using SimpleSurvivalStrats.Buffs;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SimpleSurvivalStrats.Items
{
    public class BloodDemonsPact : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Blood Demon's Pact");
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
            recipe.AddIngredient(ItemID.Shackle, 1);
            recipe.AddIngredient(ItemID.Vertebrae, 5);
            recipe.AddIngredient(ItemID.Bunny, 1);
            recipe.AddIngredient(ItemID.ThrowingKnife, 1);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this);
            recipe.AddRecipe();
            recipe = null;

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Shackle, 1);
            recipe.AddIngredient(ItemID.RottenChunk, 5);
            recipe.AddIngredient(ItemID.Bunny, 1);
            recipe.AddIngredient(ItemID.ThrowingKnife, 1);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this);
            recipe.AddRecipe();
            recipe = null;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.AddBuff(mod.BuffType<LifestealBuff>(), 1);
        }
    }
}
