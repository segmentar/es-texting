using Core;

namespace Core.Shared
{
    using System;

    public partial class STContainerTerminatorSequenceOrdinalOrdinal : SAInterface.IContainerSequence
    {
        public STContainer Container { get; set; }

        public STContainerTerminatorSequenceOrdinalOrdinal(SGDelimiter delimiter_VALUE, SGDelimiter delimiter_TERMINATOR, Boolean _front_back_, Int32 rebase, Int32 ordindal_PRIMARY, Int32 ordinal_SECONDARY, Boolean backward, SGText text, Boolean debug)
        {
            Debug(delimiter_VALUE, delimiter_TERMINATOR, _front_back_, rebase, ordindal_PRIMARY, ordinal_SECONDARY, backward, text, debug);

            var container_VALUE = STContainer.MakeContainerManyOrdinalOrdinal(delimiter_VALUE, rebase, ordindal_PRIMARY, ordinal_SECONDARY, backward, text, debug);

            var container_TERMINATOR = STContainer.MakeContainerManyOrdinalOrdinal(delimiter_TERMINATOR, rebase, ordinal_SECONDARY, ordindal_PRIMARY, backward, text, debug);

            var container = STContainer.MakeContainerCollider(container_VALUE, container_TERMINATOR, _front_back_, debug);

            this.Container = container;

            return;
        }

        ~STContainerTerminatorSequenceOrdinalOrdinal()
        {
            return;
        }
    }
}
