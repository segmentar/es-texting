using Core;

namespace Core.Shared
{
    using System;

    public partial class STWord
    {
        public static STWord Runtime_MakeWordReplaceIndexCount(SGDelimiter delimiter, SGSymbol symbol, Int32 index, Int32 count, SGText text)
        {
            STWord wordResult = default;

            wordResult = MakeWordReplaceIndexCount(delimiter, symbol, index, count, text, SAPolicy.WordDebugPolicy);

            return wordResult;
        }
    }
}
