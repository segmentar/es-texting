using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;
    using System.Collections.Generic;

    public partial class STWord
    {
        public static STWord Runtime_MakeWordInsert(SGSymbol symbol, SGText text)
        {
            STWord wordResult = default;

            wordResult = MakeWordInsert(symbol, text, SAPolicy.WordDebugPolicy);

            return wordResult;
        }
    }
}
