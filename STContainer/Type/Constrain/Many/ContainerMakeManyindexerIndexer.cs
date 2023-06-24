using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class STContainer
    {
        public static STContainer MakeContainerManyIndexerIndexer(Int32 rebase, Int32 indexer_START, Int32 indexer_END, Boolean backward, SGText text, SGDelimiter delimiter, Boolean debug)
        {
            STContainer containerResult = default;

            Debug_ContainerManyIndexerIndexer(rebase, indexer_START, indexer_END, backward, text, delimiter, debug);

            /*foreach (String symbol_VALUE in delimiter.DelimiterArray)
            {
                var symbol = new SGSymbol(symbol_VALUE);

                foreach (SToken token in MakeTokenOccurrenceIndexerIndexer(symbol, rebase, indexer_START, indexer_END, backward, text, debug))
                {
                    collectionResult.Add(token);

                    continue;
                }

                continue;
            }*/

            return containerResult;
        }
    }
}
