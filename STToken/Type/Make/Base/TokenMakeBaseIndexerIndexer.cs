using Core;

namespace Core.Shared
{
    using System;

    public partial class STToken
    {
        public static STToken MakeTokenBaseIndexerIndexer(SGSymbol symbol, Int32 rebase, Int32 indexer_START, Int32 indexer_END, Boolean backward, Boolean skip, Boolean next, SGText text, Boolean debug)
        {
            STToken tokenResult = default;

            Debug_TokenBaseIndexerIndexer(symbol, rebase, indexer_START, indexer_END, backward, skip, next, text, debug);

            STQuery sQuery;
            
            if (backward)
            {
                sQuery = STQuery.MakeQueryBackwardIndexerIndexer(symbol, indexer_START, indexer_END, skip, next, text, debug);
            }
            else
            {
                sQuery = STQuery.MakeQueryForwardIndexerIndexer(symbol, indexer_START, indexer_END, skip, next, text, debug);
            }

            if (sQuery.Value == -1)
            {
                tokenResult = new STToken(symbol, (sQuery.Value + rebase), sQuery.Quantity, false, debug);
            }
            else
            {
                tokenResult = new STToken(symbol, (sQuery.Value + rebase), sQuery.Quantity, true, debug);
            }
                
            return tokenResult;
        }
    }
}
