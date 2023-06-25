using Core;

namespace Core.Shared
{
    using System;

    public partial class STWord
    {
        public static STWord Runtime_MakeWordIsolateDefault(SGText text)
        {
            STWord wordResult = default;

            wordResult = MakeWordIsolateDefault(text, SAPolicy.WordDebugPolicy);

            return wordResult;
        }
    }
}
