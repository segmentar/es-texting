using Core;

namespace Core.Shared
{
    using System;

    public partial class STToken
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
                String.Empty + nameof(STToken) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "compress",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(Found) + ':' + ' ' + Found,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
                String.Empty + '.' + "compress-raw",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(Symbol) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(Position) + ':' + ' ' + Position,
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(Quantity) + ':' + ' ' + Quantity,
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(Symbol) + ':',
                String.Empty + Symbol
            });
        }
    }
}
