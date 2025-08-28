using System;
using System.Windows.Forms;

namespace MultiFormTemplate_Minimal
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize(); // provided by WinForms source generator
            Application.Run(new Form1());
        }
    }
}
