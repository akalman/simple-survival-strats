using SimpleSurvivalStrats.Buffs;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SimpleSurvivalStrats.Items
{
    public class PestilenceDemonsPact : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pestilence Demon's Pact");
            Tooltip.SetDefault(@"
Damaging enemies heals you.
Significantly increases max health.
Gives extremely fast health regen out of combat.
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
            recipe.AddIngredient(ItemID.BandofRegeneration, 1);
            recipe.AddIngredient(ItemID.LifeforcePotion, 2);
            recipe.AddIngredient(mod.ItemType<BloodDemonsPact>(), 1);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this);
            recipe.AddRecipe();
            recipe = null;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.AddBuff(mod.BuffType<LifestealBuff>(), 1);
            player.statLifeMax2 += 200;
        }
    }
}
