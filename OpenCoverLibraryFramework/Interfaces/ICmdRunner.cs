using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCoverLibrary.Interfaces
{
    /// <summary>
    /// Purpose: We want it to run external application for us
    /// </summary>
    public interface ICmdRunner : IDisposable
    {
        void Run(string arguments);
        StreamWriter GetInputStream();
        StreamReader GetOutputStream();
        StreamReader GetErrorStream();
        string GetAllOutputText();
        string GetAllErrorText();
        Process ExposeProcess();
    }
}
