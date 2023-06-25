using Core;

namespace Core.Shared
{
    using System;

    public partial class STWord
    {
        public static STWord Runtime_MakeWordRemoveDefault(SGText text)
        {
            STWord wordResult = default;

            wordResult = MakeWordRemoveDefault(text, SAPolicy.WordDebugPolicy);

            return wordResult;
        }
    }
}
