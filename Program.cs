// See https://aka.ms/new-console-template for more information

Console.WriteLine(Solution("din"));
Console.WriteLine(Solution("recedE"));
Console.WriteLine(Solution("Success"));
Console.WriteLine(Solution("(( @"));


static string Solution(string text)
{

    string[] newString = new string[text.Length];

    var textArray = text.ToArray();
    for (int i = 0; i < textArray.Length; i++)
    {
        var duplicatedChars = textArray.ToList().FindAll(x => String.Equals(textArray[i].ToString(), x.ToString(), StringComparison.OrdinalIgnoreCase));
        if (duplicatedChars.Count < 2)
            newString[i] = "(";
        else
            newString[i] = ")";

    }
    return String.Join("", newString);

}