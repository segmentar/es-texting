using Core;

namespace Core.Shared
{
    using System;

    public partial class STWord
    {
        public static STWord Runtime_MakeWordReverseIndex(SGText text, Int32 index)
        {
            STWord wordResult = default;

            wordResult = MakeWordReverseIndex(text, index, SAPolicy.WordDebugPolicy);

            return wordResult;
        }
    }
}
