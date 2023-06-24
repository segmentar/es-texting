using Core;

namespace Core.Shared
{
    using System;

    public partial class STToken
    {
        public static STToken Runtime_MakeTokenValue(SGSymbol symbol, Int32 rebase, Boolean backward, SGText text)
        {
            STToken tokenResult = default;

            tokenResult = MakeTokenValue(symbol, rebase, backward, text, SAPolicy.TokenDebugPolicy);
                
            return tokenResult;
        }
    }
}
