namespace org.telegram.api.input.chat.photo
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using org.telegram.api.input.file;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLInputChatUploadedPhoto : TLAbsInputChatPhoto
    {
        public const int CLASS_ID = -1837345356;
        private TLAbsInputFile file;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xab, 0x68 })]
        public TLInputChatUploadedPhoto()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLInputChatUploadedPhoto(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 11, 0x77 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.file = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLAbsInputFile>.Value);
        }

        public override int getClassId() => 
            -1837345356;

        public virtual TLAbsInputFile getFile() => 
            this.file;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 6, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.file, stream);
        }

        public virtual void setFile(TLAbsInputFile file)
        {
            this.file = file;
        }

        public override string toString() => 
            "inputChatUploadedPhoto#927c55b4";
    }
}

