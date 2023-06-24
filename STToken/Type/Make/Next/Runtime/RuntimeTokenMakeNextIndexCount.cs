using Core;

namespace Core.Shared
{
    using System;

    public partial class STToken
    {
        public static STToken Runtime_MakeTokenNextIndexCount(SGSymbol symbol, Int32 rebase, Boolean move, Int32 index, Int32 count, Boolean backward, SGText text)
        {
            STToken tokenResult = default;

            tokenResult = MakeTokenNextIndexCount(symbol, rebase, move, index, count, backward, text, SAPolicy.TokenDebugPolicy);

            return tokenResult;
        }
    }
}
