using Core;

namespace Core.Shared
{
    using System;

    public partial class STContainerTerminatorSequenceIndex : SAInterface.IContainerSequence
    {
        public STContainer Container { get; set; }

        public STContainerTerminatorSequenceIndex(SGDelimiter delimiter_VALUE, SGDelimiter delimiter_TERMINATOR, Boolean _front_back_, Int32 rebase, Int32 index, Boolean backward, SGText text, Boolean debug)
        {
            Debug(delimiter_VALUE, delimiter_TERMINATOR, _front_back_, rebase, index, backward, text, debug);

            var container_VALUE = STContainer.MakeContainerManyIndex(delimiter_VALUE, rebase, index, backward, text, debug);

            var container_TERMINATOR = STContainer.MakeContainerManyIndex(delimiter_TERMINATOR, rebase, index, backward, text, debug);

            var container = STContainer.MakeContainerCollider(container_VALUE, container_TERMINATOR, _front_back_, debug);

            this.Container = container;

            return;
        }

        ~STContainerTerminatorSequenceIndex()
        {
            return;
        }
    }
}
