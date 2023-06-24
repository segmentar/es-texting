using Core;

namespace Core.Shared
{
    using System;

    public partial class STWord
    {
        public static STWord Runtime_MakeWordReplacePrimarySecondary(SGDelimiter delimiter, SGSymbol symbol, Int32 primary, Int32 secondary, SGText text)
        {
            STWord wordResult = default;

            wordResult = MakeWordReplacePrimarySecondary(delimiter, symbol, primary, secondary, text, SAPolicy.WordDebugPolicy);

            return wordResult;
        }
    }
}
