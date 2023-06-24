using Core;

namespace Core.Shared
{
    using System;
    
    public partial class STSearch
    {
        public static STSearch MakeSearchBackwardDefault(Int32 size, Int32 volume, Boolean next, Boolean debug)
        {
            STSearch searchResult = default;

            var complex = new STSearchSequenceBackwardDefault(size, volume, next, debug).Complex;

            ArrayList.Add(complex);

            searchResult = MakeSearchBackwardIndexCount(size, volume, complex.Index, complex.Count, next, debug);

            return searchResult;
        }
    }
}
