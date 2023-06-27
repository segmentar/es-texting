using Core;

namespace Core.Shared
{
    using System;

    public partial class STContainer
    {
        public static STContainer Runtime_MakeContainerVarianceIndex(SGDelimiter delimiter, Int32 rebase, Int32 index, Boolean backward, SGText text)
        {
            STContainer containerResult = default;

            containerResult = MakeContainerVarianceIndex(delimiter, rebase, index, backward, text, SAPolicy.ContainerDebugPolicy);

            return containerResult;
        }
    }
}
