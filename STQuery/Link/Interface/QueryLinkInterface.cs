using Core;

namespace Core.Shared
{
    using System;

    public partial class SAInterface
    {
        public interface IQuerySequence
        {
            STSearchReadOnly Immutable { get; set; }
        }
    }
}
