using Core;

namespace Core.Shared
{
    using System;

    public partial struct STTokenReadOnly
    {
        public static STTokenReadOnly MakeTokenReadOnlyNew(STToken token)
        {
            STTokenReadOnly tokenResult = default;

            tokenResult = new STTokenReadOnly(
                symbol: token.Symbol,
                position: token.Position,
                quantity: token.Quantity,
                found: token.Found,
                isDebug: token.IsDebug
                );

            return tokenResult;
        }
    }
}
