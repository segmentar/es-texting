using Core;

namespace Core.Shared
{
    using System;

    public partial class STWord
    {
        public static STWord Runtime_MakeWordReplace(SGDelimiter delimiter, SGSymbol symbol, SGText text)
        {
            STWord wordResult = default;

            wordResult = MakeWordReplace(delimiter, symbol, text, SAPolicy.WordDebugPolicy);

            return wordResult;
        }
    }
}
