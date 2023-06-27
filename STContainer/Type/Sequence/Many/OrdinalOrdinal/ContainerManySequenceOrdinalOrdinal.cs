using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class STContainerManySequenceOrdinalOrdinal : SAInterface.IContainerSequence
    {
        public STContainer Container { get; set; }

        public STContainerManySequenceOrdinalOrdinal(SGDelimiter delimiter, Int32 rebase, Int32 ordinal_PRIMARY, Int32 ordinal_SECONDARY, Boolean backward, SGText text, Boolean debug)
        {
            Debug(delimiter, rebase, ordinal_PRIMARY, ordinal_SECONDARY, backward, text, debug);

            var list = new List<STToken>();

            foreach (SGSymbol symbol in delimiter.DelimiterList)
            {
                foreach (STToken token in STContainer.MakeContainerOccurrenceIndexerIndexer(symbol, rebase, ordinal_PRIMARY, ordinal_SECONDARY, backward, text, debug).TokenList)
                {
                    list.Add(token);

                    continue;
                }

                continue;
            }

            var container = STContainer.MakeContainerBase(list, debug);

            this.Container = container;

            return;
        }

        ~STContainerManySequenceOrdinalOrdinal()
        {
            return;
        }
    }
}
