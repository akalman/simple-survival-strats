using Terraria.ModLoader;

namespace SimpleSurvivalStrats
{
    class SimpleSurvivalStrats : Mod
    {
        public SimpleSurvivalStrats()
        {
            Properties = new ModProperties
            {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true
            };
        }

//        public override void Load()
//        {
//            base.Load();
//
//            AddPlayer("EffectiveHealthDefensePlayer", new EffectiveHealthDefensePlayer());
//        }
    }
}
