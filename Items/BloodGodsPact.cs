using SimpleSurvivalStrats.Buffs;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SimpleSurvivalStrats.Items
{
    public class BloodGodsPact : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Blood God's Pact");
            Tooltip.SetDefault(@"
Damaging enemies heals you.
The effect is doubled briefly after a critical hit.
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
            recipe.AddIngredient(ItemID.AvengerEmblem, 1);
            recipe.AddIngredient(ItemID.MoonStone, 1);
            recipe.AddIngredient(mod.ItemType<BloodDemonsPact>(), 1);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this);
            recipe.AddRecipe();
            recipe = null;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.AddBuff(mod.BuffType<LifestealBuff>(), 1);
            player.magicCrit += 10;
            player.meleeCrit += 10;
            player.rangedCrit += 10;
            player.thrownCrit += 10;
        }
    }
}
