using Core;

namespace Core.Shared
{
    using System;

    public partial class STQuery
    {
        public static STQuery MakeQueryForwardIndex(SGSymbol symbol, Int32 index, Boolean skip, Boolean next, SGText text, Boolean debug)
        {
            STQuery queryResult = default;

            var immutable = new STQuerySequenceForwardIndex(symbol, index, next, text, debug).Immutable;

            ArrayList.Add(immutable);

            queryResult = MakeQueryForwardBase(symbol, immutable.Index, immutable.Count, skip, next, text, debug);

            return queryResult;
        }
    }
}
