namespace org.telegram.api.document.attribute
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLDocumentAttributeAudio : TLAbsDocumentAttribute
    {
        public const int CLASS_ID = -1739392570;
        private int duration;
        private const int FLAG_PERFORMER = 2;
        private const int FLAG_TITLE = 1;
        private const int FLAG_UNUSED3 = 8;
        private const int FLAG_UNUSED4 = 0x10;
        private const int FLAG_UNUSED5 = 0x20;
        private const int FLAG_UNUSED6 = 0x40;
        private const int FLAG_UNUSED7 = 0x80;
        private const int FLAG_UNUSED8 = 0x100;
        private const int FLAG_UNUSED9 = 0x200;
        private const int FLAG_VOICE = 0x400;
        private const int FLAG_WAVEFORM = 4;
        private int flags;
        private string performer;
        private string title;
        private TLBytes waveform;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 2, 0x68 })]
        public TLDocumentAttributeAudio()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLDocumentAttributeAudio(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x4b, 0x6c, 0x6c, 0x6a, 140, 0x6a, 140, 0x6a, 0x8d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.duration = StreamingUtils.readInt(stream);
            if ((this.flags & 1) != 0)
            {
                this.title = StreamingUtils.readTLString(stream);
            }
            if ((this.flags & 2) != 0)
            {
                this.performer = StreamingUtils.readTLString(stream);
            }
            if ((this.flags & 4) != 0)
            {
                this.waveform = StreamingUtils.readTLBytes(stream, context);
            }
        }

        public override int getClassId() => 
            -1739392570;

        public virtual int getDuration() => 
            this.duration;

        public virtual string getPerformer() => 
            this.performer;

        public virtual string getTitle() => 
            this.title;

        public virtual TLBytes getWaveform() => 
            this.waveform;

        public virtual bool isVoice() => 
            ((this.flags & 0x400) != 0);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x3b, 0x6c, 0x6c, 0x6a, 140, 0x6a, 140, 0x6a, 0x8e })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeInt(this.duration, stream);
            if ((this.flags & 1) != 0)
            {
                StreamingUtils.writeTLString(this.title, stream);
            }
            if ((this.flags & 2) != 0)
            {
                StreamingUtils.writeTLString(this.performer, stream);
            }
            if ((this.flags & 4) != 0)
            {
                StreamingUtils.writeTLBytes(this.waveform, stream);
            }
        }

        public virtual void setDuration(int duration)
        {
            this.duration = duration;
        }

        public virtual void setPerformer(string performer)
        {
            this.performer = performer;
        }

        public virtual void setTitle(string title)
        {
            this.title = title;
        }

        public virtual void setWaveform(TLBytes waveform)
        {
            this.waveform = waveform;
        }

        public override string toString() => 
            "documentAttributeAudio#9852f9c6";
    }
}

