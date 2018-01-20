using SimpleSurvivalStrats.Buffs;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SimpleSurvivalStrats.Items
{
    public class MercurysBoots : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mercury's Boots");
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
            recipe.AddIngredient(ItemID.FrostsparkBoots, 1);
            recipe.AddIngredient(ItemID.EoCShield, 1);
            recipe.AddIngredient(mod.ItemType<LesserAngelsPact>(), 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
            recipe = null;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.accRunSpeed = 6.75f;
            player.rocketBoots = 3;
            player.moveSpeed = player.moveSpeed + 0.08f;
            player.iceSkate = true;
            player.dash = 2;

            if (!player.HasBuff(mod.BuffType<DamageBlockCooldownBuff>()))
            {
                player.AddBuff(mod.BuffType<DamageBlockBuff>(), 1);
            }
        }
    }
}
