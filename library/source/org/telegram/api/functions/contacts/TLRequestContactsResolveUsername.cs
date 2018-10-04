namespace org.telegram.api.functions.contacts
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using java.lang;
    using org.telegram.api.contacts;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/api/contacts/TLResolvedPeer;>;")]
    public class TLRequestContactsResolveUsername : TLMethod
    {
        public const int CLASS_ID = -113456221;
        private string username;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 170, 0x68 })]
        public TLRequestContactsResolveUsername()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestContactsResolveUsername(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(0x10)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x16, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.username = StreamingUtils.readTLString(stream);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb3, 0x68, 0x63, 0x90, 0x68, 0x87 })]
        public virtual TLResolvedPeer deserializeResponse(InputStream stream, TLContext context)
        {
            TLObject obj2 = StreamingUtils.readTLObject(stream, context);
            if (obj2 == null)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IOException("Unable to parse response");
            }
            if (obj2 is TLResolvedPeer)
            {
                return (TLResolvedPeer) obj2;
            }
            Throwable.__<suppressFillInStackTrace>();
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected ").append(ClassLiteral<TLResolvedPeer>.Value.getName()).append(", got: ").append(Object.instancehelper_getClass(obj2).getCanonicalName()).toString());
        }

        public override int getClassId() => 
            -113456221;

        public virtual string getUsername() => 
            this.username;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x11, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLString(this.username, stream);
        }

        public virtual void setUsername(string username)
        {
            this.username = username;
        }

        public override string toString() => 
            "contacts.resolveUsername#f93ccba3";
    }
}

