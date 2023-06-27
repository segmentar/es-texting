using Core;

namespace Core.Shared
{
    using System;

    public partial struct STContainerReadOnly
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
                String.Empty + nameof(STContainer) + ' ' + "::" + ' ' + nameof(STContainerReadOnly) + ' ' + '{',
                String.Empty + '.' + "structure",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(TokenCollection) + ' ' + ". . ." + ' ' + $"[{TokenCollection.Count}]",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(TokenImmutableCollection) + ' ' + ". . ." + ' ' + $"[{TokenImmutableCollection.Count}]",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(TokenCollection) + ':',
                String.Empty + String.Join('\n'.ToString(), TokenCollection),
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(TokenImmutableCollection) + ':',
                String.Empty + String.Join('\n'.ToString(), TokenImmutableCollection)
            });
        }
    }
}
