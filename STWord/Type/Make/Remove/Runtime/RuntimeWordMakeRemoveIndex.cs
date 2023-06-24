using Core;

namespace Core.Shared
{
    using System;

    public partial class STWord
    {
        public static STWord Runtime_MakeWordRemoveIndex(SGText text, Int32 index)
        {
            STWord wordResult = default;

            wordResult = MakeWordRemoveIndex(text, index, SAPolicy.WordDebugPolicy);

            return wordResult;
        }
    }
}
