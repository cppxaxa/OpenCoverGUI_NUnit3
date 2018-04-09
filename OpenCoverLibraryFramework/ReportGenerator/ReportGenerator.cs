using OpenCoverLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OpenCoverLibrary.ReportGenerator
{
    public class ReportGenerator : IReportGenerator
    {
        private readonly string ReportGeneratorExecFullPath;
        private readonly ICmdRunner runner;

        public ReportGenerator(string ReportGeneratorExecFullPath)
        {
            this.ReportGeneratorExecFullPath = ReportGeneratorExecFullPath;
            runner = new CmdRunner.CmdRunner(ReportGeneratorExecFullPath);
        }

        public void Dispose()
        {
            runner.Dispose();
        }

        public void Generate(string coverageXmlPath, string sourceDirectory)
        {
            string args = String.Join(
                " ",
                "-reports:" + coverageXmlPath,
                "-targetdir:.",
                "-sourcedirs:" + sourceDirectory
                );

            runner.Run(args);

            while (!runner.ExposeProcess().HasExited)
                Thread.Sleep(300);
        }
    }
}
