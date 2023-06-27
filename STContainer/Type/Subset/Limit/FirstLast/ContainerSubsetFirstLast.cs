using Core;

namespace Core.Shared
{
    using System;

    public partial class STContainer
    {
        public static STContainer ContainerFirstLastSubset(STContainer container, Boolean _first_last_, Boolean debug)
        {
            STContainer containerResult = default;

            if (_first_last_)
            {
                containerResult = ContainerFirstSubset(container, debug);
            }
            else
            {
                containerResult = ContainerLastSubset(container, debug);
            }

            return containerResult;
        }
    }
}
