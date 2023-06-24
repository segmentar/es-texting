using Core;

namespace Core.Shared
{
    using System;

    public partial class STWord
    {
        public static STWord MakeWordReverseIndex(SGText text, Int32 index, Boolean debug)
        {
            STWord wordResult = default;

            var search = STSearch.MakeSearchForwardIndex(SAConstantVoid.SearchSizeDefault, text.Value.Length, index, SAConstantDisagreement.SearchNextDefault, debug);

            var start = search.Index;

            var length = search.Count;

            Info_WordReverseIndex(search, start, length, debug);

            wordResult = MakeWordReverseIndexCount(text, start, length, debug);

            return wordResult;
        }
    }
}
