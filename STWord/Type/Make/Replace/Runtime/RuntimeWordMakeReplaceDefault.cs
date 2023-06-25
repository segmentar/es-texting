using Core;

namespace Core.Shared
{
    using System;

    public partial class STWord
    {
        public static STWord Runtime_MakeWordReplaceDefault(SGDelimiter delimiter, SGSymbol symbol, SGText text)
        {
            STWord wordResult = default;

            wordResult = MakeWordReplaceDefault(delimiter, symbol, text, SAPolicy.WordDebugPolicy);

            return wordResult;
        }
    }
}
