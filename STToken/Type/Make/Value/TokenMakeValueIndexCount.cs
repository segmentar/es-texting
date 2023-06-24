using Core;

namespace Core.Shared
{
    using System;

    public partial class STToken
    {
        public static STToken MakeTokenValueIndexCount(SGSymbol symbol, Int32 rebase, Int32 index, Int32 count, Boolean backward, SGText text, Boolean debug)
        {
            STToken tokenResult = default;

            tokenResult = MakeTokenBaseIndexCount(symbol, rebase, index, count, backward, SAConstantDisagreement.TokenSkipDefault, SAConstantDisagreement.TokenNextDefault, text, debug);

            return tokenResult;
        }
    }
}
