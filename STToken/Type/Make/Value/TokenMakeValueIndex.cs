using Core;

namespace Core.Shared
{
    using System;

    public partial class STToken
    {
        public static STToken MakeTokenValueIndex(SGSymbol symbol, Int32 rebase, Int32 index, Boolean backward, SGText text, Boolean debug)
        {
            STToken tokenResult = default;

            tokenResult = MakeTokenBaseIndex(symbol, rebase, index, backward, SAConstantDisagreement.TokenSkipDefault, SAConstantDisagreement.TokenNextDefault, text, debug);

            return tokenResult;
        }
    }
}
