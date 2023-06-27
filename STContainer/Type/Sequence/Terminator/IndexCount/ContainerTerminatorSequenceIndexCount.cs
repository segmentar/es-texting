using Core;

namespace Core.Shared
{
    using System;

    public partial class STContainerTerminatorSequenceIndexCount : SAInterface.IContainerSequence
    {
        public STContainer Container { get; set; }

        public STContainerTerminatorSequenceIndexCount(SGDelimiter delimiter_VALUE, SGDelimiter delimiter_TERMINATOR, Boolean _front_back_, Int32 rebase, Int32 index, Int32 count, Boolean backward, SGText text, Boolean debug)
        {
            Debug(delimiter_VALUE, delimiter_TERMINATOR, _front_back_, rebase, index, count, backward, text, debug);

            var container_VALUE = STContainer.MakeContainerManyIndexCount(delimiter_VALUE, rebase, index, count, backward, text, debug);

            var container_TERMINATOR = STContainer.MakeContainerManyIndexCount(delimiter_TERMINATOR, rebase, count, index, backward, text, debug);

            var container = STContainer.MakeContainerCollider(container_VALUE, container_TERMINATOR, _front_back_, debug);

            this.Container = container;

            return;
        }

        ~STContainerTerminatorSequenceIndexCount()
        {
            return;
        }
    }
}
