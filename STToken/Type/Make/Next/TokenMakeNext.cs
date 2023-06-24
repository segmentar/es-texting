using Core;

namespace Core.Shared
{
    using System;

    public partial class STToken
    {
        public static STToken MakeTokenNext(SGSymbol symbol, Int32 rebase, Boolean move, Boolean backward, SGText text, Boolean debug)
        {
            STToken tokenResult = default;

            tokenResult = MakeTokenBaseDefault(symbol, rebase, backward, SAConstantDisagreement.TokenSkipDefault, move, text, debug);

            return tokenResult;
        }
    }
}
