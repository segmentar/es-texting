using Core;

namespace Core.Shared
{
    using System;

    public partial class STToken
    {
        public static STToken MakeTokenNextIndexerIndexer(SGSymbol symbol, Int32 rebase, Boolean move, Int32 indexer_START, Int32 indexer_END, Boolean backward, SGText text, Boolean debug)
        {
            STToken tokenResult = default;

            tokenResult = MakeTokenBaseIndexerIndexer(symbol, rebase, indexer_START, indexer_END, backward, SAConstantDisagreement.TokenSkipDefault, move, text, debug);

            return tokenResult;
        }
    }
}
