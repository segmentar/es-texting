using Core;

namespace Core.Shared
{
    using System;

    public partial class STWord
    {
        public static STWord Runtime_MakeWordIsolatePrimarySecondary(SGText text, Int32 primary, Int32 secondary)
        {
            STWord wordResult = default;

            wordResult = MakeWordIsolatePrimarySecondary(text, primary, secondary, SAPolicy.WordDebugPolicy);

            return wordResult;
        }
    }
}
