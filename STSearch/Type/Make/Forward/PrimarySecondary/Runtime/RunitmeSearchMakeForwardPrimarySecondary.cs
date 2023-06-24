using Core;

namespace Core.Shared
{
    using System;
    
    public partial class STSearch
    {
        public static STSearch Runtime_MakeSearchForwardPrimarySecondary(Int32 size, Int32 volume, Int32 primary, Int32 secondary, Boolean next)
        {
            STSearch searchResult = default;

            searchResult = MakeSearchForwardPrimarySecondary(size, volume, primary, secondary, next, SAPolicy.SearchDebugPolicy);

            return searchResult;
        }
    }
}
