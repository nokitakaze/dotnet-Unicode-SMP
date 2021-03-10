using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RangeGenerator
{
    internal static class Program
    {
        private static readonly Regex GoodLine = new("(.+?)\\s+\\(([0-9a-fA-F]+)[–-]([0-9a-fA-F]+)\\)");

        private static async Task Main()
        {
            var list = await File.ReadAllLinesAsync("wikipedia-list.txt");
            var fullTextInner = list
                .Select(t =>
                {
                    var m = GoodLine.Match(t);
                    if (!m.Success)
                    {
                        return null;
                    }

                    var name = m
                        .Groups[1]
                        .Value
                        .Replace("-", "_")
                        .Split(' ')
                        .Select(nm =>
                        {
                            var c1 = nm.Substring(0, 1);
                            var c2 = nm.Substring(1);

                            return c1.ToUpperInvariant() + c2.ToLowerInvariant();
                        })
                        .Aggregate((a, b) => a + b);
                    var firstIndex = int.Parse(m.Groups[2].Value, NumberStyles.HexNumber);
                    var firstIndexS = firstIndex.ToString("x6");
                    var lastIndex = int.Parse(m.Groups[3].Value, NumberStyles.HexNumber);
                    var lastIndexS = lastIndex.ToString("x6");

                    return string.Format(
                        "        public static UnicodeRangeExtended {0} =>\n" +
                        "            {0}_Ref ?? CreateRange(ref {0}_Ref, 0x{1}_{2}, 0x{3}_{4});\n" +
                        "\n" +
                        "        private static UnicodeRangeExtended? {0}_Ref;",
                        name,
                        firstIndexS.Substring(0, 2),
                        firstIndexS.Substring(2),
                        lastIndexS.Substring(0, 2),
                        lastIndexS.Substring(2)
                    );
                })
                .Where(x => x != null)
                .Aggregate((a, b) => a + "\n\n" + b);

            var fullText =
                "namespace UnicodeSMP\n" +
                "{\n" +
                "   public static partial class UnicodeRanges\n" +
                "   {\n" +
                fullTextInner +
                "\n" +
                "   }\n" +
                "}";

            await File.WriteAllTextAsync("UnicodeRanges.cs", fullText);
        }
    }
}