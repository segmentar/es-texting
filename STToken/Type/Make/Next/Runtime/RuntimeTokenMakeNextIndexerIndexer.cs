using Core;

namespace Core.Shared
{
    using System;

    public partial class STToken
    {
        public static STToken Runtime_MakeTokenNextIndexerIndexer(SGSymbol symbol, Int32 rebase, Boolean move, Int32 indexer_START, Int32 indexer_END, Boolean backward, SGText text)
        {
            STToken tokenResult = default;

            tokenResult = MakeTokenNextIndexerIndexer(symbol, rebase, move, indexer_START, indexer_END, backward, text, SAPolicy.TokenDebugPolicy);

            return tokenResult;
        }
    }
}
