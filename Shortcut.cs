using System;
using System.IO;
using IWshRuntimeLibrary;

namespace PersonelOtomasyon
{
    public class ShortcutHelper
    {
        public static void CreateShortcut()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string shortcutPath = Path.Combine(desktopPath, "PersonelOtomasyon.lnk");

            if (System.IO.File.Exists(shortcutPath))
            {
                System.Windows.Forms.MessageBox.Show("Kısayol zaten mevcut.");
                return;
            }

            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutPath);
            shortcut.Description = "Personel Otomasyon Sistemi";
            shortcut.TargetPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            shortcut.WorkingDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            shortcut.Save();

            System.Windows.Forms.MessageBox.Show("Masaüstü kısayolu oluşturuldu.");
        }
    }
}
