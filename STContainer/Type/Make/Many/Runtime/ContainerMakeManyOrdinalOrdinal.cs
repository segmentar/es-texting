﻿using Core;

namespace Core.Shared
{
    using System;

    public partial class STContainer
    {
        public static STContainer Runtime_MakeContainerManyOrdinalOrdinal(SGDelimiter delimiter, Int32 rebase, Int32 ordinal_PRIMARY, Int32 ordinal_SECONDARY, Boolean backward, SGText text)
        {
            STContainer containerResult = default;

            containerResult = MakeContainerManyOrdinalOrdinal(delimiter, rebase, ordinal_PRIMARY, ordinal_SECONDARY, backward, text, SAPolicy.ContainerDebugPolicy);

            return containerResult;
        }
    }
}
