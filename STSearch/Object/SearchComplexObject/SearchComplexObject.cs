using Core;

namespace Core.Shared
{
    using System;
    
    public partial struct STSearchComplex
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
                String.Empty + nameof(STSearch) + ' ' + "::" + ' ' + nameof(STSearchComplex) + ' ' + '{',
                String.Empty + '.' + "structure",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(Index) + ':' + ' ' + Index,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(Count) + ':' + ' ' + Count,
                String.Empty + '}'
            });
        }
    }
}
