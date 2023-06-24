using Core;

namespace Core.Shared
{
    using System;

    public partial class STToken
    {
        public static STToken MakeTokenBaseIndexCount(SGSymbol symbol, Int32 rebase, Int32 index, Int32 count, Boolean backward, Boolean skip, Boolean next, SGText text, Boolean debug)
        {
            STToken tokenResult = default;

            Debug_TokenBaseIndexCount(symbol, rebase, index, count, backward, skip, next, text, debug);

            STQuery sQuery;
            
            if (backward)
            {
                sQuery = STQuery.MakeQueryBackwardIndexCount(symbol, index, count, skip, next, text, debug);
            }
            else
            {
                sQuery = STQuery.MakeQueryForwardIndexCount(symbol, index, count, skip, next, text, debug);
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
