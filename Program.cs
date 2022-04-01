using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextEditor_Core;

namespace TextEditor
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm form = new MainForm();
            MessageService sevice = new MessageService();
            FileManager fileManager = new FileManager();

            Presentor presentor = new Presentor(form, fileManager, sevice);

            Application.Run(form);
        }
    }
}
