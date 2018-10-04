namespace org.telegram.api.functions.account
{
    using IKVM.Attributes;
    using java.io;
    using java.lang;
    using org.telegram.api.account;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/api/account/TLAccountPasswordSettings;>;")]
    public class TLRequestAccountGetPasswordSettings : TLMethod
    {
        public const int CLASS_ID = -1131605573;
        private TLBytes currentPasswordHash;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xab, 0x68 })]
        public TLRequestAccountGetPasswordSettings()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestAccountGetPasswordSettings(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(0x11)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x15, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.currentPasswordHash = StreamingUtils.readTLBytes(stream, context);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 180, 0x68, 0x63, 0x70, 0x68, 0x67 })]
        public virtual TLAccountPasswordSettings deserializeResponse(InputStream stream, TLContext context)
        {
            TLObject obj2 = StreamingUtils.readTLObject(stream, context);
            if (obj2 == null)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IOException("Unable to parse response");
            }
            if (obj2 is TLAccountPasswordSettings)
            {
                return (TLAccountPasswordSettings) obj2;
            }
            Throwable.__<suppressFillInStackTrace>();
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected org.telegram.tl.TLAccountPasswordSettings, got: ").append(Object.instancehelper_getClass(obj2).getCanonicalName()).toString());
        }

        public override int getClassId() => 
            -1131605573;

        public virtual TLBytes getCurrentPasswordHash() => 
            this.currentPasswordHash;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x10, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLBytes(this.currentPasswordHash, stream);
        }

        public virtual void setCurrentPasswordHash(TLBytes currentPasswordHash)
        {
            this.currentPasswordHash = currentPasswordHash;
        }

        public override string toString() => 
            "account.getPasswordSettings#bc8d11bb";
    }
}

