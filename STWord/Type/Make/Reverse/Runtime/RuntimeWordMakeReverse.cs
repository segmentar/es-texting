using Core;

namespace Core.Shared
{
    using System;

    public partial class STWord
    {
        public static STWord Runtime_MakeWordReverse(SGText text)
        {
            STWord wordResult = default;

            wordResult = MakeWordReverse(text, SAPolicy.WordDebugPolicy);

            return wordResult;
        }
    }
}
