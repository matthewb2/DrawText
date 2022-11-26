using System;
using ConsoleDraw;

namespace DrawTextEx
{
    class Program
    {
        static void Main(string[] args)
        {
            //Setup
            WindowManager.UpdateWindow(100, 40);
            WindowManager.UpdateWindow(100, 40);

            WindowManager.SetWindowTitle("TEXT");

            //Start Program
            new MainWindow();
        }
    }
}
