﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ammy.BackendCommon
{
    public interface IAmmyBackend
    {
        Type[] ProvideTypes();
        void CompilationFinished(CompilationResult result);

        event EventHandler<CompilationRequest> CompilationRequested;
    }
}