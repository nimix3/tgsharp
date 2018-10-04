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

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/tl/TLIntVector;>;")]
    public class TLRequestContactsExportCard : TLMethod
    {
        public const int CLASS_ID = -2065352905;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa6, 0x68 })]
        public TLRequestContactsExportCard()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestContactsExportCard(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(14)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(0x21)]
        public virtual TLIntVector deserializeResponse(InputStream stream, TLContext context) => 
            StreamingUtils.readTLIntVector(stream, context);

        public override int getClassId() => 
            -2065352905;

        public override string toString() => 
            "contacts.exportCard#84e53737";
    }
}

