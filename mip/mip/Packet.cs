using System;

namespace mip
{
    public class Packet
    {
        public Packet(PacketType type)
        {
            this.Type = type;
        }

        public PacketType Type { get; set; }

        public byte[] Content { get; internal set; }

        public uint SequenceNumber { get; internal set; }

        public Connection Socket { get; internal set; }

    }

    public enum PacketType { TCP, UDP };

}
