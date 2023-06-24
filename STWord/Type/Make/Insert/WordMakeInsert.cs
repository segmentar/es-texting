using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;
    using System.Collections.Generic;

    public partial class STWord
    {
        public static STWord MakeWordInsert(SGSymbol symbol, SGText text, Boolean debug)
        {
            STWord wordResult = default;

            var search = STSearch.MakeSearchForwardDefault(SAConstantVoid.SearchSizeDefault, text.Value.Length, SAConstantDisagreement.SearchNextDefault, debug);

            var start = search.Index;

            var length = search.Count;

            Info_WordInsert(search, start, length, debug);

            wordResult = MakeWordInsertIndexCount(symbol, start, length, text, debug);

            return wordResult;
        }
    }
}
