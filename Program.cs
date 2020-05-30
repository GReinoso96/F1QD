using System;
using System.IO;

namespace QuestDump
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("Quest Data Dumper");
			if (args == null || args.Length == 0)
			{
				return;
			}
			if (args.Length >= 1&&args.Length <= 2)
			{
				try
				{
					DumpQuest(args[0], args[1]);
				}
				catch (Exception e)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("\n\nError: " + e.Message);
				}
			}
			Console.ForegroundColor = ConsoleColor.Gray;
		}

		static void DumpQuest(string inputfile, string outputformat)
		{
			FileStream fs = new FileStream(inputfile,FileMode.Open,FileAccess.Read);
			BinaryReader br = new BinaryReader(fs);
			Console.WriteLine("File has been read");

			int offsetSeek = 84;

			br.BaseStream.Seek(offsetSeek, SeekOrigin.Begin);
			uint offsetFirst = br.ReadUInt32();
			uint unknown1 = br.ReadUInt16();
			uint questIDHex = br.ReadUInt16();
			Console.WriteLine(offsetFirst.ToString());
			Console.WriteLine(Convert.ToString(questIDHex, 16));

			//string questID = Convert.ToString(questIDHex, 16);
			string questIDInt = questIDHex.ToString();

			br.BaseStream.Seek(offsetFirst, SeekOrigin.Begin);
			uint offsetSecond = br.ReadUInt32();
			Console.WriteLine(offsetSecond.ToString());

			br.BaseStream.Seek(offsetSecond, SeekOrigin.Begin);
			uint offsetToName = br.ReadUInt32();
			uint offsetToSucCon = br.ReadUInt32();
			uint offsetToFailCon = br.ReadUInt32();
			uint offsetToDescription = br.ReadUInt32();
			Console.WriteLine(offsetToName.ToString());

			br.BaseStream.Seek(offsetToName, SeekOrigin.Begin);
			string name = (ReadUntilNull(br));
			string nicename = name.Replace(":", "_");

			br.BaseStream.Seek(offsetToSucCon, SeekOrigin.Begin);
			string sucCon = (ReadUntilNull(br));

			br.BaseStream.Seek(offsetToFailCon, SeekOrigin.Begin);
			string failCon = (ReadUntilNull(br));

			br.BaseStream.Seek(offsetToDescription, SeekOrigin.Begin);
			string requestor = (ReadUntilNewLine(br));
			br.BaseStream.Seek(offsetToDescription + requestor.Length + 1, SeekOrigin.Begin);
			string simpledescription = (ReadUntilNull(br));
			br.BaseStream.Seek(offsetToDescription, SeekOrigin.Begin);
			string description = (ReadUntilNull(br));

			string questText;

			//Map
			br.BaseStream.Seek(28, SeekOrigin.Begin);
			uint questLocale = br.ReadUInt32();
			string localeStr;
			//Fee
			br.BaseStream.Seek(64, SeekOrigin.Begin);
			uint questFee = br.ReadUInt32();
			//Reward
			uint questReward = br.ReadUInt32();
			//Failure Decrease
			uint failureCost = br.ReadUInt32();

			switch (questLocale)
			{
				case 4:
					localeStr = "Jungle";
					break;
				case 8:
					localeStr = "Battleground";
					break;
				case 10:
					localeStr = "Fortress";
					break;
				case 20:
					localeStr = "Castle Schrade";
					break;
				case 21:
					localeStr = "Forest and Hills";
					break;
				case 50:
					localeStr = "Desert";
					break;
				case 61:
					localeStr = "Volcano";
					break;
				case 67:
					localeStr = "Swamp";
					break;
				case 89:
					localeStr = "Great Arena";
					break;
				default:
					localeStr = "Unknown";
					break;
			}

			//Since Arena and Great Arena use the same identifier
			switch (questIDInt)
            {
				case "10105":
				case "1005":
					localeStr = "Arena";
					break;
				default:
					break;
            }

			switch (outputformat)
			{
				//github table syntax
				case "-gh":

					sucCon = sucCon.Replace("\n", "<br/>");
					failCon = failCon.Replace("\n", "<br/>");
					requestor = requestor.Replace("Requestor: ", "");
					simpledescription = simpledescription.Replace("\n", "<br/>");
					questText = "| Parameter | Value |\n" +
								"| --- | --- |\n" +
								"| Quest ID | " + questIDInt.PadLeft(5, '0') + " |\n" +
								"| Title | " + name + " |\n" +
								"| Location | " + localeStr + " |\n" +
								"| Quest Fee | " + questFee + "z |\n" +
								"| Quest Reward | " + questReward + "z |\n" +
								"| Failure Cost | " + failureCost + "z |\n" +
								"| Client | " + requestor + " |\n" +
								"| Description | " + simpledescription + " |\n" +
								"| Success Condition | " + sucCon + " |\n" +
								"| Failure Condition | " + failCon + " |\n";
					break;
				//plain text
				case "-pt":
				default:
					questText = $"{questIDInt.PadLeft(5, '0')}\n{name}\n{localeStr}\n{sucCon}\n{failCon}\n{description}\n{questFee}\n{questReward}\n{failureCost}";
					break;
			}

			try
			{
				File.WriteAllText(questIDInt.PadLeft(5, '0') + " - " + nicename + ".txt", questText);
			}
			catch (Exception e)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("\n\nError: " + e.Message);
			}

			Console.ForegroundColor = ConsoleColor.Gray;
			return;
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
	}
}
