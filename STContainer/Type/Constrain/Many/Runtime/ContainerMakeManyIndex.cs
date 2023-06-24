using Core;

namespace Core.Shared
{
    using System;

    public partial class STContainer
    {
        public static STContainer Runtime_MakeContainerManyIndex(SGDelimiter delimiter, Int32 rebase, Int32 index, Boolean backward, SGText text)
        {
            STContainer containerResult = default;

            containerResult = MakeContainerManyIndex(rebase, index, backward, text, delimiter, SAPolicy.ContainerDebugPolicy);

            return containerResult;
        }
    }
}
