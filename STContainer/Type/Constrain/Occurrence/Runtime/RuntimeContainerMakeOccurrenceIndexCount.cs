using Core;

namespace Core.Shared
{
    using System;

    public partial class STContainer
    {
        public static STContainer Runtime_MakeTokenOccurrenceIndexCount(SGSymbol symbol, Int32 rebase, Int32 index, Int32 count, Boolean backward, SGText text)
        {
            STContainer containerResult = default;

            containerResult = MakeContainerOccurrenceIndexCount(symbol, rebase, index, count, backward, text, SAPolicy.ContainerDebugPolicy);

            return containerResult;
        }
    }
}
