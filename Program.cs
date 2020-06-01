using System;
using System.IO;
using System.Linq.Expressions;

namespace QuestDump
{
	class Program
	{
		static string[] itemName = new string[]{ "Book of Combos 1",
											"Book of Combos 2",
											"Book of Combos 3",
											"Book of Combos 4",
											"Book of Combos 5",
											"Alchemy Guide",
											"Potion",
											"Mega Potion",
											"Nutrients",
											"Mega Nutrients",
											"Antidote",
											"Immunizer",
											"Power Juice",
											"Mega Juice",
											"Demondrug",
											"Mega Demondrug",
											"Power Pill",
											"Armorskin",
											"Mega Armorskin",
											"Armor Pill",
											"Cool Drink",
											"Hot Drink",
											"Psychoserum",
											"Monster Fluid",
											"Monster Broth",
											"Herbal Medicine",
											"Max Potion",
											"Ancient Potion",
											"Catalyst",
											"Gunpowder",
											"Lifecrystals",
											"Lifepowder",
											"Powercharm",
											"Powertalon",
											"Armorcharm",
											"Armortalon",
											"Raw Meat",
											"Rare Steak",
											"Well-Done Steak",
											"Gourmet Steak",
											"Burnt Meat",
											"Poisoned Meat",
											"Tainted Meat",
											"Drugged Meat",
											"Kingmeat",
											"Throwing Knife",
											"Poison Thrw Knf",
											"Sleeping Thr Knf",
											"Paralyze Thr Knf",
											"Bomb Material",
											"Paintball",
											"Flash Bomb",
											"Sonic Bomb",
											"Dung",
											"Wyvern Droppings",
											"Dung Bomb",
											"Smoke Bomb",
											"Poison Smoke Bmb",
											"Farcaster",
											"Spiderweb",
											"Net",
											"Pitfall Trap",
											"Trap Tool",
											"Barrel Lid",
											"Small Barrel",
											"Large Barrel",
											"Sm Barrel-Bomb",
											"Sm Barrel-Bomb+",
											"Lg Barrel-Bomb",
											"Lg Barrel-Bomb+",
											"Huskberry",
											"Sm Bone Husk",
											"Lg Bone Husk",
											"Normal S Lv1",
											"Normal S Lv2",
											"Normal S Lv3",
											"Pierce S Lv1",
											"Pierce S Lv2",
											"Pierce S Lv3",
											"Pellet S Lv1",
											"Pellet S Lv2",
											"Pellet S Lv3",
											"Crag S Lv1",
											"Crag S Lv2",
											"Crag S Lv3",
											"Clust S Lv1",
											"Clust S Lv2",
											"Clust S Lv3",
											"Flaming S",
											"Ice S",
											"Thunder S",
											"Dragon S",
											"Recov S Lv1",
											"Recov S Lv2",
											"Poison S Lv1",
											"Poison S Lv2",
											"Stun S Lv1",
											"Stun S Lv2",
											"Sleep S Lv1",
											"Sleep S Lv2",
											"Tranq S",
											"Paint S",
											"Demon S",
											"Armor S",
											"Cricket",
											"Worm",
											"Firefly",
											"Frog",
											"Tuna Bait",
											"Arrowana Bait",
											"Goldenfish Bait",
											"Mega Fishing Fly",
											"Old Pickaxe",
											"Iron Pickaxe",
											"Mega Pickaxe",
											"Expand Pickaxe",
											"Old Bugnet",
											"Bugnet",
											"Mega Bugnet",
											"BBQ Spit",
											"Gourmet BBQ Spit",
											"Whetstone",
											"Binoculars",
											"Garbage",
											"Flute",
											"Health Flute",
											"Antidote Flute",
											"Demon Flute",
											"Armor Flute",
											"Honey",
											"Herb",
											"Antidote Herb",
											"Fire Herb",
											"Ivy",
											"Sleep Herb",
											"Sap Plant",
											"Felvine",
											"Cactus Flower",
											"King Cactus",
											"Hot Pepper",
											"Dosbiscus",
											"Special Mushroom",
											"Blue Mushroom",
											"Nitroshroom",
											"Stunshroom",
											"Toadstool",
											"Dragon Toadstool",
											"Spicy Mushroom",
											"Chaos Mushroom",
											"Paintberry",
											"Power Seed",
											"Armor Seed",
											"Dragon Seed",
											"Scatternut",
											"Needleberry",
											"Bomberry",
											"Red Seed",
											"Green Seed",
											"Stone",
											"Disk Stone",
											"Iron Ore",
											"Earth Crystal",
											"Machalite Ore",
											"Dragonite Ore",
											"Carbalite Ore",
											"Great Stone",
											"Union Ore",
											"Firestone",
											"Firecell Stone",
											"Coal",
											"Lightcrystal",
											"Novacrystal",
											"Pure Crystal",
											"Antiseptic Stone",
											"Ice Crystal",
											"Rainbow Ore",
											"Knife Mackerel",
											"Sushifish",
											"Sleepyfish",
											"Pin Tuna",
											"Rumblefish",
											"Scatterfish",
											"Burst Arrowana",
											"Bomb Arrowana",
											"Goldenfish",
											"Speartuna",
											"Small Goldenfish",
											"Springnight Carp",
											"Pickaxe Fish",
											"Bugnet Fish",
											"Cooler Fish",
											"Insect Husk",
											"Yambug",
											"Bughopper",
											"Snakebee Larva",
											"Godbug",
											"Bitterbug",
											"Flashbug",
											"Thunderbug",
											"King Scarab",
											"Joiner Grasshppr",
											"Rainbow Insect",
											"Screamer",
											"Poison Sac",
											"Toxin Sac",
											"Stun Sac",
											"Paralysis Sac",
											"Sleep Sac",
											"Coma Sac",
											"Flame Sac",
											"Inferno Sac",
											"Electro Sac",
											"Thunder Sac",
											"Power Extract",
											"Pale Extract",
											"Sm Monster Bone",
											"Med Monster Bone",
											"Lg Monster Bone",
											"Monster Bone+",
											"Hrd Monster Bone",
											"Mystery Bone",
											"Unknown Skull",
											"Master's Skull",
											"Bone",
											"Wyvern Fang",
											"Wyvern Claw ",
											"Mosswine Hide",
											"Mosswine Head",
											"Bullfango Pelt",
											"Bullfango Head",
											"Kelbi Horn",
											"Kelbi Hide",
											"Velociprey Fang",
											"Velociprey Scale",
											"Velocip. Scale+",
											"Velociprey Hide",
											"Velociprey Hide+",
											"Velocidrome Claw",
											"Velocidrome Head",
											"WhtVeloprySclPc",
											"WhtVelopry Scale",
											"Wht Velopry Hide",
											"Genprey Fang",
											"Genprey Scale",
											"Genprey Scale+",
											"Genprey Hide",
											"Genprey Hide+",
											"Gendrome Hide",
											"Ioprey Fang",
											"Ioprey Scale",
											"Ioprey Scale+",
											"Ioprey Hide",
											"Ioprey Hide+",
											"Iodrome Hide",
											"Kut-Ku Coin",
											"Kut-Ku Scale",
											"Kut-Ku Shell",
											"Kut-Ku Carapace",
											"Kut-Ku Ear",
											"Long Kut-Ku Ear",
											"Tiny Beak",
											"Giant Beak",
											"Splendid Beak",
											"Kut-Ku Webbing",
											"Kut-Ku Wing",
											"Blue Kut-Ku Scl",
											"Blue Kut-Ku Shl",
											"BluKutKuCarapace",
											"SmlBlueKut-KuEar",
											"Blue Kut-Ku Ear",
											"Blue Kut-Ku Wing",
											"Gypceros Coin",
											"Rubbery Hide",
											"Rubbery Hide+",
											"Gypceros Head",
											"Pur Rubbery Hide",
											"Piscine Fang",
											"Piscine Liver",
											"Piscine Jaw",
											"Plesioth Coin",
											"Plesioth Scale",
											"Plesioth Scale+",
											"Plesioth Fin",
											"Plesioth Top Fin",
											"GrnPlesiothSclPc",
											"Grn Plesioth Scl",
											"GrnPlesiothFinPc",
											"Grn Plesioth Fin",
											"Cephalos Coin",
											"Cephalos Scale",
											"Cephalos Scale+",
											"Cephalos Fin",
											"Cephalos Fin+",
											"Coral Cphlos Scl",
											"Coral Cphlos Fin",
											"Rathian Coin",
											"Rathian Claw",
											"Rathian Scale",
											"Rathian Scale+",
											"Rathian Plate",
											"Rathian Ruby",
											"Rathian Shell",
											"Rathian Carapace",
											"Rathian Spike",
											"Pnk Rathian Claw",
											"Pnk Rathian Scl",
											"Pnk Rathian Scl+",
											"Pnk Rthian Plate",
											"Pnk Rathian Rby",
											"Pnk Rathian Shl",
											"Pnk Rathian Cpc",
											"Pnk Rthian Thorn",
											"Gld Rathian Clw",
											"Gld Rathian Scl",
											"Gld Rthian Plate",
											"Gld Rathian Rby",
											"Gld Rathian Shl",
											"Gld Rthian Thorn",
											"Rathalos Coin",
											"Rathalos Claw",
											"Rathalos Scale",
											"Rathalos Scale+",
											"Rathalos Plate",
											"Rathalos Ruby",
											"Rathalos Shell",
											"Rathlos Carapace",
											"Wyvern Marrow",
											"Rathalos Tail",
											"Rathalos Webbing",
											"Rathalos Wing",
											"Azure Rthlos Clw",
											"Azure Rthlos Scl",
											"Azre Rthlos Scl+",
											"Azre Rthls Plate",
											"Azure Rthlos Rby",
											"Azure Rthlos Shl",
											"Azure Rthlos Cpc",
											"Rthlos BrainStem",
											"Azur Rthlos Tail",
											"Azr Rthls Webbng",
											"Azur Rthlos Wing",
											"Slvr Rthalos Clw",
											"Slvr Rthalos Scl",
											"Slvr Rthls Plate",
											"Slvr Rthalos Rby",
											"Slvr Rthalos Shl",
											"Slvr Rthals Tail",
											"Slv Rthls Webbng",
											"Slvr Rthlos Wing",
											"Khezu Coin",
											"Flabby Hide",
											"Khezu Hide - Tan",
											"Pale Bone",
											"Pale Khezu Steak",
											"Pale Lips",
											"Alluring Hide",
											"Basarios Coin",
											"Basarios Shell",
											"Basrios Carapace",
											"Basarios Wing",
											"Basarios Tears",
											"Gravios Coin",
											"Gravios Shell",
											"Gravios Carapace",
											"GraviosHeavyShl",
											"Gravios Wing",
											"StrngGraviosWing",
											"Gravios Head",
											"Gravios Jaw",
											"Blk Gravios Crst",
											"Blk Gravios Shl",
											"Blk Gravios Cpc",
											"Blk Gravios Head",
											"Blk Gravios Wing",
											"Twisted Horn",
											"Majestic Horn",
											"Solid Blos Horn",
											"Diablos Shell",
											"Diablos Carapace",
											"Diablos Spine",
											"Diablos Thoracic",
											"Diablos Tail",
											"Blos Jaw",
											"Blos Fang",
											"TwstBlkBlosHrn",
											"Black Blos Shell",
											"Black Blos Spine",
											"Black Blos Tail",
											"Vespoid Abdomen",
											"Vespoid Shell",
											"Vespoid Carapace",
											"Vespoid Wing",
											"Vespoid Bladefin",
											"Vspoid Razorwing",
											"Hornetaur Shell",
											"Hornet Carapace",
											"Hornetaur Head",
											"Hornetaur Wing",
											"Hornet Bladefin",
											"Hornet Razorwing",
											"Sm Lobstershell",
											"Lg Lobstershell",
											"Gt Lobstershell",
											"Monoblos Coin",
											"Crimson Horn",
											"Monoblos Shell",
											"Monoblos Spine",
											"Monoblos Heart",
											"Wht Monoblos Hrn",
											"Wht Monoblos Shl",
											"Wht Monoblos Spn",
											"Kirin Horn",
											"Kirin Hide",
											"Kirin Hide+",
											"SpecialKirinHide",
											"Kirin Mane",
											"Kirin Thndr Tail",
											"Kirin Azure Horn",
											"Kirin Azr T-Tail",
											"Sm Lao-Shan Claw",
											"Lao-Shan's Claw",
											"Lao-Shan's Horn",
											"Lao-Shan's Scale",
											"Lao-Shan Scale+",
											"Lao-Shan's Plate",
											"Lao-Shan's Ruby",
											"Lao-Shan's Shell",
											"Lao-ShanCarapace",
											"Lao-Shan's Spine",
											"LaoShan Thoracic",
											"LaoS Heavy Shell",
											"Azure LaoS Claw",
											"Azure LaoS Horn",
											"Azure LaoS Scale",
											"Azure LaoS Plate",
											"Azure LaoS Shell",
											"Azure LaoS Spine",
											"Fatalis' Horn",
											"Fatalis' Spike",
											"Fatalis' Gore",
											"Fatalis' Scale",
											"Fatalis' Scale+",
											"Thck Fatalis Scl",
											"Fatalis' Shell",
											"Fatalis Carapace",
											"Fatalis Hvy Shl",
											"Fatalis' Crust",
											"Hrd Fatalis Crst",
											"Hvy Fatalis Crst",
											"Fatalis' Eye",
											"Fatalis Shrp Eye",
											"Fatalis Evil Eye",
											"Fatalis' Webbing",
											"Fatalis' Wing",
											"Fatalis Strg Wng",
											"Fatlis Crmsn Hrn",
											"Fatlis Crmsn Scl",
											"Fatlis Crmsn Shl",
											"Ft Crmsn B-Plate",
											"Fatalis Devl Eye",
											"Fatlis Crmsn Wng",
											"Garuga Scale",
											"Garuga Shell",
											"Garuga Ear",
											"Sharpened Beak",
											"Garuga Wing",
											"Garuga Plate",
											"Garuga Mane",
											"Garuga Carapace",
											"Long Garuga Ear",
											"Stylish Beak",
											"StrongGarugaWing",
											"Egg Ticket",
											"Jewel Ticket",
											"Commendation",
											"Pawprint Stamp",
											"Old Lady's Note",
											"Guild Ticket",
											"Silver Ticket",
											"Gold Ticket",
											"Platinum Ticket",
											"BBQ Ticket",
											"Hunter Citation",
											"Heaven&EarthCrst",
											"Grt Sword Ticket",
											"Hammer Ticket",
											"Lance Ticket",
											"Saber Ticket",
											"Gunner Ticket",
											"Paw Pass Ticket",
											"Limited Paw Pass",
											"Magazine Ticket",
											"Dummy item",
											"ThunderG Voucher",
											"Chrome Voucher",
											"PineFlynMealPass",
											"BmboFlynMealPass",
											"PlumFlynMealPass",
											"VeggieElderTcket",
											"VeggieElderTckt+",
											"VegElderTcktBrz",
											"VegElderTcktSlv",
											"VegElderTcktGld",
											"Lost Umbrella",
											"Chief's Old Swrd",
											"Ruststone",
											"Ruststone",
											"Ruststone",
											"Ruststone",
											"Ruststone",
											"Ancient Stone",
											"Ancient Stone",
											"Ancient Stone",
											"Ancient Stone",
											"Ancient Stone",
											"Organizer Guide",
											"Backpacker Guide",
											"Mosswine Info",
											"Bullfango Info",
											"Kelbi Info",
											"Aptonoth Info",
											"Apceros Info",
											"Felyne Info",
											"Melynx Info",
											"Velociprey Info",
											"Velocidrome Info",
											"Genprey Info",
											"Gendrome Info",
											"Ioprey Info",
											"Iodrome Info",
											"Rathalos Info",
											"Rathian Info",
											"Yian Kut-Ku Info",
											"Gypceros Info",
											"Vespoid Info",
											"Hornetaur Info",
											"Khezu Info",
											"Plesioth Info",
											"Cephalos Info",
											"Cephadrome Info",
											"Monoblos Info",
											"Diablos Info",
											"Gravios Info",
											"Basarios Info",
											"Kirin Info",
											"Lao-Shan Info",
											"Fatalis Info",
											"Garuga Info",
											"Steel Egg",
											"Silver Egg",
											"Golden Egg",
											"Map",
											"First-aid Med.",
											"Ration",
											"Portable Spit",
											"Mini Whetstone",
											"Tranq Bomb",
											"Ballista S",
											"Cannon S",
											"Wyvern",
											"Wyvern Egg",
											"Herbivore Egg",
											"Sootstone Ore",
											"Quartz Ore",
											"Powderstone",
											"Disk S",
											"Antidote S",
											"Dung S",
											"Gravios Jewel",
											"Gravios Jewel",
											"Blos Jewel",
											"Blos Jewel",
											"Rathian Jewel",
											"Rathian Jewel",
											"Plesioth Jewel",
											"Plesioth Jewel",
											"Rathalos Jewel",
											"Rathalos Jewel",
											"SearingJewelRock",
											"SearingJewelRock",
											"Dragon Fossil",
											"Dragon Fossil",
											"Prizm Egg",
											"Prizm Egg",
											"Stalactite Egg",
											"Stalactite Egg",
											"Amber Egg",
											"Amber Egg",
											"Lava Springs Egg",
											"Lava Springs Egg",
											"Wyvern Fossil",
											"Wyvern Fossil",
											"Swamp Pea",
											"Swamp Pea",
											"Giant Quail Egg",
											"Giant Quail Egg",
											"Hard Dragonrock",
											"Hard Dragonrock",
											"Dragonrock",
											"Dragonrock",
											"Gravios Giblets",
											"Blos Heart",
											"Rathian Chops",
											"Plesioth Filet",
											"Rathalos Tongue",
											"Gravios Wingtip",
											"Blos Sirloin",
											"Rathian Roast",
											"Fatty Plesioth",
											"Rathalos Liver",
											"Purple Crest",
											"Orange Crest",
											"Red Crest",
											"Dragonite (L)",
											"Dragonite (M)",
											"Dragonite (S)",
											"MelyneTreasurBrl",
											"Foreign Currency",
											"Felyne Flute",
											"Rich Spiderweb",
											"Vivacious Plant",
											"Vitamin Grass",
											"Queen Cactus",
											"Rascal Wheat",
											"Peach Clover",
											"Energy Plant",
											"Romantic Shroom",
											"Long Mushroom",
											"Charisma Shroom",
											"Glamour Shroom",
											"Skin Care Shroom",
											"Layered Mushroom",
											"Flaming Bean",
											"Desert Lotusroot",
											"Writhe Nut",
											"Melonberry",
											"King Speartuna",
											"Volcano Mackerel",
											"FlamingPondSmelt",
											"Magma Trout",
											"TannedGoldenfish",
											"Feudal Tuna",
											"Merchant Sardine",
											"Geisha Arrowana",
											"Latin Tuna",
											"Goldendrome",
											"Messengerfish",
											"Jewel Fragment",
											"Searing Diamond",
											"Zealous Ruby",
											"Charming Crystal",
											"Zealous Emerald",
											"Minagarde Night",
											"Meteorite",
											"Power Pebble",
											"Star Fragment",
											"Fireworks Stone",
											"Maiden Termite",
											"Desert Strider",
											"Madame Cricket",
											"Killer Beetle",
											"Designer Locust",
											"Scorpion Beetle",
											"Golden Butterfly",
											"Mansion Crab",
											"Tuxedo Beetle",
											"Longleg Bagworm",
											"King Earthworm" };
		static string[] monsterName = new string[]{ "Rathian",
													"Fatalis",
													"Kelbi",
													"Mosswine",
													"Bullfango",
													"Yian Kut-Ku",
													"Lao-Shan Lung",
													"Cephadrome",
													"Felyne",
													"dummy",
													"Rathalos",
													"Aptonoth",
													"Genprey",
													"Diablos",
													"Khezu",
													"Velociprey",
													"Gravios",
													"dummy",
													"Vespoid",
													"Gypceros",
													"Plesioth",
													"Basarios",
													"Melynx",
													"Hornetaur",
													"Apceros",
													"Monoblos",
													"Velocidrome",
													"Gendrome",
													"dummy",
													"Ioprey",
													"Iodrome",
													"dummy",
													"Kirin",
													"Cephalos",
													"White Velociprey",
													"Crimson Fatalis",
													"Pink Rathian",
													"Blue Yian Kut-Ku",
													"Purple Gypceros",
													"Yian Garuga",
													"Azure Rathalos",
													"Gold Rathian",
													"Black Diablos",
													"White Monoblos",
													"Red Khezu",
													"Green Plesioth",
													"Black Gravios",
													"Basarios",
													"Silver Rathalos",
													"Ashen Lao-Shan Lung" };
		static void Main(string[] args)
		{
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("Quest Data Dumper\n\n" +
							"Usage: questdump inputfile format language\n\n" +
							"Formats:\n" +
							"-gh = Markdown Table for Github\n" +
							"-pt = Plain Text\n\n" +
							"Languages:\n" +
							"-en = English\n" +
							"-fr = French\n" +
							"-ge = German\n" +
							"-it = Italian\n" +
							"-sp = Spanish\n");
			if (args == null || args.Length <= 2)
			{
				Console.ForegroundColor = ConsoleColor.Gray;
				return;
			}
			if (args.Length >= 1&&args.Length <= 3)
			{
				try
				{
					DumpQuest(args[0], args[1], args[2]);
				}
				catch (Exception e)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("\n\nError: " + e.Message);
				}
			}
			Console.ForegroundColor = ConsoleColor.Gray;
		}

