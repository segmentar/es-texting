using Core;

namespace Core.Shared
{
    using System;
    
    public partial class STSearch
    {
        public static STSearch MakeSearchBackwardIndex(Int32 size, Int32 volume, Int32 index, Boolean next, Boolean debug)
        {
            STSearch searchResult = default;

            var complex = new STSearchSequenceBackwardIndex(size, volume, index, next, debug).Complex;

            ArrayList.Add(complex);

            searchResult = MakeSearchBackwardIndexCount(size, volume, complex.Index, complex.Count, next, debug);

            return searchResult;
        }
    }
}
