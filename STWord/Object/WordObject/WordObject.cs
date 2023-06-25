using Core;

namespace Core.Shared
{
    using System;

    public partial class STWord
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
                String.Empty + nameof(STWord) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "compress",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
                String.Empty + '.' + "compress-raw",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(WordBefore) + ':' + ' ' + $"[{WordBefore}]",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(WordAfter) + ':' + ' ' + $"[{WordAfter}]",
                String.Empty + '}'
            });
        }
    }
}
