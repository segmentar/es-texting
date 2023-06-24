using Core;

namespace Core.Shared
{
    using System;

    public partial class STWord
    {
        public static STWord Runtime_MakeWordRemove(SGText text)
        {
            STWord wordResult = default;

            wordResult = MakeWordRemove(text, SAPolicy.WordDebugPolicy);

            return wordResult;
        }
    }
}
