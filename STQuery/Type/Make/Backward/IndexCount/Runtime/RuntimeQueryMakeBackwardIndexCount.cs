using Core;

namespace Core.Shared
{
    using System;

    public partial class STQuery
    {
        public static STQuery Runtime_MakeQueryBackwardIndexCount(SGSymbol symbol, Int32 index, Int32 count, Boolean skip, Boolean next, SGText text)
        {
            STQuery queryResult = default;

            queryResult = MakeQueryBackwardIndexCount(symbol, index, count, skip, next, text, SAPolicy.QueryDebugPolicy);

            return queryResult;
        }
    }
}
