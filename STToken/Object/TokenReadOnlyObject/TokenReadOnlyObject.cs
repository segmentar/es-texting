using Core;

namespace Core.Shared
{
    using System;

    public partial struct STTokenReadOnly
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
                String.Empty + nameof(STToken) + ' ' + "::" + ' ' + nameof(STTokenReadOnly) + ' ' + '{',
                String.Empty + '.' + "structure",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(Symbol) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(Position) + ':' + ' ' + Position,
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(Quantity) + ':' + ' ' + Quantity,
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(Found) + ':' + ' ' + Found,
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(Symbol) + ':',
                String.Empty + Symbol
            });
        }
    }
}
