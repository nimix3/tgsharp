namespace org.telegram.api.foundgif
{
    using IKVM.Attributes;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public abstract class TLAbsFoundGif : TLObject
    {
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x1b)]
        public TLAbsFoundGif()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAbsFoundGif(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }
    }
}

