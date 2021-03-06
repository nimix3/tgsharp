﻿namespace org.telegram.api.functions.messages
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

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/api/messages/TLAbsMessages;>;")]
    public class TLRequestMessagesGetMessages : TLMethod
    {
        public const int CLASS_ID = 0x4222fa74;
        private TLIntVector id;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xab, 0x68 })]
        public TLRequestMessagesGetMessages()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestMessagesGetMessages(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(0x11)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x15, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.id = StreamingUtils.readTLIntVector(stream, context);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 180, 0x68, 0x63, 0x70, 0x68, 0x67 })]
        public virtual TLAbsMessages deserializeResponse(InputStream stream, TLContext context)
        {
            TLObject obj2 = StreamingUtils.readTLObject(stream, context);
            if (obj2 == null)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IOException("Unable to parse response");
            }
            if (obj2 is TLAbsMessages)
            {
                return (TLAbsMessages) obj2;
            }
            Throwable.__<suppressFillInStackTrace>();
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected org.telegram.api.messages.TLAbsMessages, got: ").append(Object.instancehelper_getClass(obj2).getCanonicalName()).toString());
        }

        public override int getClassId() => 
            0x4222fa74;

        public virtual TLIntVector getId() => 
            this.id;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x10, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLVector(this.id, stream);
        }

        public virtual void setId(TLIntVector value)
        {
            this.id = value;
        }

        public override string toString() => 
            "messages.getMessages#4222fa74";
    }
}

