﻿namespace org.telegram.api.functions.contacts
{
    using IKVM.Attributes;
    using java.io;
    using java.lang;
    using org.telegram.api.input.user;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/tl/TLBool;>;")]
    public class TLRequestContactsUnblock : TLMethod
    {
        public const int CLASS_ID = -448724803;
        private TLAbsInputUser id;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xab, 0x68 })]
        public TLRequestContactsUnblock()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestContactsUnblock(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(0x11)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x15, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.id = StreamingUtils.readTLObject(stream, context);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 180, 0x68, 0x63, 0x70, 0x68, 0x67 })]
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
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected org.telegram.tl.TLBool, got: ").append(Object.instancehelper_getClass(obj2).getCanonicalName()).toString());
        }

        public override int getClassId() => 
            -448724803;

        public virtual TLAbsInputUser getId() => 
            this.id;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x10, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.id, stream);
        }

        public virtual void setId(TLAbsInputUser value)
        {
            this.id = value;
        }

        public override string toString() => 
            "contacts.unblock#e54100bd";
    }
}

