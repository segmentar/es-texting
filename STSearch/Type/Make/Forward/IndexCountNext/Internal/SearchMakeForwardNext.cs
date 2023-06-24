using Core;

namespace Core.Shared
{
    using System;
    
    public partial class STSearch
    {
        public static STSearch MakeSearchForwardNext(Int32 size, Int32 volume, Int32 index, Int32 count, Boolean next, Boolean debug)
        {
            STSearch searchResult = default;

            var complex = new STSearchSequenceFowardIndexCountNext(size, volume, index, count, next, debug).Complex;

            ArrayList.Add(complex);

            searchResult = new STSearch(size, volume, index, count, next, debug);

            return searchResult;
        }
    }
}
