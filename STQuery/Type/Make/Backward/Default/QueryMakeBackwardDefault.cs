using Core;

namespace Core.Shared
{
    using System;

    public partial class STQuery
    {
        public static STQuery MakeQueryBackwardDefault(SGSymbol symbol, Boolean skip, Boolean next, SGText text, Boolean debug)
        {
            STQuery queryResult = default;

            var immutable = new STQuerySequenceBackwardDefault(symbol, next, text, debug).Immutable;

            ArrayList.Add(immutable);

            queryResult = MakeQueryBackwardBase(symbol, immutable.Index, immutable.Count, skip, next, text, debug);

            return queryResult;
        }
    }
}
