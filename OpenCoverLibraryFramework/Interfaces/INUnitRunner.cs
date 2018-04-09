using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCoverLibrary.Interfaces
{
    public interface INUnitRunner : IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dllPath"></param>
        /// <param name="coverageXmlFileName">With XML extension</param>
        void RunDLL(string dllPath, string coverageXmlFileName);
    }
}
