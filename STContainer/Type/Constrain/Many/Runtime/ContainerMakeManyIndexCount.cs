using Core;

namespace Core.Shared
{
    using System;

    public partial class STContainer
    {
        public static STContainer Runtime_MakeContainerManyIndexCount(Int32 rebase, Int32 index, Int32 count, Boolean backward, SGText text, SGDelimiter delimiter)
        {
            STContainer containerResult = default;

            containerResult = MakeContainerManyIndexCount(rebase, index, count, backward, text, delimiter, SAPolicy.ContainerDebugPolicy);

            return containerResult;
        }
    }
}
