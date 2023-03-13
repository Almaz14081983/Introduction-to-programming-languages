
Console.Clear();

string[] existingArray = new string[9] {"14", ".", "03", ".", "23", "при", "-", "вет", "пока"};
string[] newArray = new string[existingArray.Length];

int count = 0;
for (int i = 0; i < existingArray.Length; i++)
{
if(existingArray[i].Length <= 3)
    {
    newArray[count] = existingArray[i];
    count++;
    }
}

for (int i = 0; i < newArray.Length; i++)
{
    Console.Write($"{newArray[i]} ");
}


