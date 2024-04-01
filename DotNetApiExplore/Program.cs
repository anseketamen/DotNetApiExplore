using System.Xml;
using System.Xml.Linq;
using System.Text.Json;

var sourcePath = "dotnet-api-docs\\xml";
// クラス名とメンバ名のペア
var output = new Dictionary<string, List<string>>();
// クラス名とメンバ名（publicとかついたやつ）のペア
var friendlyOutput = new Dictionary<string, List<string>>();
var count = 0;

foreach (var file in Directory.GetFiles(sourcePath, "*.xml", new EnumerationOptions() { RecurseSubdirectories = true }))
{
    using var stream = File.OpenRead(file);
    var root = XElement.Load(stream);

    if (root.Name != "Type") continue;

    foreach (var member in root.Element("Members")?.Elements("Member") ?? [])
    {
        var asmVersions = (member.Element("AssemblyInfo")?.Elements("AssemblyVersion") ?? []).Select(x => x.Value).ToHashSet();
        // たぶんきっとおそらく
        // 8.0.0.0と9.0.0.0だけなら .NET 8 以降のAPIのはず…
        // なんかVisualBasicで10.0.0.0みたいなのが出てきたけど気にしないことにする
        if (asmVersions.Count == 2 && asmVersions.Contains("8.0.0.0") && asmVersions.Contains("9.0.0.0"))
        {
            var key = root.Attribute("FullName")?.Value;
            if (key == null) continue;

            var value = member.Attribute("MemberName")?.Value.Replace("&lt;", "<").Replace("&gt;", ">");
            if (value == null) continue;

            var friendlyValue = member.Elements("MemberSignature")
                .FirstOrDefault(x => x.Attribute("Language")
                ?.Value == "C#")
                ?.Attribute("Value")
                ?.Value
                .Replace("&lt;", "<")
                .Replace("&gt;", ">");

            if (friendlyValue == null) continue;

            if (!output.ContainsKey(key))
            {
                output.Add(key, []);
            }
            if (!friendlyOutput.ContainsKey(key))
            {
                friendlyOutput.Add(key, []);
            }
            output[key].Add(value);
            friendlyOutput[key].Add(friendlyValue);
        }
    }
    count++;
    Console.Write($"\rAnalyzed: {count}");
}

// JSON出力
{
    var json = JsonSerializer.Serialize(output, new JsonSerializerOptions()
    {
        WriteIndented = true,
        Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
    });
    File.WriteAllText("output.json", json);
}

// markdown出力 1
{
    using var markdownStream = File.Create("output.md");
    using var markdownWriter = new StreamWriter(markdownStream);
    foreach (var item in output)
    {
        markdownWriter.WriteLine($"* `{item.Key}`");
        // オーバーロードと演算子オーバーロードは抜く
        foreach (var item2 in item.Value.Distinct().Where(x => x != ".ctor" && !x.StartsWith("op_")))
        {
            markdownWriter.WriteLine($"  * {item2}");
        }
    }
}

// markdown出力 2
{
    using var markdownStream = File.Create("output-friendly.md");
    using var markdownWriter = new StreamWriter(markdownStream);
    foreach (var item in friendlyOutput)
    {
        markdownWriter.WriteLine($"* {item.Key}");
        foreach (var item2 in item.Value)
        {
            markdownWriter.WriteLine($"  * {item2}");
        }
    }
}

Console.WriteLine();
Console.WriteLine("finished");

