using Core;

namespace Core.Shared
{
    using System;

    public partial class STWord
    {
        public static STWord MakeWordInsertIndexCount(SGSymbol symbol, Int32 index, Int32 count, SGText text, Boolean debug)
        {
            STWord wordResult = default;

            var volume = text.Value.Length;

            var search = STSearch.MakeSearchForwardIndexCount(SAConstantVoid.SearchSizeDefault, volume, index, count, SAConstantDisagreement.SearchNextDefault, debug);

            var immutable = STSearchReadOnly.MakeSearchReadOnlyNew(search);

            ArrayList.Add(immutable);

            var word = new STWordInsert(symbol, immutable.Index, immutable.Count, text, debug).Word;

            wordResult = word;

            return wordResult;
        }
    }
}
