using Core;

namespace Core.Shared
{
    using System;

    public partial class STToken
    {
        public static STToken MakeTokenValueDefault(SGSymbol symbol, Int32 rebase, Boolean backward, SGText text, Boolean debug)
        {
            STToken tokenResult = default;

            tokenResult = MakeTokenBaseDefault(symbol, rebase, backward, SAConstantDisagreement.TokenSkipDefault, SAConstantDisagreement.TokenNextDefault, text, debug);

            return tokenResult;
        }
    }
}