		static void DumpQuest(string inputfile, string outputformat, string language)
		{
			FileStream fs = new FileStream(inputfile, FileMode.Open, FileAccess.Read);
			BinaryReader br = new BinaryReader(fs);
			uint QuestHeader = ReadHeader(br);
			if(QuestHeader==60)
            {
				DumpTextF1(br, outputformat, language);
			}
		}

		struct supplies
		{
			public uint itemName;
			public uint itemAmount;
			public string itemNameStr;
		}

		struct rewards
		{
			public uint itemName;
			public uint itemAmount;
			public uint itemChance;
			public string itemNameStr;
		}

		static string ReadUntilNull(BinaryReader stream)
		{
			string str = "";
			char chr;
			while ((int)(chr = stream.ReadChar()) != 0)
				str += chr;
			return str;
		}

		static string ReadUntilNewLine(BinaryReader stream)
		{
			string str = "";
			char chr;
			while ((int)(chr = stream.ReadChar()) != 10)
				str += chr;
			return str;
		}

		static uint ReadHeader(BinaryReader stream)
		{
			uint header;

			stream.BaseStream.Seek(0, SeekOrigin.Begin);
			header = stream.ReadUInt32();
			return header;
		}

		static uint GetAreaPointerF1(BinaryReader stream)
		{
			uint offsetAreas;

			stream.BaseStream.Seek(4, SeekOrigin.Begin);
			offsetAreas = stream.ReadUInt32();
			return offsetAreas;
		}

