using Core;

namespace Core.Shared
{
    using System;

    public partial struct STWordReadOnly
    {
        public static STWordReadOnly MakeWordReadOnlyNew(STWord word)
        {
            STWordReadOnly immutableResult = default;

            immutableResult = new STWordReadOnly(
                wordBefore: word.WordBefore,
                wordAfter: word.WordAfter,
                isDebug: word.IsDebug
                );

            return immutableResult;
        }
    }
}
