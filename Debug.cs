using Terraria.ID;
using Terraria.ModLoader;

namespace SimpleSurvivalStrats
{
    public static class Debug
    {
        public const bool On = true;

        public static ModRecipe MakeDebugRecipe(Mod mod, ModItem result)
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(result);
            return recipe;
        }
    }
}