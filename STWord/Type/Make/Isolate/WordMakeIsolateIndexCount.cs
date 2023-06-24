using Core;

namespace Core.Shared
{
    using System;

    public partial class STWord
    {
        public static STWord MakeWordIsolateIndexCount(SGText text, Int32 index, Int32 count, Boolean debug)
        {
            STWord wordResult = default;

            var search = STSearch.MakeSearchForwardIndexCount(SAConstantVoid.SearchSizeDefault, text.Value.Length, index, count, SAConstantDisagreement.SearchNextDefault, debug);

            var start = search.Index;

            var length = search.Count;

            Info_WordIsolateIndexCount(search, start, length, debug);

            wordResult = MakeWordIsolateBase(text, start, length, debug);

            return wordResult;
        }
    }
}
