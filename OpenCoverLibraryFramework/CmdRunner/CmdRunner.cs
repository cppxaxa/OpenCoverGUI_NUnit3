using OpenCoverLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCoverLibrary.CmdRunner
{
    public class CmdRunner : ICmdRunner
    {
        private readonly string executableFullName;
        private readonly Process p;
        private readonly ProcessStartInfo info;
        private Task<string> outputTextTask, errorTextTask;

        public CmdRunner(string executableFullName)
        {
            p = new Process();
            info = new ProcessStartInfo();

            info.FileName = executableFullName;

            this.executableFullName = executableFullName;
        }

        public void Dispose()
        {
            if (!p.HasExited)
            {
                p.Close();
                p.Kill();
            }
        }

        private void ReadAllStreamReaders()
        {
            outputTextTask = this.GetOutputStream().ReadToEndAsync();
            errorTextTask = this.GetErrorStream().ReadToEndAsync();

            Task.WaitAll(outputTextTask, errorTextTask);
        }

        public string GetAllErrorText()
        {
            if (!p.HasExited)
                this.ReadAllStreamReaders();

            return errorTextTask.Result;
        }

        public string GetAllOutputText()
        {
            if (!p.HasExited)
                this.ReadAllStreamReaders();

            return outputTextTask.Result;
        }

        public StreamReader GetErrorStream()
        {
            return p.StandardError;
        }

        public StreamWriter GetInputStream()
        {
            return p.StandardInput;
        }

        public StreamReader GetOutputStream()
        {
            return p.StandardOutput;
        }

        public void Run(string args)
        {
            info.Arguments = args;

            p.StartInfo = info;
            p.Start();
        }

        public Process ExposeProcess()
        {
            return p;
        }
    }
}
