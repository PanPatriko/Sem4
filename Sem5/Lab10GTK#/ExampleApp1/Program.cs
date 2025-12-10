using System;
using Gtk;

namespace ExampleApp1
{
    /// <summary> A program. </summary>
    static class Program
    {
        /// <summary> The main entry point for the application. </summary>
        [STAThread]
        static void Main()
        {
            Application.Init();
            MainWindow win = MainWindow.Create();
            win.Title = "Lab10GTK#";
            win.Show();
            Application.Run();
        }
    }
}
