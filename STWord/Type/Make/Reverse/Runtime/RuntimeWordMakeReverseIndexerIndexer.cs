using Core;

namespace Core.Shared
{
    using System;

    public partial class STWord
    {
        public static STWord Runtime_MakeWordReverseIndexerIndexer(SGText text, Int32 indexer_START, Int32 indexer_END)
        {
            STWord wordResult = default;

            wordResult = MakeWordReverseIndexerIndexer(text, indexer_START, indexer_END, SAPolicy.WordDebugPolicy);

            return wordResult;
        }
    }
}
