using Core;

namespace Core.Shared
{
    using System;

    public partial class STQuery
    {
        public static STQuery MakeQueryBackwardIndex(SGSymbol symbol, Int32 index, Boolean skip, Boolean next, SGText text, Boolean debug)
        {
            STQuery queryResult = default;

            var immutable = new STQuerySequenceBackwardIndex(symbol, index, next, text, debug).Immutable;

            ArrayList.Add(immutable);

            queryResult = MakeQueryBackwardBase(symbol, immutable.Index, immutable.Count, skip, next, text, debug);

            return queryResult;
        }
    }
}
