using System;
using System.Text;
using System.Numerics;
using System.IO;
using Newtonsoft.Json;

namespace LeagueData
{
    class Program
    {
        static void Main(string[] args)
        {
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings { Formatting = Formatting.Indented };

            var outPath = "<path>\\GameServerRenewed\\LeagueSandbox.GameServer.Utils\\Data\\Characters";
            foreach (var d in Directory.EnumerateDirectories("<path>\\DATA\\Characters"))
            {
                var name = d.Substring(d.LastIndexOf("\\") + 1);
                var iniPath = $"{d}/{name}.inibin";
                var charDir = Path.Combine(outPath, name);
                if (!Directory.Exists(charDir))
                    Directory.CreateDirectory(charDir);

                if (File.Exists(iniPath))
                {
                    using var file = new BinaryReader(File.OpenRead(iniPath));
                    var ini = new IniBin(file);
                    var chardata = new CharData(name, ini);
                    var json = JsonConvert.SerializeObject(chardata);
                    File.WriteAllText(Path.Combine(charDir, $"{name}.json"), json);

                    Console.WriteLine($"Read: {name}");
                }

                var spellsPath = Path.Combine(d, "Spells");
                if (!Directory.Exists(spellsPath))
                    continue;

                var spells = Directory.EnumerateFiles(spellsPath, "*.inibin");
                foreach (var spellPath in spells)
                {
                    using var file = new BinaryReader(File.OpenRead(spellPath));
                    var ini = new IniBin(file);
                    var spellName = Path.GetFileNameWithoutExtension(spellPath);
                    var spellData = new SpellData(spellName, ini);
                    var json = JsonConvert.SerializeObject(spellData);
                    var spellsDir = Path.Combine(charDir, "Spells");
                    if (!Directory.Exists(spellsDir))
                        Directory.CreateDirectory(spellsDir);

                    File.WriteAllText(Path.Combine(spellsDir, $"{spellName}.json"), json);

                    Console.WriteLine($"Read: {name}/{spellName}");
                }
            }

            outPath = "<path>\\GameServerRenewed\\LeagueSandbox.GameServer.Utils\\Data\\Spells";
            foreach (var d in Directory.EnumerateFiles("<path>\\DATA\\Spells", "*.inibin"))
            {
                var name = Path.GetFileNameWithoutExtension(d);
                using var file = new BinaryReader(File.OpenRead(d));
                var ini = new IniBin(file);
                var chardata = new SpellData(name, ini);
                var json = JsonConvert.SerializeObject(chardata);
                File.WriteAllText(Path.Combine(outPath, $"{name}.json"), json);

                Console.WriteLine($"Read: {name}");
            }
        }
    }
}
