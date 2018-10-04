namespace org.telegram.api.keyboard.button
{
    using IKVM.Attributes;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public abstract class TLAbsKeyboardButton : TLObject
    {
        protected internal string text;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9d, 0x68 })]
        internal TLAbsKeyboardButton()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAbsKeyboardButton(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public virtual string getText() => 
            this.text;
    }
}

