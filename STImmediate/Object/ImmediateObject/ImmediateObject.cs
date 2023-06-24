using Core;

namespace Core.Shared
{
    using System;

    public partial class STImmediate
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
                String.Empty + nameof(STImmediate) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "compress",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
                String.Empty + '.' + "compress-raw",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(ImmediateBefore) + ':' + ' ' + $"[{ImmediateBefore}]",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(ImmediateAfter) + ':' + ' ' + $"[{ImmediateAfter}]",
                String.Empty + '}'
            });
        }
    }
}
