namespace org.telegram.api.input.game
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using org.telegram.api.input.user;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLInputGameShortName : TLAbsInputGame
    {
        private TLAbsInputUser botId;
        public const int CLASS_ID = -1020139510;
        private string shortName;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x11)]
        public TLInputGameShortName()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLInputGameShortName(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 2, 0x77, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.botId = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLAbsInputUser>.Value);
            this.shortName = StreamingUtils.readTLString(stream);
        }

        public virtual TLAbsInputUser getBotId() => 
            this.botId;

        public override int getClassId() => 
            -1020139510;

        public virtual string getShortName() => 
            this.shortName;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xbc, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.botId, stream);
            StreamingUtils.writeTLString(this.shortName, stream);
        }

        public virtual void setBotId(TLAbsInputUser botId)
        {
            this.botId = botId;
        }

        public virtual void setShortName(string shortName)
        {
            this.shortName = shortName;
        }

        public override string toString() => 
            "inputGameShortName#c331e80a";
    }
}

