using Core;

namespace Core.Shared
{
    using System;

    public partial class STWord
    {
        public static STWord MakeWordRemoveIndexerIndexer(SGText text, Int32 indexer_START, Int32 indexer_END, Boolean debug)
        {
            STWord wordResult = default;

            var volume = text.Value.Length;

            var search = STSearch.MakeSearchForwardIndexerIndexer(SAConstantVoid.SearchSizeDefault, volume, indexer_START, indexer_END, SAConstantDisagreement.SearchNextDefault, debug);

            var immutable = STSearchReadOnly.MakeSearchReadOnlyNew(search);

            ArrayList.Add(immutable);

            var word = new STWordRemove(text, immutable.Index, immutable.Count, debug).Word;

            wordResult = word;

            return wordResult;
        }
    }
}
