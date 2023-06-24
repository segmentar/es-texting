using Core;

namespace Core.Shared
{
    using System;

    public partial class STWord
    {
        public static STWord Runtime_MakeWordIsolate(SGText text)
        {
            STWord wordResult = default;

            wordResult = MakeWordIsolate(text, SAPolicy.WordDebugPolicy);

            return wordResult;
        }
    }
}
