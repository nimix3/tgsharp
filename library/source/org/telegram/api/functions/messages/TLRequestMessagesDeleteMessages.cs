namespace org.telegram.api.functions.messages
{
    using IKVM.Attributes;
    using java.io;
    using java.lang;
    using org.telegram.api.messages;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/api/messages/TLAffectedMessages;>;")]
    public class TLRequestMessagesDeleteMessages : TLMethod
    {
        public const int CLASS_ID = -443640366;
        private const int FLAG_REVOKE = 1;
        private int flags;
        private TLIntVector id;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa5, 0x68 })]
        public TLRequestMessagesDeleteMessages()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestMessagesDeleteMessages(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(14)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x13, 0x6c, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.id = StreamingUtils.readTLIntVector(stream, context);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xae, 0x68, 0x63, 0x70, 0x68, 0x67 })]
        public virtual TLAffectedMessages deserializeResponse(InputStream stream, TLContext context)
        {
            TLObject obj2 = StreamingUtils.readTLObject(stream, context);
            if (obj2 == null)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IOException("Unable to parse response");
            }
            if (obj2 is TLAffectedMessages)
            {
                return (TLAffectedMessages) obj2;
            }
            Throwable.__<suppressFillInStackTrace>();
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected org.telegram.api.messages.TLAffectedMessages, got: ").append(Object.instancehelper_getClass(obj2).getCanonicalName()).toString());
        }

        public override int getClassId() => 
            -443640366;

        public virtual TLIntVector getId() => 
            this.id;

        private bool isRevoke() => 
            ((this.flags & 1) != 0);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 13, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeTLVector(this.id, stream);
        }

        public virtual void setId(TLIntVector id)
        {
            this.id = id;
        }

        [LineNumberTable(new byte[] { 0x9f, 130, 130, 0x63, 0x90, 0x8f })]
        private void setRevoke(bool flag1)
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

        public override string toString() => 
            "messages.deleteMessages#e58e95d2";
    }
}

