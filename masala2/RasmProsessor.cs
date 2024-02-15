using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masala2
{
    public class RasmProsessor
    {
        public delegate void RasmFilterHandler(Rasm rasm);
        public void Jarayon(string path, RasmFilterHandler filterHandler)
        {
            var rasm = Rasm.Load(path);
            filterHandler(rasm);
        }
    }
}
