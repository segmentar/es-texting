using Core;

namespace Core.Shared
{
    using System;

    public partial class STToken
    {
        public static STToken Runtime_MakeTokenSkipPrimarySecondary(SGSymbol symbol, Int32 rebase, Int32 primary, Int32 secondary, Boolean backward, SGText text)
        {
            STToken tokenResult = default;

            tokenResult = MakeTokenSkipPrimarySecondary(symbol, rebase, primary, secondary, backward, text, SAPolicy.TokenDebugPolicy);

            return tokenResult;
        }
    }
}
