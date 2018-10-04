namespace org.telegram.mtproto.tl.pq
{
    using IKVM.Attributes;
    using ikvm.internal;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;

    public class TLInitContext : TLContext
    {
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9c, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x72 })]
        protected internal override void init()
        {
            this.registerClass(0x60469778, ClassLiteral<ReqPQ>.Value);
            this.registerClass(0x5162463, ClassLiteral<ResPQ>.Value);
            this.registerClass(-686627650, ClassLiteral<ReqDhParams>.Value);
            this.registerClass(-790100132, ClassLiteral<ServerDhOk>.Value);
            this.registerClass(0x79cb045d, ClassLiteral<ServerDhFailure>.Value);
            this.registerClass(-1249309254, ClassLiteral<ServerDhInner>.Value);
            this.registerClass(0x3bcbf734, ClassLiteral<DhGenOk>.Value);
            this.registerClass(-1499615742, ClassLiteral<DhGenFailure>.Value);
            this.registerClass(0x46dc1fb9, ClassLiteral<DhGenRetry>.Value);
            this.registerClass(-184262881, ClassLiteral<ReqSetDhClientParams>.Value);
            this.registerClass(0x6643b654, ClassLiteral<ClientDhInner>.Value);
            this.registerClass(0x7ae432f5, ClassLiteral<MTRpcReqError>.Value);
        }
    }
}

