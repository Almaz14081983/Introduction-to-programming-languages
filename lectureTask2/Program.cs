﻿//void Method2(string msg)
//{
//    Console.WriteLine(msg);
//}
//Method2("Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i<count)
    {
        Console.WriteLine(msg);
        i++;
    }
    
}
Method21(msg:"Текст", count: 4);
