namespace org.telegram.tl
{
    using IKVM.Attributes;
    using ikvm.internal;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLVector<Ljava/lang/Long;>;")]
    public class TLLongVector : TLVector
    {
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x97, 0x68, 0x6d })]
        public TLLongVector()
        {
            this.setDestClass(ClassLiteral<Long>.Value);
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLLongVector(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override string toString() => 
            "vector<long>#1cb5c415";
    }
}

