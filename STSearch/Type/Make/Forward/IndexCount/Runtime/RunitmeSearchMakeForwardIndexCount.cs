using Core;

namespace Core.Shared
{
    using System;
    
    public partial class STSearch
    {
        public static STSearch Runtime_MakeSearchForwardIndexCount(Int32 size, Int32 volume, Int32 index, Int32 count, Boolean next)
        {
            STSearch searchResult = default;

            searchResult = MakeSearchForwardIndexCount(size, volume, index, count, next, SAPolicy.SearchDebugPolicy);

            return searchResult;
        }
    }
}
