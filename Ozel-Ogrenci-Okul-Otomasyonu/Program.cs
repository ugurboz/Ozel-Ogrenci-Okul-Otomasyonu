using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ozel_Ogrenci_Okul_Otomasyonu
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // DevExpress Skin Ayarları
            // DevExpress.UserSkins.BonusSkins.Register(); // Reference not found in project
            DevExpress.Skins.SkinManager.EnableFormSkins();

            // Modern bir tema seçiyoruz (The Bezier veya Office 2019 Colorful)
            // Eğer "The Bezier" yoksa "Office 2019 Colorful" kullanır.
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2019 Colorful");

            // Daha akıcı grafikler için (Destekleniyorsa)
            // WindowsFormsSettings.ForceDirectXPaint(); 

            Application.Run(new FrmGiris());
        }
    }
}
