using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;
    using System.Collections.Generic;

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
