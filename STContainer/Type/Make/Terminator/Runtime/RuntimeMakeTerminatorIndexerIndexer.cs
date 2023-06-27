using Core;

namespace Core.Shared
{
    using System;

    public partial class STContainer
    {
        public static STContainer Runtime_MakeContainerTerminatorIndexerIndexer(SGDelimiter delimiter_VALUE, SGDelimiter delimiter_TERMINATOR, Boolean _front_back__ANSWER_BOOLEAN__, Int32 rebase, Int32 indexer_START, Int32 indexer_END, Boolean backward, SGText text)
        {
            STContainer containerResult = default;

            containerResult = MakeContainerTerminatorIndexerIndexer(delimiter_VALUE, delimiter_TERMINATOR, _front_back__ANSWER_BOOLEAN__, rebase, indexer_START, indexer_END, backward, text, SAPolicy.ContainerDebugPolicy);

            return containerResult;
        }
    }
}
