using Core;

namespace Core.Shared
{
    using System;

    public partial class STWord
    {
        public static STWord MakeWordReplace(SGDelimiter delimiter, SGSymbol symbol, SGText text, Boolean debug)
        {
            STWord wordResult = default;

            var search = STSearch.MakeSearchForwardDefault(SAConstantVoid.SearchSizeDefault, text.Value.Length, SAConstantDisagreement.SearchNextDefault, debug);

            var start = search.Index;

            var length = search.Count;

            Info_WordReplace(search, start, length, debug);

            wordResult = MakeWordReplaceIndexCount(delimiter, symbol, start, length, text, debug);

            return wordResult;
        }
    }
}
