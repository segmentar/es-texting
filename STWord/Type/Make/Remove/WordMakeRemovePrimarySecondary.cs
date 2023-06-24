using Core;

namespace Core.Shared
{
    using System;

    public partial class STWord
    {
        public static STWord MakeWordRemovePrimarySecondary(SGText text, Int32 primary, Int32 secondary, Boolean debug)
        {
            STWord wordResult = default;

            var search = STSearch.MakeSearchForwardPrimarySecondary(SAConstantVoid.SearchSizeDefault, text.Value.Length, primary, secondary, SAConstantDisagreement.TokenNextDefault, debug);

            var start = search.Index;

            var length = search.Count;

            Info_WordRemovePrimarySecondary(search, start, length, debug);

            wordResult = MakeWordRemoveIndexCount(text, start, length, debug);

            return wordResult;
        }
    }
}
