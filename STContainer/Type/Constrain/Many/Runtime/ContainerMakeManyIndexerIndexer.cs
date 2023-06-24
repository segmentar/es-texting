using Core;

namespace Core.Shared
{
    using System;

    public partial class STContainer
    {
        public static STContainer Runtime_MakeContainerManyIndexerIndexer(Int32 rebase, Int32 indexer_START, Int32 indexer_END, Boolean backward, SGText text, SGDelimiter delimiter)
        {
            STContainer containerResult = default;

            containerResult = MakeContainerManyIndexerIndexer(rebase, indexer_START, indexer_END, backward, text, delimiter, SAPolicy.ContainerDebugPolicy);

            return containerResult;
        }
    }
}
