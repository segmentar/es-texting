using Core;

namespace Core.Shared
{
    using System;

    public partial class STToken
    {
        public static STToken Runtime_MakeTokenValuePrimarySecondary(SGSymbol symbol, Int32 rebase, Int32 primary, Int32 secondary, Boolean backward, SGText text)
        {
            STToken tokenResult = default;

            tokenResult = MakeTokenValuePrimarySecondary(symbol, rebase, primary, secondary, backward, text, SAPolicy.TokenDebugPolicy);
                
            return tokenResult;
        }
    }
}
