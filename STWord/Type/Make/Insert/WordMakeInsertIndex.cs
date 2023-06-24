using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;
    using System.Collections.Generic;

    public partial class STWord
    {
        public static STWord MakeWordInsertIndex(SGSymbol symbol, Int32 index, SGText text, Boolean debug)
        {
            STWord wordResult = default;

            var search = STSearch.MakeSearchForwardIndex(SAConstantVoid.SearchSizeDefault, text.Value.Length, index, SAConstantDisagreement.SearchNextDefault, debug);

            var start = search.Index;

            var length = search.Count;

            Info_WordInsertIndex(search, start, length, debug);

            wordResult = MakeWordInsertIndexCount(symbol, start, length, text, debug);

            return wordResult;
        }
    }
}
