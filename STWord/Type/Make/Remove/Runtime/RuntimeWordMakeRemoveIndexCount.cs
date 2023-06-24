using Core;

namespace Core.Shared
{
    using System;

    public partial class STWord
    {
        public static STWord Runtime_MakeWordRemoveIndexCount(SGText text, Int32 index, Int32 count)
        {
            STWord wordResult = default;

            wordResult = MakeWordRemoveIndexCount(text, index, count, SAPolicy.WordDebugPolicy);

            return wordResult;
        }
    }
}
