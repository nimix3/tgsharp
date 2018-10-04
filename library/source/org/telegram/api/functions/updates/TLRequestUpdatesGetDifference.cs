namespace org.telegram.api.functions.updates
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using java.lang;
    using org.telegram.api.updates.difference;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/api/updates/difference/TLAbsDifference;>;")]
    public class TLRequestUpdatesGetDifference : TLMethod
    {
        public const int CLASS_ID = 0x25939651;
        private int date;
        private const int FLAG_PTS_TOTAL_LIMIT = 1;
        private int flags;
        private int pts;
        private int ptsTotalLimit;
        private int qts;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa8, 0x68 })]
        public TLRequestUpdatesGetDifference()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestUpdatesGetDifference(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(13)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x34, 0x6c, 0x6c, 0x6a, 140, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.pts = StreamingUtils.readInt(stream);
            if ((this.flags & 1) != 0)
            {
                this.ptsTotalLimit = StreamingUtils.readInt(stream);
            }
            this.date = StreamingUtils.readInt(stream);
            this.qts = StreamingUtils.readInt(stream);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb1, 0x68, 0x63, 0x70, 0x68, 0x67, 0x7f, 10 })]
        public virtual TLAbsDifference deserializeResponse(InputStream stream, TLContext context)
        {
            TLObject obj2 = StreamingUtils.readTLObject(stream, context);
            if (obj2 == null)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IOException("Unable to parse response");
            }
            if (obj2 is TLAbsDifference)
            {
                return (TLAbsDifference) obj2;
            }
            Throwable.__<suppressFillInStackTrace>();
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected ").append(ClassLiteral<TLAbsDifference>.Value.getCanonicalName()).append(", got: ").append(Object.instancehelper_getClass(obj2).getCanonicalName()).toString());
        }

        public override int getClassId() => 
            0x25939651;

        public virtual int getDate() => 
            this.date;

        public virtual int getFlags() => 
            this.flags;

        public virtual int getPts() => 
            this.pts;

        public virtual int getPtsTotalLimit() => 
            this.ptsTotalLimit;

        public virtual int getQts() => 
            this.qts;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x29, 0x6c, 0x6c, 0x6a, 140, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeInt(this.pts, stream);
            if ((this.flags & 1) != 0)
            {
                StreamingUtils.writeInt(this.ptsTotalLimit, stream);
            }
            StreamingUtils.writeInt(this.date, stream);
            StreamingUtils.writeInt(this.qts, stream);
        }

        public virtual void setDate(int date)
        {
            this.date = date;
        }

        public virtual void setPts(int pts)
        {
            this.pts = pts;
        }

        [LineNumberTable(new byte[] { 0x9f, 0x7a, 130, 0x63, 0x90, 0x8f })]
        private void setPtsTotalLimit(bool flag1)
        {
            if (flag1)
            {
                this.flags |= 1;
            }
            else
            {
                this.flags &= -2;
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 11, 110, 0x6c })]
        public virtual void setPtsTotalLimit(int ptsTotalLimit)
        {
            this.ptsTotalLimit = (ptsTotalLimit <= 0) ? 0 : ptsTotalLimit;
            this.setPtsTotalLimit(ptsTotalLimit > 0);
        }

        public virtual void setQts(int qts)
        {
            this.qts = qts;
        }

        public override string toString() => 
            "updates.getDifference#25939651";
    }
}