		static uint GetSupplyPointerF1(BinaryReader stream)
		{
			uint offsetSupplies;

			stream.BaseStream.Seek(8, SeekOrigin.Begin);
			offsetSupplies = stream.ReadUInt32();
			return offsetSupplies;
		}

		static uint GetRewardsPointerF1(BinaryReader stream)
		{
			uint offsetRewards1;
			uint offsetRewards2;

			stream.BaseStream.Seek(12, SeekOrigin.Begin);
			offsetRewards1 = stream.ReadUInt32();
			stream.BaseStream.Seek(offsetRewards1+4, SeekOrigin.Begin);
			offsetRewards2 = stream.ReadUInt32();
			return offsetRewards2;
		}

		static uint GetObjectivePointerF1(BinaryReader stream, bool skipBytes)
		{
			uint offsetObjective;

			stream.BaseStream.Seek(16, SeekOrigin.Begin);
			offsetObjective = stream.ReadUInt32();
			if(skipBytes)
			{
				offsetObjective += 8;
			}
			return offsetObjective;
		}

		static string GetAreaF1(BinaryReader stream,string questID)
		{
			string areaName;
			uint areaNumber;

			stream.BaseStream.Seek(28, SeekOrigin.Begin);
			areaNumber = stream.ReadUInt32();

			switch (areaNumber)
			{
				case 4:
					areaName = "Jungle";
					break;
				case 8:
					areaName = "Battleground";
					break;
				case 10:
					areaName = "Fortress";
					break;
				case 20:
					areaName = "Castle Schrade";
					break;
				case 21:
					areaName = "Forest and Hills";
					break;
				case 50:
					areaName = "Desert";
					break;
				case 61:
					areaName = "Volcano";
					break;
				case 67:
					areaName = "Swamp";
					break;
				case 89:
					areaName = "Great Arena";
					break;
				default:
					areaName = "Unknown";
					break;
			}

			switch (questID)
			{
				case "10105":
				case "1005":
					areaName = "Arena";
					break;
				default:
					break;
			}

			return areaName;
		}

