using SimpleSurvivalStrats.Buffs;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SimpleSurvivalStrats.Items
{
    public class SecondLife : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Second Life");
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
            recipe.AddIngredient(ItemID.CobaltShield, 1);
            recipe.AddIngredient(ItemID.LifeforcePotion, 1);
            recipe.AddIngredient(mod.ItemType<SoulImplant>(), 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
            recipe = null;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.statLifeMax2 += 100;
            player.noKnockback = true;

            if (!player.HasBuff(mod.BuffType<RebirthCooldownBuff>()))
            {
                player.AddBuff(mod.BuffType<RebirthBuff>(), 1);
            }
        }
    }
}
