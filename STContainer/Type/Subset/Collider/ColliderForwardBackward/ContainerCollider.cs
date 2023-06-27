using Core;

namespace Core.Shared
{
    using System;

    public partial class STContainer
    {
        public static STContainer MakeContainerCollider(STContainer container_VALUE, STContainer container_TERMINATOR, Boolean _front_back_, Boolean debug)
        {
            STContainer containerResult = default;

            if (_front_back_)
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
