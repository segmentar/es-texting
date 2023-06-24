using Core;

namespace Core.Shared
{
    using System;

    public partial class STQuery
    {
        public static STQuery Runtime_MakeQueryForwardIndex(SGSymbol symbol, Int32 index, Boolean skip, Boolean next, SGText text)
        {
            STQuery queryResult = default;

            queryResult = MakeQueryForwardIndex(symbol, index, skip, next, text, SAPolicy.QueryDebugPolicy);

            return queryResult;
        }
    }
}
