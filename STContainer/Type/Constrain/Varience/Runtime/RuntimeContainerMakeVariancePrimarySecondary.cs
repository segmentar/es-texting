using Core;

namespace Core.Shared
{
    using System;

    public partial class STContainer
    {
        public static STContainer Runtime_MakeContainerVariancePrimarySecondary(SGDelimiter delimiter, Int32 rebase, Int32 primary, Int32 secondary, Boolean backward, SGText text)
        {
            STContainer containerResult = default;

            containerResult = MakeContainerVariancePrimarySecondary(delimiter, rebase, primary, secondary, backward, text, SAPolicy.ContainerDebugPolicy);

            return containerResult;
        }
    }
}
