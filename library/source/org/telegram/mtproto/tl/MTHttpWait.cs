namespace org.telegram.mtproto.tl
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class MTHttpWait : TLObject
    {
        public const int CLASS_ID = -1835453025;
        private int max_delay;
        private int max_wait;
        private int wait_after;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xae, 0x68 })]
        public MTHttpWait()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected MTHttpWait(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa8, 0x68, 0x67, 0x67, 0x67 })]
        public MTHttpWait(int max_delay, int wait_after, int max_wait)
        {
            this.max_delay = max_delay;
            this.wait_after = wait_after;
            this.max_wait = max_wait;
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x17, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.max_delay = StreamingUtils.readInt(stream);
            this.wait_after = StreamingUtils.readInt(stream);
            this.max_wait = StreamingUtils.readInt(stream);
        }

        public override int getClassId() => 
            -1835453025;

        public virtual int getMax_delay() => 
            this.max_delay;

        public virtual int getMax_wait() => 
            this.max_wait;

        public virtual int getWait_after() => 
            this.wait_after;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x10, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.max_delay, stream);
            StreamingUtils.writeInt(this.wait_after, stream);
            StreamingUtils.writeInt(this.max_wait, stream);
        }

        public virtual void setMax_delay(int max_delay)
        {
            this.max_delay = max_delay;
        }

        public virtual void setMax_wait(int max_wait)
        {
            this.max_wait = max_wait;
        }

        public virtual void setWait_after(int wait_after)
        {
            this.wait_after = wait_after;
        }

        public override string toString() => 
            "MTHttpWait#9299359f";
    }
}

