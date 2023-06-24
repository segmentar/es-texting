using Core;

namespace Core.Shared
{
    using System;

    public partial class STWord
    {
        public static STWord MakeWordReversePrimarySecondary(SGText text, Int32 primary, Int32 secondary, Boolean debug)
        {
            STWord wordResult = default;

            var search = STSearch.MakeSearchForwardPrimarySecondary(SAConstantVoid.SearchSizeDefault, text.Value.Length, primary, secondary, SAConstantDisagreement.SearchNextDefault, debug);

            var start = search.Index;

            var length = search.Count;

            Info_WordReversePrimarySecondary(search, start, length, debug);

            wordResult = MakeWordReverseIndexCount(text, primary, secondary, debug);

            return wordResult;
        }
    }
}
