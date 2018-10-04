namespace org.telegram.mtproto.tl
{
    using IKVM.Attributes;
    using java.io;
    using java.util;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class MTFutureSalts : TLObject
    {
        public const int CLASS_ID = -1370486635;
        private int now;
        private long requestId;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/mtproto/tl/MTFutureSalt;>;")]
        private TLVector salts;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb1, 0xe8, 0x38, 0xeb, 0x4a })]
        public MTFutureSalts()
        {
            this.salts = new TLVector();
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected MTFutureSalts(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Signature("(JILorg/telegram/tl/TLVector<Lorg/telegram/mtproto/tl/MTFutureSalt;>;)V"), LineNumberTable(new byte[] { 0x9f, 0xab, 8, 0xab, 0x67, 0x67, 0x67 })]
        public MTFutureSalts(long requestId, int now, TLVector salts)
        {
            this.salts = new TLVector();
            this.requestId = requestId;
            this.now = now;
            this.salts = salts;
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x12, 0x6c, 0x6c, 0x67, 0x6b, 0x66, 0x66, 0x68, 0xed, 0x3d, 230, 0x45 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.requestId = StreamingUtils.readLong(stream);
            this.now = StreamingUtils.readInt(stream);
            int num = StreamingUtils.readInt(stream);
            this.salts.clear();
            int num2 = 0;
            while (true)
            {
                if (num2 >= num)
                {
                    break;
                }
                MTFutureSalt t = new MTFutureSalt();
                t.deserializeBody(stream, context);
                this.salts.add(t);
                num2++;
            }
        }

        public override int getClassId() => 
            -1370486635;

        public virtual int getNow() => 
            this.now;

        public virtual long getRequestId() => 
            this.requestId;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/mtproto/tl/MTFutureSalt;>;")]
        public virtual TLVector getSalts() => 
            this.salts;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 8, 0x6c, 0x6c, 0x71, 0x7f, 1, 0x67, 0x62 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeLong(this.requestId, stream);
            StreamingUtils.writeInt(this.now, stream);
            StreamingUtils.writeInt(this.salts.size(), stream);
            Iterator iterator = this.salts.iterator();
            while (true)
            {
                if (!iterator.hasNext())
                {
                    break;
                }
                ((MTFutureSalt) iterator.next()).serializeBody(stream);
            }
        }

        public override string toString() => 
            "future_salts#ae500895";
    }
}

