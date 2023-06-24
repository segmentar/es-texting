using Core;

namespace Core.Shared
{
    using System;
    
    public partial class STSearch
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
                String.Empty + nameof(STSearch) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "compress",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(Next) + ':' + ' ' + Next,
                String.Empty + '.' + "compress-raw",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(Size) + ':' + ' ' + Size,
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(Volume) + ':' + ' ' + Volume,
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(Index) + ':' + ' ' + Index,
                String.Empty + '\t' + '~' + "06" + ' ' + nameof(Count) + ':' + ' ' + Count,
                String.Empty + '}'
            });
        }
    }
}
