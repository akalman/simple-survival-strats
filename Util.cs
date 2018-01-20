using Terraria;

namespace SimpleSurvivalStrats
{
    public static class Util
    {
        public static void Heal(Player player, int amount)
        {
            HealSilent(player, amount);

            if (Main.myPlayer == player.whoAmI)
            {
                player.HealEffect(amount, false);
            }
        }

        public static void HealSilent(Player player, int amount)
        {
            player.statLife += amount;

            if (player.statLife > player.statLifeMax2)
            {
                player.statLife = player.statLifeMax2;
            }
        }
    }
}