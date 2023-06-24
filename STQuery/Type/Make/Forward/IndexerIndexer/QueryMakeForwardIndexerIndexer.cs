﻿using Core;

namespace Core.Shared
{
    using System;

    public partial class STQuery
    {
        public static STQuery MakeQueryForwardIndexerIndexer(SGSymbol symbol, Int32 indexer_START, Int32 indexer_END, Boolean skip, Boolean next, SGText text, Boolean debug)
        {
            STQuery queryResult = default;

            var immutable = new STQuerySequenceForwardIndexerIndexer(symbol, indexer_START, indexer_END, next, text, debug).Immutable;

            ArrayList.Add(immutable);

            queryResult = MakeQueryForwardBase(symbol, immutable.Index, immutable.Count, skip, next, text, debug);

            return queryResult;
        }
    }
}
