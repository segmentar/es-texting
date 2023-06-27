using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class STContainerVarianceSequenceIndexerIndexer : SAInterface.IContainerSequence
    {
        public STContainer Container { get; set; }

        public STContainerVarianceSequenceIndexerIndexer(SGDelimiter delimiter, Int32 rebase, Int32 indexer_START, Int32 indexer_END, Boolean backward, SGText text, Boolean debug)
        {
            Debug(delimiter, rebase, indexer_START, indexer_END, backward, text, debug);

            var list = new List<STToken>();

            foreach (SGSymbol symbol in delimiter.DelimiterList)
            {
                var token = STToken.MakeTokenValueIndexerIndexer(symbol, rebase, indexer_START, indexer_END, backward, text, debug);

                if (token.Found is false)
                {
                    continue;
                }
                else
                    "false".ToString();

                list.Add(token);

                break;
            }

            var container = STContainer.MakeContainerBase(list, debug);

            this.Container = container;

            return;
        }

        ~STContainerVarianceSequenceIndexerIndexer()
        {
            return;
        }
    }
}
