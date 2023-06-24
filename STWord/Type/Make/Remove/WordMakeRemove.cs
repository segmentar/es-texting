using Core;

namespace Core.Shared
{
    using System;

    public partial class STWord
    {
        public static STWord MakeWordRemove(SGText text, Boolean debug)
        {
            STWord wordResult = default;

            var search = STSearch.MakeSearchForwardDefault(SAConstantVoid.SearchSizeDefault, text.Value.Length, SAConstantDisagreement.TokenNextDefault, debug);

            var start = search.Index;

            var length = search.Count;

            Info_WordRemove(search, start, length, debug);

            wordResult = MakeWordRemoveIndexCount(text, start, length, debug);

            return wordResult;
        }
    }
}
