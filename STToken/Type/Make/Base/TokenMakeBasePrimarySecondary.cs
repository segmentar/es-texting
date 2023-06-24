using Core;

namespace Core.Shared
{
    using System;

    public partial class STToken
    {
        public static STToken MakeTokenBasePrimarySecondary(SGSymbol symbol, Int32 rebase, Int32 primary, Int32 secondary, Boolean backward, Boolean skip, Boolean next, SGText text, Boolean debug)
        {
            STToken tokenResult = default;

            Debug_TokenBasePrimarySecondary(symbol, rebase, primary, secondary, backward, skip, next, text, debug);

            STQuery sQuery;
            
            if (backward)
            {
                sQuery = STQuery.MakeQueryBackwardPrimarySecondary(symbol, primary, secondary, skip, next, text, debug);
            }
            else
            {
                sQuery = STQuery.MakeQueryForwardPrimarySecondary(symbol, primary, secondary, skip, next, text, debug);
            }

            if (sQuery.Value == -1)
            {
                tokenResult = new STToken(symbol, (sQuery.Value + rebase), sQuery.Quantity, false, debug);
            }
            else
            {
                tokenResult = new STToken(symbol, (sQuery.Value + rebase), sQuery.Quantity, true, debug);
            }
                
            return tokenResult;
        }
    }
}
