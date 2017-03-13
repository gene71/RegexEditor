using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexEditor.AppCache
{
    [Serializable]
    public class RegexProject
    {
        public string RegexProjName { get; set; }
        public List<RegexFormCache> RegexForms { get; set; }
    }
}
