using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;

    using System.Collections.ObjectModel;

    public partial class STContainer
    {
        public static STContainer MakeContainerOccurrenceIndexerIndexer(SGSymbol symbol, Int32 rebase, Int32 indexer_START, Int32 indexer_END, Boolean backward, SGText text, Boolean debug)
        {
            STContainer containerResult = default;

            Debug_ContainerOccurrenceIndexerIndexer(symbol, rebase, indexer_START, indexer_END, backward, text, debug);

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

            containerResult = new STContainer(list, debug);

            return containerResult;
        }
    }
}
