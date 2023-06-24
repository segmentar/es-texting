using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;
    using System.Collections.Generic;

    public partial class STWord
    {
        public static STWord MakeWordInsertPrimarySecondary(SGSymbol symbol, Int32 primary, Int32 secondary, SGText text, Boolean debug)
        {
            STWord wordResult = default;

            var search = STSearch.MakeSearchForwardPrimarySecondary(SAConstantVoid.SearchSizeDefault, text.Value.Length, primary, secondary, SAConstantDisagreement.SearchNextDefault, debug);

            var start = search.Index;

            var length = search.Count;

            Info_WordInsertPrimarySecondary(search, start, length, debug);

            wordResult = MakeWordInsertIndexCount(symbol, start, length, text, debug);

            return wordResult;
        }
    }
}
