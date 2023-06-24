﻿using Core;

namespace Core.Shared
{
    using System;

    public partial class STToken
    {
        public static STToken MakeTokenValueIndexerIndexer(SGSymbol symbol, Int32 rebase, Int32 indexer_START, Int32 indexer_END, Boolean backward, SGText text, Boolean debug)
        {
            STToken tokenResult = default;

            tokenResult = MakeTokenBaseIndexerIndexer(symbol, rebase, indexer_START, indexer_END, backward, SAConstantDisagreement.TokenSkipDefault, SAConstantDisagreement.TokenNextDefault, text, debug);

            return tokenResult;
        }
    }
}
