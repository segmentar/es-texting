using Core;

namespace Core.Shared
{
    using System;

    public partial class STWord
    {
        public static STWord MakeWordIsolate(SGText text, Boolean debug)
        {
            STWord wordResult = default;

            var search = STSearch.MakeSearchForwardDefault(SAConstantVoid.SearchSizeDefault, text.Value.Length, SAConstantDisagreement.SearchNextDefault, debug);

            var start = search.Index;

            var length = search.Count;

            Info_WordIsolate(search, start, length, debug);

            wordResult = MakeWordIsolateIndexCount(text, start, length, debug);

            return wordResult;
        }
    }
}
