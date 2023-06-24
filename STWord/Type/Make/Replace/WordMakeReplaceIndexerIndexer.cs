using Core;

namespace Core.Shared
{
    using System;

    public partial class STWord
    {
        public static STWord MakeWordReplaceIndexerIndexer(SGDelimiter delimiter, SGSymbol symbol, Int32 indexer_START, Int32 indexer_END, SGText text, Boolean debug)
        {
            STWord wordResult = default;

            var search = STSearch.MakeSearchForwardIndexerIndexer(SAConstantVoid.SearchSizeDefault, text.Value.Length, indexer_START, indexer_END, SAConstantDisagreement.SearchNextDefault, debug);

            var start = search.Index;

            var length = search.Count;

            Info_WordReplaceIndexerIndexer(search, start, length, debug);

            wordResult = MakeWordReplaceIndexCount(delimiter, symbol, start, length, text, debug);

            return wordResult;
        }
    }
}
