using CR.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CR.Core;
using CR.Util;
using System.IO;
using System.Text.RegularExpressions;

namespace RegexEditor
{
    public class ScanEngine : CRScanEngine
    {
        List<CRVul> Vuls;

        public ScanEngine()
        {
            Vuls = new List<CRVul>();
        }

        public List<CRVul> GetVuls(string dirPath, CRScanner scanner)
        {
            
            try
            {
                FileUtil fu = new FileUtil();
                foreach (var f in fu.GetFiles(dirPath))
                {
                    FileInfo fi = new FileInfo(f);
                    foreach (var ex in scanner.FileExtensions)
                    {
                        if (fi.Extension == ex)
                        {
                            //do scan
                            getVuls(f, scanner);
                        }
                    }
                }

                return cleanVuls(Vuls);
            }
            catch (Exception ex)
            {
                //TODO: add custom exception
                throw new Exception(ex.Message);
            }

                                   
        }

        private void getVuls(string filePath, CRScanner crs)
        {
            
            //TODO: add try catch
            foreach(var p in crs.Patterns)
            {
                var lines = File.ReadAllLines(filePath);
                for (int i = 0; i < lines.Length; i++)
                {
                    var matches = Regex.Matches(lines[i], p);
                    if (matches.Count > 0)
                    {
                        //found match make vul
                        CRVul crvul = new CRVul();
                        crvul.CRVID = crs.CRVID;
                        crvul.Line = lines[i].ToString();
                        crvul.LineNumber = i + 1;//account for 0
                        crvul.Path = filePath;
                        //TODO: clean vuls
                        Vuls.Add(crvul);
                    }

                }

            }
           
        }

        /// <summary>
        /// cleanVuls removes duplicate vulnerability objects from list
        /// </summary>
        /// <param name="vuls"></param>
        /// <returns>List<CRVUL></CRVUL></returns>
        /// <exception cref="Exceptions.CRScanEngine">CRRegMatcherException</exception>
        private List<CRVul> cleanVuls(List<CRVul> vuls)
        {
            List<CRVul> cleanVuls = new List<CRVul>();
            try
            {
                foreach (var v in vuls)
                {
                    bool found = false;
                    foreach (var vul in cleanVuls)
                    {
                        if (v.Line == vul.Line)
                        {
                            found = true;
                        }

                    }//end inner loop


                    if (found)
                    {
                        //dont add
                    }
                    else
                    {
                        //add
                        cleanVuls.Add(v);
                    }

                }//end main loop
                //cleanVuls = vuls.Distinct<CRVul>().ToList();
            }
            catch (Exception ex)
            {
                //throw new Exceptions.CRScanEngineException(
                //                "Error cleaning vuls..." + ex.Message);
            }

            return cleanVuls;
        }
    }
}
