using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class STContainer
    {
        public static STContainer MakeContainerFirstLast(STContainer container, Boolean _first_last__ANSWER__BOOLEAN__, Boolean debug)
        {
            STContainer containerResult = default;

            if (_first_last__ANSWER__BOOLEAN__)
            {
                containerResult = MakeContainerFirst(container, debug);
            }
            else
            {
                containerResult = MakeContainerLast(container, debug);
            }

            return containerResult;
        }
    }
}
