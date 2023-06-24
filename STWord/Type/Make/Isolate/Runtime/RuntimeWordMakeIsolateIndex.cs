using Core;

namespace Core.Shared
{
    using System;

    public partial class STWord
    {
        public static STWord Runtime_MakeWordIsolateIndex(SGText text, Int32 index)
        {
            STWord wordResult = default;

            wordResult = MakeWordIsolateIndex(text, index, SAPolicy.WordDebugPolicy);

            return wordResult;
        }
    }
}
