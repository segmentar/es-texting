using Core;

namespace Core.Shared
{
    using System;

    public partial class STWord
    {
        public static STWord Runtime_MakeWordIsolateIndexCount(SGText text, Int32 index, Int32 count)
        {
            STWord wordResult = default;

            wordResult = MakeWordIsolateIndexCount(text, index, count, SAPolicy.WordDebugPolicy);

            return wordResult;
        }
    }
}
