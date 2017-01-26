using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ammy.BackendCommon
{
    public interface IAmmyBackend
    {
        /// <summary>
        /// This property will be initialized in Host.Initialize() call
        /// </summary>
        IAmmyCompiler Compiler { get; set; }

        string[] DefaultNamespaces { get; }
        bool NeedRuntimeUpdate { get; }
        PlatformTypeNames PlatformTypeNames { get; }

        Type[] ProvideTypes();
    }
}
