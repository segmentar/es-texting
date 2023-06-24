using Core;

namespace Core.Shared
{
    using System;

    public partial struct STSearchReadOnly  
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
                String.Empty + nameof(STSearch) + ' ' + "::" + ' ' + nameof(STSearchReadOnly) + ' ' + '{',
                String.Empty + '.' + "structure",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(Size) + ':' + ' ' + Size,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(Volume) + ':' + ' ' + Volume,
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(Index) + ':' + ' ' + Index,
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(Count) + ':' + ' ' + Count,
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(Next) + ':' + ' ' + Next,
                String.Empty + '\t' + '~' + "06" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
                String.Empty + '}'
            });
        }
    }
}
