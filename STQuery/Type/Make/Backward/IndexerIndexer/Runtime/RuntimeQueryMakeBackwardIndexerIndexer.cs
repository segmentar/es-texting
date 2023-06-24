﻿using Core;

namespace Core.Shared
{
    using System;

    public partial class STQuery
    {
        public static STQuery Runtime_MakeQueryBackwardIndexerIndexer(SGSymbol symbol, Int32 indexer_START, Int32 indexer_END, Boolean skip, Boolean next, SGText text)
        {
            STQuery queryResult = default;

            queryResult = MakeQueryBackwardIndexerIndexer(symbol, indexer_START, indexer_END, skip, next, text, SAPolicy.QueryDebugPolicy);

            return queryResult;
        }
    }
}
