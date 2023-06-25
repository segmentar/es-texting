using Core;

namespace Core.Shared
{
    using System;

    public partial class STWord
    {
        public static STWord MakeWordReversePrimarySecondary(SGText text, Int32 primary, Int32 secondary, Boolean debug)
        {
            STWord wordResult = default;

            var volume = text.Value.Length;

            var search = STSearch.MakeSearchForwardPrimarySecondary(SAConstantVoid.SearchSizeDefault, volume, primary, secondary, SAConstantDisagreement.SearchNextDefault, debug);

            var immutable = STSearchReadOnly.MakeSearchReadOnlyNew(search);

            ArrayList.Add(immutable);

            var word = new STWordReverse(text, immutable.Index, immutable.Count, debug).Word;

            wordResult = word;

            return wordResult;
        }
    }
}
