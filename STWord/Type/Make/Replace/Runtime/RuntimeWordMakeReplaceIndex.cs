using Core;

namespace Core.Shared
{
    using System;

    public partial class STWord
    {
        public static STWord Runtime_MakeWordReplaceIndex(SGDelimiter delimiter, SGSymbol symbol, Int32 index, SGText text)
        {
            STWord wordResult = default;

            wordResult = MakeWordReplaceIndex(delimiter, symbol, index, text, SAPolicy.WordDebugPolicy);

            return wordResult;
        }
    }
}
