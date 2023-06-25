using Core;

namespace Core.Shared
{
    using System;

    public partial struct STWordReadOnly
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
                String.Empty + nameof(STWord) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "structure",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(WordBefore) + ':' + ' ' + $"[{WordBefore}]",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(WordAfter) + ':' + ' ' + $"[{WordAfter}]",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
                String.Empty + '}'
            });
        }
    }
}