		static uint GetZennyF1(BinaryReader stream, string type)
		{
			uint zenny;


			switch(type)
			{
				case "fee":
				case "Fee":
					stream.BaseStream.Seek(64, SeekOrigin.Begin);
					zenny = stream.ReadUInt32();
					break;
				case "failure":
				case "Failure":
					stream.BaseStream.Seek(72, SeekOrigin.Begin);
					zenny = stream.ReadUInt32();
					break;
				case "reward":
				case "Reward":
				default:
					stream.BaseStream.Seek(68, SeekOrigin.Begin);
					zenny = stream.ReadUInt32();
					break;
			}

			return zenny;
		}

		static uint GetStringsPointerF1(BinaryReader stream, string language)
		{
			uint stringOffsets;
			uint languagesOffset;

			stream.BaseStream.Seek(84, SeekOrigin.Begin);
			languagesOffset = stream.ReadUInt32();

			stream.BaseStream.Seek(languagesOffset, SeekOrigin.Begin);

			uint stringsEnglish = stream.ReadUInt32();
			Console.WriteLine(stringsEnglish);
			uint stringsEnglish2 = stream.ReadUInt32();
			Console.WriteLine(stringsEnglish2);
			uint stringsGerman = stream.ReadUInt32();
			Console.WriteLine(stringsGerman);
			uint stringsFrench = stream.ReadUInt32();
			Console.WriteLine(stringsFrench);
			uint stringsSpanish = stream.ReadUInt32();
			Console.WriteLine(stringsSpanish);
			uint stringsItalian = stream.ReadUInt32();
			Console.WriteLine(stringsItalian);

			switch (language)
			{
				case "-en":
					stringOffsets = stringsEnglish2;
					break;
				case "-ge":
					stringOffsets = stringsGerman;
					break;
				case "-fr":
					stringOffsets = stringsFrench;
					break;
				case "-sp":
					stringOffsets = stringsSpanish;
					break;
				case "-it":
					stringOffsets = stringsItalian;
					break;
				default:
					stringOffsets = stringsEnglish;
					break;
			}

			return stringOffsets;
		}

