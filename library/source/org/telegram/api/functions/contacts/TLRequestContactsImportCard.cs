namespace org.telegram.api.functions.contacts
{
    using IKVM.Attributes;
    using java.io;
    using java.lang;
    using org.telegram.api.user;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/api/user/TLAbsUser;>;")]
    public class TLRequestContactsImportCard : TLMethod
    {
        public const int CLASS_ID = 0x4fe196fe;
        private TLIntVector exportCard;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xab, 0x68 })]
        public TLRequestContactsImportCard()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestContactsImportCard(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(0x11)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 6, 0x68, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            base.deserializeBody(stream, context);
            this.exportCard = StreamingUtils.readTLIntVector(stream, context);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 180, 0x68, 0x63, 0x90, 0x68, 0x87 })]
        public virtual TLAbsUser deserializeResponse(InputStream stream, TLContext context)
        {
            TLObject obj2 = StreamingUtils.readTLObject(stream, context);
            if (obj2 == null)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IOException("Unable to parse response");
            }
            if (obj2 is TLAbsUser)
            {
                return (TLAbsUser) obj2;
            }
            Throwable.__<suppressFillInStackTrace>();
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected org.telegram.api.user.TLAbsUser, got: ").append(Object.instancehelper_getClass(obj2).getCanonicalName()).toString());
        }

        public override int getClassId() => 
            0x4fe196fe;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0, 0x67, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            base.serializeBody(stream);
            StreamingUtils.writeTLVector(this.exportCard, stream);
        }

        public override string toString() => 
            "contacts.importCard#4fe196fe";
    }
}

