using System;
using System.Diagnostics;

//1
Process process = new Process();
process.StartInfo.FileName = "Notepad.exe";
process.Start();
process.WaitForExit();
Console.WriteLine("Hello");
Console.WriteLine("Quit" + process.ExitCode);


//2
Process process1 = new Process();
process1.StartInfo.FileName = "Notepad.exe";
process1.Start();
Console.WriteLine("Wait(0) or Finish(1)");
string Choice = Console.ReadLine();

if (Choice == "0")
{
    process1.WaitForExit();
    Console.WriteLine("Quit" + process1.ExitCode);
}
else if (Choice == "1")
{
    process1.Kill();
    Console.WriteLine("Finish" + process1.ExitCode);
}
else
{
    Console.WriteLine("Incorrect");
}