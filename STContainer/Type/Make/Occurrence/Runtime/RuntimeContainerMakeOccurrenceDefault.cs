using Core;

namespace Core.Shared
{
    using System;

    public partial class STContainer
    {
        public static STContainer Runtime_MakeContainerOccurrenceDefault(SGSymbol symbol, Int32 rebase, Boolean backward, SGText text)
        {
            STContainer containerResult = default;

            containerResult = MakeContainerOccurrenceDefault(symbol, rebase, backward, text, SAPolicy.ContainerDebugPolicy);

            return containerResult;
        }
    }
}
