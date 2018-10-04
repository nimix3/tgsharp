namespace org.telegram.api.functions.users
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLAbsUser;>;>;")]
    public class TLRequestUsersGetUsers : TLMethod
    {
        public const int CLASS_ID = 0xd91a548;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/input/user/TLAbsInputUser;>;")]
        protected internal TLVector id;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xae, 0x68 })]
        public TLRequestUsersGetUsers()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestUsersGetUsers(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(0x11)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x13, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.id = StreamingUtils.readTLVector(stream, context);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Signature("(Ljava/io/InputStream;Lorg/telegram/tl/TLContext;)Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLAbsUser;>;"), LineNumberTable(0x29)]
        public virtual TLVector deserializeResponse(InputStream stream, TLContext context) => 
            StreamingUtils.readTLVector(stream, context);

        public override int getClassId() => 
            0xd91a548;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/input/user/TLAbsInputUser;>;")]
        public virtual TLVector getId() => 
            this.id;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 14, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLVector(this.id, stream);
        }

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/input/user/TLAbsInputUser;>;)V")]
        public virtual void setId(TLVector value)
        {
            this.id = value;
        }

        public override string toString() => 
            "users.getUsers#d91a548";
    }
}

