using System;
using System.IO;
using System.Windows.Forms;

namespace PersonelOtomasyon
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            string desktopShortcut = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "PersonelOtomasyon.lnk");
            if (!File.Exists(desktopShortcut))
            {
                ShortcutHelper.CreateShortcut();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
