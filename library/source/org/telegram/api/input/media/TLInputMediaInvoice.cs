namespace org.telegram.api.input.media
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using org.telegram.api.input.paymentapi;
    using org.telegram.api.paymentapi;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLInputMediaInvoice : TLAbsInputMedia
    {
        public const int CLASS_ID = -1844103547;
        private string description;
        private const int FLAG_PHOTO = 1;
        private int flags;
        private TLInvoice invoice;
        private TLBytes payload;
        private TLInputWebDocument photo;
        private string provider;
        private string startParam;
        private string title;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xad, 0x68 })]
        public TLInputMediaInvoice()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLInputMediaInvoice(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x41, 0x6c, 0x6c, 0x6c, 0x6a, 0x97, 0x77, 0x6d, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.title = StreamingUtils.readTLString(stream);
            this.description = StreamingUtils.readTLString(stream);
            if ((this.flags & 1) != 0)
            {
                this.photo = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLInputWebDocument>.Value);
            }
            this.invoice = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLInvoice>.Value);
            this.payload = StreamingUtils.readTLBytes(stream, context);
            this.provider = StreamingUtils.readTLString(stream);
            this.startParam = StreamingUtils.readTLString(stream);
        }

        public override int getClassId() => 
            -1844103547;

        public virtual string getDescription() => 
            this.description;

        public virtual TLInvoice getInvoice() => 
            this.invoice;

        public virtual TLBytes getPayload() => 
            this.payload;

        public virtual TLInputWebDocument getPhoto() => 
            this.photo;

        public virtual string getProvider() => 
            this.provider;

        public virtual string getStartParam() => 
            this.startParam;

        public virtual string getTitle() => 
            this.title;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x33, 0x6c, 0x6c, 0x6c, 0x6a, 140, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeTLString(this.title, stream);
            StreamingUtils.writeTLString(this.description, stream);
            if ((this.flags & 1) != 0)
            {
                StreamingUtils.writeTLObject(this.photo, stream);
            }
            StreamingUtils.writeTLObject(this.invoice, stream);
            StreamingUtils.writeTLBytes(this.payload, stream);
            StreamingUtils.writeTLString(this.provider, stream);
            StreamingUtils.writeTLString(this.startParam, stream);
        }

        public virtual void setDescription(string description)
        {
            this.description = description;
        }

        public virtual void setInvoice(TLInvoice invoice)
        {
            this.invoice = invoice;
        }

        public virtual void setPayload(TLBytes payload)
        {
            this.payload = payload;
        }

        [LineNumberTable(new byte[] { 9, 0x63, 0x91, 0x8e, 0x67 })]
        public virtual void setPhoto(TLInputWebDocument photo)
        {
            if (photo == null)
            {
                this.flags &= -2;
            }
            else
            {
                this.flags |= 1;
            }
            this.photo = photo;
        }

        public virtual void setProvider(string provider)
        {
            this.provider = provider;
        }

        public virtual void setStartParam(string startParam)
        {
            this.startParam = startParam;
        }

        public virtual void setTitle(string title)
        {
            this.title = title;
        }

        public override string toString() => 
            "inputMediaInvoice#92153685";
    }
}

