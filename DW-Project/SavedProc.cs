using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DW_Project
{
    [Serializable]
    class SavedProc
    {
        public string name;
        public string proc;

        public SavedProc(string name, string proc)
        {
            this.name = name;
            this.proc = proc;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
