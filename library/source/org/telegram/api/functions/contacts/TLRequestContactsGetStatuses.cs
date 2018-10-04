namespace org.telegram.api.functions.contacts
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/tl/TLVector<Lorg/telegram/api/contact/TLContactStatus;>;>;")]
    public class TLRequestContactsGetStatuses : TLMethod
    {
        public const int CLASS_ID = -995929106;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa7, 0x68 })]
        public TLRequestContactsGetStatuses()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestContactsGetStatuses(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(15)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Signature("(Ljava/io/InputStream;Lorg/telegram/tl/TLContext;)Lorg/telegram/tl/TLVector<Lorg/telegram/api/contact/TLContactStatus;>;"), LineNumberTable(0x22)]
        public virtual TLVector deserializeResponse(InputStream stream, TLContext context) => 
            StreamingUtils.readTLVector(stream, context);

        public override int getClassId() => 
            -995929106;

        public override string toString() => 
            "contacts.getStatuses#c4a353ee";
    }
}

