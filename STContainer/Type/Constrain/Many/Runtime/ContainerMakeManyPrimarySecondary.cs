using Core;

namespace Core.Shared
{
    using System;

    public partial class STContainer
    {
        public static STContainer Runtime_MakeContainerManyPrimarySecondary(Int32 rebase, Int32 primary, Int32 secondary, Boolean backward, SGText text, SGDelimiter delimiter)
        {
            STContainer containerResult = default;

            containerResult = MakeContainerManyPrimarySecondary(rebase, primary, secondary, backward, text, delimiter, SAPolicy.ContainerDebugPolicy);

            return containerResult;
        }
    }
}
