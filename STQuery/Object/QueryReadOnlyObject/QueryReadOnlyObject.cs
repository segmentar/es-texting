using Core;

namespace Core.Shared
{
    using System;

    public partial struct STQueryReadOnly
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
                String.Empty + nameof(STQuery) + ' ' + "::" + ' ' + nameof(STQueryReadOnly) + ' ' + '{',
                String.Empty + '.' + "structure",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(Value) + ':' + ' ' + Value,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(Quantity) + ':' + ' ' + Quantity,
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(Skip) + ':' + ' ' + Skip,
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(Next) + ':' + ' ' + Next,
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
                String.Empty + '}'
            });
        }
    }
}
