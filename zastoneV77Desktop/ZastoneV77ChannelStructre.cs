using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zastoneV77Desktop
{
    public class ZastoneV77ChannelStructre
    {
        public string RXFreq { get; set; }
        public string ToneDec { get; set; }
        public string TXFreq { get; set; }
        public string ToneEnc { get; set; }
        public string ScanAdd { get; set; }
        public string WideNarrow { get; set; }
        public string Txpower { get; set; }
        public string BusyLock { get; set; }
        public string Scramble { get; set; }
        public string Compander { get; set; }
        public string PTTID { get; set; }
    }


    public enum CommandResultType
    {
        ChannelInformation,
        ToneInformation,
        GeneralProgramInformation,
        Unknown
    }

    public class CommandStructre
    {
        public byte[] Command { get; set; }
        public bool IsDecodable { get; set; }
        public CommandResultType CommandResultType { get; set; }
    }
}