		static string GetQuestStringF1(BinaryReader stream, uint stringsoffset, String whichstr)
        {
			string stringReturn = "";

			stream.BaseStream.Seek(stringsoffset, SeekOrigin.Begin);
			uint TitleOffset = stream.ReadUInt32();
			uint SuccessOffset = stream.ReadUInt32();
			uint FailureOffset = stream.ReadUInt32();
			uint DescriptionOffset = stream.ReadUInt32();

			Console.WriteLine("Reading Title");
			stream.BaseStream.Seek(TitleOffset, SeekOrigin.Begin);
			string titleStr = ReadUntilNull(stream);
			Console.WriteLine("Reading Success");
			stream.BaseStream.Seek(SuccessOffset, SeekOrigin.Begin);
			string succStr = ReadUntilNull(stream);
			Console.WriteLine("Reading Failure");
			stream.BaseStream.Seek(FailureOffset, SeekOrigin.Begin);
			string failStr = ReadUntilNull(stream);
			Console.WriteLine("Reading Description");
			stream.BaseStream.Seek(DescriptionOffset, SeekOrigin.Begin);
			string descStr = ReadUntilNull(stream);

			switch (whichstr)
			{
				case "Title":
					stringReturn = titleStr;
					break;
				case "Success":
					stringReturn = succStr;
					break;
				case "Failure":
					stringReturn = failStr;
					break;
				case "Description":
					stringReturn = descStr;
					break;
				default:
					stringReturn = titleStr;
					break;
			}

			return stringReturn;
		}

