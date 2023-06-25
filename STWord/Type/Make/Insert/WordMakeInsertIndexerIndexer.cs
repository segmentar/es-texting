using Core;

namespace Core.Shared
{
    using System;

    public partial class STWord
    {
        public static STWord MakeWordInsertIndexerIndexer(SGSymbol symbol, Int32 indexer_START, Int32 indexer_END, SGText text, Boolean debug)
        {
            STWord wordResult = default;

            var volume = text.Value.Length;

            var search = STSearch.MakeSearchForwardIndexerIndexer(SAConstantVoid.SearchSizeDefault, volume, indexer_START, indexer_END, SAConstantDisagreement.SearchNextDefault, debug);

            var immutable = STSearchReadOnly.MakeSearchReadOnlyNew(search);

            ArrayList.Add(immutable);

            var word = new STWordInsert(symbol, immutable.Index, immutable.Count, text, debug).Word;

            wordResult = word;

            return wordResult;
        }
    }
}
