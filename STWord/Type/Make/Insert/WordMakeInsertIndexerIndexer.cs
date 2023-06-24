using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;
    using System.Collections.Generic;

    public partial class STWord
    {
        public static STWord MakeWordInsertIndexerIndexer(SGSymbol symbol, Int32 indexer_START, Int32 indexer_END, SGText text, Boolean debug)
        {
            STWord wordResult = default;

            var search = STSearch.MakeSearchForwardIndexerIndexer(SAConstantVoid.SearchSizeDefault, text.Value.Length, indexer_START, indexer_END, SAConstantDisagreement.SearchNextDefault, debug);

            var start = search.Index;

            var length = search.Count;

            Info_WordInsertIndexerIndexer(search, start, length, debug);

            wordResult = MakeWordInsertIndexCount(symbol, start, length, text, debug);

            return wordResult;
        }
    }
}
