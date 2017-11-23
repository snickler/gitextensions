using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using GitUIPluginInterfaces;

namespace GitUI.AutoCompletion
{
    public interface IAutoCompleteProvider
    {
        Task<IEnumerable<AutoCompleteWord>> GetAutoCompleteWords (IGitModuleState module, CancellationTokenSource cts);
    }
}