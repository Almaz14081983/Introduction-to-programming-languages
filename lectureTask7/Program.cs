string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежеле бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?2";
// string s =   q w e r t y
//              0 1 2 3 4 5
// s[3] = r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    
    int length = text.Length;

    for (int i = 0; i < length;  i++)
    {
        if(text[i]== oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine();
Console.WriteLine(newText);

Console.WriteLine();

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);

Console.WriteLine();

string newestText = Replace(newText, 'с', 'С');
Console.WriteLine(newestText);
Console.WriteLine();