using Core;

namespace Core.Shared
{
    using System;

    public partial class STToken
    {

        public static STToken MakeTokenNextPrimarySecondary(SGSymbol symbol, Int32 rebase, Boolean move, Int32 primary, Int32 secondary, Boolean backward, SGText text, Boolean debug)
        {
            STToken tokenResult = default;

            tokenResult = MakeTokenBasePrimarySecondary(symbol, rebase, primary, secondary, backward, SAConstantDisagreement.TokenSkipDefault, move, text, debug);

            return tokenResult;
        }
    }
}
