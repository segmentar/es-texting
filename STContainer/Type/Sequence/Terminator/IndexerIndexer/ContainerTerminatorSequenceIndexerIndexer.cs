using Core;

namespace Core.Shared
{
    using System;

    public partial class STContainerTerminatorSequenceIndexerIndexer : SAInterface.IContainerSequence
    {
        public STContainer Container { get; set; }

        public STContainerTerminatorSequenceIndexerIndexer(SGDelimiter delimiter_VALUE, SGDelimiter delimiter_TERMINATOR, Boolean _front_back_, Int32 rebase, Int32 indexer_START, Int32 indexer_END, Boolean backward, SGText text, Boolean debug)
        {
            Debug(delimiter_VALUE, delimiter_TERMINATOR, _front_back_, rebase, indexer_START, indexer_END, backward, text, debug);

            var container_VALUE = STContainer.MakeContainerManyIndexerIndexer(delimiter_VALUE, rebase, indexer_START, indexer_END, backward, text, debug);

            var container_TERMINATOR = STContainer.MakeContainerManyIndexerIndexer(delimiter_TERMINATOR, rebase, indexer_END, indexer_START, backward, text, debug);

            var container = STContainer.MakeContainerCollider(container_VALUE, container_TERMINATOR, _front_back_, debug);

            this.Container = container;

            return;
        }

        ~STContainerTerminatorSequenceIndexerIndexer()
        {
            return;
        }
    }
}
