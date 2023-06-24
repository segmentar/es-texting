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
                String.Empty + '.' + "compressed",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
                String.Empty + '.' + "compressed-raw",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(Before) + ':' + ' ' + $"[{Before}]",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(After) + ':' + ' ' + $"[{After}]",
                String.Empty + '}'
            });
        }
    }
}
