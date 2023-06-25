using Core;

namespace Core.Shared
{
    using System;

    public partial class STWord
    {
        public static STWord MakeWordIsolateIndex(SGText text, Int32 index, Boolean debug)
        {
            STWord wordResult = default;

            var volume = text.Value.Length;

            var search = STSearch.MakeSearchForwardIndex(SAConstantVoid.SearchSizeDefault, volume, index, SAConstantDisagreement.SearchNextDefault, debug);

            var immutable = STSearchReadOnly.MakeSearchReadOnlyNew(search);

            ArrayList.Add(immutable);

            var word = new STWordIsolate(text, immutable.Index, immutable.Count, debug).Word;

            wordResult = word;

            return wordResult;
        }
    }
}
