using Core;

namespace Core.Shared
{
    using System;

    public partial class STContainer
    {
        public static STContainer Runtime_MakeContainerMany(SGDelimiter delimiter, Int32 rebase, Boolean backward, SGText text)
        {
            STContainer containerResult = default;

            containerResult = MakeContainerMany(delimiter, rebase, backward, text, SAPolicy.ContainerDebugPolicy);

            return containerResult;
        }
    }
}
