namespace org.telegram.tl
{
    using IKVM.Attributes;
    using ikvm.internal;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLVector<Ljava/lang/String;>;")]
    public class TLStringVector : TLVector
    {
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x97, 0x68, 0x6d })]
        public TLStringVector()
        {
            this.setDestClass(ClassLiteral<String>.Value);
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLStringVector(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override string toString() => 
            "vector<string>#1cb5c415";
    }
}

