﻿using Core;

namespace Core.Shared
{
    using System;

    public partial class STContainer
    {
        public static STContainer MakeContainerTerminatorIndexCount(SGDelimiter delimiter_VALUE, SGDelimiter delimiter_TERMINATOR, Boolean _front_back__ANSWER_BOOLEAN__, Int32 rebase, Int32 index, Int32 count, Boolean backward, SGText text, Boolean debug)
        {
            STContainer containerResult = default;

            Debug_ContainerTerminatorIndexCount(delimiter_VALUE, delimiter_TERMINATOR, _front_back__ANSWER_BOOLEAN__, rebase, index, count, backward, text, debug);

            var container_VALUE = Runtime_MakeContainerMany(delimiter_VALUE, rebase, backward, text);

            var container_TERMINATOR = Runtime_MakeContainerMany(delimiter_TERMINATOR, rebase, backward, text);

            containerResult = Runtime_MakeContainerCollider(container_VALUE, container_TERMINATOR, _front_back__ANSWER_BOOLEAN__);

            return containerResult;
        }
    }
}
