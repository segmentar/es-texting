using Core;

namespace Core.Shared
{
    using System;

    public partial class STWord
    {
        public static STWord Runtime_MakeWordInsertIndex(SGSymbol symbol, Int32 index, SGText text)
        {
            STWord wordResult = default;

            wordResult = MakeWordInsertIndex(symbol, index, text, SAPolicy.WordDebugPolicy);

            return wordResult;
        }
    }
}
