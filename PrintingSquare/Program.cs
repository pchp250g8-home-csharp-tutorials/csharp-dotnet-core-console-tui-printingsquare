// See https://aka.ms/new-console-template for more information
var strLine = "Hello,World!!! Printing Square!!!";
Console.Clear();
Console.CursorVisible = false;
for(int i = 0; i < strLine.Length; i++)
{
    Console.SetCursorPosition(10 + i, 10);
    Console.Write(strLine[i]+"\u2588");
    Thread.Sleep(500);
}
Console.SetCursorPosition(10, 10);
Console.Write(strLine+" ");
Console.ReadKey();

