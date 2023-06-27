using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial struct STContainerReadOnly
    {
        public readonly ReadOnlyCollection<STToken> TokenCollection;

        public readonly ReadOnlyCollection<STTokenReadOnly> TokenImmutableCollection;

        public readonly Boolean IsDebug;

        public STContainerReadOnly(ReadOnlyCollection<STToken> tokenCollection, ReadOnlyCollection<STTokenReadOnly> tokenImmutableCollection, Boolean isDebug)
        {
            this.TokenCollection = tokenCollection;

            this.TokenImmutableCollection = tokenImmutableCollection;

            this.IsDebug = isDebug;

            return;
        }
    }
}
