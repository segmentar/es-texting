using Core;

namespace Core.Shared
{
    using System;

    public partial class STToken
    {
        public static STToken MakeTokenNextIndex(SGSymbol symbol, Int32 rebase, Boolean move, Int32 index, Boolean backward, SGText text, Boolean debug)
        {
            STToken tokenResult = default;

            tokenResult = MakeTokenBaseIndex(symbol, rebase, index, backward, SAConstantDisagreement.TokenSkipDefault, move, text, debug);

            return tokenResult;
        }
    }
}
