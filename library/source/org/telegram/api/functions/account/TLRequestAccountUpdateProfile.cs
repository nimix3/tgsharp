namespace org.telegram.api.functions.account
{
    using IKVM.Attributes;
    using ikvm.internal;
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
    public class TLRequestAccountUpdateProfile : TLMethod
    {
        private string about;
        public const int CLASS_ID = 0x78515775;
        private string firstName;
        private const int FLAG_ABOUT = 4;
        private const int FLAG_FIRSTNAME = 1;
        private const int FLAG_LASTNAME = 2;
        private int flags;
        private string lastName;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb7, 0x68 })]
        public TLRequestAccountUpdateProfile()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestAccountUpdateProfile(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(0x10)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x51, 0x6c, 0x6a, 140, 0x6a, 140, 0x6a, 140 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            if ((this.flags & 1) != 0)
            {
                this.firstName = StreamingUtils.readTLString(stream);
            }
            if ((this.flags & 2) != 0)
            {
                this.lastName = StreamingUtils.readTLString(stream);
            }
            if ((this.flags & 4) != 0)
            {
                this.about = StreamingUtils.readTLString(stream);
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0, 0x68, 0x63, 0x90, 0x68, 0x87 })]
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
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected ").append(ClassLiteral<TLAbsUser>.Value.getCanonicalName()).append(", got: ").append(Object.instancehelper_getClass(obj2).getCanonicalName()).toString());
        }

        [LineNumberTable(new byte[] { 0x9f, 0x7a, 0x42, 0x63, 0x90, 0x90 })]
        private void enableFlag(int num1, bool flag1)
        {
            if (flag1)
            {
                this.flags |= num1;
            }
            else
            {
                this.flags &= num1 ^ -1;
            }
        }

        public virtual string getAbout() => 
            this.about;

        public override int getClassId() => 
            0x78515775;

        public virtual string getFirstName() => 
            this.firstName;

        public virtual string getLastName() => 
            this.lastName;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x43, 0x6c, 0x6a, 140, 0x6a, 140, 0x6a, 0x8e })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            if ((this.flags & 1) != 0)
            {
                StreamingUtils.writeTLString(this.firstName, stream);
            }
            if ((this.flags & 2) != 0)
            {
                StreamingUtils.writeTLString(this.lastName, stream);
            }
            if ((this.flags & 4) != 0)
            {
                StreamingUtils.writeTLString(this.about, stream);
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x3d, 0x67, 0x70 })]
        public virtual void setAbout(string value)
        {
            this.about = value;
            this.enableFlag(4, value != null);
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x19, 0x67, 120 })]
        public virtual void setFirstName(string value)
        {
            this.firstName = value;
            this.enableFlag(1, (value != null) && !String.instancehelper_isEmpty(value));
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x34, 0x67, 120 })]
        public virtual void setLastName(string value)
        {
            this.lastName = value;
            this.enableFlag(2, (value != null) && !String.instancehelper_isEmpty(value));
        }

        public override string toString() => 
            "account.updateProfile#78515775";
    }
}

