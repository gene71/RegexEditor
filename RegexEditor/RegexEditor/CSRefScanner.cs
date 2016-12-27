using CR.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexEditor
{
    public class CSRefScanner
    {
        public static List<string> ProjectReferences(string dirPath)
        {
            List<string> CSProjReferences = new List<string>();
            try
            {
                FileUtil fu = new FileUtil();
                foreach(var f in fu.GetFiles(dirPath))
                {
                    FileInfo fi = new FileInfo(f);
                    if (fi.Extension == ".csproj")
                    {
                        //list the project path
                        if (!CSProjReferences.Contains(f))
                        {
                            CSProjReferences.Add("Project file: " + f);
                        }

                        MatchCollection mc = 
                            Regex.Matches(File.ReadAllText(f), "<Reference Include=[\"A-z0-9.]+");
                        foreach(var s in mc)
                        {
                            string[] sa = s.ToString().Split('"');
                            if(sa.Length > 2)
                            {
                                if(!CSProjReferences.Contains(sa[1]))
                                {
                                    CSProjReferences.Add(sa[1]);
                                }
                            }
                        }

                    }

                }
                return CSProjReferences;
            }
            catch (Exception ex)
            {
                //TODO: create custom for this
                throw new Exception(ex.Message);
            }

           
            return null;
        }

    }
}
