public class OldPhonePadDecoder
{
    private static readonly Dictionary<char, string> KeyMap = new()
    {
        { '2', "ABC" }, { '3', "DEF" }, { '4', "GHI" },
        { '5', "JKL" }, { '6', "MNO" }, { '7', "PQRS" },
        { '8', "TUV" }, { '9', "WXYZ" }, { '0', " " }
    };

    public string Decode(string input)
    {
        if (string.IsNullOrEmpty(input))
            return string.Empty;

        var result = new List<char>();

        char current = '\0';
        int count = 0;

        foreach (var c in input)
        {
            if (c == '#')
                break;

            if (c == ' ')
            {
                AddCharacter();
                continue;
            }

            if (c == '*')
            {
                AddCharacter();
                if (result.Count > 0)
                    result.RemoveAt(result.Count - 1);
                continue;
            }

            if (c == current)
            {
                count++;
            }
            else
            {
                AddCharacter();
                current = c;
                count = 1;
            }
        }

        AddCharacter();

        return new string(result.ToArray());

        void AddCharacter()
        {
            if (count == 0) return;

            if (!KeyMap.ContainsKey(current))
            {
                count = 0;
                return;
            }

            var letters = KeyMap[current];
            int index = (count - 1) % letters.Length;

            result.Add(letters[index]);
            count = 0;
        }
    }
}
