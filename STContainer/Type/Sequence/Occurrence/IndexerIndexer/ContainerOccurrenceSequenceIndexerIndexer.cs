using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class STContainerOccurrenceSequenceIndexerIndexer : SAInterface.IContainerSequence
    {
        public STContainer Container { get; set; }

        public STContainerOccurrenceSequenceIndexerIndexer(SGSymbol symbol, Int32 rebase, Int32 indexer_START, Int32 indexer_END, Boolean backward, SGText text, Boolean debug)
        {
            Debug(symbol, rebase, indexer_START, indexer_END, backward, text, debug);

            var list = new List<STToken>();

            var move = false;

            do
            {
                var token = STToken.Runtime_MakeTokenNextIndexerIndexer(symbol, rebase, move, indexer_START, indexer_END, backward, text);

                if (token.Found is false)
                {
                    break;
                }
                else
                    "false".ToString();

                list.Add(token);

                move = move || true;

                continue;

            } while (true);

            var container = STContainer.MakeContainerBase(list, debug);

            this.Container = container;

            return;
        }

        ~STContainerOccurrenceSequenceIndexerIndexer()
        {
            return;
        }
    }
}
