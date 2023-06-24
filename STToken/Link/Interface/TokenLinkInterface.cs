using Core;

namespace Core.Shared
{
    using System;

    public partial class SAInterface
    {
        public interface ITokenSequence
        {
            STQueryReadOnly Immutable { get; set; }
        }
    }
}
