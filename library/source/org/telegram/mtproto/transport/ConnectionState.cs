namespace org.telegram.mtproto.transport
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.lang;
    using System;
    using System.Runtime.CompilerServices;

    [Serializable, Signature("Ljava/lang/Enum<Lorg/telegram/mtproto/transport/ConnectionState;>;"), Modifiers(0x4030)]
    internal sealed class ConnectionState : Enum
    {
        [Modifiers(0x101a)]
        private static ConnectionState[] $VALUES = new ConnectionState[] { TcpConnectionStageSuspended, TcpConnectionStageIdle, TcpConnectionStageConnecting, TcpConnectionStageReconnecting, TcpConnectionStageConnected };
        [Modifiers(0x4019)]
        public static ConnectionState TcpConnectionStageConnected = new ConnectionState("TcpConnectionStageConnected", 4);
        [Modifiers(0x4019)]
        public static ConnectionState TcpConnectionStageConnecting = new ConnectionState("TcpConnectionStageConnecting", 2);
        [Modifiers(0x4019)]
        public static ConnectionState TcpConnectionStageIdle = new ConnectionState("TcpConnectionStageIdle", 1);
        [Modifiers(0x4019)]
        public static ConnectionState TcpConnectionStageReconnecting = new ConnectionState("TcpConnectionStageReconnecting", 3);
        [Modifiers(0x4019)]
        public static ConnectionState TcpConnectionStageSuspended = new ConnectionState("TcpConnectionStageSuspended", 0);

        [MethodImpl(MethodImplOptions.NoInlining), Signature("()V"), LineNumberTable(9)]
        private ConnectionState(string text1, int num1) : base(text1, num1)
        {
            GC.KeepAlive(this);
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void __<clinit>()
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(9)]
        public static ConnectionState valueOf(string text1) => 
            ((ConnectionState) Enum.valueOf(ClassLiteral<ConnectionState>.Value, text1));

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(9)]
        public static ConnectionState[] values() => 
            ((ConnectionState[]) $VALUES.Clone());
    }
}

