namespace org.telegram.api.messages
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using org.telegram.api.updates;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLMessagesPeerDialogs : TLObject
    {
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/chat/TLAbsChat;>;")]
        private TLVector chats;
        public const int CLASS_ID = 0x3371c354;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/dialog/TLDialog;>;")]
        private TLVector dialogs;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/message/TLAbsMessage;>;")]
        private TLVector messages;
        private TLUpdatesState state;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLAbsUser;>;")]
        private TLVector users;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xac, 0x68 })]
        public TLMessagesPeerDialogs()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLMessagesPeerDialogs(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x13, 0x72, 0x72, 0x72, 0x72, 0x77 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.dialogs = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLDialog>.Value);
            this.messages = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLAbsMessage>.Value);
            this.chats = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLAbsChat>.Value);
            this.users = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLAbsUser>.Value);
            this.state = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLUpdatesState>.Value);
        }

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/chat/TLAbsChat;>;")]
        public virtual TLVector getChats() => 
            this.chats;

        public override int getClassId() => 
            0x3371c354;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/dialog/TLDialog;>;")]
        public virtual TLVector getDialogs() => 
            this.dialogs;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/message/TLAbsMessage;>;")]
        public virtual TLVector getMessages() => 
            this.messages;

        public virtual TLUpdatesState getState() => 
            this.state;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLAbsUser;>;")]
        public virtual TLVector getUsers() => 
            this.users;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 10, 0x6c, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLVector(this.dialogs, stream);
            StreamingUtils.writeTLVector(this.messages, stream);
            StreamingUtils.writeTLVector(this.chats, stream);
            StreamingUtils.writeTLVector(this.users, stream);
            StreamingUtils.writeTLObject(this.state, stream);
        }

        public override string toString() => 
            "messages.peerDialogs#3371c354";
    }
}

