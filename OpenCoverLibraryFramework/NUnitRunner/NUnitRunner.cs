using OpenCoverLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace OpenCoverLibrary.NUnitRunner
{
    public class NUnitRunner : INUnitRunner
    {
        private readonly ICmdRunner runner;
        private readonly string OpenCoverExecFullName, NUnit3ConsoleExecFullName;

        public NUnitRunner(string OpenCoverExecFullName, string NUnit3ConsoleExecFullName)
        {
            this.OpenCoverExecFullName = OpenCoverExecFullName;
            this.NUnit3ConsoleExecFullName = NUnit3ConsoleExecFullName;

            runner = new CmdRunner.CmdRunner(OpenCoverExecFullName);
        }

        public void Dispose()
        {
            runner.Dispose();
        }

        public void RunDLL(string dllFullName, string coverageXmlFileName)
        {
            string args = String.Join(" ",
                "-target:" + this.NUnit3ConsoleExecFullName,
                "-targetargs:" + dllFullName,
                "-output:" + coverageXmlFileName,
                "-register:user"
                );

            runner.Run(args);

            while (!runner.ExposeProcess().HasExited)
                Thread.Sleep(300);
        }
    }
}
