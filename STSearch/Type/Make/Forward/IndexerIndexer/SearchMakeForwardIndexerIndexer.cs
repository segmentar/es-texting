using Core;

namespace Core.Shared
{
    using System;
    
    public partial class STSearch
    {
        public static STSearch MakeSearchForwardIndexerIndexer(Int32 size, Int32 volume, Int32 indexer_START, Int32 indexer_END, Boolean next, Boolean debug)
        {
            STSearch searchResult = default;

            var complex = new STSearchSequenceFowardIndexerIndexer(size, volume, indexer_START, indexer_END, next, debug).Complex;

            ArrayList.Add(complex);

            searchResult = MakeSearchForwardIndexCount(size, volume, complex.Index, complex.Count, next, debug);

            return searchResult;
        }
    }
}
