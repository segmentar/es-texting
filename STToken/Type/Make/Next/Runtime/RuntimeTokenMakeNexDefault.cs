using Core;

namespace Core.Shared
{
    using System;

    public partial class STToken
    {
        public static STToken Runtime_MakeTokenNextDefault(SGSymbol symbol, Int32 rebase, Boolean move, Boolean backward, SGText text)
        {
            STToken tokenResult = default;

            tokenResult = MakeTokenNextDefault(symbol, rebase, move, backward, text, SAPolicy.TokenDebugPolicy);

            return tokenResult;
        }
    }
}
