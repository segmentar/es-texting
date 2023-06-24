using Core;

namespace Core.Shared
{
    using System;

    public partial class STQuery
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
                String.Empty + nameof(STQuery) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "compress",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(Skip) + ':' + ' ' + Skip,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(Next) + ':' + ' ' + Next,
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
                String.Empty + '.' + "compess-raw",
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(Value) + ':' + ' ' + Value, 
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(Quantity) + ':' + ' ' + Quantity,
                String.Empty + '}'
            });
        }
    }
}
