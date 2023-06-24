using Core;

namespace Core.Shared
{
    using System;

    public partial class STContainer
    {
        public static STContainer Runtime_MakeTokenOccurrenceIndexerIndexer(SGSymbol symbol, Int32 rebase, Int32 indexer_START, Int32 indexer_END, Boolean backward, SGText text)
        {
            STContainer containerResult = default;

            containerResult = MakeContainerOccurrenceIndexerIndexer(symbol, rebase, indexer_START, indexer_END, backward, text, SAPolicy.ContainerDebugPolicy);

            return containerResult;
        }
    }
}
