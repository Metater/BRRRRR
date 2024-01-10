using BRRRRR;
using System.Drawing;
using System.Diagnostics;

Console.WriteLine("Hello, World!");

Win32.GetCursorPos(out Point pos);
Console.WriteLine(pos);

Thread.Sleep(4000);

Process[] processlist = Process.GetProcesses();

IntPtr handle = IntPtr.Zero;

foreach (Process process in processlist)
{
    if (!String.IsNullOrEmpty(process.MainWindowTitle))
    {
        Console.WriteLine("Process: {0} ID: {1} Window title: {2}", process.ProcessName, process.Id, process.MainWindowTitle);

        //if (process.MainWindowTitle == "Minecraft 1.12.2") handle = process.MainWindowHandle;
        if (process.Id == 17328) handle = process.MainWindowHandle;
    }
}

for (int i = 0; i < 1000; i++) ClickOnPointTool.ClickOnPoint(handle, pos);