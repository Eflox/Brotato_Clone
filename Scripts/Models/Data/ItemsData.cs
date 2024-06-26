/*
 * ItemsData.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 05/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using Brotato_Clone.Interfaces;
using System.Collections.Generic;

namespace Brotato_Clone.Models
{
    public static class ItemsData
    {
        public static readonly IReadOnlyDictionary<string, Item> Items;
        public static readonly IReadOnlyDictionary<string, IAttribute> Attributes;

        private static readonly string _assetSource = "Brotato";
        private static readonly string _path = "Sprites/Items";

        static ItemsData()
        {
            Attributes = new Dictionary<string, IAttribute>
            {
                { "WellRounded", new WellRoundedAttribute() },
                { "Brawler", new BrawlerAttributeData() },

                { "Heart", new HeartAttribute() },
                { "Lungs", new LungsAttribute() },
                { "Teeth", new TeethAttribute() },

                { "Acid", new AcidAttribute() },
                { "Adrenaline", new AdrenalineAttribute() },
                { "AlienBaby", new AlienBabyAttribute() },
                { "AlienEyes", new AlienEyesAttribute() },
                { "AlienMagic", new AlienMagicAttribute() },
                { "AlienTongue", new AlienTongueAttribute() },
                { "AlienWorm", new AlienWormAttribute() },
                { "Alloy", new AlloyAttribute() },
                { "Anvil", new AnvilAttribute() },
                { "BabyElephant", new BabyElephantAttribute() },
                { "BabyGecko", new BabyGeckoAttribute() },
                { "BabyWithABeard", new BabyWithABeardAttribute() },
                { "Bag", new BagAttribute() },
                { "Bandana", new BandanaAttribute() },
                { "Banner", new BannerAttribute() },
                { "Barricade", new BarricadeAttribute() },
                { "Bat", new BatAttribute() },
                { "BeanTeacher", new BeanTeacherAttribute() },
                { "Beanie", new BeanieAttribute() },
                { "BigArms", new BigArmsAttribute() },
                { "BlackBelt", new BlackBeltAttribute() },
                { "Blindfold", new BlindfoldAttribute() },
                { "BloodDonation", new BloodDonationAttribute() },
                { "BloodLeech", new BloodLeechAttribute() },
                { "BloodyHand", new BloodyHandAttribute() },
                { "BoilingWater", new BoilingWaterAttribute() },
                { "Book", new BookAttribute() },
                { "BowlerHat", new BowlerHatAttribute() },
                { "BoxingGlove", new BoxingGloveAttribute() },
                { "BrokenMouth", new BrokenMouthAttribute() },
                { "Butterfly", new ButterflyAttribute() },
                { "Cake", new CakeAttribute() },
                { "Campfire", new CampfireAttribute() },
                { "Candle", new CandleAttribute() },
                { "Cape", new CapeAttribute() },
                { "Chameleon", new ChameleonAttribute() },
                { "Charcoal", new CharcoalAttribute() },
                { "ClawTree", new ClawTreeAttribute() },
                { "Clover", new CloverAttribute() },
                { "Coffee", new CoffeeAttribute() },
                { "Cog", new CogAttribute() },
                { "CommunitySupport", new CommunitySupportAttribute() },
                { "Compass", new CompassAttribute() },
                { "Coupon", new CouponAttribute() },
                { "Crown", new CrownAttribute() },
                { "CuteMonkey", new CuteMonkeyAttribute() },
                { "Cyberball", new CyberballAttribute() },
                { "CyclopsWorm", new CyclopsWormAttribute() },
                { "DangerousBunny", new DangerousBunnyAttribute() },
                { "DefectiveSteroids", new DefectiveSteroidsAttribute() },
                { "Diploma", new DiplomaAttribute() },
                { "DuctTape", new DuctTapeAttribute() },
                { "Dynamite", new DynamiteAttribute() },
                { "EnergyBracelet", new EnergyBraceletAttribute() },
                { "EstysCouch", new EstysCouchAttribute() },
                { "Exoskeleton", new ExoskeletonAttribute() },
                { "ExplosiveShells", new ExplosiveShellsAttribute() },
                { "ExplosiveTurret", new ExplosiveTurretAttribute() },
                { "ExtraStomach", new ExtraStomachAttribute() },
                { "EyesSurgery", new EyesSurgeryAttribute() },
                { "Fertilizer", new FertilizerAttribute() },
                { "Fairy", new FairyAttribute() },
                { "Fin", new FinAttribute() },
                { "Focus", new FocusAttribute() },
                { "FuelTank", new FuelTankAttribute() },
                { "GamblingToken", new GamblingTokenAttribute() },
                { "Garden", new GardenAttribute() },
                { "GentleAlien", new GentleAlienAttribute() },
                { "GiantBelt", new GiantBeltAttribute() },
                { "GlassCannon", new GlassCannonAttribute() },
                { "Glasses", new GlassesAttribute() },
                { "Gnome", new GnomeAttribute() },
                { "GoatSkull", new GoatSkullAttribute() },
                { "GrindsMagicalLeaf", new GrindsMagicalLeafAttribute() },
                { "GummyBerserker", new GummyBerserkerAttribute() },
                { "Handcuffs", new HandcuffsAttribute() },
                { "HeadInjury", new HeadInjuryAttribute() },
                { "HeavyBullets", new HeavyBulletsAttribute() },
                { "Hedgehog", new HedgehogAttribute() },
                { "Helmet", new HelmetAttribute() },
                { "HuntingTrophy", new HuntingTrophyAttribute() },
                { "ImprovedTools", new ImprovedToolsAttribute() },
                { "IncendiaryTurret", new IncendiaryTurretAttribute() },
                { "Injection", new InjectionAttribute() },
                { "Insanity", new InsanityAttribute() },
                { "JetPack", new JetPackAttribute() },
                { "Landmines", new LandminesAttribute() },
                { "LaserTurret", new LaserTurretAttribute() },
                { "LeatherVest", new LeatherVestAttribute() },
                { "Lemonade", new LemonadeAttribute() },
                { "Lens", new LensAttribute() },
                { "LittleFrog", new LittleFrogAttribute() },
                { "LittleMuscleyDude", new LittleMuscleyDudeAttribute() },
                { "LostDuck", new LostDuckAttribute() },
                { "LuckyCharm", new LuckyCharmAttribute() },
                { "LuckyCoin", new LuckyCoinAttribute() },
                { "Lure", new LureAttribute() },
                { "LumberjackShirt", new LumberjackShirtAttribute() },
                { "Mammoth", new MammothAttribute() },
                { "Mastery", new MasteryAttribute() },
                { "Medal", new MedalAttribute() },
                { "MedicalTurret", new MedicalTurretAttribute() },
                { "Medikit", new MedikitAttribute() },
                { "MetalDetector", new MetalDetectorAttribute() },
                { "MetalPlate", new MetalPlateAttribute() },
                { "Missile", new MissileAttribute() },
                { "Mouse", new MouseAttribute() },
                { "Mushroom", new MushroomAttribute() },
                { "Mutation", new MutationAttribute() },
                { "NightGoggles", new NightGogglesAttribute() },
                { "Octopus", new OctopusAttribute() },
                { "Padding", new PaddingAttribute() },
                { "Panda", new PandaAttribute() },
                { "PeacefulBee", new PeacefulBeeAttribute() },
                { "Peacock", new PeacockAttribute() },
                { "Pencil", new PencilAttribute() },
                { "PiggyBank", new PiggyBankAttribute() },
                { "Plant", new PlantAttribute() },
                { "PlasticExplosive", new PlasticExplosiveAttribute() },
                { "PoisonousTonic", new PoisonousTonicAttribute() },
                { "PocketFactory", new PocketFactoryAttribute() },
                { "Potato", new PotatoAttribute() },
                { "PowerGenerator", new PowerGeneratorAttribute() },
                { "PropellerHat", new PropellerHatAttribute() },
                { "Pumpkin", new PumpkinAttribute() },
                { "RecyclingMachine", new RecyclingMachineAttribute() },
                { "RegenerationPotion", new RegenerationPotionAttribute() },
                { "RetromationsHoodie", new RetromationsHoodieAttribute() },
                { "Ricochet", new RicochetAttribute() },
                { "RipAndTear", new RipandTearAttribute() },
                { "Riposte", new RiposteAttribute() },
                { "Ritual", new RitualAttribute() },
                { "RobotArm", new RobotArmAttribute() },
                { "SadTomato", new SadTomatoAttribute() },
                { "Scar", new ScarAttribute() },
                { "ScaredSausage", new ScaredSausageAttribute() },
                { "Scope", new ScopeAttribute() },
                { "Shackles", new ShacklesAttribute() },
                { "ShadyPotion", new ShadyPotionAttribute() },
                { "SharpBullet", new SharpBulletAttribute() },
                { "Shmoop", new ShmoopAttribute() },
                { "SifdsRelic", new SifdsRelicAttribute() },
                { "SilverBullet", new SilverBulletAttribute() },
                { "SmallMagazine", new SmallMagazineAttribute() },
                { "Snail", new SnailAttribute() },
                { "Snake", new SnakeAttribute() },
                { "SpicySauce", new SpicySauceAttribute() },
                { "Spider", new SpiderAttribute() },
                { "Statue", new StatueAttribute() },
                { "StrangeBook", new StrangeBookAttribute() },
                { "StoneSkin", new StoneSkinAttribute() },
                { "Sunglasses", new SunglassesAttribute() },
                { "Tardigrade", new TardigradeAttribute() },
                { "Tentacle", new TentacleAttribute() },
                { "TerrifiedOnion", new TerrifiedOnionAttribute() },
                { "Toolbox", new ToolboxAttribute() },
                { "Torture", new TortureAttribute() },
                { "ToxicSludge", new ToxicSludgeAttribute() },
                { "Tractor", new TractorAttribute() },
                { "Tree", new TreeAttribute() },
                { "TriangleOfPower", new TriangleofPowerAttribute() },
                { "Turret", new TurretAttribute() },
                { "Tyler", new TylerAttribute() },
                { "UglyTooth", new UglyToothAttribute() },
                { "VigilanteRing", new VigilanteRingAttribute() },
                { "WanderingBot", new WanderingBotAttribute() },
                { "WarriorHelmet", new WarriorHelmetAttribute() },
                { "WeirdFood", new WeirdFoodAttribute() },
                { "WeirdGhost", new WeirdGhostAttribute() },
                { "Wheat", new WheatAttribute() },
                { "Wheelbarrow", new WheelbarrowAttribute() },
                { "Whetstone", new WhetstoneAttribute() },
                { "WhiteFlag", new WhiteFlagAttribute() },
                { "Wings", new WingsAttribute() },
                { "Wisdom", new WisdomAttribute() },
                { "WolfHelmet", new WolfHelmetAttribute() }
            };

            string fullPath = $"{_assetSource}/{_path}/";

            Items = new Dictionary<string, Item>
            {
                {
                    "Acid", new Item
                    {
                        Name = "Acid",
                        Description = "+8 Max HP\n-4% Dodge",
                        SpritePath = $"{fullPath}/Acid",
                        Rarity = Rarity.Tier2,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 65,
                        Limit = 0
                    }
                },
                {
                    "Adrenaline", new Item
                    {
                        Name = "Adrenaline",
                        Description = "+5% Dodge\n50% chance to heal 5 HP when dodging an attack",
                        SpritePath = $"{fullPath}/Adrenaline",
                        Rarity = Rarity.Tier3,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 60,
                        Limit = 1
                    }
                },
                {
                    "AlienBaby", new Item
                    {
                        Name = "AlienBaby",
                        Description = "+15 Max HP\n+8 Enemy Speed",
                        SpritePath = $"{fullPath}/AlienBaby",
                        Rarity = Rarity.Tier3,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 80,
                        Limit = 0
                    }
                },
                {
                    "AlienEyes", new Item
                    {
                        Name = "AlienEyes",
                        Description = "Shoots +6 alien eyes around you every 3 seconds dealing (50% Max HP) damage",
                        SpritePath = $"{fullPath}/AlienEyes",
                        Rarity = Rarity.Tier2,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 50,
                        Limit = 0
                    }
                },
                {
                    "AlienMagic", new Item
                    {
                        Name = "AlienMagic",
                        Description = "+8 Max HP\n+3 HP Regeneration\n-8 Luck",
                        SpritePath = $"{fullPath}/AlienMagic",
                        Rarity = Rarity.Tier3,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 85,
                        Limit = 0
                    }
                },
                {
                    "AlienTongue", new Item
                    {
                        Name = "AlienTongue",
                        Description = "+30% pickup range",
                        SpritePath = $"{fullPath}/AlienTongue",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 25,
                        Limit = 0
                    }
                },
                {
                    "AlienWorm", new Item
                    {
                        Name = "AlienWorm",
                        Description = "+2 HP Regeneration\n-1 HP recovered from consumables\n+3 Max HP",
                        SpritePath = $"{fullPath}/AlienWorm",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 15,
                        Limit = 0
                    }
                },
                {
                    "Alloy", new Item
                    {
                        Name = "Alloy",
                        Description = "+3 Melee Damage\n+3 Ranged Damage\n+3 Elemental Damage\n+3 Engineering\n+5% Crit Chance\n-6% Dodge",
                        SpritePath = $"{fullPath}/Alloy",
                        Rarity = Rarity.Tier3,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 80,
                        Limit = 0
                    }
                },
                {
                    "Anvil", new Item
                    {
                        Name = "Anvil",
                        Description = "A random weapon is upgraded when entering a shop. If you have no weapon to upgrade, you gain +2 Armor instead.",
                        SpritePath = $"{fullPath}/Anvil",
                        Rarity = Rarity.Tier4,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 120,
                        Limit = 1,
                    }
                },
                {
                    "BabyElephant", new Item
                    {
                        Name = "BabyElephant",
                        Description = "+25% chance to deal (25% Luck) damage to a random enemy when you pick up a material",
                        SpritePath = $"{fullPath}/BabyElephant",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 25,
                        Limit = 0
                    }
                },
                {
                    "BabyGecko", new Item
                    {
                        Name = "BabyGecko",
                        Description = "+20% chance to instantly attract a material when it's dropped\n+10 Range",
                        SpritePath = $"{fullPath}/BabyGecko",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 18,
                        Limit = 5
                    }
                },
                {
                    "BabyWithABeard", new Item
                    {
                        Name = "BabyWithABeard",
                        Description = "+1 bullet dealing 1+ (100% Ranged Damage) damage is fired from an enemy corpse when they die\n-50 Range",
                        SpritePath = $"{fullPath}/BabyWithABeard",
                        Rarity = Rarity.Tier3,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 100,
                        Limit = 0
                    }
                },
                {
                    "Bag", new Item
                    {
                        Name = "Bag",
                        Description = "+15 materials when you pick up a crate\n-1% Speed",
                        SpritePath = $"{fullPath}/Bag",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 15,
                        Limit = 3
                    }
                },
                {
                    "Bait", new Item
                    {
                        Name = "Bait",
                        Description = "+8% Damage\nSpecial enemies appear at the beginning of the next wave",
                        SpritePath = $"{fullPath}/Bait",
                        Rarity = Rarity.Tier2,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 25,
                        Limit = 0
                    }
                },
                {
                    "Bandana", new Item
                    {
                        Name = "Bandana",
                        Description = "Projectiles pierce through +1 additional target\n-10% Damage",
                        SpritePath = $"{fullPath}/Bandana",
                        Rarity = Rarity.Tier3,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 75,
                        Limit = 0
                    }
                },
                {
                    "Banner", new Item
                    {
                        Name = "Banner",
                        Description = "+20 Range\n+10% Attack Speed\n-2% Life Steal",
                        SpritePath = $"{fullPath}/Banner",
                        Rarity = Rarity.Tier2,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 55,
                        Limit = 0
                    }
                },
                {
                    "Barricade", new Item
                    {
                        Name = "Barricade",
                        Description = "+8 Armor while standing still.\n-5% Speed",
                        SpritePath = $"{fullPath}/Barricade",
                        Rarity = Rarity.Tier3,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 75,
                        Limit = 0
                    }
                },
                {
                    "Bat", new Item
                    {
                        Name = "Bat",
                        Description = "+2% Life Steal\n-2 Harvesting",
                        SpritePath = $"{fullPath}/Bat",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 20,
                        Limit = 0
                    }
                },
                {
                    "BeanTeacher", new Item
                    {
                        Name = "BeanTeacher",
                        Description = "+40% XP Gain\n-2% Life Steal",
                        SpritePath = $"{fullPath}/BeanTeacher",
                        Rarity = Rarity.Tier3,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 70,
                        Limit = 0
                    }
                },
                {
                    "Beanie", new Item
                    {
                        Name = "Beanie",
                        Description = "+4% Speed\n-6 Range",
                        SpritePath = $"{fullPath}/Beanie",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 20,
                        Limit = 0
                    }
                },
                {
                    "BigArms", new Item
                    {
                        Name = "BigArms",
                        Description = "+12 Melee Damage\n+6 Ranged Damage\n-1 Armor\n-5% Speed",
                        SpritePath = $"{fullPath}/BigArms",
                        Rarity = Rarity.Tier4,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 105,
                        Limit = 0,
                    }
                },
                {
                    "BlackBelt", new Item
                    {
                        Name = "BlackBelt",
                        Description = "+25% XP Gain\n+3 Melee Damage\n-8 Luck",
                        SpritePath = $"{fullPath}/BlackBelt",
                        Rarity = Rarity.Tier2,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 50,
                        Limit = 0
                    }
                },
                {
                    "Blindfold", new Item
                    {
                        Name = "Blindfold",
                        Description = "+5% Crit Chance\n+5% Dodge\n-15 Range",
                        SpritePath = $"{fullPath}/Blindfold",
                        Rarity = Rarity.Tier2,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 45,
                        Limit = 0
                    }
                },
                {
                    "BloodDonation", new Item
                    {
                        Name = "BloodDonation",
                        Description = "+40 Harvesting\nYou take 1 damage per second (does not give invulnerability time)",
                        SpritePath = $"{fullPath}/BloodDonation",
                        Rarity = Rarity.Tier3,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 50,
                        Limit = 0
                    }
                },
                {
                    "BloodLeech", new Item
                    {
                        Name = "BloodLeech",
                        Description = "+2% Life Steal\n+2 HP Regeneration\n-4 Harvesting",
                        SpritePath = $"{fullPath}/BloodLeech",
                        Rarity = Rarity.Tier2,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 45,
                        Limit = 0
                    }
                },
                {
                    "BloodyHand", new Item
                    {
                        Name = "BloodyHand",
                        Description = "+12% Life Steal\n+2% Damage for every 1% Life Steal you have\nYou take 1 damage per second (does not give invulnerability time)",
                        SpritePath = $"{fullPath}/BloodyHand",
                        Rarity = Rarity.Tier4,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 100,
                        Limit = 1
                    }
                },
                {
                    "BoilingWater", new Item
                    {
                        Name = "BoilingWater",
                        Description = "+2 Elemental Damage\n-1 Max HP",
                        SpritePath = $"{fullPath}/BoilingWater",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 30,
                        Limit = 0
                    }
                },
                {
                    "Book", new Item
                    {
                        Name = "Book",
                        Description = "+1 Engineering",
                        SpritePath = $"{fullPath}/Book",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 8,
                        Limit = 0
                    }
                },
                {
                    "BowlerHat", new Item
                    {
                        Name = "BowlerHat",
                        Description = "+15 Luck\n+18 Harvesting\n-5% Attack Speed\n-3% Crit Chance",
                        SpritePath = $"{fullPath}/BowlerHat",
                        Rarity = Rarity.Tier3,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 75,
                        Limit = 0,
                    }
                },
                {
                    "BoxingGlove", new Item
                    {
                        Name = "BoxingGlove",
                        Description = "+3 Knockback",
                        SpritePath = $"{fullPath}/BoxingGlove",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 15,
                        Limit = 0
                    }
                },
                {
                    "BrokenMouth", new Item
                    {
                        Name = "BrokenMouth",
                        Description = "+5 Max HP\n-1 HP Regeneration",
                        SpritePath = $"{fullPath}/BrokenMouth",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 25,
                        Limit = 0
                    }
                },
                {
                    "Butterfly", new Item
                    {
                        Name = "Butterfly",
                        Description = "+2% Life Steal\n-1 Elemental Damage",
                        SpritePath = $"{fullPath}/Butterfly",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 30,
                        Limit = 0
                    }
                },
                {
                    "Cake", new Item
                    {
                        Name = "Cake",
                        Description = "+3 Max HP\n-1% Damage",
                        SpritePath = $"{fullPath}/Cake",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 15,
                        Limit = 0
                    }
                },
                {
                    "Campfire", new Item
                    {
                        Name = "Campfire",
                        Description = "+2 Elemental Damage\n+2 HP Regeneration\n-2% Speed",
                        SpritePath = $"{fullPath}/Campfire",
                        Rarity = Rarity.Tier2,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 40,
                        Limit = 0
                    }
                },
                {
                    "Candle", new Item
                    {
                        Name = "Candle",
                        Description = "+4 Elemental Damage\n+1 HP Regeneration\n-10% Enemies\n-5% Damage",
                        SpritePath = $"{fullPath}/Candle",
                        Rarity = Rarity.Tier3,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 65,
                        Limit = 1
                    }
                },
                {
                    "Cape", new Item
                    {
                        Name = "Cape",
                        Description = "+5% Life Steal\n+20% Dodge\n-2 Melee Damage\n-2 Ranged Damage\n-2 Elemental Damage",
                        SpritePath = $"{fullPath}/Cape",
                        Rarity = Rarity.Tier4,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 110,
                        Limit = 0
                    }
                },
                {
                    "Chameleon", new Item
                    {
                        Name = "Chameleon",
                        Description = "+20% Dodge while standing still.\n-4% Damage\n+3% Dodge",
                        SpritePath = $"{fullPath}/Chameleon",
                        Rarity = Rarity.Tier3,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 70,
                        Limit = 0
                    }
                },
                {
                    "Charcoal", new Item
                    {
                        Name = "Charcoal",
                        Description = "+1 Elemental Damage\n+2 Melee Damage\n-2 Harvesting",
                        SpritePath = $"{fullPath}/Charcoal",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 20,
                        Limit = 0
                    }
                },
                {
                    "ClawTree", new Item
                    {
                        Name = "ClawTree",
                        Description = "+1 Melee Damage\n+3% Crit Chance\n-1 Max HP",
                        SpritePath = $"{fullPath}/ClawTree",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 20,
                        Limit = 0
                    }
                },
                {
                    "Clover", new Item
                    {
                        Name = "Clover",
                        Description = "+20 Luck\n+6% Dodge\n-2% Life Steal",
                        SpritePath = $"{fullPath}/Clover",
                        Rarity = Rarity.Tier3,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 65,
                        Limit = 0
                    }
                },
                {
                    "Coffee", new Item
                    {
                        Name = "Coffee",
                        Description = "+10% Attack Speed\n-2% Damage",
                        SpritePath = $"{fullPath}/Coffee",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 15,
                        Limit = 0
                    }
                },
                {
                    "Cog", new Item
                    {
                        Name = "Cog",
                        Description = "+4 Engineering\n-4% Damage",
                        SpritePath = $"{fullPath}/Cog",
                        Rarity = Rarity.Tier2,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 35,
                        Limit = 0
                    }
                },
                {
                    "CommunitySupport", new Item
                    {
                        Name = "CommunitySupport",
                        Description = "+1% Attack Speed for every current living enemy\n-2 Armor",
                        SpritePath = $"{fullPath}/CommunitySupport",
                        Rarity = Rarity.Tier3,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 75,
                        Limit = 1,
                    }
                },
                {
                    "Compass", new Item
                    {
                        Name = "Compass",
                        Description = "+5% Speed\n+3 Engineering\n-3% Crit Chance",
                        SpritePath = $"{fullPath}/Compass",
                        Rarity = Rarity.Tier2,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 40,
                        Limit = 0,
                    }
                },
                {
                    "Coupon", new Item
                    {
                        Name = "Coupon",
                        Description = "-5% Price",
                        SpritePath = $"{fullPath}/Coupon",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 15,
                        Limit = 5
                    }
                },
                {
                    "Crown", new Item
                    {
                        Name = "Crown",
                        Description = "Harvesting increases by an additional +8% at the end of a wave (stacking)",
                        SpritePath = $"{fullPath}/Crown",
                        Rarity = Rarity.Tier3,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 70,
                        Limit = 1
                    }
                },
                {
                    "CuteMonkey", new Item
                    {
                        Name = "CuteMonkey",
                        Description = "+8% chance to heal 1 HP when picking up a material\n-1 Ranged Damage",
                        SpritePath = $"{fullPath}/CuteMonkey",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 25,
                        Limit = 13
                    }
                },
                {
                    "Cyberball", new Item
                    {
                        Name = "Cyberball",
                        Description = "+25% chance to deal (25% Luck) damage to a random enemy when an enemy dies",
                        SpritePath = $"{fullPath}/Cyberball",
                        Rarity = Rarity.Tier2,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 35,
                        Limit = 0
                    }
                },
                {
                    "CyclopsWorm", new Item
                    {
                        Name = "CyclopsWorm",
                        Description = "+12% Damage\n-12 Range",
                        SpritePath = $"{fullPath}/CyclopsWorm",
                        Rarity = Rarity.Tier2,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 45,
                        Limit = 0
                    }
                },
                {
                    "DangerousBunny", new Item
                    {
                        Name = "DangerousBunny",
                        Description = "+1 free reroll in the shop",
                        SpritePath = $"{fullPath}/DangerousBunny",
                        Rarity = Rarity.Tier2,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 35,
                        Limit = 3
                    }
                },
                {
                    "DefectiveSteroids", new Item
                    {
                        Name = "DefectiveSteroids",
                        Description = "+2 Melee Damage\n-3% Attack Speed\n+2 Max HP",
                        SpritePath = $"{fullPath}/DefectiveSteroids",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 20,
                        Limit = 0
                    }
                },
                {
                    "Diploma", new Item
                    {
                        Name = "Diploma",
                        Description = "+10 Engineering\n+20% XP Gain\n-3 Max HP",
                        SpritePath = $"{fullPath}/Diploma",
                        Rarity = Rarity.Tier4,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 80,
                        Limit = 0
                    }
                },
                {
                    "DuctTape", new Item
                    {
                        Name = "DuctTape",
                        Description = "+1 Armor\n+1 Engineering\n-2 Max HP",
                        SpritePath = $"{fullPath}/DuctTape",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 25,
                        Limit = 0
                    }
                },
                {
                    "Dynamite", new Item
                    {
                        Name = "Dynamite",
                        Description = "+15% Explosion Damage",
                        SpritePath = $"{fullPath}/Dynamite",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 20,
                        Limit = 0
                    }
                },
                {
                    "EnergyBracelet", new Item
                    {
                        Name = "EnergyBracelet",
                        Description = "+4% Crit Chance\n+2 Elemental Damage\n-2 Ranged Damage",
                        SpritePath = $"{fullPath}/EnergyBracelet",
                        Rarity = Rarity.Tier2,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 55,
                        Limit = 0
                    }
                },
                {
                    "EstysCouch", new Item
                    {
                        Name = "EstysCouch",
                        Description = "+2 HP Regeneration for every permanent -1% Speed you have.\n+5 Max HP\n-15% Speed",
                        SpritePath = $"{fullPath}/EstysCouch",
                        Rarity = Rarity.Tier4,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 100,
                        Limit = 1
                    }
                },
                {
                    "Exoskeleton", new Item
                    {
                        Name = "Exoskeleton",
                        Description = "+5 Armor\n+5% Crit Chance\n+5 Engineering\n+5% Speed\n-2 HP Regeneration\n-2% Life Steal",
                        SpritePath = $"{fullPath}/Exoskeleton",
                        Rarity = Rarity.Tier4,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 90,
                        Limit = 0
                    }
                },
                {
                    "ExplosiveShells", new Item
                    {
                        Name = "ExplosiveShells",
                        Description = "+60% Explosion Damage\n+15% Explosion Size\n-15% Damage",
                        SpritePath = $"{fullPath}/ExplosiveShells",
                        Rarity = Rarity.Tier4,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 120,
                        Limit = 0,
                    }
                },
                {
                    "ExplosiveTurret", new Item
                    {
                        Name = "ExplosiveTurret",
                        Description = "Spawns a turret that shoots explosive bullets dealing 25 + (175% Engineering Stat) damage every 0.87s.",
                        SpritePath = $"{fullPath}/ExplosiveTurret",
                        Rarity = Rarity.Tier4,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 80,
                        Limit = 0
                    }
                },
                {
                    "ExtraStomach", new Item
                    {
                        Name = "ExtraStomach",
                        Description = "+1 Max HP when picking up a consumable while at maximum health (max +10 per wave)",
                        SpritePath = $"{fullPath}/ExtraStomach",
                        Rarity = Rarity.Tier4,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 100,
                        Limit = 1
                    }
                },
                {
                    "EyesSurgery", new Item
                    {
                        Name = "EyesSurgery",
                        Description = "Burning activates +10% faster\n-10 Range",
                        SpritePath = $"{fullPath}/EyesSurgery",
                        Rarity = Rarity.Tier2,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 60,
                        Limit = 3
                    }
                },
                {
                    "Fertilizer", new Item
                    {
                        Name = "Fertilizer",
                        Description = "+8 Harvesting\n-1 Melee Damage",
                        SpritePath = $"{fullPath}/Fertilizer",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 15,
                        Limit = 0
                    }
                },
                {
                    "Fairy", new Item
                    {
                        Name = "Fairy",
                        Description = "+1 HP Regeneration for every different Tier I item you have\n-2 HP Regeneration for every different Tier IV item you have",
                        SpritePath = $"{fullPath}/Fairy",
                        Rarity = Rarity.Tier3,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 85,
                        Limit = 0,
                    }
                },
                {
                    "Fin", new Item
                    {
                        Name = "Fin",
                        Description = "+10% Speed\n+3% Life Steal\n-8 Luck",
                        SpritePath = $"{fullPath}/Fin",
                        Rarity = Rarity.Tier3,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 65,
                        Limit = 0,
                    }
                },
                {
                    "Focus", new Item
                    {
                        Name = "Focus",
                        Description = "+30% Damage\n-3% Attack Speed for every different weapon you have",
                        SpritePath = $"{fullPath}/Focus",
                        Rarity = Rarity.Tier4,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 110,
                        Limit = 0,
                    }
                },
                {
                    "FuelTank", new Item
                    {
                        Name = "FuelTank",
                        Description = "+4 Elemental Damage\n-1 Melee Damage\n-1 Ranged Damage",
                        SpritePath = $"{fullPath}/FuelTank",
                        Rarity = Rarity.Tier2,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 45,
                        Limit = 0
                    }
                },
                {
                    "GamblingToken", new Item
                    {
                        Name = "GamblingToken",
                        Description = "+8% Dodge\n-1 Armor",
                        SpritePath = $"{fullPath}/GamblingToken",
                        Rarity = Rarity.Tier2,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 60,
                        Limit = 0
                    }
                },
                {
                    "Garden", new Item
                    {
                        Name = "Garden",
                        Description = "Spawns a garden that creates a fruit every 15 seconds",
                        SpritePath = $"{fullPath}/Garden",
                        Rarity = Rarity.Tier2,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 50,
                        Limit = 0
                    }
                },
                {
                    "GentleAlien", new Item
                    {
                        Name = "GentleAlien",
                        Description = "+5% Damage\n+5% Enemies\n+2 Max HP",
                        SpritePath = $"{fullPath}/GentleAlien",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 30,
                        Limit = 10
                    }
                },
                {
                    "GiantBelt", new Item
                    {
                        Name = "GiantBelt",
                        Description = "Critical hits deal 10% of an enemy’s current health as bonus damage (1% for bosses and elites)",
                        SpritePath = $"{fullPath}/GiantBelt",
                        Rarity = Rarity.Tier4,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 100,
                        Limit = 1,
                    }
                },
                {
                    "GlassCannon", new Item
                    {
                        Name = "GlassCannon",
                        Description = "+25% Damage\n-3 Armor",
                        SpritePath = $"{fullPath}/GlassCannon",
                        Rarity = Rarity.Tier3,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 75,
                        Limit = 0
                    }
                },
                {
                    "Glasses", new Item
                    {
                        Name = "Glasses",
                        Description = "+20 Range",
                        SpritePath = $"{fullPath}/Glasses",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 25,
                        Limit = 0
                    }
                },
                {
                    "Gnome", new Item
                    {
                        Name = "Gnome",
                        Description = "+10 Melee Damage\n+10 Elemental Damage\n-20 Range\n-20% pickup range",
                        SpritePath = $"{fullPath}/Gnome",
                        Rarity = Rarity.Tier4,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 100,
                        Limit = 0,
                    }
                },
                {
                    "GoatSkull", new Item
                    {
                        Name = "GoatSkull",
                        Description = "+3 Melee Damage\n-2% Crit Chance",
                        SpritePath = $"{fullPath}/GoatSkull",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 25,
                        Limit = 0
                    }
                },
                {
                    "GrindsMagicalLeaf", new Item
                    {
                        Name = "GrindsMagicalLeaf",
                        Description = "+3 Max HP at the end of a wave (stacking)\n+1 HP Regeneration at the end of a wave (stacking)\n+1% Life Steal at the end of a wave (stacking)",
                        SpritePath = $"{fullPath}/GrindsMagicalLeaf",
                        Rarity = Rarity.Tier4,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 100,
                        Limit = 0
                    }
                },
                {
                    "GummyBerserker", new Item
                    {
                        Name = "GummyBerserker",
                        Description = "+5% Attack Speed\n+15 Range\n-1 Armor",
                        SpritePath = $"{fullPath}/GummyBerserker",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 25,
                        Limit = 0
                    }
                },
                {
                    "Handcuffs", new Item
                    {
                        Name = "Handcuffs",
                        Description = "+8 Melee Damage\n+8 Ranged Damage\n+8 Elemental Damage\nYour max HP is capped at its current value",
                        SpritePath = $"{fullPath}/Handcuffs",
                        Rarity = Rarity.Tier3,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 80,
                        Limit = 1
                    }
                },
                {
                    "HeadInjury", new Item
                    {
                        Name = "HeadInjury",
                        Description = "+6% Damage\n-8 Range",
                        SpritePath = $"{fullPath}/HeadInjury",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 25,
                        Limit = 0
                    }
                },
                {
                    "HeavyBullets", new Item
                    {
                        Name = "HeavyBullets",
                        Description = "+5 Ranged Damage\n+10% Damage\n+10 Range\n-5% Attack Speed\n-5% Crit Chance",
                        SpritePath = $"{fullPath}/HeavyBullets",
                        Rarity = Rarity.Tier4,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 100,
                        Limit = 0
                    }
                },
                {
                    "Hedgehog", new Item
                    {
                        Name = "Hedgehog",
                        Description = "+2 Melee Damage\n+1 Ranged Damage\n-1 HP Regeneration",
                        SpritePath = $"{fullPath}/Hedgehog",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 30,
                        Limit = 0
                    }
                },
                {
                    "Helmet", new Item
                    {
                        Name = "Helmet",
                        Description = "+1 Armor\n-2% Speed",
                        SpritePath = $"{fullPath}/Helmet",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 25,
                        Limit = 0
                    }
                },
                {
                    "HuntingTrophy", new Item
                    {
                        Name = "HuntingTrophy",
                        Description = "+33% chance to get 1 material when killing an enemy with a critical hit",
                        SpritePath = $"{fullPath}/HuntingTrophy",
                        Rarity = Rarity.Tier3,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 55,
                        Limit = 3,
                    }
                },
                {
                    "ImprovedTools", new Item
                    {
                        Name = "ImprovedTools",
                        Description = "+10% Attack Speed\nReduces the attack cooldown of your structures by 50%",
                        SpritePath = $"{fullPath}/ImprovedTools",
                        Rarity = Rarity.Tier3,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 70,
                        Limit = 1,
                    }
                },
                {
                    "IncendiaryTurret", new Item
                    {
                        Name = "IncendiaryTurret",
                        Description = "Spawns a turret that shoots piercing flames dealing 1 damage and inflicting burn for 5 + (33% Engineering Stat) damage every second for 8 seconds. Attacks every 0.28s.",
                        SpritePath = $"{fullPath}/IncendiaryTurret",
                        Rarity = Rarity.Tier2,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 40,
                        Limit = 0
                    }
                },
                {
                    "Injection", new Item
                    {
                        Name = "Injection",
                        Description = "+7% Damage\n-2 Max HP",
                        SpritePath = $"{fullPath}/Injection",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 20,
                        Limit = 0
                    }
                },
                {
                    "Insanity", new Item
                    {
                        Name = "Insanity",
                        Description = "+6% Crit Chance\n-3% Damage",
                        SpritePath = $"{fullPath}/Insanity",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 20,
                        Limit = 0
                    }
                },
                {
                    "JetPack", new Item
                    {
                        Name = "JetPack",
                        Description = "+15% Speed\n+10% Dodge\n-5 Max HP\n-1 Armor",
                        SpritePath = $"{fullPath}/JetPack",
                        Rarity = Rarity.Tier4,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 100,
                        Limit = 0
                    }
                },
                {
                    "Landmines", new Item
                    {
                        Name = "Landmines",
                        Description = "A landmine spawns every 12 seconds dealing 10 + (100% Engineering Stat) damage in an area",
                        SpritePath = $"{fullPath}/Landmines",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 15,
                        Limit = 0
                    }
                },
                {
                    "LaserTurret", new Item
                    {
                        Name = "LaserTurret",
                        Description = "Spawns a turret that shoots piercing lasers dealing 20 + (150% Engineering Stat) damage every 0.87s. The laser pierces up to 3 targets.",
                        SpritePath = $"{fullPath}/LaserTurret",
                        Rarity = Rarity.Tier3,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 65,
                        Limit = 0
                    }
                },
                {
                    "LeatherVest", new Item
                    {
                        Name = "LeatherVest",
                        Description = "+2 Armor\n+6% Dodge\n-3 Max HP",
                        SpritePath = $"{fullPath}/LeatherVest",
                        Rarity = Rarity.Tier2,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 45,
                        Limit = 0
                    }
                },
                {
                    "Lemonade", new Item
                    {
                        Name = "Lemonade",
                        Description = "+1 HP recovered from consumables",
                        SpritePath = $"{fullPath}/Lemonade",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 15,
                        Limit = 0
                    }
                },
                {
                    "Lens", new Item
                    {
                        Name = "Lens",
                        Description = "+1 Ranged Damage\n-5 Range",
                        SpritePath = $"{fullPath}/Lens",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 20,
                        Limit = 0
                    }
                },
                {
                    "LittleFrog", new Item
                    {
                        Name = "LittleFrog",
                        Description = "+20% pickup range\n+10 Harvesting\n-5% Dodge",
                        SpritePath = $"{fullPath}/LittleFrog",
                        Rarity = Rarity.Tier2,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 50,
                        Limit = 0
                    }
                },
                {
                    "LittleMuscleyDude", new Item
                    {
                        Name = "LittleMuscleyDude",
                        Description = "+3 Melee Damage\n+5 Max HP\n-15 Range",
                        SpritePath = $"{fullPath}/LittleMuscleyDude",
                        Rarity = Rarity.Tier2,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 50,
                        Limit = 0
                    }
                },
                {
                    "LostDuck", new Item
                    {
                        Name = "LostDuck",
                        Description = "+10 Luck\n-1 Elemental Damage",
                        SpritePath = $"{fullPath}/LostDuck",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 25,
                        Limit = 0
                    }
                },
                {
                    "LuckyCharm", new Item
                    {
                        Name = "LuckyCharm",
                        Description = "+30 Luck\n-2 Melee Damage\n-1 Ranged Damage",
                        SpritePath = $"{fullPath}/LuckyCharm",
                        Rarity = Rarity.Tier3,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 75,
                        Limit = 0,
                    }
                },
                {
                    "LuckyCoin", new Item
                    {
                        Name = "LuckyCoin",
                        Description = "+2 Luck for every 1% Crit Chance you have\n-2 Armor",
                        SpritePath = $"{fullPath}/LuckyCoin",
                        Rarity = Rarity.Tier4,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 100,
                        Limit = 1
                    }
                },
                {
                    "Lure", new Item
                    {
                        Name = "Lure",
                        Description = "+3 HP Regeneration\n2 additional loot aliens appear during the next wave",
                        SpritePath = $"{fullPath}/Lure",
                        Rarity = Rarity.Tier2,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 34,
                        Limit = 0,
                    }
                },
                {
                    "LumberjackShirt", new Item
                    {
                        Name = "LumberjackShirt",
                        Description = "Trees die in one hit",
                        SpritePath = $"{fullPath}/LumberjackShirt",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 15,
                        Limit = 1
                    }
                },
                {
                    "Mammoth", new Item
                    {
                        Name = "Mammoth",
                        Description = "+20 Melee Damage\n+5 HP Regeneration\n-8% Damage\n-3% Speed",
                        SpritePath = $"{fullPath}/Mammoth",
                        Rarity = Rarity.Tier4,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 130,
                        Limit = 0
                    }
                },
                {
                    "Mastery", new Item
                    {
                        Name = "Mastery",
                        Description = "+6 Melee Damage\n-3 Ranged Damage",
                        SpritePath = $"{fullPath}/Mastery",
                        Rarity = Rarity.Tier2,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 55,
                        Limit = 0
                    }
                },
                {
                    "Medal", new Item
                    {
                        Name = "Medal",
                        Description = "+3 Max HP\n+3% Damage\n+1 Armor\n+3% Speed\n-4% Crit Chance",
                        SpritePath = $"{fullPath}/Medal",
                        Rarity = Rarity.Tier2,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 55,
                        Limit = 0
                    }
                },
                {
                    "MedicalTurret", new Item
                    {
                        Name = "MedicalTurret",
                        Description = "Spawns a medical turret that shoots projectiles healing 3 + (5% Engineering Stat) HP every 2.2s.",
                        SpritePath = $"{fullPath}/MedicalTurret",
                        Rarity = Rarity.Tier2,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 40,
                        Limit = 0
                    }
                },
                {
                    "Medikit", new Item
                    {
                        Name = "Medikit",
                        Description = "+10 HP Regeneration\n+2 HP Regeneration every 5 seconds until the end of the wave\n-10 Luck",
                        SpritePath = $"{fullPath}/Medikit",
                        Rarity = Rarity.Tier4,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 95,
                        Limit = 0,
                    }
                },
                {
                    "MetalDetector", new Item
                    {
                        Name = "MetalDetector",
                        Description = "+5% chance to double the value of picked up materials\n+6 Luck\n+2 Engineering\n-5% Damage",
                        SpritePath = $"{fullPath}/MetalDetector",
                        Rarity = Rarity.Tier2,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 40,
                        Limit = 0
                    }
                },
                {
                    "MetalPlate", new Item
                    {
                        Name = "MetalPlate",
                        Description = "+2 Armor\n-3% Damage",
                        SpritePath = $"{fullPath}/MetalPlate",
                        Rarity = Rarity.Tier2,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 40,
                        Limit = 0
                    }
                },
                {
                    "Missile", new Item
                    {
                        Name = "Missile",
                        Description = "+10% Damage\n-4% Attack Speed",
                        SpritePath = $"{fullPath}/Missile",
                        Rarity = Rarity.Tier2,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 45,
                        Limit = 0
                    }
                },
                {
                    "Mouse", new Item
                    {
                        Name = "Mouse",
                        Description = "+5% Life Steal\n+10% Enemies\n-5 Harvesting",
                        SpritePath = $"{fullPath}/Mouse",
                        Rarity = Rarity.Tier3,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 55,
                        Limit = 5
                    }
                },
                {
                    "Mushroom", new Item
                    {
                        Name = "Mushroom",
                        Description = "+3 HP Regeneration\n-2 Luck",
                        SpritePath = $"{fullPath}/Mushroom",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 25,
                        Limit = 0
                    }
                },
                {
                    "Mutation", new Item
                    {
                        Name = "Mutation",
                        Description = "+1 Ranged Damage\n+1 Elemental Damage\n-3% Speed",
                        SpritePath = $"{fullPath}/Mutation",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 25,
                        Limit = 0
                    }
                },
                {
                    "NightGoggles", new Item
                    {
                        Name = "NightGoggles",
                        Description = "+15% Crit Chance\n+50 Range\n-3 Max HP\n-1 Armor",
                        SpritePath = $"{fullPath}/NightGoggles",
                        Rarity = Rarity.Tier4,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 90,
                        Limit = 0,
                    }
                },
                {
                    "Octopus", new Item
                    {
                        Name = "Octopus",
                        Description = "+12 Max HP\n+5 HP Regeneration\n+3% Life Steal\n-8% Crit Chance",
                        SpritePath = $"{fullPath}/Octopus",
                        Rarity = Rarity.Tier4,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 105,
                        Limit = 0,
                    }
                },
                {
                    "Padding", new Item
                    {
                        Name = "Padding",
                        Description = "+3 Max HP\n+1 Max HP for every 100 Materials you have.\n-5% Speed",
                        SpritePath = $"{fullPath}/Padding",
                        Rarity = Rarity.Tier2,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 45,
                        Limit = 0,
                    }
                },
                {
                    "Panda", new Item
                    {
                        Name = "Panda",
                        Description = "+12 Max HP\n+25 Luck\n-5% Damage",
                        SpritePath = $"{fullPath}/Panda",
                        Rarity = Rarity.Tier4,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 100,
                        Limit = 0,
                    }
                },
                {
                    "PeacefulBee", new Item
                    {
                        Name = "PeacefulBee",
                        Description = "+4% Dodge\n+4 Harvesting\n-1 Melee Damage\n-1 Ranged Damage",
                        SpritePath = $"{fullPath}/PeacefulBee",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 18,
                        Limit = 0
                    }
                },
                {
                    "Peacock", new Item
                    {
                        Name = "Peacock",
                        Description = "+25% XP Gain\n+100% XP Gain during the next wave\n+50% Enemy damage during the next wave",
                        SpritePath = $"{fullPath}/Peacock",
                        Rarity = Rarity.Tier3,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 50,
                        Limit = 0
                    }
                },
                {
                    "Pencil", new Item
                    {
                        Name = "Pencil",
                        Description = "+2 Engineering\n-1% Attack Speed\n-1% Crit Chance",
                        SpritePath = $"{fullPath}/Pencil",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 15,
                        Limit = 0
                    }
                },
                {
                    "PiggyBank", new Item
                    {
                        Name = "PiggyBank",
                        Description = "+20% of your materials at the start of waves",
                        SpritePath = $"{fullPath}/PiggyBank",
                        Rarity = Rarity.Tier2,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 40,
                        Limit = 1
                    }
                },
                {
                    "Plant", new Item
                    {
                        Name = "Plant",
                        Description = "+3 HP Regeneration\n-1% Life Steal",
                        SpritePath = $"{fullPath}/Plant",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 10,
                        Limit = 0
                    }
                },
                {
                    "PlasticExplosive", new Item
                    {
                        Name = "PlasticExplosive",
                        Description = "+25% Explosion Size",
                        SpritePath = $"{fullPath}/PlasticExplosive",
                        Rarity = Rarity.Tier3,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 60,
                        Limit = 0
                    }
                },
                {
                    "PoisonousTonic", new Item
                    {
                        Name = "PoisonousTonic",
                        Description = "+10% Attack Speed\n+5% Crit Chance\n+15 Range\n-2 HP Regeneration",
                        SpritePath = $"{fullPath}/PoisonousTonic",
                        Rarity = Rarity.Tier3,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 80,
                        Limit = 0
                    }
                },
                {
                    "PocketFactory", new Item
                    {
                        Name = "PocketFactory",
                        Description = "+2 Engineering\nKilling a tree spawns a turret",
                        SpritePath = $"{fullPath}/PocketFactory",
                        Rarity = Rarity.Tier2,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 75,
                        Limit = 0
                    }
                },
                {
                    "Potato", new Item
                    {
                        Name = "Potato",
                        Description = "+3 Max HP\n+2 HP Regeneration\n+1% Life Steal\n+5% Damage\n+5% Attack Speed\n+3% Speed\n+3% Dodge\n+1 Armor\n+5 Luck",
                        SpritePath = $"{fullPath}/Potato",
                        Rarity = Rarity.Tier4,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 95,
                        Limit = 0,
                    }
                },
                {
                    "PowerGenerator", new Item
                    {
                        Name = "PowerGenerator",
                        Description = "+1% Damage for every permanent 1% Speed you have.\n-5% Damage",
                        SpritePath = $"{fullPath}/PowerGenerator",
                        Rarity = Rarity.Tier3,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 65,
                        Limit = 1
                    }
                },
                {
                    "PropellerHat", new Item
                    {
                        Name = "PropellerHat",
                        Description = "+10 Luck\n-2% Damage",
                        SpritePath = $"{fullPath}/PropellerHat",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 28,
                        Limit = 0
                    }
                },
                {
                    "Pumpkin", new Item
                    {
                        Name = "Pumpkin",
                        Description = "+15% Piercing Damage. Can't go above base damage\n-2% Damage",
                        SpritePath = $"{fullPath}/Pumpkin",
                        Rarity = Rarity.Tier2,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 40,
                        Limit = 0
                    }
                },
                {
                    "RecyclingMachine", new Item
                    {
                        Name = "RecyclingMachine",
                        Description = "Gain +35% more materials from recycling items",
                        SpritePath = $"{fullPath}/RecyclingMachine",
                        Rarity = Rarity.Tier2,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 35,
                        Limit = 1
                    }
                },
                {
                    "RegenerationPotion", new Item
                    {
                        Name = "RegenerationPotion",
                        Description = "HP Regeneration is doubled while you have less than 50% health\n+3 HP Regeneration",
                        SpritePath = $"{fullPath}/RegenerationPotion",
                        Rarity = Rarity.Tier4,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 90,
                        Limit = 1
                    }
                },
                {
                    "RetromationsHoodie", new Item
                    {
                        Name = "RetromationsHoodie",
                        Description = "+2% Attack Speed for every 1% Dodge you have.\n-80 Range",
                        SpritePath = $"{fullPath}/RetromationsHoodie",
                        Rarity = Rarity.Tier4,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 100,
                        Limit = 1
                    }
                },
                {
                    "Ricochet", new Item
                    {
                        Name = "Ricochet",
                        Description = "Your projectiles gain +1 bounce\n-25% Damage",
                        SpritePath = $"{fullPath}/Ricochet",
                        Rarity = Rarity.Tier4,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 110,
                        Limit = 0
                    }
                },
                {
                    "RipAndTear", new Item
                    {
                        Name = "RipAndTear",
                        Description = "Enemies have a +20% chance to explode for 10 + (50% Melee Damage) damage when they die\n-12 Harvesting",
                        SpritePath = $"{fullPath}/RipAndTear",
                        Rarity = Rarity.Tier3,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 65,
                        Limit = 5,
                    }
                },
                {
                    "Riposte", new Item
                    {
                        Name = "Riposte",
                        Description = "+2 Melee Damage\n100% chance to deal 1 (300% Melee Damage) damage to an enemy when dodging their attack",
                        SpritePath = $"{fullPath}/Riposte",
                        Rarity = Rarity.Tier2,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 40,
                        Limit = 0
                    }
                },
                {
                    "Ritual", new Item
                    {
                        Name = "Ritual",
                        Description = "+6% Damage\n+2% Life Steal\n-2 Engineering",
                        SpritePath = $"{fullPath}/Ritual",
                        Rarity = Rarity.Tier2,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 60,
                        Limit = 0,
                    }
                },
                {
                    "RobotArm", new Item
                    {
                        Name = "RobotArm",
                        Description = "+6 Armor\n+6 Engineering\n-2 HP Regeneration\n-2% Life Steal",
                        SpritePath = $"{fullPath}/RobotArm",
                        Rarity = Rarity.Tier4,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 90,
                        Limit = 0,
                    }
                },
                {
                    "SadTomato", new Item
                    {
                        Name = "SadTomato",
                        Description = "+8 HP Regeneration\nStart waves with -50% HP",
                        SpritePath = $"{fullPath}/SadTomato",
                        Rarity = Rarity.Tier3,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 50,
                        Limit = 1
                    }
                },
                {
                    "Scar", new Item
                    {
                        Name = "Scar",
                        Description = "+20% XP Gain\n-8 Range",
                        SpritePath = $"{fullPath}/Scar",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 30,
                        Limit = 0
                    }
                },
                {
                    "ScaredSausage", new Item
                    {
                        Name = "ScaredSausage",
                        Description = "Attacks have a +25% chance to deal 1x3 + (100% Elemental Damage) burning damage",
                        SpritePath = $"{fullPath}/ScaredSausage",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 25,
                        Limit = 4
                    }
                },
                {
                    "Scope", new Item
                    {
                        Name = "Scope",
                        Description = "+2 Ranged Damage\n+25 Range\n-7% Attack Speed",
                        SpritePath = $"{fullPath}/Scope",
                        Rarity = Rarity.Tier2,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 55,
                        Limit = 0
                    }
                },
                {
                    "Shackles", new Item
                    {
                        Name = "Shackles",
                        Description = "+8 HP Regeneration\n+8 Engineering\n+80 Range\nYour Speed is capped at its current value",
                        SpritePath = $"{fullPath}/Shackles",
                        Rarity = Rarity.Tier3,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 80,
                        Limit = 1
                    }
                },
                {
                    "ShadyPotion", new Item
                    {
                        Name = "ShadyPotion",
                        Description = "+20 Luck\n-2 HP Regeneration",
                        SpritePath = $"{fullPath}/ShadyPotion",
                        Rarity = Rarity.Tier2,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 48,
                        Limit = 0
                    }
                },
                {
                    "SharpBullet", new Item
                    {
                        Name = "SharpBullet",
                        Description = "Projectiles pierce through 1 additional target\n-20% Piercing Damage\n-5% Damage",
                        SpritePath = $"{fullPath}/SharpBullet",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 25,
                        Limit = 1
                    }
                },
                {
                    "Shmoop", new Item
                    {
                        Name = "Shmoop",
                        Description = "+6 Max HP\n+2 HP Regeneration\n-2 Melee Damage\n-1 Ranged Damage",
                        SpritePath = $"{fullPath}/Shmoop",
                        Rarity = Rarity.Tier3,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 60,
                        Limit = 0
                    }
                },
                {
                    "SifdsRelic", new Item
                    {
                        Name = "SifdsRelic",
                        Description = "+100% chance to instantly attract a material when its dropped",
                        SpritePath = $"{fullPath}/SifdsRelic",
                        Rarity = Rarity.Tier4,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 100,
                        Limit = 1
                    }
                },
                {
                    "SilverBullet", new Item
                    {
                        Name = "SilverBullet",
                        Description = "+25% damage against bosses and elites",
                        SpritePath = $"{fullPath}/SilverBullet",
                        Rarity = Rarity.Tier3,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 70,
                        Limit = 0
                    }
                },
                {
                    "SmallMagazine", new Item
                    {
                        Name = "SmallMagazine",
                        Description = "+2 Ranged Damage\n+10% Attack Speed\n-6% Damage",
                        SpritePath = $"{fullPath}/SmallMagazine",
                        Rarity = Rarity.Tier2,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 60,
                        Limit = 0
                    }
                },
                {
                    "Snail", new Item
                    {
                        Name = "Snail",
                        Description = "-5 Enemy Speed\n-3% Speed",
                        SpritePath = $"{fullPath}/Snail",
                        Rarity = Rarity.Tier2,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 40,
                        Limit = 1,
                    }
                },
                {
                    "Snake", new Item
                    {
                        Name = "Snake",
                        Description = "Burning spreads to a nearby enemy\n-1 Max HP",
                        SpritePath = $"{fullPath}/Snake",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 25,
                        Limit = 0
                    }
                },
                {
                    "SpicySauce", new Item
                    {
                        Name = "SpicySauce",
                        Description = "+3 Max HP\nConsumables have a 25% chance to explode for 10 (100% Max HP) damage when picked up",
                        SpritePath = $"{fullPath}/SpicySauce",
                        Rarity = Rarity.Tier2,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 40,
                        Limit = 4,
                    }
                },
                {
                    "Spider", new Item
                    {
                        Name = "Spider",
                        Description = "+12% Damage\n+6% Attack Speed for every different weapon you have\n-3% Dodge\n-5 Harvesting",
                        SpritePath = $"{fullPath}/Spider",
                        Rarity = Rarity.Tier4,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 120,
                        Limit = 0,
                    }
                },
                {
                    "Statue", new Item
                    {
                        Name = "Statue",
                        Description = "+40% Attack Speed while standing still.\n-10% Speed",
                        SpritePath = $"{fullPath}/Statue",
                        Rarity = Rarity.Tier3,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 60,
                        Limit = 0
                    }
                },
                {
                    "StrangeBook", new Item
                    {
                        Name = "StrangeBook",
                        Description = "+1 Engineering for every 1 Elemental Damage you have.\n-1 Melee Damage\n-1 Ranged Damage",
                        SpritePath = $"{fullPath}/StrangeBook",
                        Rarity = Rarity.Tier3,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 70,
                        Limit = 1
                    }
                },
                {
                    "StoneSkin", new Item
                    {
                        Name = "StoneSkin",
                        Description = "+1 Max HP for every 1 permanent Armor you have\n-2 Armor",
                        SpritePath = $"{fullPath}/StoneSkin",
                        Rarity = Rarity.Tier3,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 80,
                        Limit = 1,
                    }
                },
                {
                    "Sunglasses", new Item
                    {
                        Name = "Sunglasses",
                        Description = "+10% Crit Chance\n-1 Armor",
                        SpritePath = $"{fullPath}/Sunglasses",
                        Rarity = Rarity.Tier2,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 50,
                        Limit = 0
                    }
                },
                {
                    "Tardigrade", new Item
                    {
                        Name = "Tardigrade",
                        Description = "Nullifies the damage of +1 hit taken every wave",
                        SpritePath = $"{fullPath}/Tardigrade",
                        Rarity = Rarity.Tier3,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 50,
                        Limit = 0
                    }
                },
                {
                    "Tentacle", new Item
                    {
                        Name = "Tentacle",
                        Description = "+3% Crit Chance\n+20% chance to heal 1 HP when killing an enemy with a critical hit",
                        SpritePath = $"{fullPath}/Tentacle",
                        Rarity = Rarity.Tier2,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 32,
                        Limit = 5,
                    }
                },
                {
                    "TerrifiedOnion", new Item
                    {
                        Name = "TerrifiedOnion",
                        Description = "+4% Speed\n-6 Luck",
                        SpritePath = $"{fullPath}/TerrifiedOnion",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 15,
                        Limit = 0
                    }
                },
                {
                    "Toolbox", new Item
                    {
                        Name = "Toolbox",
                        Description = "+6 Engineering\n-8% Attack Speed",
                        SpritePath = $"{fullPath}/Toolbox",
                        Rarity = Rarity.Tier3,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 55,
                        Limit = 0
                    }
                },
                {
                    "Torture", new Item
                    {
                        Name = "Torture",
                        Description = "+15 Max HP\nRestore +4 HP per second. Cannot heal any other way.",
                        SpritePath = $"{fullPath}/Torture",
                        Rarity = Rarity.Tier4,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 110,
                        Limit = 1
                    }
                },
                {
                    "ToxicSludge", new Item
                    {
                        Name = "ToxicSludge",
                        Description = "+2 Elemental Damage\n-2% Dodge",
                        SpritePath = $"{fullPath}/ToxicSludge",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 20,
                        Limit = 0
                    }
                },
                {
                    "Tractor", new Item
                    {
                        Name = "Tractor",
                        Description = "+40 Harvesting\n-8% Damage",
                        SpritePath = $"{fullPath}/Tractor",
                        Rarity = Rarity.Tier3,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 70,
                        Limit = 0
                    }
                },
                {
                    "Tree", new Item
                    {
                        Name = "Tree",
                        Description = "More trees spawn",
                        SpritePath = $"{fullPath}/Tree",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 15,
                        Limit = 0
                    }
                },
                {
                    "TriangleOfPower", new Item
                    {
                        Name = "TriangleOfPower",
                        Description = "+20% Damage\n+1 Armor\n-2% Damage until the end of the wave when you take damage",
                        SpritePath = $"{fullPath}/TriangleOfPower",
                        Rarity = Rarity.Tier3,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 65,
                        Limit = 0
                    }
                },
                {
                    "Turret", new Item
                    {
                        Name = "Turret",
                        Description = "Spawns a turret that shoots bullets dealing 10 + (80% Engineering Stat) damage every 0.73s.",
                        SpritePath = $"{fullPath}/Turret",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 15,
                        Limit = 0
                    }
                },
                {
                    "Tyler", new Item
                    {
                        Name = "Tyler",
                        Description = "Spawns a little guy that slowly shoots 10 piercing lightning projectiles around him for 10 + (100% Engineering Stat) damage every 2.2s. The projectiles pierce up to 2 targets.",
                        SpritePath = $"{fullPath}/Tyler",
                        Rarity = Rarity.Tier3,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 75,
                        Limit = 0
                    }
                },
                {
                    "UglyTooth", new Item
                    {
                        Name = "UglyTooth",
                        Description = "Hitting an enemy removes +10% of their speed (Max: 30%)\n-3% Speed",
                        SpritePath = $"{fullPath}/UglyTooth",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 25,
                        Limit = 1
                    }
                },
                {
                    "VigilanteRing", new Item
                    {
                        Name = "VigilanteRing",
                        Description = "+3% Damage at the end of a wave (stacking)",
                        SpritePath = $"{fullPath}/VigilanteRing",
                        Rarity = Rarity.Tier3,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 92,
                        Limit = 0
                    }
                },
                {
                    "WanderingBot", new Item
                    {
                        Name = "WanderingBot",
                        Description = "Spawns a little bot that slows down nearby enemies",
                        SpritePath = $"{fullPath}/WanderingBot",
                        Rarity = Rarity.Tier3,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 60,
                        Limit = 0
                    }
                },
                {
                    "WarriorHelmet", new Item
                    {
                        Name = "WarriorHelmet",
                        Description = "+3 Armor\n+5 Max HP\n-5% Speed",
                        SpritePath = $"{fullPath}/WarriorHelmet",
                        Rarity = Rarity.Tier3,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 80,
                        Limit = 0
                    }
                },
                {
                    "WeirdFood", new Item
                    {
                        Name = "WeirdFood",
                        Description = "+2 HP recovered from consumables\n-2% Dodge",
                        SpritePath = $"{fullPath}/WeirdFood",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 20,
                        Limit = 0
                    }
                },
                {
                    "WeirdGhost", new Item
                    {
                        Name = "WeirdGhost",
                        Description = "+3 Max HP\nStart the next wave with 1 HP",
                        SpritePath = $"{fullPath}/WeirdGhost",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 12,
                        Limit = 0
                    }
                },
                {
                    "Wheat", new Item
                    {
                        Name = "Wheat",
                        Description = "+4 Melee Damage\n+2 Ranged Damage\n+10 Harvesting\n-2 Elemental Damage",
                        SpritePath = $"{fullPath}/Wheat",
                        Rarity = Rarity.Tier3,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 85,
                        Limit = 0,
                    }
                },
                {
                    "Wheelbarrow", new Item
                    {
                        Name = "Wheelbarrow",
                        Description = "-1 Armor\n+16 Harvesting",
                        SpritePath = $"{fullPath}/Wheelbarrow",
                        Rarity = Rarity.Tier2,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 40,
                        Limit = 0
                    }
                },
                {
                    "Whetstone", new Item
                    {
                        Name = "Whetstone",
                        Description = "+4% Life Steal\n-3 Knockback",
                        SpritePath = $"{fullPath}/Whetstone",
                        Rarity = Rarity.Tier2,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 40,
                        Limit = 0,
                    }
                },
                {
                    "WhiteFlag", new Item
                    {
                        Name = "WhiteFlag",
                        Description = "+5 Harvesting\n-5% Enemies",
                        SpritePath = $"{fullPath}/WhiteFlag",
                        Rarity = Rarity.Tier2,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 40,
                        Limit = 1
                    }
                },
                {
                    "Wings", new Item
                    {
                        Name = "Wings",
                        Description = "+10% Speed\n+30 Range\n-2 Elemental Damage",
                        SpritePath = $"{fullPath}/Wings",
                        Rarity = Rarity.Tier3,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 85,
                        Limit = 0
                    }
                },
                {
                    "Wisdom", new Item
                    {
                        Name = "Wisdom",
                        Description = "+5 damage every 5 seconds\n-20% Damage",
                        SpritePath = $"{fullPath}/Wisdom",
                        Rarity = Rarity.Tier3,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 85,
                        Limit = 1
                    }
                },
                {
                    "WolfHelmet", new Item
                    {
                        Name = "WolfHelmet",
                        Description = "+10 Elemental Damage\n+20 Luck\n-5 Engineering",
                        SpritePath = $"{fullPath}/WolfHelmet",
                        Rarity = Rarity.Tier4,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 90,
                        Limit = 0
                    }
                }
            };
        }
    }
}