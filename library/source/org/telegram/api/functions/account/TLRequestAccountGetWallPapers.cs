namespace org.telegram.api.functions.account
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/tl/TLVector<Lorg/telegram/api/wallpaper/TLAbsWallPaper;>;>;")]
    public class TLRequestAccountGetWallPapers : TLMethod
    {
        public const int CLASS_ID = -1068696894;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(15)]
        public TLRequestAccountGetWallPapers()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestAccountGetWallPapers(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(15)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Signature("(Ljava/io/InputStream;Lorg/telegram/tl/TLContext;)Lorg/telegram/tl/TLVector<Lorg/telegram/api/wallpaper/TLAbsWallPaper;>;"), LineNumberTable(0x1b)]
        public virtual TLVector deserializeResponse(InputStream stream, TLContext context) => 
            StreamingUtils.readTLVector(stream, context);

        public override int getClassId() => 
            -1068696894;

        public override string toString() => 
            "account.getWallPapers#c04cfac2";
    }
}

