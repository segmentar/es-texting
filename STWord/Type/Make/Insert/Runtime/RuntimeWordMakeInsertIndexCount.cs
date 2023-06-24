using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;
    using System.Collections.Generic;

    public partial class STWord
    {
        public static STWord Runtime_MakeWordInsertIndexCount(SGSymbol symbol, Int32 index, Int32 count, SGText text)
        {
            STWord wordResult = default;

            wordResult = MakeWordInsertIndexCount(symbol, index, count, text, SAPolicy.WordDebugPolicy);

            return wordResult;
        }
    }
}
