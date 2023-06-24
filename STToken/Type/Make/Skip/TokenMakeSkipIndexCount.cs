using Core;

namespace Core.Shared
{
    using System;

    public partial class STToken
    {
        public static STToken MakeTokenSkipIndexCount(SGSymbol symbol, Int32 rebase, Int32 index, Int32 count, Boolean backward, SGText text, Boolean debug)
        {
            STToken tokenResult = default;

            tokenResult = MakeTokenBaseIndexCount(symbol, rebase, index, count, backward, true, SAConstantDisagreement.TokenNextDefault, text, debug);

            return tokenResult;
        }
    }
}
