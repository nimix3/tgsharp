﻿namespace org.telegram.api.input.bot.inlineresult
{
    using IKVM.Attributes;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public abstract class TLAbsInputBotInlineResult : TLObject
    {
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xab, 0x68 })]
        internal TLAbsInputBotInlineResult()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAbsInputBotInlineResult(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }
    }
}

