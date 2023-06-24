using Core;

namespace Core.Shared
{
    using System;

    public partial class STToken
    {
        public static STToken MakeTokenNextIndexCount(SGSymbol symbol, Int32 rebase, Boolean move, Int32 index, Int32 count, Boolean backward, SGText text, Boolean debug)
        {
            STToken tokenResult = default;

            tokenResult = MakeTokenBaseIndexCount(symbol, rebase, index, count, backward, SAConstantDisagreement.TokenSkipDefault, move, text, debug);

            return tokenResult;
        }
    }
}
