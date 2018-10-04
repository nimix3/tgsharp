namespace org.telegram.api.engine
{
    using IKVM.Attributes;
    using org.telegram.tl;
    using System;

    [Signature("<T:Lorg/telegram/tl/TLObject;>Ljava/lang/Object;")]
    public interface RpcCallback
    {
        void onError(int i, string str);
        [Signature("(TT;)V")]
        void onResult(TLObject tlo);
    }
}

