namespace org.telegram.api.functions.messages
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using java.lang;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/tl/TLBool;>;")]
    public class TLRequestMessagesReorderPinnedDialogs : TLMethod
    {
        public const int CLASS_ID = -1784678844;
        private const int FLAG_FORCE = 1;
        private int flags;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/input/peer/TLAbsInputPeer;>;")]
        private TLVector order;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa4, 0x68 })]
        public TLRequestMessagesReorderPinnedDialogs()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestMessagesReorderPinnedDialogs(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(10)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x13, 0x6c, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.order = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLAbsInputPeer>.Value);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xad, 0x68, 0x63, 0x90, 0x68, 0x87 })]
        public virtual TLBool deserializeResponse(InputStream stream, TLContext context)
        {
            TLObject obj2 = StreamingUtils.readTLObject(stream, context);
            if (obj2 == null)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IOException("Unable to parse response");
            }
            if (obj2 is TLBool)
            {
                return (TLBool) obj2;
            }
            Throwable.__<suppressFillInStackTrace>();
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected ").append(ClassLiteral<TLBool>.Value.getName()).append(", got: ").append(Object.instancehelper_getClass(obj2).getCanonicalName()).toString());
        }

        public override int getClassId() => 
            -1784678844;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/input/peer/TLAbsInputPeer;>;")]
        public virtual TLVector getOrder() => 
            this.order;

        private bool isForced() => 
            ((this.flags & 1) != 0);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 13, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeTLVector(this.order, stream);
        }

        [LineNumberTable(new byte[] { 0x9f, 130, 130, 0x63, 0x90, 0x8f })]
        private void setForce(bool flag1)
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

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/input/peer/TLAbsInputPeer;>;)V")]
        public virtual void setOrder(TLVector order)
        {
            this.order = order;
        }

        public override string toString() => 
            "messages.reorderPinnedDialogs#959ff644";
    }
}

