using Core;

namespace Core.Shared
{
    using System;

    public partial class STWord
    {
        public static STWord Runtime_MakeWordInsertPrimarySecondary(SGSymbol symbol, Int32 primary, Int32 secondary, SGText text)
        {
            STWord wordResult = default;

            wordResult = MakeWordInsertPrimarySecondary(symbol, primary, secondary, text, SAPolicy.WordDebugPolicy);

            return wordResult;
        }
    }
}
