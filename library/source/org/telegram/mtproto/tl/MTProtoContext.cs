namespace org.telegram.mtproto.tl
{
    using IKVM.Attributes;
    using ikvm.internal;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;

    public class MTProtoContext : TLContext
    {
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 
            0x9f, 0x9c, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70,
            0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x72
        })]
        protected internal override void init()
        {
            this.registerClass(0x7abe77ec, ClassLiteral<MTPing>.Value);
            this.registerClass(-213746804, ClassLiteral<MTPingDelayDisconnect>.Value);
            this.registerClass(0x347773c5, ClassLiteral<MTPong>.Value);
            this.registerClass(0x62d6b459, ClassLiteral<MTMsgsAck>.Value);
            this.registerClass(-1631450872, ClassLiteral<MTNewSessionCreated>.Value);
            this.registerClass(-1477445615, ClassLiteral<MTBadMessageNotification>.Value);
            this.registerClass(-307542917, ClassLiteral<MTBadServerSalt>.Value);
            this.registerClass(-501201412, ClassLiteral<MTDestroySessionOk>.Value);
            this.registerClass(0x62d350c9, ClassLiteral<MTDestroySessionNone>.Value);
            this.registerClass(-530561358, ClassLiteral<MTMessageCopy>.Value);
            this.registerClass(-2137147681, ClassLiteral<MTNewMessageDetailedInfo>.Value);
            this.registerClass(0x276d3ec6, ClassLiteral<MTMessageDetailedInfo>.Value);
            this.registerClass(0x7d861a08, ClassLiteral<MTNeedResendMessage>.Value);
            this.registerClass(0x73f1f8dc, ClassLiteral<MTMessagesContainer>.Value);
            this.registerClass(0x2144ca19, ClassLiteral<MTRpcError>.Value);
            this.registerClass(0x58e4a740, ClassLiteral<MTRpcDropAnswer>.Value);
            this.registerClass(-212046591, ClassLiteral<MTRpcResult>.Value);
            this.registerClass(0x5e2ad36e, ClassLiteral<MTRpcAnswerUnknown>.Value);
            this.registerClass(-847714938, ClassLiteral<MTRpcAnswerDroppedRunning>.Value);
            this.registerClass(-1539647305, ClassLiteral<MTRpcAnswerDropped>.Value);
            this.registerClass(-414113498, ClassLiteral<MTDestroySession>.Value);
            this.registerClass(-1835453025, ClassLiteral<MTHttpWait>.Value);
            this.registerClass(-1188971260, ClassLiteral<MTGetFutureSalts>.Value);
            this.registerClass(0x949d9dc, ClassLiteral<MTFutureSalt>.Value);
            this.registerClass(-1370486635, ClassLiteral<MTFutureSalts>.Value);
            this.registerClass(-1933520591, ClassLiteral<MTMessagesAllInfo>.Value);
            this.registerClass(0x4deb57d, ClassLiteral<MTMessagesStateInfo>.Value);
            this.registerClass(-630588590, ClassLiteral<MTMsgsStateReq>.Value);
        }
    }
}

