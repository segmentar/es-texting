using Core;

namespace Core.Shared
{
    using System;

    public partial class STWord
    {
        public static STWord Runtime_MakeWordRemovePrimarySecondary(SGText text, Int32 primary, Int32 secondary)
        {
            STWord wordResult = default;

            wordResult = MakeWordRemovePrimarySecondary(text, primary, secondary, SAPolicy.WordDebugPolicy);

            return wordResult;
        }
    }
}
