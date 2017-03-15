using RegexEditor.AppCache;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// 
/// </summary>
namespace RegexEditor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //AppData.rp = new RegexProject();
            
            //check to see if there is a default project
            //if(File.Exists("Default.rp"))
            //{
            //    //load default
            //    RegexProject rp =
            //        RegexSerializer.LoadRegexProject("Default.rp");
            //    foreach (var fc in rp.RegexForms)
            //    {
            //        Application.EnableVisualStyles();
            //        Application.SetCompatibleTextRenderingDefault(false);
            //        Application.Run(new RegexEditorForm());
            //    }
            //}
            //else
            //{
            //    //TODO: load last saved .rp
            //    Application.EnableVisualStyles();
            //    Application.SetCompatibleTextRenderingDefault(false);
            //    Application.Run(new RegexEditorForm());
            //}

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RegexEditorForm());

        }
    }
}
