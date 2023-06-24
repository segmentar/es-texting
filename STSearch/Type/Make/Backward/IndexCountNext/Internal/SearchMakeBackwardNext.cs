using Core;

namespace Core.Shared
{
    using System;
    
    public partial class STSearch
    {
        public static STSearch MakeSearchBackwardNext(Int32 size, Int32 volume, Int32 index, Int32 count, Boolean next, Boolean debug)
        {
            STSearch searchResult = default;

            var complex = new STSearchSequenceBackwardIndexCountNext(size, volume, index, count, next, debug).Complex;

            ArrayList.Add(complex);

            searchResult = new STSearch(size, volume, complex.Index, complex.Count, next, debug);

            return searchResult;
        }
    }
}
