using Core;

namespace Core.Shared
{
    using System;

    public partial struct STImmediateReadOnly
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
                String.Empty + nameof(STImmediate) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "structure",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(ImmediateBefore) + ':' + ' ' + $"[{ImmediateBefore}]",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(ImmediateAfter) + ':' + ' ' + $"[{ImmediateAfter}]",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
                String.Empty + '}'
            });
        }
    }
}
