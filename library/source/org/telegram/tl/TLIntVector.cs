namespace org.telegram.tl
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.lang;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLVector<Ljava/lang/Integer;>;")]
    public class TLIntVector : TLVector
    {
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x97, 0x68, 0x6d })]
        public TLIntVector()
        {
            this.setDestClass(ClassLiteral<Integer>.Value);
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLIntVector(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa1, 0x6c, 0x67, 0x34, 0xa6 })]
        public virtual int[] toIntArray()
        {
            int[] numArray = new int[this.size()];
            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = ((Integer) this.get(i)).intValue();
            }
            return numArray;
        }

        public override string toString() => 
            "vector<int>#1cb5c415";
    }
}

