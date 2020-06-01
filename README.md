# F1QD
A C# tool that dumps text and values from Monster Hunter Freedom quests.
Targets .NET Core 3.1

## Usage
Run in command line.
```
questdump inputfile format language

Formats:
-gh = Markdown Table for Github
-pt = Plain text output

Languages:
-en = English
-fr = French
-ge = German
-it = Italian
-sp = Spanish
```

### Example Output
| Parameter | Value |
| --- | --- |
| Quest ID | 10001 |
| Title | Basics: Finding Raw Meat |
| Location | Forest and Hills |
| Objective | Deliver 2 Raw Meat |
| Quest Fee | 0z |
| Quest Reward | 100z |
| Failure Cost | 40z |
| Client | Village Chief |
| Description | First, a little trial. Hunt<br/>down an Aptonoth and harvest<br/>the meat. Deliver 2 pieces<br/>of Raw Meat and you'll<br/>complete your first quest! |
| Success Condition | Deliver 2 pcs Raw Meat |
| Failure Condition | Reward Zero<br/>Time Over |
| Supply Items |  Map x 1 <br/> Mini Whetstone x 2 <br/> Ration x 2 <br/> First-aid Med. x 3 <br/> Normal S Lv1 x 1 <br/> Binoculars x 1 <br/> |
| Reward Items |  Sm Monster Bone x 1 4% <br/> Cricket x 1 25% <br/> Cricket x 1 25% <br/> Mystery Bone x 1 25% <br/> Mystery Bone x 1 20% <br/> Sm Monster Bone x 2 1% <br/> |

## Roadmap
* Mediawiki table output.
* Figure out more quest data.
* Remove Client/Description splitter.
* Figure out reward amounts.
* Quest Timers.
* Gathering Points.

## License
GPL 3.0
