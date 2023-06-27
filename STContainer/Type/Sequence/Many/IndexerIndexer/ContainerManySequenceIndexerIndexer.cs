using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class STContainerManySequenceIndexerIndexer : SAInterface.IContainerSequence
    {
        public STContainer Container { get; set; }

        public STContainerManySequenceIndexerIndexer(SGDelimiter delimiter, Int32 rebase, Int32 indexer_START, Int32 indexer_END, Boolean backward, SGText text, Boolean debug)
        {
            Debug(delimiter, rebase, indexer_START, indexer_END, backward, text, debug);

            var list = new List<STToken>();

            foreach (SGSymbol symbol in delimiter.DelimiterList)
            {
                foreach (STToken token in STContainer.MakeContainerOccurrenceIndexerIndexer(symbol, rebase, indexer_START, indexer_END, backward, text, debug).TokenList)
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

        ~STContainerManySequenceIndexerIndexer()
        {
            return;
        }
    }
}
