using Core;

namespace Core.Shared
{
    using System;

    public partial class STQuery
    {
        public static STQuery MakeQueryBackwardPrimarySecondary(SGSymbol symbol, Int32 primary, Int32 secondary, Boolean skip, Boolean next, SGText text, Boolean debug)
        {
            STQuery queryResult = default;

            var immutable = new STQuerySequenceBackwardPrimarySecondary(symbol, primary, secondary, next, text, debug).Immutable;

            ArrayList.Add(immutable);

            queryResult = MakeQueryBackwardBase(symbol, immutable.Index, immutable.Count, skip, next, text, debug);

            return queryResult;
        }
    }
}
