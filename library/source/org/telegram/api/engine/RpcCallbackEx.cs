namespace org.telegram.api.engine
{
    using IKVM.Attributes;
    using System;

    [Signature("<T:Lorg/telegram/tl/TLObject;>Ljava/lang/Object;Lorg/telegram/api/engine/RpcCallback<TT;>;"), Implements(new string[] { "org.telegram.api.engine.RpcCallback" })]
    public interface RpcCallbackEx : RpcCallback
    {
        void onConfirmed();
    }
}

