using Core;

namespace Core.Shared
{
    using System;

    public partial class STWord
    {
        public static STWord MakeWordIsolateIndexerIndexer(SGText text, Int32 indexer_START, Int32 indexer_END, Boolean debug)
        {
            STWord wordResult = default;

            var search = STSearch.MakeSearchForwardIndexerIndexer(SAConstantVoid.SearchSizeDefault, text.Value.Length, indexer_START, indexer_END, SAConstantDisagreement.SearchNextDefault, debug);

            var start = search.Index;

            var length = search.Count;

            Info_WordIsolateIndexerIndexer(search, start, length, debug);

            wordResult = MakeWordIsolateIndexCount(text, start, length, debug);

            return wordResult;
        }
    }
}
