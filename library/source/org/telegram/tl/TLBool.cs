namespace org.telegram.tl
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public abstract class TLBool : TLObject
    {
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(8)]
        public TLBool()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLBool(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }
    }
}

