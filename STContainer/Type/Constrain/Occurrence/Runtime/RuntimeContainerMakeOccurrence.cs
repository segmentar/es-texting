using Core;

namespace Core.Shared
{
    using System;

    public partial class STContainer
    {
        public static STContainer Runtime_MakeContainerOccurrence(SGSymbol symbol, Int32 rebase, Boolean backward, SGText text)
        {
            STContainer containerResult = default;

            containerResult = MakeContainerOccurrence(symbol, rebase, backward, text, SAPolicy.ContainerDebugPolicy);

            return containerResult;
        }
    }
}
