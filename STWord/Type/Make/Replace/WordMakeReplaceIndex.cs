using Core;

namespace Core.Shared
{
    using System;

    public partial class STWord
    {
        public static STWord MakeWordReplaceIndex(SGDelimiter delimiter, SGSymbol symbol, Int32 index, SGText text, Boolean debug)
        {
            STWord wordResult = default;

            var search = STSearch.MakeSearchForwardIndex(SAConstantVoid.SearchSizeDefault, text.Value.Length, index, SAConstantDisagreement.SearchNextDefault, debug);

            var start = search.Index;

            var length = search.Count;

            Info_WordReplaceIndex(search, start, length, debug);

            wordResult = MakeWordReplaceIndexCount(delimiter, symbol, start, length, text, debug);

            return wordResult;
        }
    }
}
