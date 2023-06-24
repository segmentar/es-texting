using Core;

namespace Core.Shared
{
    using System;

    public partial class STToken
    {
        public static STToken MakeTokenBaseDefault(SGSymbol symbol, Int32 rebase, Boolean backward, Boolean skip, Boolean next, SGText text, Boolean debug)
        {
            STToken tokenResult = default;

            var immutable = new STTokenSequenceDefault(symbol, backward, skip, next, text, debug).Immutable;

            ArrayList.Add(immutable);

            if ((immutable.Value == -1) is true)
            {
                tokenResult = new STToken(symbol, (immutable.Value + rebase), immutable.Quantity, false, debug);
            }
            else
            {
                tokenResult = new STToken(symbol, (immutable.Value + rebase), immutable.Quantity, true, debug);
            }
                
            return tokenResult;
        }
    }
}
