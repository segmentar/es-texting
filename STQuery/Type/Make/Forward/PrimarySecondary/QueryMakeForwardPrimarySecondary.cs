using Core;

namespace Core.Shared
{
    using System;

    public partial class STQuery
    {
        public static STQuery MakeQueryForwardPrimarySecondary(SGSymbol symbol, Int32 primary, Int32 secondary, Boolean skip, Boolean next, SGText text, Boolean debug)
        {
            STQuery queryResult = default;

            var immutable = new STQuerySequenceForwardPrimarySecondary(symbol, primary, secondary, next, text, debug).Immutable;

            ArrayList.Add(immutable);

            queryResult = MakeQueryForwardBase(symbol, immutable.Index, immutable.Count, skip, next, text, debug);

            return queryResult;
        }
    }
}
