using Core;

namespace Core.Shared
{
    using System;

    public partial class STWord
    {
        public static STWord Runtime_MakeWordInsertDefault(SGSymbol symbol, SGText text)
        {
            STWord wordResult = default;

            wordResult = MakeWordInsertDefault(symbol, text, SAPolicy.WordDebugPolicy);

            return wordResult;
        }
    }
}
