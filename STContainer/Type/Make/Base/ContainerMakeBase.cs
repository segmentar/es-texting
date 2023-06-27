using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class STContainer
    {
        public static STContainer MakeContainerBase(IEnumerable<STToken> enumerable, Boolean debug)
        {
            STContainer containerResult = default;

            var list = new List<STToken>(enumerable);

            var list_IMMUTABLE = new List<STTokenReadOnly>();

            foreach (STToken token in list)
            {
                var immutable = STTokenReadOnly.MakeTokenReadOnlyNew(token);

                list_IMMUTABLE.Add(immutable);

                continue;
            }

            containerResult = new STContainer(list, list_IMMUTABLE, debug);

            return containerResult;
        }
    }
}