		static string GetQuestIDF1(BinaryReader stream)
		{
			uint questID;
			string questIDStr;

			stream.BaseStream.Seek(90, SeekOrigin.Begin);
			questID = stream.ReadUInt16();

			questIDStr = questID.ToString();

			return questIDStr.PadLeft(5, '0');
		}

		static string GetObjectiveTypeString(uint type)
		{
			string questType;
			switch (type)
			{
				case 2:
					questType = "Slay";
					break;
				case 4:
					questType = "Deliver";
					break;
				default:
					questType = "Unknown";
					break;
			}
			return questType;
		}

		static void DumpTextF1(BinaryReader br, string outputformat, string language)
		{
			Console.WriteLine("File has been read");

			string questID = GetQuestIDF1(br);

			string areaName = GetAreaF1(br, questID);

			uint pointerSupplies = GetSupplyPointerF1(br);

			br.BaseStream.Seek(pointerSupplies, SeekOrigin.Begin);
			uint supplyType = 0;
			uint supplyNumber = 0;
			string allSupplyNames = "";

			while (br.ReadInt16() != 0)
            {
				supplyNumber++;
            }

			supplyNumber /= 2;
			supplyNumber++;
			Console.WriteLine("Total: " + supplyNumber);

			supplies[] supp = new supplies[supplyNumber];
			Console.WriteLine("Supp array created");

			br.BaseStream.Seek(pointerSupplies, SeekOrigin.Begin);

			Console.WriteLine("Creating complete item list");

			for (int n = 1; n < supplyNumber; n++)
			{
				Console.WriteLine("Reading Supply Type");
				supplyType = br.ReadUInt16();
				supp[n].itemName = supplyType;
				Console.WriteLine("Reading Supply Amount");
				supp[n].itemAmount = br.ReadUInt16();
				Console.WriteLine("Reading Supply Name");
				supp[n].itemNameStr = itemName[supplyType - 1];
				Console.WriteLine("Adding Item to list");
				allSupplyNames = $"{allSupplyNames} {supp[n].itemNameStr} x {supp[n].itemAmount} \n";
			}

			uint PointerRewards = GetRewardsPointerF1(br);

			br.BaseStream.Seek(PointerRewards, SeekOrigin.Begin);
			uint rewardType = 0;
			uint rewardNumber = 0;
			string allRewardNames = "";

			while (br.ReadInt16() != 0)
            {
				rewardNumber++;
            }

			rewardNumber--;
			rewardNumber /= 3;
			rewardNumber++;
			Console.WriteLine("Total: " + rewardNumber);

			rewards[] rew = new rewards[rewardNumber];
			Console.WriteLine("Rew array created");

			br.BaseStream.Seek(PointerRewards, SeekOrigin.Begin);

			Console.WriteLine("Creating complete item list");

			for (int n = 1; n < rewardNumber; n++)
			{
				Console.WriteLine("Reading Reward Chance");
				rew[n].itemChance = br.ReadUInt16();
				Console.WriteLine("Reading Reward Type");
				rewardType = br.ReadUInt16();
				rew[n].itemName = rewardType;
				Console.WriteLine("Reading Reward Amount");
				rew[n].itemAmount = br.ReadUInt16();
				Console.WriteLine("Reading Reward Name");
				rew[n].itemNameStr = itemName[rewardType - 1];
				Console.WriteLine("Adding Item to list");
				allRewardNames = $"{allRewardNames} {rew[n].itemNameStr} x {rew[n].itemAmount} {rew[n].itemChance}% \n";
			}

			Console.WriteLine("Grabbing Objective Pointer");
			uint pointerObjectives = GetObjectivePointerF1(br, true);

			Console.WriteLine("Reading Objective Data");
			br.BaseStream.Seek(pointerObjectives, SeekOrigin.Begin);
			uint objectiveType1 = br.ReadUInt16();
			uint objectiveTarget1 = br.ReadUInt16();
			uint objectiveAmount1 = br.ReadUInt16();
			br.BaseStream.Seek(2, SeekOrigin.Current);
			uint objectiveType2 = br.ReadUInt16();
			uint objectiveTarget2 = br.ReadUInt16();
			uint objectiveAmount2 = br.ReadUInt16();

			Console.WriteLine("Setting up Objective String");
			string objectiveString1 = GetObjectiveTypeString(objectiveType1);
			string objectivesComplete = "";

			switch (objectiveString1)
            {
                case "Slay":
					Console.WriteLine("Objective 1 Slay");
					objectivesComplete = $"{objectiveString1} {objectiveAmount1} {monsterName[objectiveTarget1 - 1]}";
					Console.WriteLine("Objective Acquired");
					break;
				case "Deliver":
					Console.WriteLine("Objective 1 Deliver");
					objectivesComplete = $"{objectiveString1} {objectiveAmount1} {itemName[objectiveTarget1 - 1]}";
					Console.WriteLine("Objective Acquired");
					break;
				default:
						break;

			}

			Console.WriteLine("Objective 1 Passed");

			if (objectiveType2 != 11)
			{
				Console.WriteLine("Setting up Objective String 2");
				string objectiveString2 = GetObjectiveTypeString(objectiveType2);

				switch (objectiveString2)
				{
					case "Slay":
						Console.WriteLine("Objective 2 Slay");
						objectivesComplete = $"{objectivesComplete}\n{objectiveString2} {objectiveAmount2} {monsterName[objectiveTarget2 - 1]}";
						break;
					case "Deliver":
						Console.WriteLine("Objective 2 Deliver");
						objectivesComplete = $"{objectivesComplete}\n{objectiveString2} {objectiveAmount2} {itemName[objectiveTarget2 - 1]}";
						break;
					default:
						break;

				}
			}

			Console.WriteLine("Acquiring Languages pointer");
			uint pointerText = GetStringsPointerF1(br, language);

			Console.WriteLine("Acquiring Title Strings");
			string questTitle = GetQuestStringF1(br, pointerText, "Title");
			Console.WriteLine("Acquiring Success Strings");
			string questSuccess = GetQuestStringF1(br, pointerText, "Success");
			Console.WriteLine("Acquiring Failure Strings");
			string questFailure = GetQuestStringF1(br, pointerText, "Failure");
			Console.WriteLine("Acquiring Description Strings");
			string questDescription = GetQuestStringF1(br, pointerText, "Description");

			Console.WriteLine("Creating Client and Simple Description");
			br.BaseStream.Seek(pointerText+12, SeekOrigin.Begin);
			uint descOffAux = br.ReadUInt32();
			br.BaseStream.Seek(descOffAux, SeekOrigin.Begin);
			string questRequestor = ReadUntilNewLine(br);
			string questDescriptionSimple = ReadUntilNull(br);

			string questText = "";

			Console.WriteLine("Reading Monetary Values");
			uint questFee = GetZennyF1(br, "Fee");
			uint questReward = GetZennyF1(br, "Reward");
			uint questFail = GetZennyF1(br, "Failure");

			switch (outputformat)
			{
				//github table syntax
				case "-gh":

					questSuccess = questSuccess.Replace("\n", "<br/>");
					questFailure = questFailure.Replace("\n", "<br/>");
					objectivesComplete = objectivesComplete.Replace("\n", "<br/>");
					questRequestor = questRequestor.Replace("Requestor: ", "");
					questDescriptionSimple = questDescriptionSimple.Replace("\n", "<br/>");
					allSupplyNames = allSupplyNames.Replace("\n", "<br/>");
					allRewardNames = allRewardNames.Replace("\n", "<br/>");
					questText = "| Parameter | Value |\n" +
								"| --- | --- |\n" +
								"| Quest ID | " + questID + " |\n" +
								"| Title | " + questTitle + " |\n" +
								"| Location | " + areaName + " |\n" +
								"| Objective | " + objectivesComplete + " |\n" +
								"| Quest Fee | " + questFee + "z |\n" +
								"| Quest Reward | " + questReward + "z |\n" +
								"| Failure Cost | " + questFail + "z |\n" +
								"| Client | " + questRequestor + " |\n" +
								"| Description | " + questDescriptionSimple + " |\n" +
								"| Success Condition | " + questSuccess + " |\n" +
								"| Failure Condition | " + questFailure + " |\n" +
								"| Supply Items | " + allSupplyNames + " |\n" +
								"| Reward Items | " + allRewardNames + " |\n" +
								"| Total Rewards | " + rewardNumber + " |";
					break;
				//plain text
				case "-pt":
				default:
					questText = $"{questID}\n{questTitle}\nLocation: {areaName}\n{objectivesComplete}\nFee: {questFee}\nReward: {questReward}\nFailure Cost: {questFail}\n{questDescription}\nSuccess Condition: {questSuccess}\nFailure Condition: {questFailure}\nSupplies:\n{allSupplyNames}\nRewards:\n{allRewardNames}\nTotal Rewards: {rewardNumber}";
					break;
			}

			try
			{
				string questNiceTitle = questTitle;
				questNiceTitle = questNiceTitle.Replace(":", "");
				questNiceTitle = questNiceTitle.Replace("?", "");

				File.WriteAllText(questID + " - " + questNiceTitle + ".txt", questText);
			}
			catch (Exception e)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("\n\nError: " + e.Message);
			}

			Console.ForegroundColor = ConsoleColor.Gray;
			return;
		}
	}
}
