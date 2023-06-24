using Core;

namespace Core.Shared
{
    using System;

    public partial class STWord
    {
        public static STWord MakeWordReplacePrimarySecondary(SGDelimiter delimiter, SGSymbol symbol, Int32 primary, Int32 secondary, SGText text, Boolean debug)
        {
            STWord wordResult = default;

            var search = STSearch.MakeSearchForwardPrimarySecondary(SAConstantVoid.SearchSizeDefault, text.Value.Length, primary, secondary, SAConstantDisagreement.SearchNextDefault, debug);

            var start = search.Index;

            var length = search.Count;

            Info_WordReplacePrimarySecondary(search, start, length, debug);

            wordResult = MakeWordReplaceIndexCount(delimiter, symbol, start, length, text, debug);

            return wordResult;
        }
    }
}
