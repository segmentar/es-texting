using Core;

namespace Core.Shared
{
    using System;

    public partial class STQuery
    {
        public static STQuery Runtime_MakeQueryForwardDefault(SGSymbol symbol, Boolean skip, Boolean next, SGText text)
        {
            STQuery queryResult = default;

            queryResult = MakeQueryForwardDefault(symbol, skip, next, text, SAPolicy.QueryDebugPolicy);

            return queryResult;
        }
    }
}
