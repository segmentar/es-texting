using Core;

namespace Core.Shared
{
    using System;
    
    public partial class STSearch
    {
        public static STSearch Runtime_MakeSearchForwardIndex(Int32 size, Int32 volume, Int32 index, Boolean next)
        {
            STSearch searchResult = default;

            searchResult = MakeSearchForwardIndex(size, volume, index, next, SAPolicy.SearchDebugPolicy);

            return searchResult;
        }
    }
}
