using Core;

namespace Core.Shared
{
    using System;

    public partial class STWord
    {
        public static STWord MakeWordRemoveDefault(SGText text, Boolean debug)
        {
            STWord wordResult = default;

            var volume = text.Value.Length;

            var search = STSearch.MakeSearchForwardDefault(SAConstantVoid.SearchSizeDefault, volume, SAConstantDisagreement.SearchNextDefault, debug);

            var immutable = STSearchReadOnly.MakeSearchReadOnlyNew(search);

            ArrayList.Add(immutable);

            var word = new STWordRemove(text, immutable.Index, immutable.Count, debug).Word;

            wordResult = word;

            return wordResult;
        }
    }
}
