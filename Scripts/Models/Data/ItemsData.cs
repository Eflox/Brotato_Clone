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

                { "Skull", new SkullAttribute() },
                { "Heart", new HeartAttribute() },
                { "Lungs", new LungsAttribute() },
                { "Teeth", new TeethAttribute() },
                { "Triceps", new TricepsAttribute() },
                { "Forearms", new ForearmsAttribute() },
                { "Shoulders", new ShouldersAttribute() },
                { "Brain", new BrainAttribute() },
                { "Reflexes", new ReflexesAttribute() },
                { "Fingers", new FingersAttribute() },
                { "Eyes", new EyesAttribute() },
                { "Chest", new ChestAttribute() },
                { "Back", new BackAttribute() },
                { "Legs", new LegsAttribute() },
                { "Nose", new NoseAttribute() },
                { "Hands", new HandsAttribute() },

                { "Acid", new AcidAttribute() },
                { "Adrenaline", new AdrenalineAttribute() },
                { "Alien Baby", new AlienBabyAttribute() },
                { "Alien Eyes", new AlienEyesAttribute() },
                { "Alien Magic", new AlienMagicAttribute() },
                { "Alien Tongue", new AlienTongueAttribute() },
                { "Alien Worm", new AlienWormAttribute() },
                { "Alloy", new AlloyAttribute() },
                { "Anvil", new AnvilAttribute() },
                { "Baby Elephant", new BabyElephantAttribute() },
                { "Baby Gecko", new BabyGeckoAttribute() },
                { "Baby With A Beard", new BabyWithABeardAttribute() },
                { "Bag", new BagAttribute() },
                { "Bandana", new BandanaAttribute() },
                { "Banner", new BannerAttribute() },
                { "Barricade", new BarricadeAttribute() },
                { "Bat", new BatAttribute() },
                { "Beanie", new BeanieAttribute() },
                { "Big Arms", new BigArmsAttribute() },
                { "Black Belt", new BlackBeltAttribute() },
                { "Blindfold", new BlindfoldAttribute() },
                { "Blood Donation", new BloodDonationAttribute() },
                { "Blood Leech", new BloodLeechAttribute() },
                { "Bloody Hand", new BloodyHandAttribute() },
                { "Boiling Water", new BoilingWaterAttribute() },
                { "Book", new BookAttribute() },
                { "Bowler Hat", new BowlerHatAttribute() },
                { "Boxing Glove", new BoxingGloveAttribute() },
                { "Broken Mouth", new BrokenMouthAttribute() },
                { "Butterfly", new ButterflyAttribute() },
                { "Cake", new CakeAttribute() },
                { "Campfire", new CampfireAttribute() },
                { "Candle", new CandleAttribute() },
                { "Cape", new CapeAttribute() },
                { "Chameleon", new ChameleonAttribute() },
                { "Charcoal", new CharcoalAttribute() },
                { "Claw Tree", new ClawTreeAttribute() },
                { "Clover", new CloverAttribute() },
                { "Coffee", new CoffeeAttribute() },
                { "Cog", new CogAttribute() },
                { "Community Support", new CommunitySupportAttribute() },
                { "Compass", new CompassAttribute() },
                { "Coupon", new CouponAttribute() },
                { "Crown", new CrownAttribute() },
                { "Cute Monkey", new CuteMonkeyAttribute() },
                { "Cyberball", new CyberballAttribute() },
                { "Cyclops Worm", new CyclopsWormAttribute() },
                { "Dangerous Bunny", new DangerousBunnyAttribute() },
                { "Defective Steroids", new DefectiveSteroidsAttribute() },
                { "Diploma", new DiplomaAttribute() },
                { "Duct Tape", new DuctTapeAttribute() },
                { "Dynamite", new DynamiteAttribute() },
                { "Energy Bracelet", new EnergyBraceletAttribute() },
                { "Estys Couch", new EstysCouchAttribute() },
                { "Exoskeleton", new ExoskeletonAttribute() },
                { "Explosive Shells", new ExplosiveShellsAttribute() },
                { "Explosive Turret", new ExplosiveTurretAttribute() },
                { "Extra Stomach", new ExtraStomachAttribute() },
                { "Eyes Surgery", new EyesSurgeryAttribute() },
                { "Fertilizer", new FertilizerAttribute() },
                { "Fairy", new FairyAttribute() },
                { "Fin", new FinAttribute() },
                { "Focus", new FocusAttribute() },
                { "Fuel Tank", new FuelTankAttribute() },
                { "Gambling Token", new GamblingTokenAttribute() },
                { "Garden", new GardenAttribute() },
                { "Gentle Alien", new GentleAlienAttribute() },
                { "Giant Belt", new GiantBeltAttribute() },
                { "Glass Cannon", new GlassCannonAttribute() },
                { "Glasses", new GlassesAttribute() },
                { "Gnome", new GnomeAttribute() },
                { "Goat Skull", new GoatSkullAttribute() },
                { "Grinds Magical Leaf", new GrindsMagicalLeafAttribute() },
                { "Gummy Berserker", new GummyBerserkerAttribute() },
                { "Handcuffs", new HandcuffsAttribute() },
                { "Head Injury", new HeadInjuryAttribute() },
                { "Heavy Bullets", new HeavyBulletsAttribute() },
                { "Hedgehog", new HedgehogAttribute() },
                { "Helmet", new HelmetAttribute() },
                { "Hunting Trophy", new HuntingTrophyAttribute() },
                { "Incendiary Turret", new IncendiaryTurretAttribute() },
                { "Injection", new InjectionAttribute() },
                { "Insanity", new InsanityAttribute() },
                { "Jet Pack", new JetPackAttribute() },
                { "Landmines", new LandminesAttribute() },
                { "Laser Turret", new LaserTurretAttribute() },
                { "Leather Vest", new LeatherVestAttribute() },
                { "Lemonade", new LemonadeAttribute() },
                { "Lens", new LensAttribute() },
                { "Little Frog", new LittleFrogAttribute() },
                { "Little Muscley Dude", new LittleMuscleyDudeAttribute() },
                { "Lost Duck", new LostDuckAttribute() },
                { "Lucky Charm", new LuckyCharmAttribute() },
                { "Lucky Coin", new LuckyCoinAttribute() },
                { "Lure", new LureAttribute() },
                { "Lumberjack Shirt", new LumberjackShirtAttribute() },
                { "Mammoth", new MammothAttribute() },
                { "Mastery", new MasteryAttribute() },
                { "Medal", new MedalAttribute() },
                { "Medical Turret", new MedicalTurretAttribute() },
                { "Medikit", new MedikitAttribute() },
                { "Metal Detector", new MetalDetectorAttribute() },
                { "Metal Plate", new MetalPlateAttribute() },
                { "Missile", new MissileAttribute() },
                { "Mouse", new MouseAttribute() },
                { "Mushroom", new MushroomAttribute() },
                { "Mutation", new MutationAttribute() },
                { "Night Goggles", new NightGogglesAttribute() },
                { "Octopus", new OctopusAttribute() },
                { "Padding", new PaddingAttribute() },
                { "Panda", new PandaAttribute() },
                { "Peaceful Bee", new PeacefulBeeAttribute() },
                { "Peacock", new PeacockAttribute() },
                { "Pencil", new PencilAttribute() },
                { "Piggy Bank", new PiggyBankAttribute() },
                { "Plant", new PlantAttribute() },
                { "Plastic Explosive", new PlasticExplosiveAttribute() },
                { "Poisonous Tonic", new PoisonousTonicAttribute() },
                { "Pocket Factory", new PocketFactoryAttribute() },
                { "Potato", new PotatoAttribute() },
                { "Power Generator", new PowerGeneratorAttribute() },
                { "Propeller Hat", new PropellerHatAttribute() },
                { "Pumpkin", new PumpkinAttribute() },
                { "Recycling Machine", new RecyclingMachineAttribute() },
                { "Regeneration Potion", new RegenerationPotionAttribute() },
                { "Retromations Hoodie", new RetromationsHoodieAttribute() },
                { "Ricochet", new RicochetAttribute() },
                { "Rip And Tear", new RipandTearAttribute() },
                { "Riposte", new RiposteAttribute() },
                { "Ritual", new RitualAttribute() },
                { "Robot Arm", new RobotArmAttribute() },
                { "Sad Tomato", new SadTomatoAttribute() },
                { "Scar", new ScarAttribute() },
                { "Scared Sausage", new ScaredSausageAttribute() },
                { "Scope", new ScopeAttribute() },
                { "Shackles", new ShacklesAttribute() },
                { "Shady Potion", new ShadyPotionAttribute() },
                { "Sharp Bullet", new SharpBulletAttribute() },
                { "Shmoop", new ShmoopAttribute() },
                { "Sifds Relic", new SifdsRelicAttribute() },
                { "Silver Bullet", new SilverBulletAttribute() },
                { "Small Magazine", new SmallMagazineAttribute() },
                { "Snail", new SnailAttribute() },
                { "Snake", new SnakeAttribute() },
                { "Spicy Sauce", new SpicySauceAttribute() },
                { "Spider", new SpiderAttribute() },
                { "Statue", new StatueAttribute() },
                { "Strange Book", new StrangeBookAttribute() },
                { "Stone Skin", new StoneSkinAttribute() },
                { "Sunglasses", new SunglassesAttribute() },
                { "Tardigrade", new TardigradeAttribute() },
                { "Tentacle", new TentacleAttribute() },
                { "Terrified Onion", new TerrifiedOnionAttribute() },
                { "Toolbox", new ToolboxAttribute() },
                { "Torture", new TortureAttribute() },
                { "Toxic Sludge", new ToxicSludgeAttribute() },
                { "Tractor", new TractorAttribute() },
                { "Tree", new TreeAttribute() },
                { "Triangle Of Power", new TriangleofPowerAttribute() },
                { "Turret", new TurretAttribute() },
                { "Tyler", new TylerAttribute() },
                { "Ugly Tooth", new UglyToothAttribute() },
                { "Vigilante Ring", new VigilanteRingAttribute() },
                { "Wandering Bot", new WanderingBotAttribute() },
                { "Warrior Helmet", new WarriorHelmetAttribute() },
                { "Weird Food", new WeirdFoodAttribute() },
                { "Weird Ghost", new WeirdGhostAttribute() },
                { "Wheat", new WheatAttribute() },
                { "Wheelbarrow", new WheelbarrowAttribute() },
                { "Whetstone", new WhetstoneAttribute() },
                { "White Flag", new WhiteFlagAttribute() },
                { "Wings", new WingsAttribute() },
                { "Wisdom", new WisdomAttribute() },
                { "Wolf Helmet", new WolfHelmetAttribute() }
            };

            string fullPath = $"{_assetSource}/{_path}";

            Items = new Dictionary<string, Item>
            {
                {
                    "Acid", new Item
                    {
                        Name = "Acid",
                        Description = "[g]+8[c] Max HP[nl][r]-4%[c] Dodge",
                        SpritePath = $"{fullPath}/Acid",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 65,
                        Limit = 0
                    }
                },
                {
                    "Adrenaline", new Item
                    {
                        Name = "Adrenaline",
                        Description = "[g]+5%[c] Dodge[nl][g]50%[c] chance to heal [g]5[c] HP when dodging an attack",
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
                        Name = "Alien Baby",
                        Description = "[g]+15[c] Max HP[nl][g]+8[c] Enemy Speed",
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
                        Name = "Alien Eyes",
                        Description = "Shoots [g]+6[c] alien eyes around you every [g]3[c] seconds dealing ([g]50%[c] Max HP) damage",
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
                        Name = "Alien Magic",
                        Description = "[g]+8[c] Max HP[nl][g]+3[c] HP Regeneration[nl][r]-8[c] Luck",
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
                        Name = "Alien Tongue",
                        Description = "[g]+30%[c] pickup range",
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
                        Name = "Alien Worm",
                        Description = "[g]+2[c] HP Regeneration[nl][r]-1[c] HP recovered from consumables[nl][g]+3[c] Max HP",
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
                        Description = "[g]+3[c] Melee Damage[nl][g]+3[c] Ranged Damage[nl][g]+3[c] Elemental Damage[nl][g]+3[c] Engineering[nl][g]+5%[c] Crit Chance[nl][r]-6%[c] Dodge",
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
                        Description = "A random weapon is upgraded when entering a shop. If you have no weapon to upgrade, you gain [g]+2[c] Armor instead.",
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
                        Name = "Baby Elephant",
                        Description = "[g]+25%[c] chance to deal ([g]25%[c] Luck) damage to a random enemy when you pick up a material",
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
                        Name = "Baby Gecko",
                        Description = "[g]+20%[c] chance to instantly attract a material when it's dropped[nl][g]+10[c] Range",
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
                        Name = "Baby With A Beard",
                        Description = "[g]+1[c] bullet dealing [g]1[c]+ ([g]100%[c] Ranged Damage) damage is fired from an enemy corpse when they die[nl][r]-50[c] Range",
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
                        Description = "[g]+15[c] materials when you pick up a crate[nl][r]-1%[c] Speed",
                        SpritePath = $"{fullPath}/Bag",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 15,
                        Limit = 3
                    }
                },
                {
                    "Bandana", new Item
                    {
                        Name = "Bandana",
                        Description = "Projectiles pierce through [g]+1[c] additional target[nl][r]-10%[c] Damage",
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
                        Description = "[g]+20[c] Range[nl][g]+10%[c] Attack Speed[nl][r]-2%[c] Life Steal",
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
                        Description = "[g]+8[c] Armor while standing still.[nl][r]-5%[c] Speed",
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
                        Description = "[g]+2%[c] Life Steal[nl][r]-2[c] Harvesting",
                        SpritePath = $"{fullPath}/Bat",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 20,
                        Limit = 0
                    }
                },
                {
                    "Beanie", new Item
                    {
                        Name = "Beanie",
                        Description = "[g]+4%[c] Speed[nl][r]-6[c] Range",
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
                        Name = "Big Arms",
                        Description = "[g]+12[c] Melee Damage[nl][g]+6[c] Ranged Damage[nl][r]-1[c] Armor[nl][r]-5%[c] Speed",
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
                        Name = "Black Belt",
                        Description = "[g]+25%[c] XP Gain[nl][g]+3[c] Melee Damage[nl][r]-8[c] Luck",
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
                        Description = "[g]+5%[c] Crit Chance[nl][g]+5%[c] Dodge[nl][r]-15[c] Range",
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
                        Name = "Blood Donation",
                        Description = "[g]+40[c] Harvesting[nl]You take [r]1[c] damage per second (does not give invulnerability time)",
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
                        Name = "Blood Leech",
                        Description = "[g]+2%[c] Life Steal[nl][g]+2[c] HP Regeneration[nl][r]-4[c] Harvesting",
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
                        Name = "Bloody Hand",
                        Description = "[g]+12%[c] Life Steal[nl][g]+2%[c] Damage for every [g]1%[c] Life Steal you have[nl]You take [r]1[c] damage per second (does not give invulnerability time)",
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
                        Name = "Boiling Water",
                        Description = "[g]+2[c] Elemental Damage[nl][r]-1[c] Max HP",
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
                        Description = "[g]+1[c] Engineering",
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
                        Name = "Bowler Hat",
                        Description = "[g]+15[c] Luck[nl][g]+18[c] Harvesting[nl][r]-5%[c] Attack Speed[nl][r]-3%[c] Crit Chance",
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
                        Name = "Boxing Glove",
                        Description = "[g]+3[c] Knockback",
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
                        Name = "Broken Mouth",
                        Description = "[g]+5[c] Max HP[nl][r]-1[c] HP Regeneration",
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
                        Description = "[g]+2%[c] Life Steal[nl][r]-1[c] Elemental Damage",
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
                        Description = "[g]+3[c] Max HP[nl][r]-1%[c] Damage",
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
                        Description = "[g]+2[c] Elemental Damage[nl][g]+2[c] HP Regeneration[nl][r]-2%[c] Speed",
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
                        Description = "[g]+4[c] Elemental Damage[nl][g]+1[c] HP Regeneration[nl][r]-10%[c] Enemies[nl][r]-5%[c] Damage",
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
                        Description = "[g]+5%[c] Life Steal[nl][g]+20%[c] Dodge[nl][r]-2[c] Melee Damage[nl][r]-2[c] Ranged Damage[nl][r]-2[c] Elemental Damage",
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
                        Description = "[g]+20%[c] Dodge while standing still.[nl][r]-4%[c] Damage[nl][g]+3%[c] Dodge",
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
                        Description = "[g]+1[c] Elemental Damage[nl][g]+2[c] Melee Damage[nl][r]-2[c] Harvesting",
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
                        Name = "Claw Tree",
                        Description = "[g]+1[c] Melee Damage[nl][g]+3%[c] Crit Chance[nl][r]-1[c] Max HP",
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
                        Description = "[g]+20[c] Luck[nl][g]+6%[c] Dodge[nl][r]-2%[c] Life Steal",
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
                        Description = "[g]+10%[c] Attack Speed[nl][r]-2%[c] Damage",
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
                        Description = "[g]+4[c] Engineering[nl][r]-4%[c] Damage",
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
                        Name = "Community Support",
                        Description = "[g]+1%[c] Attack Speed for every current living enemy[nl][r]-2[c] Armor",
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
                        Description = "[g]+5%[c] Speed[nl][g]+3[c] Engineering[nl][r]-3%[c] Crit Chance",
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
                        Description = "[g]-5%[c] Price",
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
                        Description = "Harvesting increases by an additional [g]+8%[c] at the end of a wave (stacking)",
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
                        Name = "Cute Monkey",
                        Description = "[g]+8%[c] chance to heal [g]1[c] HP when picking up a material[nl][r]-1[c] Ranged Damage",
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
                        Description = "[g]+25%[c] chance to deal ([g]25%[c] Luck) damage to a random enemy when an enemy dies",
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
                        Name = "Cyclops Worm",
                        Description = "[g]+12%[c] Damage[nl][r]-12[c] Range",
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
                        Name = "Dangerous Bunny",
                        Description = "[g]+1[c] free reroll in the shop",
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
                        Name = "Defective Steroids",
                        Description = "[g]+2[c] Melee Damage[nl][r]-3%[c] Attack Speed[nl][g]+2[c] Max HP",
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
                        Description = "[g]+10[c] Engineering[nl][g]+20%[c] XP Gain[nl][r]-3[c] Max HP",
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
                        Name = "Duct Tape",
                        Description = "[g]+1[c] Armor[nl][g]+1[c] Engineering[nl][r]-2[c] Max HP",
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
                        Description = "[g]+15%[c] Explosion Damage",
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
                        Name = "Energy Bracelet",
                        Description = "[g]+4%[c] Crit Chance[nl][g]+2[c] Elemental Damage[nl][r]-2[c] Ranged Damage",
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
                        Name = "Estys Couch",
                        Description = "[g]+2[c] HP Regeneration for every permanent [r]-1%[c] Speed you have.[nl][g]+5[c] Max HP[nl][r]-15%[c] Speed",
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
                        Description = "[g]+5[c] Armor[nl][g]+5%[c] Crit Chance[nl][g]+5[c] Engineering[nl][g]+5%[c] Speed[nl][r]-2[c] HP Regeneration[nl][r]-2%[c] Life Steal",
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
                        Name = "Explosive Shells",
                        Description = "[g]+60%[c] Explosion Damage[nl][g]+15%[c] Explosion Size[nl][r]-15%[c] Damage",
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
                        Name = "Explosive Turret",
                        Description = "Spawns a turret that shoots explosive bullets dealing [g]25[c] + ([g]175%[c] Engineering Stat) damage every [g]0.87s[c].",
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
                        Name = "Extra Stomach",
                        Description = "[g]+1[c] Max HP when picking up a consumable while at maximum health (max [g]+10[c] per wave)",
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
                        Name = "Eyes Surgery",
                        Description = "Burning activates [g]+10%[c] faster[nl][r]-10[c] Range",
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
                        Description = "[g]+8[c] Harvesting[nl][r]-1[c] Melee Damage",
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
                        Description = "[g]+1[c] HP Regeneration for every different Tier I item you have[nl][r]-2[c] HP Regeneration for every different Tier IV item you have",
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
                        Description = "[g]+10%[c] Speed[nl][g]+3%[c] Life Steal[nl][r]-8[c] Luck",
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
                        Description = "[g]+30%[c] Damage[nl][r]-3%[c] Attack Speed for every different weapon you have",
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
                        Name = "Fuel Tank",
                        Description = "[g]+4[c] Elemental Damage[nl][r]-1[c] Melee Damage[nl][r]-1[c] Ranged Damage",
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
                        Name = "Gambling Token",
                        Description = "[g]+8%[c] Dodge[nl][r]-1[c] Armor",
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
                        Description = "Spawns a garden that creates a fruit every [g]15[c] seconds",
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
                        Name = "Gentle Alien",
                        Description = "[g]+5%[c] Damage[nl][g]+5%[c] Enemies[nl][g]+2[c] Max HP",
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
                        Name = "Giant Belt",
                        Description = "Critical hits deal [g]+10%[c] of an enemy’s current health as bonus damage ([g]+1%[c] for bosses and elites)",
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
                        Name = "Glass Cannon",
                        Description = "[g]+25%[c] Damage[nl][r]-3[c] Armor",
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
                        Description = "[g]+20[c] Range",
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
                        Description = "[g]+10[c] Melee Damage[nl][g]+10[c] Elemental Damage[nl][r]-20[c] Range[nl][r]-20%[c] pickup range",
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
                        Name = "Goat Skull",
                        Description = "[g]+3[c] Melee Damage[nl][r]-2%[c] Crit Chance",
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
                        Name = "Grinds Magical Leaf",
                        Description = "[g]+3[c] Max HP at the end of a wave (stacking)[nl][g]+1[c] HP Regeneration at the end of a wave (stacking)[nl][g]+1%[c] Life Steal at the end of a wave (stacking)",
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
                        Name = "Gummy Berserker",
                        Description = "[g]+5%[c] Attack Speed[nl][g]+15[c] Range[nl][r]-1[c] Armor",
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
                        Description = "[g]+8[c] Melee Damage[nl][g]+8[c] Ranged Damage[nl][g]+8[c] Elemental Damage[nl]Your max HP is capped at its current value",
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
                        Name = "Head Injury",
                        Description = "[g]+6%[c] Damage[nl][r]-8[c] Range",
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
                        Name = "Heavy Bullets",
                        Description = "[g]+5[c] Ranged Damage[nl][g]+10%[c] Damage[nl][g]+10[c] Range[nl][r]-5%[c] Attack Speed[nl][r]-5%[c] Crit Chance",
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
                        Description = "[g]+2[c] Melee Damage[nl][g]+1[c] Ranged Damage[nl][r]-1[c] HP Regeneration",
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
                        Description = "[g]+1[c] Armor[nl][r]-2%[c] Speed",
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
                        Name = "Hunting Trophy",
                        Description = "[g]+33%[c] chance to get [g]1[c] material when killing an enemy with a critical hit",
                        SpritePath = $"{fullPath}/HuntingTrophy",
                        Rarity = Rarity.Tier3,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 55,
                        Limit = 3,
                    }
                },
                {
                    "IncendiaryTurret", new Item
                    {
                        Name = "Incendiary Turret",
                        Description = "Spawns a turret that shoots piercing flames dealing [g]1[c] damage and inflicting burn for [g]5[c] + ([g]33%[c] Engineering Stat) damage every second for [g]8[c] seconds. Attacks every [g]0.28s[c].",
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
                        Description = "[g]+7%[c] Damage[nl][r]-2[c] Max HP",
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
                        Description = "[g]+6%[c] Crit Chance[nl][r]-3%[c] Damage",
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
                        Name = "Jet Pack",
                        Description = "[g]+15%[c] Speed[nl][g]+10%[c] Dodge[nl][r]-5[c] Max HP[nl][r]-1[c] Armor",
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
                        Description = "A landmine spawns every [g]12[c] seconds dealing [g]10[c] + ([g]100%[c] Engineering Stat) damage in an area",
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
                        Name = "Laser Turret",
                        Description = "Spawns a turret that shoots piercing lasers dealing [g]20[c] + ([g]150%[c] Engineering Stat) damage every [g]0.87s[c]. The laser pierces up to [g]3[c] targets.",
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
                        Name = "Leather Vest",
                        Description = "[g]+2[c] Armor[nl][g]+6%[c] Dodge[nl][r]-3[c] Max HP",
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
                        Description = "[g]+1[c] HP recovered from consumables",
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
                        Description = "[g]+1[c] Ranged Damage[nl][r]-5[c] Range",
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
                        Name = "Little Frog",
                        Description = "[g]+20%[c] pickup range[nl][g]+10[c] Harvesting[nl][r]-5%[c] Dodge",
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
                        Name = "Little Muscley Dude",
                        Description = "[g]+3[c] Melee Damage[nl][g]+5[c] Max HP[nl][r]-15[c] Range",
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
                        Name = "Lost Duck",
                        Description = "[g]+10[c] Luck[nl][r]-1[c] Elemental Damage",
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
                        Name = "Lucky Charm",
                        Description = "[g]+30[c] Luck[nl][r]-2[c] Melee Damage[nl][r]-1[c] Ranged Damage",
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
                        Name = "Lucky Coin",
                        Description = "[g]+2[c] Luck for every [g]1%[c] Crit Chance you have[nl][r]-2[c] Armor",
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
                        Description = "[g]+3[c] HP Regeneration[nl]2 additional loot aliens appear during the next wave",
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
                        Name = "Lumberjack Shirt",
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
                        Description = "[g]+20[c] Melee Damage[nl][g]+5[c] HP Regeneration[nl][r]-8%[c] Damage[nl][r]-3%[c] Speed",
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
                        Description = "[g]+6[c] Melee Damage[nl][r]-3[c] Ranged Damage",
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
                        Description = "[g]+3[c] Max HP[nl][g]+3%[c] Damage[nl][g]+1[c] Armor[nl][g]+3%[c] Speed[nl][r]-4%[c] Crit Chance",
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
                        Name = "Medical Turret",
                        Description = "Spawns a medical turret that shoots projectiles healing [g]3[c] + ([g]5%[c] Engineering Stat) HP every [g]2.2s[c].",
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
                        Description = "[g]+10[c] HP Regeneration[nl][g]+2[c] HP Regeneration every [g]5[c] seconds until the end of the wave[nl][r]-10[c] Luck",
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
                        Name = "Metal Detector",
                        Description = "[g]+5%[c] chance to double the value of picked up materials[nl][g]+6[c] Luck[nl][g]+2[c] Engineering[nl][r]-5%[c] Damage",
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
                        Name = "Metal Plate",
                        Description = "[g]+2[c] Armor[nl][r]-3%[c] Damage",
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
                        Description = "[g]+10%[c] Damage[nl][r]-4%[c] Attack Speed",
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
                        Description = "[g]+5%[c] Life Steal[nl][r]+10%[c] Enemies[nl][r]-5[c] Harvesting",
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
                        Description = "[g]+3[c] HP Regeneration[nl][r]-2[c] Luck",
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
                        Description = "[g]+1[c] Ranged Damage[nl][g]+1[c] Elemental Damage[nl][r]-3%[c] Speed",
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
                        Name = "Night Goggles",
                        Description = "[g]+15%[c] Crit Chance[nl][g]+50[c] Range[nl][r]-3[c] Max HP[nl][r]-1[c] Armor",
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
                        Description = "[g]+12[c] Max HP[nl][g]+5[c] HP Regeneration[nl][g]+3%[c] Life Steal[nl][r]-8%[c] Crit Chance",
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
                        Description = "[g]+3[c] Max HP[nl][g]+1[c] Max HP for every [g]100[c] Materials you have.[nl][r]-5%[c] Speed",
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
                        Description = "[g]+12[c] Max HP[nl][g]+25[c] Luck[nl][r]-5%[c] Damage",
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
                        Name = "Peaceful Bee",
                        Description = "[g]+4%[c] Dodge[nl][g]+4[c] Harvesting[nl][r]-1[c] Melee Damage[nl][r]-1[c] Ranged Damage",
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
                        Description = "[g]+25%[c] XP Gain[nl][g]+100%[c] XP Gain during the next wave[nl][g]+50%[c] Enemy damage during the next wave",
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
                        Description = "[g]+2[c] Engineering[nl][r]-1%[c] Attack Speed[nl][r]-1%[c] Crit Chance",
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
                        Name = "Piggy Bank",
                        Description = "[g]+20%[c] of your materials at the start of waves",
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
                        Description = "[g]+3[c] HP Regeneration[nl][r]-1%[c] Life Steal",
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
                        Description = "[g]+25%[c] Explosion Size",
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
                        Description = "[g]+10%[c] Attack Speed[nl][g]+5%[c] Crit Chance[nl][g]+15[c] Range[nl][r]-2[c] HP Regeneration",
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
                        Name = "Pocket Factory",
                        Description = "[g]+2[c] Engineering[nl]Killing a tree spawns a turret",
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
                        Description = "[g]+3[c] Max HP[nl][g]+2[c] HP Regeneration[nl][g]+1%[c] Life Steal[nl][g]+5%[c] Damage[nl][g]+5%[c] Attack Speed[nl][g]+3%[c] Speed[nl][g]+3%[c] Dodge[nl][g]+1[c] Armor[nl][g]+5[c] Luck",
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
                        Name = "Power Generator",
                        Description = "[g]+1%[c] Damage for every permanent [g]1%[c] Speed you have.[nl][r]-5%[c] Damage",
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
                        Name = "Propeller Hat",
                        Description = "[g]+10[c] Luck[nl][r]-2%[c] Damage",
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
                        Description = "[g]+15%[c] Piercing Damage. Can't go above base damage[nl][r]-2%[c] Damage",
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
                        Name = "Recycling Machine",
                        Description = "Gain [g]+35%[c] more materials from recycling items",
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
                        Name = "Regeneration Potion",
                        Description = "HP Regeneration is doubled while you have less than [g]50%[c] health[nl][g]+3[c] HP Regeneration",
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
                        Name = "Retromations Hoodie",
                        Description = "[g]+2%[c] Attack Speed for every [g]1%[c] Dodge you have.[nl][r]-80[c] Range",
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
                        Description = "Your projectiles gain [g]+1[c] bounce[nl][r]-25%[c] Damage",
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
                        Name = "Rip And Tear",
                        Description = "Enemies have a [g]+20%[c] chance to explode for [g]10[c] + ([g]50%[c] Melee Damage) damage when they die[nl][r]-12[c] Harvesting",
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
                        Description = "[g]+2[c] Melee Damage[nl][g]100%[c] chance to deal [g]1[c] ([g]300%[c] Melee Damage) damage to an enemy when dodging their attack",
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
                        Description = "[g]+6%[c] Damage[nl][g]+2%[c] Life Steal[nl][r]-2[c] Engineering",
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
                        Name = "Robot Arm",
                        Description = "[g]+6[c] Armor[nl][g]+6[c] Engineering[nl][r]-2[c] HP Regeneration[nl][r]-2%[c] Life Steal",
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
                        Name = "Sad Tomato",
                        Description = "[g]+8[c] HP Regeneration[nl]Start waves with [r]-50%[c] HP",
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
                        Description = "[g]+20%[c] XP Gain[nl][r]-8[c] Range",
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
                        Name = "Scared Sausage",
                        Description = "Attacks have a [g]+25%[c] chance to deal [g]1x3[c] + ([g]100%[c] Elemental Damage) burning damage",
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
                        Description = "[g]+2[c] Ranged Damage[nl][g]+25[c] Range[nl][r]-7%[c] Attack Speed",
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
                        Description = "[g]+8[c] HP Regeneration[nl][g]+8[c] Engineering[nl][g]+80[c] Range[nl]Your Speed is capped at its current value",
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
                        Name = "Shady Potion",
                        Description = "[g]+20[c] Luck[nl][r]-2[c] HP Regeneration",
                        SpritePath = $"{fullPath}/ShadyPotion",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 20,
                        Limit = 0
                    }
                },
                {
                    "Shmoop", new Item
                    {
                        Name = "Shmoop",
                        Description = "[g]+6[c] Max HP[nl][g]+2[c] HP Regeneration[nl][g]+1%[c] Life Steal[nl][r]-3%[c] Speed",
                        SpritePath = $"{fullPath}/Shmoop",
                        Rarity = Rarity.Tier2,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 45,
                        Limit = 0
                    }
                },
                {
                    "SmallMagazine", new Item
                    {
                        Name = "Small Magazine",
                        Description = "[g]+12[c] Max HP[nl][g]+8[c] HP Regeneration[nl][r]-5%[c] Attack Speed[nl][r]-5%[c] Crit Chance",
                        SpritePath = $"{fullPath}/SmallMagazine",
                        Rarity = Rarity.Tier3,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 60,
                        Limit = 0
                    }
                },
                {
                    "Snail", new Item
                    {
                        Name = "Snail",
                        Description = "[g]-5[c] Enemy Speed[nl][r]-3%[c] Speed",
                        SpritePath = $"{fullPath}/Snail",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 40,
                        Limit = 1
                    }
                },
                {
                    "Snake", new Item
                    {
                        Name = "Snake",
                        Description = "Burning spreads to a nearby enemy for [g]50%[c] of its remaining damage",
                        SpritePath = $"{fullPath}/Snake",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 30,
                        Limit = 0
                    }
                },
                {
                    "Spider", new Item
                    {
                        Name = "Spider",
                        Description = "[g]+8%[c] Attack Speed for every different Tier III item you have[nl][r]-5%[c] Dodge",
                        SpritePath = $"{fullPath}/Spider",
                        Rarity = Rarity.Tier4,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 75,
                        Limit = 0,
                    }
                },
                {
                    "SpicySauce", new Item
                    {
                        Name = "Spicy Sauce",
                        Description = "[g]+2[c] Elemental Damage[nl]You take [r]1[c] damage per second (does not give invulnerability time)",
                        SpritePath = $"{fullPath}/SpicySauce",
                        Rarity = Rarity.Tier2,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 35,
                        Limit = 0,
                    }
                },
                {
                    "StoneSkin", new Item
                    {
                        Name = "Stone Skin",
                        Description = "[g]+8[c] Armor[nl][r]-6[c] Luck",
                        SpritePath = $"{fullPath}/StoneSkin",
                        Rarity = Rarity.Tier3,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 65,
                        Limit = 0
                    }
                },
                {
                    "StrangeBook", new Item
                    {
                        Name = "Strange Book",
                        Description = "[g]+8%[c] Chance to heal when dealing Elemental Damage",
                        SpritePath = $"{fullPath}/StrangeBook",
                        Rarity = Rarity.Tier3,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 50,
                        Limit = 0
                    }
                },
                {
                    "Sunglasses", new Item
                    {
                        Name = "Sunglasses",
                        Description = "[g]+5%[c] Crit Chance[nl][r]-2[c] Armor",
                        SpritePath = $"{fullPath}/Sunglasses",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 35,
                        Limit = 0
                    }
                },
                {
                    "Tree", new Item
                    {
                        Name = "Tree",
                        Description = "Spawns a tree at the start of the wave",
                        SpritePath = $"{fullPath}/Tree",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 10,
                        Limit = 1
                    }
                },
                {
                    "TriangleOfPower", new Item
                    {
                        Name = "Triangle Of Power",
                        Description = "[g]+20%[c] Damage[nl][r]-2[c] Damage for every damage you take until the end of the wave",
                        SpritePath = $"{fullPath}/TriangleOfPower",
                        Rarity = Rarity.Tier3,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 60,
                        Limit = 0
                    }
                },
                {
                    "Turret", new Item
                    {
                        Name = "Turret",
                        Description = "Spawns a turret that shoots bullets dealing [g]15[c] + ([g]150%[c] Engineering Stat) damage every [g]0.8s[c]",
                        SpritePath = $"{fullPath}/Turret",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 45,
                        Limit = 0
                    }
                },
                {
                    "Tyler", new Item
                    {
                        Name = "Tyler",
                        Description = "Spawns a little robot following you and dealing [g]50[c] Burning Damage (based on [g]250%[c] of your Elemental Damage)",
                        SpritePath = $"{fullPath}/Tyler",
                        Rarity = Rarity.Tier3,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 65,
                        Limit = 1
                    }
                },
                {
                    "VigilanteRing", new Item
                    {
                        Name = "Vigilante Ring",
                        Description = "[g]+2%[c] Damage at the end of a wave (stacking)",
                        SpritePath = $"{fullPath}/VigilanteRing",
                        Rarity = Rarity.Tier3,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 80,
                        Limit = 1
                    }
                },
                {
                    "WarriorHelmet", new Item
                    {
                        Name = "Warrior Helmet",
                        Description = "[g]+5[c] Armor[nl][r]-15%[c] Crit Chance",
                        SpritePath = $"{fullPath}/WarriorHelmet",
                        Rarity = Rarity.Tier3,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 70,
                        Limit = 0
                    }
                },
                {
                    "Wheat", new Item
                    {
                        Name = "Wheat",
                        Description = "[g]+5[c] Harvesting[nl][g]+1%[c] Life Steal[nl][r]-3[c] Dodge",
                        SpritePath = $"{fullPath}/Wheat",
                        Rarity = Rarity.Tier1,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 25,
                        Limit = 0
                    }
                },
                {
                    "Wisdom", new Item
                    {
                        Name = "Wisdom",
                        Description = "[g]+5%[c] Damage every [g]5[c] seconds until the end of the wave[nl][r]-20%[c] Damage",
                        SpritePath = $"{fullPath}/Wisdom",
                        Rarity = Rarity.Tier3,
                        Classes = new Class[] { Class.Item },
                        BasePrice = 75,
                        Limit = 0
                    }
                }
            };
        }
    }
}