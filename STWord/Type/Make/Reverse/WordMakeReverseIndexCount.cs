using Core;

namespace Core.Shared
{
    using System;

    public partial class STWord
    {
        public static STWord MakeWordReverseIndexCount(SGText text, Int32 index, Int32 count, Boolean debug)
        {
            STWord wordResult = default;

            var search = STSearch.MakeSearchForwardIndexCount(SAConstantVoid.SearchSizeDefault, text.Value.Length, index, count, SAConstantDisagreement.SearchNextDefault, debug);

            var start = search.Index;

            var length = search.Count;

            Info_WordReverseIndexCount(search, start, length, debug);

            wordResult = MakeWordReverseBase(text, index, count, debug);

            return wordResult;
        }
    }
}
