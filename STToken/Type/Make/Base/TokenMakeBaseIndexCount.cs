﻿using Core;

namespace Core.Shared
{
    using System;

    public partial class STToken
    {
        public static STToken MakeTokenBaseIndexCount(SGSymbol symbol, Int32 rebase, Int32 index, Int32 count, Boolean backward, Boolean skip, Boolean next, SGText text, Boolean debug)
        {
            STToken tokenResult = default;

            var immutable = new STTokenSequenceIndexCount(symbol, index, count, backward, skip, next, text, debug).Immutable;

            ArrayList.Add(immutable);

            var position = (immutable.Value + rebase);

            var safe_match__ZERO_TEN_value = (immutable.Value == -1) is true;

            if (safe_match__ZERO_TEN_value)
            {
                tokenResult = new STToken(symbol, position, immutable.Quantity, SAConstantDisagreement.TokenNotFoundDefault, debug);
            }
            else
            {
                tokenResult = new STToken(symbol, position, immutable.Quantity, SAConstantAgreement.TokenFoundDefault, debug);
            }

            return tokenResult;
        }
    }
}
