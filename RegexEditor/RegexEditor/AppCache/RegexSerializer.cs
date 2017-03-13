using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace RegexEditor.AppCache
{
    public static class RegexSerializer
    {
        public static void Save(string filename, object crob)
        {
            try
            {
                using (var writer = new StreamWriter(filename))
                {
                    var serializer = new XmlSerializer(crob.GetType());
                    serializer.Serialize(writer, crob);
                    writer.Flush();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error"
                   , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static RegexProject LoadRegexProject(string filepath)
        {
            try
            {
                using (FileStream fs = new FileStream(filepath, FileMode.Open)) //double check that...
                {
                    XmlSerializer _xSer = new XmlSerializer(typeof(RegexProject));

                    return (RegexProject)_xSer.Deserialize(fs);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error"
                   , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }


        }
    }

   


}
