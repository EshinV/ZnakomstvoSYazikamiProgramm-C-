﻿// //vid 1
// void Method1()
// {
//  Console.WriteLine("Author ...");
// }
// Method1();


// //Vid 2
// void Method2(string msg)
// {
//  Console.WriteLine(msg);
// }
// Method2("Text messege");

// void Method21(string msg, int count)
// {
//     int i=0;
//     while (i<count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21("Text messege",4); // lobo // Method21(msg:"Text messege", count:4) libo // Method21(count:4,msg:"Text messege") 

// //vid 3

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);

// //vid 4
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
//     while (i<count)
//     {
//         result= result+text;
//         i++;
//     }
//     return result;
// }

// string res = Method4 (10, "qwe");
// Console.WriteLine(res);


//vid 5
string Method4(int count, string text)
{
    
    string result = String.Empty;
    for (int i = 0;i<count;i++)
    {
        result= result+text;
    }
    return result;
}

string res = Method4 (10, "qwe");
Console.WriteLine(res);


for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}