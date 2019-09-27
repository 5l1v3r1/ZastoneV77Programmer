using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zastoneV77Desktop
{
    public static class V77Commands
    {

        public static readonly byte[] Nfogram = { 0x02, 0x4e, 0x46, 0x4f, 0x47, 0x52, 0x41, 0x4d };
        public static readonly byte[] Protocol02 = { 02 };
        public static readonly byte[] Protocol06 = { 06 };
        public static readonly byte[] Protocol05 = { 05 };
        public static readonly byte[] UnknBytes = { 0x52, 0x00, 0x00, 0x08 };
        public static readonly byte[] UnknBytes2 = { 0x52, 0x00, 0x08, 0x08 };
        public static readonly byte[] Channel1Read = { 0x52, 0x01, 0x00, 0x08 };    //TODO : Change This Generic
        public static readonly byte[] Channel1ToneRead = { 0x52, 0x00, 0x18, 0x08 };
    }
}
