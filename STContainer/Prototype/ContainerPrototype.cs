using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class STContainer
    {
        public STContainer(List<STToken> tokenList, List<STTokenReadOnly> tokenImmutableList, Boolean debug)
        {
            this.TokenList = tokenList;

            this.TokenImmutableList = tokenImmutableList;

            if (debug is true)
            {
                this.IsDebug = true;
            }
            else
                "false".ToString();

            return;
        }
    }
}
