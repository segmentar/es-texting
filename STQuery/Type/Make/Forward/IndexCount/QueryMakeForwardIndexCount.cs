using Core;

namespace Core.Shared
{
    using System;

    public partial class STQuery
    {
        public static STQuery MakeQueryForwardIndexCount(SGSymbol symbol, Int32 index, Int32 count, Boolean skip, Boolean next, SGText text, Boolean debug)
        {
            STQuery queryResult = default;

            var immutable = new STQuerySequenceForwardIndexCount(symbol, index, count, next, text, debug).Immutable;

            ArrayList.Add(immutable);

            queryResult = MakeQueryForwardBase(symbol, immutable.Index, immutable.Count, skip, next, text, debug);

            return queryResult;
        }
    }
}
