using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class STContainer
    {
        public static STContainer MakeContainerCollider(STContainer container_VALUE, STContainer container_TERMINATOR, Boolean _front_back__ANSWER_BOOLEAN__, Boolean debug)
        {
            STContainer containerResult = default;

            if (_front_back__ANSWER_BOOLEAN__)
            {
                containerResult = MakeContainerColliderForward(container_VALUE, container_TERMINATOR, debug);
            }
            else
            {
                containerResult = MakeContainerColliderBackward(container_VALUE, container_TERMINATOR, debug);
            }

            return containerResult;
        }
    }
}
