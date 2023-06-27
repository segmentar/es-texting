using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial struct STContainerReadOnly
    {
        public static STContainerReadOnly MakeContainerReadOnlyNew(STContainer container)
        {
            STContainerReadOnly immutableResult = default;

            immutableResult = new STContainerReadOnly(
                tokenCollection: new ReadOnlyCollection<STToken>(container.TokenList),
                tokenImmutableCollection: new ReadOnlyCollection<STTokenReadOnly>(container.TokenImmutableList),
                isDebug: container.IsDebug                
                );

            return immutableResult;
        }
    }
}
