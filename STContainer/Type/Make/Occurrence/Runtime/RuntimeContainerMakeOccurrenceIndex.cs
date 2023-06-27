using Core;

namespace Core.Shared
{
    using System;

    public partial class STContainer
    {
        public static STContainer Runtime_MakeContainerOccurrenceIndex(SGSymbol symbol, Int32 rebase, Int32 index, Boolean backward, SGText text)
        {
            STContainer containerResult = default;

            containerResult = MakeContainerOccurrenceIndex(symbol, rebase, index, backward, text, SAPolicy.ContainerDebugPolicy);

            return containerResult;
        }
    }
}
