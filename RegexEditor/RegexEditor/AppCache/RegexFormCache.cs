using CR.Core;
using CR.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexEditor.AppCache
{
    [Serializable]
    public class RegexFormCache
    {
        
        public CRScanner CRS { get; set; }
        public CRLogger CRL { get; set; }
        public string WorkingScanDir { get; set; }
        public string FileSavePath { get; set; }
    }
}
