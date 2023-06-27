using Core;

namespace Core.Shared
{
    using System;

    public partial class STContainerTerminatorSequenceDefault : SAInterface.IContainerSequence
    {
        public STContainer Container { get; set; }

        public STContainerTerminatorSequenceDefault(SGDelimiter delimiter_VALUE, SGDelimiter delimiter_TERMINATOR, Boolean _front_back_, Int32 rebase, Boolean backward, SGText text, Boolean debug)
        {
            Debug(delimiter_VALUE, delimiter_TERMINATOR, _front_back_, rebase, backward, text, debug);

            var container_VALUE = STContainer.MakeContainerMany(delimiter_VALUE, rebase, backward, text, debug);

            var container_TERMINATOR = STContainer.MakeContainerMany(delimiter_TERMINATOR, rebase, backward, text, debug);

            var container = STContainer.MakeContainerCollider(container_VALUE, container_TERMINATOR, _front_back_, debug);

            this.Container = container;

            return;
        }

        ~STContainerTerminatorSequenceDefault()
        {
            return;
        }
    }
}
