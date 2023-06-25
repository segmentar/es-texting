using Core;

namespace Core.Shared
{
    using System;

    public partial struct STTokenReadOnly
    {
        public static STTokenReadOnly MakeTokenReadOnlyNew(STToken token)
        {
            STTokenReadOnly immutableResult = default;

            immutableResult = new STTokenReadOnly(
                symbol: token.Symbol,
                position: token.Position,
                quantity: token.Quantity,
                found: token.Found,
                isDebug: token.IsDebug
                );

            return immutableResult;
        }
    }
}
