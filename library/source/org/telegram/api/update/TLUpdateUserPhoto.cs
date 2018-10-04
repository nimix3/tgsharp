namespace org.telegram.api.update
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.api.user.profile.photo;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLUpdateUserPhoto : TLAbsUpdate
    {
        public const int CLASS_ID = -1791935732;
        private int date;
        private TLAbsUserProfilePhoto photo;
        private bool previous;
        private int userId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xab, 0x68 })]
        public TLUpdateUserPhoto()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLUpdateUserPhoto(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x44, 0x6c, 0x6c, 0x72, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.userId = StreamingUtils.readInt(stream);
            this.date = StreamingUtils.readInt(stream);
            this.photo = StreamingUtils.readTLObject(stream, context);
            this.previous = StreamingUtils.readTLBool(stream);
        }

        public override int getClassId() => 
            -1791935732;

        public virtual int getDate() => 
            this.date;

        public virtual TLAbsUserProfilePhoto getPhoto() => 
            this.photo;

        public virtual int getUserId() => 
            this.userId;

        public virtual bool isPrevious() => 
            this.previous;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 60, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.userId, stream);
            StreamingUtils.writeInt(this.date, stream);
            StreamingUtils.writeTLObject(this.photo, stream);
            StreamingUtils.writeTLBool(this.previous, stream);
        }

        public virtual void setDate(int date)
        {
            this.date = date;
        }

        public virtual void setPhoto(TLAbsUserProfilePhoto photo)
        {
            this.photo = photo;
        }

        public virtual void setPrevious(bool previous)
        {
            int num = (int) previous;
            this.previous = (bool) num;
        }

        public virtual void setUserId(int userId)
        {
            this.userId = userId;
        }

        public override string toString() => 
            "updateUserPhoto#95313b0c";
    }
}

