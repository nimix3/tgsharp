namespace org.telegram.api.functions.contacts
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using java.lang;
    using org.telegram.api.input.peer;
    using org.telegram.api.toppeer.category;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/tl/TLBool;>;")]
    public class TLRequestContactsResetTopPeerRating : TLMethod
    {
        private TLAbsTopPeerCategory category;
        public const int CLASS_ID = 0x1ae373ac;
        private TLAbsInputPeer peer;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xad, 0x68 })]
        public TLRequestContactsResetTopPeerRating()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestContactsResetTopPeerRating(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(0x12)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x16, 0x77, 0x77 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.category = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLAbsTopPeerCategory>.Value);
            this.peer = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLAbsInputPeer>.Value);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb6, 0x68, 0x63, 0x70, 0x68, 0x67 })]
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
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected ").append(ClassLiteral<TLBool>.Value.getCanonicalName()).append(", got: ").append(Object.instancehelper_getClass(obj2).getCanonicalName()).toString());
        }

        public virtual TLAbsTopPeerCategory getCategory() => 
            this.category;

        public override int getClassId() => 
            0x1ae373ac;

        public virtual TLAbsInputPeer getPeer() => 
            this.peer;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x10, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.category, stream);
            StreamingUtils.writeTLObject(this.peer, stream);
        }

        public virtual void setCategory(TLAbsTopPeerCategory category)
        {
            this.category = category;
        }

        public virtual void setPeer(TLAbsInputPeer peer)
        {
            this.peer = peer;
        }

        public override string toString() => 
            "contacts.resetTopPeerRating#1ae373ac";
    }
}

