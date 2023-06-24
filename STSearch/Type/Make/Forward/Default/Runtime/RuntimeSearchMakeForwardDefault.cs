using Core;

namespace Core.Shared
{
    using System;
    
    public partial class STSearch
    {
        public static STSearch Runtime_MakeSearchForwardDefault(Int32 size, Int32 volume, Boolean next)
        {
            STSearch searchResult = default;

            searchResult = MakeSearchForwardDefault(size, volume, next, SAPolicy.SearchDebugPolicy);

            return searchResult;
        }
    }
}
