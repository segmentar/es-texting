﻿using Core;

namespace Core.Shared
{
    using System;

    public partial class STToken
    {
        public static STToken Runtime_MakeTokenSkipIndexerIndexer(SGSymbol symbol, Int32 rebase, Int32 indexer_START, Int32 indexer_END, Boolean backward, SGText text)
        {
            STToken tokenResult = default;

            tokenResult = MakeTokenSkipIndexerIndexer(symbol, rebase, indexer_START, indexer_END, backward, text, SAPolicy.TokenDebugPolicy);

            return tokenResult;
        }
    }
}
