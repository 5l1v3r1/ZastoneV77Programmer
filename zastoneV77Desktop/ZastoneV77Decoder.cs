using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zastoneV77Desktop
{
    public static class ZastoneV77Decoder
    {
        private static ZastoneV77ChannelStructre result;

        public static ZastoneV77ChannelStructre DecodeFrequenciesForRXandTx(string hexEncodedChannelData)
        {
            if (result == null) result = new ZastoneV77ChannelStructre();

            var channelDataParts = hexEncodedChannelData.Split(' ');
            result.RXFreq = channelDataParts[7] + channelDataParts[6].Insert(1, ".") + channelDataParts[5];
            result.TXFreq = channelDataParts[11] + channelDataParts[10].Insert(1, ".") + channelDataParts[9];
            return result;
        }

        public static ZastoneV77ChannelStructre DecodeRXandTxTones(string hexEncodedToneData)
        {
            if (result == null) result = new ZastoneV77ChannelStructre();

            var toneDataParts = hexEncodedToneData.Split(' ');
            result.ToneDec = Convert.ToInt32(toneDataParts[5]).ToString() + toneDataParts[4].Insert(1, ".");
            result.ToneEnc = Convert.ToInt32(toneDataParts[7]).ToString() + toneDataParts[6].Insert(1, ".");
            result.ScanAdd = toneDataParts[8][0] == 'f' ? "Yes" : "No";
            result.WideNarrow = toneDataParts[8][1] == 'f' ? "Wide" : "Narrow";
            result.Txpower = toneDataParts[8][1] == 'f' ? "High" : "Low";
            result.BusyLock = toneDataParts[8][1] == 'f' ? "No" : "Yes";
            result.Scramble = toneDataParts[8][0] == 'd' ? "No" : "Yes";
            result.Compander = toneDataParts[8][0] == '9' ? "Yes" : "No";
            result.PTTID = toneDataParts[8][0] == '1' ? "Yes" : "No";
            return result;
        }

        public static void ClearStaticVariable()
        {
            result = null;
        }
    }
}
