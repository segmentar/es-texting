using Core;

namespace Core.Shared
{
    using System;

    public partial class STToken
    {
        public static STToken Runtime_MakeTokenNextPrimarySecondary(SGSymbol symbol, Int32 rebase, Boolean move, Int32 primary, Int32 secondary, Boolean backward, SGText text)
        {
            STToken tokenResult = default;

            tokenResult = MakeTokenNextPrimarySecondary(symbol, rebase, move, primary, secondary, backward, text, SAPolicy.TokenDebugPolicy);

            return tokenResult;
        }
    }
}
