namespace org.telegram.api.messages.savedgifs
{
    using IKVM.Attributes;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public abstract class TLAbsSavedGifs : TLObject
    {
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x1b)]
        public TLAbsSavedGifs()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAbsSavedGifs(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }
    }
}

