using Core;

namespace Core.Shared
{
    using System;
    
    public partial class STSearch
    {
        public static STSearch Runtime_MakeSearchBackwardIndexCount(Int32 size, Int32 volume, Int32 index, Boolean next, Int32 count)
        {
            STSearch searchResult = default;

            searchResult = MakeSearchBackwardIndexCount(size, volume, index, count, next, SAPolicy.SearchDebugPolicy);

            return searchResult;
        }
    }
}
