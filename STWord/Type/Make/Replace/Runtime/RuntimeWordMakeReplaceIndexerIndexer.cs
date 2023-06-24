using Core;

namespace Core.Shared
{
    using System;

    public partial class STWord
    {
        public static STWord Runtime_MakeWordReplaceIndexerIndexer(SGDelimiter delimiter, SGSymbol symbol, Int32 indexer_STAT, Int32 indexer_END, SGText text)
        {
            STWord wordResult = default;

            wordResult = MakeWordReplaceIndexerIndexer(delimiter, symbol, indexer_STAT, indexer_END, text, SAPolicy.WordDebugPolicy);

            return wordResult;
        }
    }
}
