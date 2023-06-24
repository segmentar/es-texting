using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class STContainer
    {
        public STContainer(IEnumerable<STToken> enumerable, Boolean debug)
        {
            var list = new List<STToken>(enumerable);

            this.TokenList = list;

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
