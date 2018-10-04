namespace org.telegram.api.updates.channel.differences
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLUpdatesChannelDifferencesEmpty : TLAbsUpdatesChannelDifferences
    {
        public const int CLASS_ID = 0x3e11affb;
        private const int FLAG_FINAL = 1;
        private const int FLAG_TIMEOUT = 2;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa8, 0x68 })]
        public TLUpdatesChannelDifferencesEmpty()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLUpdatesChannelDifferencesEmpty(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 190, 0x6c, 0x6c, 0x6a, 140 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            base.flags = StreamingUtils.readInt(stream);
            base.pts = StreamingUtils.readInt(stream);
            if ((base.flags & 2) != 0)
            {
                base.timeout = StreamingUtils.readInt(stream);
            }
        }

        public override int getClassId() => 
            0x3e11affb;

        public virtual bool isFinal() => 
            ((base.flags & 1) != 0);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb5, 0x6c, 0x6c, 0x6a, 0x8e })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(base.flags, stream);
            StreamingUtils.writeInt(base.pts, stream);
            if ((base.flags & 2) != 0)
            {
                StreamingUtils.writeInt(base.timeout, stream);
            }
        }

        public override string toString() => 
            "updates.channelDifferenceEmpty#3e11affb";
    }
}

