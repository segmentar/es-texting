using Core;

namespace Core.Shared
{
    using System;

    public partial class STToken
    {
        public static STToken Runtime_MakeTokenSkipIndexCount(SGSymbol symbol, Int32 rebase, Int32 index, Int32 count, Boolean backward, SGText text)
        {
            STToken tokenResult = default;

            tokenResult = MakeTokenSkipIndexCount(symbol, rebase, index, count, backward, text, SAPolicy.TokenDebugPolicy);

            return tokenResult;
        }
    }
}
