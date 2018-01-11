using Terraria;
using Terraria.ModLoader;

namespace SimpleSurvivalStrats.Buffs
{
    public class LifestealBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Demonic Tribute");
            Description.SetDefault("Blood you've spilt boils and energizes you");

            Main.buffNoTimeDisplay[Type] = true;
            Main.persistentBuff[Type] = true;
            canBeCleared = false;
        }
    }
}
