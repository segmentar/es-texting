using Core;

namespace Core.Shared
{
    using System;

    public partial class STContainer
    {
        public static STContainer MakeContainerTerminatorIndexerIndexer(SGDelimiter delimiter_VALUE, SGDelimiter delimiter_TERMINATOR, Boolean _front_back__ANSWER_BOOLEAN__, Int32 rebase, Int32 indexer_START, Int32 indexer_END, Boolean backward, SGText text, Boolean debug)
        {
            STContainer containerResult = default;

            Debug_ContainerTerminatorIndexerIndexer(delimiter_VALUE, delimiter_TERMINATOR, _front_back__ANSWER_BOOLEAN__, rebase, indexer_START, indexer_END, backward, text, debug);

            var container_VALUE = Runtime_MakeContainerMany(delimiter_VALUE, rebase, backward, text);

            var container_TERMINATOR = Runtime_MakeContainerMany(delimiter_TERMINATOR, rebase, backward, text);

            containerResult = Runtime_MakeContainerCollider(container_VALUE, container_TERMINATOR, _front_back__ANSWER_BOOLEAN__);

            return containerResult;
        }
    }
}
