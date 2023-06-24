﻿using Core;

namespace Core.Shared
{
    using System;

    public partial class STQuery
    {
        public static STQuery Runtime_MakeQueryBackwardPrimarySecondary(SGSymbol symbol, Int32 primary, Int32 secondary, Boolean skip, Boolean next, SGText text)
        {
            STQuery queryResult = default;

            queryResult = MakeQueryBackwardPrimarySecondary(symbol, primary, secondary, skip, next, text, SAPolicy.QueryDebugPolicy);

            return queryResult;
        }
    }
}
