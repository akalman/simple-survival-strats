using SimpleSurvivalStrats.Buffs;
using Terraria;
using Terraria.ModLoader;

namespace SimpleSurvivalStrats.Items
{
    public class SoulImplant : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Soul Implant");
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
//            if (Debug.On)
            if (true)
            {
                var recipe = Debug.MakeDebugRecipe(mod, this);
                recipe.AddRecipe();
            }
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            if (!player.HasBuff(mod.BuffType<RebirthCooldownBuff>()))
            {
                player.AddBuff(mod.BuffType<RebirthBuff>(), 1);
            }
        }
    }
}
