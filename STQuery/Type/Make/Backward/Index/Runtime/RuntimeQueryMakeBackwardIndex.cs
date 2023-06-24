using Core;

namespace Core.Shared
{
    using System;

    public partial class STQuery
    {
        public static STQuery Runtime_MakeQueryBackwardIndex(SGSymbol symbol, Int32 index, Boolean skip, Boolean next, SGText text)
        {
            STQuery queryResult = default;

            queryResult = MakeQueryBackwardIndex(symbol, index, skip, next, text, SAPolicy.QueryDebugPolicy);

            return queryResult;
        }
    }
}
