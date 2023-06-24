using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class STContainer
    {
        public static STContainer MakeContainerVarianceIndexerIndexer(SGDelimiter delimiter, Int32 rebase, Int32 indexer_START, Int32 indexer_END, Boolean backward, SGText text, Boolean debug)
        {
            STContainer containerResult = default;

            Debug_ContainerVarianceIndexerIndexer(delimiter, rebase, indexer_START, indexer_END, backward, text, debug);

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

            containerResult = new STContainer(list, debug);

            return containerResult;
        }
    }
}
