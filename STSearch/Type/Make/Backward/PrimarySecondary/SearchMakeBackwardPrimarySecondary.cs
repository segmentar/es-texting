using Core;

namespace Core.Shared
{
    using System;
    
    public partial class STSearch
    {
        public static STSearch MakeSearchBackwardPrimarySecondary(Int32 size, Int32 volume, Int32 primary, Int32 secondary, Boolean next, Boolean debug)
        {
            STSearch searchResult = default;

            var complex = new STSearchSequenceBackwardPrimarySecondary(size, volume, primary, secondary, next, debug).Complex;

            ArrayList.Add(complex);

            searchResult = MakeSearchBackwardIndexerIndexer(size, volume, complex.Index, complex.Count, next, debug);

            return searchResult;
        }
    }
}
