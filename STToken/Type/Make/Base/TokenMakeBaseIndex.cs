using Core;

namespace Core.Shared
{
    using System;

    public partial class STToken
    {
        public static STToken MakeTokenBaseIndex(SGSymbol symbol, Int32 rebase, Int32 index, Boolean backward, Boolean skip, Boolean next, SGText text, Boolean debug)
        {
            STToken tokenResult = default;

            Debug_TokenBaseIndex(symbol, rebase, index, backward, skip, next, text, debug);

            STQuery sQuery;
            
            if (backward)
            {
                sQuery = STQuery.MakeQueryBackwardIndex(symbol, index, skip, next, text, debug);
            }
            else
            {
                sQuery = STQuery.MakeQueryForwardIndex(symbol, index, skip, next, text, debug);
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
