﻿namespace org.telegram.api.functions.help
{
    using IKVM.Attributes;
    using java.io;
    using java.lang;
    using org.telegram.api.help;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/api/help/TLSupport;>;")]
    public class TLRequestHelpGetSupport : TLMethod
    {
        public const int CLASS_ID = -1663104819;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa7, 0x68 })]
        public TLRequestHelpGetSupport()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestHelpGetSupport(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(15)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb0, 0x68, 0x63, 0x70, 0x68, 0x67 })]
        public virtual TLSupport deserializeResponse(InputStream stream, TLContext context)
        {
            TLObject obj2 = StreamingUtils.readTLObject(stream, context);
            if (obj2 == null)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IOException("Unable to parse response");
            }
            if (obj2 is TLSupport)
            {
                return (TLSupport) obj2;
            }
            Throwable.__<suppressFillInStackTrace>();
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected org.telegram.api.help.TLSupport, got: ").append(Object.instancehelper_getClass(obj2).getCanonicalName()).toString());
        }

        public override int getClassId() => 
            -1663104819;

        public override string toString() => 
            "help.getSupport#9cdf08cd";
    }
}

