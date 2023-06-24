using Core;

namespace Core.Shared
{
    using System;

    public partial class STToken
    {
        public static STToken Runtime_MakeTokenNextIndex(SGSymbol symbol, Int32 rebase, Boolean move, Int32 index, Boolean backward, SGText text)
        {
            STToken tokenResult = default;

            tokenResult = MakeTokenNextIndex(symbol, rebase, move, index, backward, text, SAPolicy.TokenDebugPolicy);

            return tokenResult;
        }
    }
}
