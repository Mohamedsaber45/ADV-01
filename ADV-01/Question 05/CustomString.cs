public class CustomString
{
    public string Value { get; set; }

    public CustomString(string value)
    {
        Value = value;
    }

    public char GetFirstNonRepeatedCharacter()
    {
        if (string.IsNullOrEmpty(Value))
            throw new Exception("Must Be Enter Any String!!");

        Dictionary<char,int> keyValuePairs = new Dictionary<char,int>();

        foreach(var c in Value)
        {
            if(keyValuePairs.ContainsKey(c))
                keyValuePairs[c]++;
            else
                keyValuePairs[c] = 1;
        }

        foreach(var c in Value)
        {
            if (keyValuePairs[c] == 1)
                return c;
        }
        throw new InvalidOperationException("No Non-Repeat Characters are Found!!");
    }
}