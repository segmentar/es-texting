using Core;

namespace Core.Shared
{
    using System;

    public partial class STContainer
    {
        public static STContainer MakeContainerVarianceIndexerIndexer(SGDelimiter delimiter, Int32 rebase, Int32 indexer_START, Int32 indexer_END, Boolean backward, SGText text, Boolean debug)
        {
            STContainer containerResult = default;

            var container = new STContainerVarianceSequenceIndexerIndexer(delimiter, rebase, indexer_START, indexer_END, backward, text, debug).Container;

            ArrayList.Add(container);

            containerResult = container;

            return containerResult;
        }
    }
}
