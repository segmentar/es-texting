using Core;

namespace Core.Shared
{
    using System;
    
    public partial class STSearch
    {
        public static STSearch Runtime_MakeSearchBackwardIndexerIndexer(Int32 size, Int32 volume, Int32 indexer_START, Int32 indexer_END, Boolean next)
        {
            STSearch searchResult = default;

            searchResult = MakeSearchBackwardIndexerIndexer(size, volume, indexer_START, indexer_END, next, SAPolicy.SearchDebugPolicy);

            return searchResult;
        }
    }
}
