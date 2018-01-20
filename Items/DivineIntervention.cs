using SimpleSurvivalStrats.Buffs;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SimpleSurvivalStrats.Items
{
    public class DivineIntervention : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Divine Intervention");
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
            recipe.AddIngredient(ItemID.StarVeil, 1);
            recipe.AddIngredient(ItemID.ThornsPotion, 5);
            recipe.AddIngredient(mod.ItemType<LesserAngelsPact>(), 1);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this);
            recipe.AddRecipe();
            recipe = null;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.starCloak = true;
            player.longInvince = true;

            if (!player.HasBuff(mod.BuffType<DamageBlockCooldownBuff>()))
            {
                player.AddBuff(mod.BuffType<DamageBlockBuff>(), 1);
            }
        }
    }
}
