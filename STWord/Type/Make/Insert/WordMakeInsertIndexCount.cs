using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;
    using System.Collections.Generic;

    public partial class STWord
    {
        public static STWord MakeWordInsertIndexCount(SGSymbol symbol, Int32 index, Int32 count, SGText text, Boolean debug)
        {
            STWord wordResult = default;

            var search = STSearch.MakeSearchForwardIndexCount(SAConstantVoid.SearchSizeDefault, text.Value.Length, index, count, SAConstantDisagreement.SearchNextDefault, debug);

            var start = search.Index;

            var length = search.Count;

            Info_WordInsertIndexCount(search, start, length, debug);

            wordResult = MakeWordInsertBase(symbol, start, length, text, debug);

            return wordResult;
        }
    }
}
