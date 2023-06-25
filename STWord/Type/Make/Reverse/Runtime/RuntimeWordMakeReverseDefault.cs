using Core;

namespace Core.Shared
{
    using System;

    public partial class STWord
    {
        public static STWord Runtime_MakeWordReverseDefault(SGText text)
        {
            STWord wordResult = default;

            wordResult = MakeWordReverseDefault(text, SAPolicy.WordDebugPolicy);

            return wordResult;
        }
    }
}
