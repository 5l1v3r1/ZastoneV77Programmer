using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SerialPortLib;
namespace zastoneV77Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static readonly List<CommandStructre> prepareRadioForCommunicationCommands = new List<CommandStructre>
        {
          new CommandStructre{Command  = V77Commands.Nfogram, IsDecodable  = false , CommandResultType = CommandResultType.Unknown},
          new CommandStructre{Command  =    V77Commands.Protocol02,     IsDecodable  = false , CommandResultType = CommandResultType.Unknown},
          new CommandStructre{Command  =   V77Commands.Protocol06,    IsDecodable  = false , CommandResultType = CommandResultType.Unknown},
          new CommandStructre{Command  =   V77Commands.Protocol05 ,    IsDecodable  = false , CommandResultType = CommandResultType.Unknown},
          new CommandStructre{Command  =   V77Commands.Protocol06    ,    IsDecodable  = false , CommandResultType = CommandResultType.Unknown},
          new CommandStructre{Command  =   V77Commands.UnknBytes   ,     IsDecodable  = false , CommandResultType = CommandResultType.Unknown},
          new CommandStructre{Command  =   V77Commands.Protocol06,  IsDecodable  = false , CommandResultType = CommandResultType.Unknown},
          new CommandStructre{Command  =   V77Commands.UnknBytes2, IsDecodable  = false , CommandResultType = CommandResultType.Unknown},
          new CommandStructre{Command  =  V77Commands.Protocol06,  IsDecodable  = false , CommandResultType = CommandResultType.Unknown},
          new CommandStructre{Command  =  V77Commands.Channel1Read     ,    IsDecodable  = true , CommandResultType = CommandResultType.ChannelInformation},
          new CommandStructre{Command  =  V77Commands.Protocol06   ,   IsDecodable  = false , CommandResultType = CommandResultType.Unknown},
          new CommandStructre{Command  =   V77Commands.Channel1ToneRead ,     IsDecodable  = true , CommandResultType = CommandResultType.ToneInformation},

        };
        private static SerialPortInput _sp = null;
        private static int _counter = 0;

        private void readRadioConfiguration_Btn(object sender, EventArgs e)
        {
            _sp = new SerialPortInput();
            _sp.SetPort("COM3", 9600);
            _sp.Connect();
            _sp.MessageReceived += OnMessageReceivedHandler;
            SendCommandsToRadio();
        }

        private void OnMessageReceivedHandler(object sender, MessageReceivedEventArgs args)
        {

            var res = ByteArrayToHexString(args.Data);
            WriteReceivedDataToGrid(res);
            if (prepareRadioForCommunicationCommands[_counter - 1].IsDecodable)
            {
                if (prepareRadioForCommunicationCommands[_counter - 1].CommandResultType ==
                    CommandResultType.ChannelInformation)
                {
                    AddToProcessedDataGrid(ZastoneV77Decoder.DecodeFrequenciesForRXandTx(res));
                }
                else if (prepareRadioForCommunicationCommands[_counter - 1].CommandResultType ==
                         CommandResultType.ToneInformation)
                {
                    AddToProcessedDataGrid(ZastoneV77Decoder.DecodeRXandTxTones(res));
                }

            }

            if (_counter != prepareRadioForCommunicationCommands.Count)
            {
                SendCommandsToRadio();
            }



            /*else if (_counter == prepareRadioForCommunicationCommands.Count)
            {
              
            } */
            else
            {
                _sp.MessageReceived -= OnMessageReceivedHandler;
                _sp.Disconnect();
            }

        }

        private void SendCommandsToRadio()
        {

            if (_counter < prepareRadioForCommunicationCommands.Count)
            {
                WriteSendedDataToLBox(prepareRadioForCommunicationCommands[_counter].Command);
                _sp.SendMessage(prepareRadioForCommunicationCommands[_counter].Command);
                _counter++;

            }
            else
            {
                _sp.MessageReceived -= OnMessageReceivedHandler;
                _sp.Disconnect();
            }
        }


        private void WriteSendedDataToLBox(byte[] sentDataBytes)
        {
            AddToRawDataGrid("Send", ByteArrayToHexString(sentDataBytes));

        }

        private void WriteReceivedDataToGrid(string receivedData)
        {
            AddToRawDataGrid("Receive", receivedData);

        }





        public static string ByteArrayToHexString(byte[] bytes)
        {
            return BitConverter.ToString(bytes).Replace("-", " ");
        }
        private void AddToRawDataGrid(string direction, string data)
        {
            object[] myArray = new object[] { direction, data };
            if (this.InvokeRequired)
                rawDataGrid.Invoke((MethodInvoker)(() => rawDataGrid.Rows.Add(myArray)));
            else rawDataGrid.Rows.Add(myArray);
        }


        private void AddToProcessedDataGrid(ZastoneV77ChannelStructre st)
        {
            if (string.IsNullOrEmpty(st.ToneDec)) return;
            var myArray = new object[] { st.RXFreq, st.ToneDec, st.TXFreq, st.ToneEnc, st.ScanAdd, st.WideNarrow, st.Txpower ,st.BusyLock,st.Scramble,st.Compander,st.PTTID};
            if (this.InvokeRequired)
                processedDataGrid.Invoke((MethodInvoker)(() => processedDataGrid.Rows.Add(myArray)));
            else processedDataGrid.Rows.Add(myArray);
            ZastoneV77Decoder.ClearStaticVariable();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


    }

}
