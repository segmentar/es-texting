using Core;

namespace Core.Shared
{
    using System;

    public partial class STWord
    {
        public static STWord MakeWordReplaceIndexCount(SGDelimiter delimiter, SGSymbol symbol, Int32 index, Int32 count, SGText text, Boolean debug)
        {
            STWord wordResult = default;

            var search = STSearch.MakeSearchForwardIndexCount(SAConstantVoid.SearchSizeDefault, text.Value.Length, index, count, SAConstantDisagreement.SearchNextDefault, debug);

            var start = search.Index;

            var length = search.Count;

            Info_WordReplaceIndexCount(search, start, length, debug);

            wordResult = MakeWordReplaceBase(delimiter, symbol, start, length, text, debug);

            return wordResult;
        }
    }
}
