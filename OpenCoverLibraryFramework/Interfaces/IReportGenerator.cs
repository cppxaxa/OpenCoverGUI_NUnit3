using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCoverLibrary.Interfaces
{
    public interface IReportGenerator : IDisposable
    {
        void Generate(string coverageXmlPath, string sourcePath);
    }
}
