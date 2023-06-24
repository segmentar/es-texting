using Core;

namespace Core.Shared
{
    using System;

    public partial class STToken
    {
        public static STToken Runtime_MakeTokenValueIndex(SGSymbol symbol, Int32 rebase, Int32 index, Boolean backward, SGText text)
        {
            STToken tokenResult = default;

            tokenResult = MakeTokenValueIndex(symbol, rebase, index, backward, text, SAPolicy.TokenDebugPolicy);
                
            return tokenResult;
        }
    }
}
