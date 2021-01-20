using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Diagnostics;

namespace MW_001_TEST
{
    public partial class Form1 : Form
    {
        string dataIN;
        string[] Rxline;
        int num;
        bool Comconnected = false;
        bool Reading = false;
        bool TESTReading = false;
        bool AT = false;
        bool CITY = false;
        bool TERM = false;
        bool TESTMODE = false;
        bool TESTRESULTS = false;
        bool NUMS = false;
        bool ATH = false;
        DateTime startDT;

        public Form1()
        {
            InitializeComponent();
        }





        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            comboBox_COM.Items.AddRange(ports);

            textBox_IMEI.Enabled = false;
            //textBox_SIMNUM.Enabled = false;

            //textBox_STFWPASS.Text = "LteWater_0122.bin";

            StreamReader pth = new StreamReader("C:\\LTEW\\STFW\\STFW.txt", Encoding.Default);
            string WORD;
            while ((WORD = pth.ReadLine()) != null)
            {
                string[] sbuf = WORD.Split(',');
                textBox_STFWPASS.Text = sbuf[0];
                textBox_STFWVER.Text = sbuf[1];
            }
            pth.Close();

            StreamReader dis = new StreamReader("C:\\LTEW\\tools\\distance.txt", Encoding.Default);
            string dist;
            dist = dis.ReadLine();
            textBox_TESTDIS.Text = dist;
            dis.Close();

            StreamReader volt = new StreamReader("C:\\LTEW\\tools\\voltage.txt", Encoding.Default);
            string voltage;
            voltage = volt.ReadLine();
            textBox_voltage.Text = voltage;
            volt.Close();

            StreamReader pro = new StreamReader("C:\\LTEW\\tools\\Product.csv", Encoding.Default);
            string PRONUM;
            int i=0;
            while ((PRONUM = pro.ReadLine()) != null)
            {
                i++;
            }
            i = i - 1;
            textBox_COUNT.Text = i.ToString();
            pro.Close();

        }

        private void button_COM_Click(object sender, EventArgs e)
        {
            if(Comconnected == false)
            {
                try
                {
                    serialPort1.PortName = comboBox_COM.Text;
                    serialPort1.BaudRate = 115200;
                    serialPort1.DataBits = 8;
                    serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), "One");
                    serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), "None");
                    //serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
                    serialPort1.Open();

                    textBox_memo.Text = "接続しました。IMEIを読み込んでください。";
                    textBox_IMEI.Enabled = true;
                    textBox_IMEI.Focus();
                    textBox_IMEI.SelectAll();
                    button_COM.Text = "切断";
                    Comconnected = true;
                }

                catch
                {
                    textBox_memo.Text = "ツールがありません。";
                    textBox_IMEI.Enabled = false;
                    button_COM.Text = "接続";
                    Comconnected = false;

                    //再検索
                    //textBox_memo.Clear();
                    comboBox_COM.Items.Clear();
                    string[] ports = SerialPort.GetPortNames();
                    comboBox_COM.Items.AddRange(ports);
                }
            }
            else //comconnected = true;
            {
                if(serialPort1.IsOpen)
                {
                    //処理を止める
                    Reading = false;
                    TESTReading = false;
                    TESTMODE = false;

                    serialPort1.Close();
                    textBox_memo.Text =  "切断しました。";
                    textBox_IMEI.Enabled = false;
                    button_COM.Text = "接続";
                    Comconnected = false;
                }

                //再検索
                //textBox_memo.Clear();
                comboBox_COM.Items.Clear();
                string[] ports = SerialPort.GetPortNames();
                comboBox_COM.Items.AddRange(ports);
            }
        }

        private void button_END_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }

            Application.Exit();
        }



        private void ShowData(object sender, EventArgs e)
        {

                foreach (string s in Rxline)
                {
                    listBox_LOG.Items.Add(s);
                    listBox_LOG.SelectedIndex = listBox_LOG.Items.Count - 1;
                    listBox_LOG.Update();
                    //System.Threading.Thread.Sleep(500);
                    //listBox_LOG.SelectedIndex = listBox_LOG.Items.Count - 1;

                    //起動判定
                    if (s.Contains("start..."))
                    {
                        textBox_memo.Text = "磁石が反応していません。";
                        Reading = false;
                        textBox_IMEI.Focus();
                        textBox_IMEI.SelectAll();
                        break;
                    }

                    //シリアルエラー判定
                    if (s.Contains("6666"))
                    {
                        textBox_memo.Text = "COM PORTエラー";
                        Reading = false;
                        break;
                    }

                    //起動判定2
                    if (s.Contains("LTE_power on"))
                    {
                        textBox_memo.Text = "電源を切ってください。";
                        Reading = false;
                        textBox_IMEI.Focus();
                        textBox_IMEI.SelectAll();
                    break;
                    }

                    //起動判定3
                    if (s.Contains("START TEST"))
                    {
                        textBox_memo.Text = "起動中";
                        textBox_memo.Update();
                    }

                    //起動済み処理
                    if (s.Contains("NUM="))
                    {
                        int len = s.Length;
                        if (len < 5)
                        {
                            textBox_memo.Text = "SIMがありません。";
                            textBox_IMEI.Focus();
                            textBox_IMEI.SelectAll();
                            Reading = false;
                        }
                        else
                        {
                            textBox_memo.Text = "テストを開始できます。";
                            NUMS = true;
                            textBox_TESTNUM.Text = s.Substring(len - 11);
                            Reading = false;
                            textBox_SIMNUM.Enabled = true;
                            textBox_SIMNUM.Focus();
                            textBox_SIMNUM.SelectAll();
                    }
                        break;
                    }
                }
        }

        private void textBox_IMEI_TextChanged(object sender, EventArgs e)
        {
            if(textBox_IMEI.TextLength == 15)
            {
                Reading = true;
                textBox_memo.Text = "テストモードで起動して下さい。";
                textBox_memo.Update();

                NUMS = false;
                textBox_TESTNUM.ResetText();
                textBox_USER.ResetText();
                textBox_CITYID.ResetText();
                textBox_terminalID.ResetText();
                textBox_TELLNUM.ResetText();
                textBox_SIMNUM.ResetText();
                textBox_NAME.ResetText();
                textBox_ADDRESS.ResetText();
                textBox_VENDER.ResetText();
                textBox_VENDERAD.ResetText();
                textBox_RECEIVER.ResetText();
                textBox_RECEIVEAD.ResetText();
                textBox_STFW.ResetText();
                textBox_TEMP.ResetText();
                textBox_VOLT.ResetText();
                textBox_DIST.ResetText();
                //textBox_TESTNUM.ResetText();

                if (serialPort1.IsOpen)
                {
                    serialPort1.DiscardInBuffer();
                    serialPort1.DiscardOutBuffer();

                    while (Reading == true)
                    {
                        this.Activate();
                        Application.DoEvents();
                        //System.Threading.Thread.Sleep(100);

                        try
                        {
                            if (serialPort1.BytesToRead > 0)
                            {
                                dataIN = serialPort1.ReadExisting();
                                Rxline = dataIN.Split('\n');
                                this.Invoke(new EventHandler(ShowData));
                            }
                        }
                        catch
                        {
                            Reading = false;
                            textBox_memo.Text = "切断しました。途中停止しました。";
                            textBox_memo.Update();
                            return;
                        }
                    }
                    

                }

            }
            else
            {

            }
        }


        private void textBox_SIMNUM_TextChanged(object sender, EventArgs e)
        { 
            num = 0;

            if (textBox_SIMNUM.TextLength == 15)
            {
                if (serialPort1.IsOpen)
                {

                    while (TESTMODE == true)
                    {
                        switch (num)
                        {
                            case 1:
                                ATTEST();
                                TESTREAD();
                                break;

                            case 2:
                                IMEITEST();
                                TESTREAD();
                                break;

                            case 3:
                                WNCTEST();
                                TESTREAD();
                                break;

                            case 4:
                                VERSION();
                                TESTREAD();
                                break;

                            case 5:
                                TEMP();
                                TESTREAD();
                                break;

                            case 6:
                                VATT();
                                TESTREAD();
                                break;

                            case 7:
                                SENSOR();
                                TESTREAD();
                                break;

                            case 8:
                                WRITECITY();
                                TESTREAD();
                                break;

                            case 9:
                                WRITESENS();
                                TESTREAD();
                                break;

                            case 10:
                                CHECKID();
                                TESTREAD();
                                TESTMODE = false;
                                break;

                            case 11:
                                ATTACH();
                                TESTREAD();
                                TESTMODE = false;
                                break;
                        }

                        num = num + 1;

                    }

                    if (TESTRESULTS == true)
                    {
                        LOGOUTPUT();
                        TESTRESULTS = false;
                    }
                    else
                    {
                        TESTLOG();
                        TESTMODE = true;
                        textBox_SIMNUM.Focus();
                        textBox_SIMNUM.SelectAll();
                    }
                }





            }

        }

        private void TESTData1(object sender, EventArgs e)
        {


            foreach (string s in Rxline)
            {
                listBox_LOG.Items.Add(s);
                listBox_LOG.SelectedIndex = listBox_LOG.Items.Count - 1;
                listBox_LOG.Update();



                //!!AT
                if (s.StartsWith("!!AT"))
                {
                    AT = true;
                    return;
                }
                //!!CITYCODE
                if (s.StartsWith("!!CITYCODE"))
                {
                    CITY = true;
                    return;
                }
                //!!SENSNO
                if (s.StartsWith("!!SENSORNO"))
                {
                    TERM = true;
                    return;
                }
                //!!ATTACH
                if (s.StartsWith("!!ATTACH"))
                {
                    ATH = true;
                    return;

                }

                if(ATH == true)
                {
                    if (s.Contains("OK"))
                    {
                        textBox_memo.Text = "ATTACH OK";
                        textBox_memo.Update();
                        ATH = false;
                        TESTReading = false;
                        break;

                    }else if (s.Contains("ERROR"))
                    {
                        textBox_memo.Text = "ATTACH ERROR";
                        textBox_memo.Update();
                        ATH = false;
                        TESTMODE = false;
                        TESTReading = false;
                        break;
                    }
                }

                if (s.StartsWith("OK"))
                {
                    if (AT == true)
                    {
                        textBox_memo.Text = "AT OK";
                        textBox_memo.Update();
                        AT = false;
                        //TESTMODE = false;
                        TESTReading = false;
                        break;
                    }
                    if(CITY == true)
                    {
                        textBox_memo.Text = "CITY CODE WRITE OK";
                        textBox_memo.Update();
                        CITY = false;
                        //TESTMODE = false;
                        TESTReading = false;
                        break;
                    }
                    if (TERM == true)
                    {
                        textBox_memo.Text = "SENSOR NUMBER WRITE OK";
                        textBox_memo.Update();
                        TERM = false;
                        //TESTMODE = false;
                        TESTReading = false;
                        break;
                    }
                    else
                    {
                        textBox_memo.Text = "FAIL";
                        textBox_memo.Update();
                        AT = false;
                        TESTMODE = false;
                        TESTReading = false;
                        break;
                    }
                    
                }

                //!!IMEI
                if (s.Contains("IMEI="))
                {

                    string WORD;
                    int WORDLEN = s.Length;
                    WORD = s.Substring(WORDLEN - 15);

                    if (WORD == textBox_IMEI.Text)
                    {
                        textBox_memo.Text = "IMEI OK";
                        textBox_memo.Update();
                    }
                    else
                    {
                        textBox_memo.Text = "IMEI ERROR";
                        textBox_memo.Update();
                        TESTMODE = false;
                    }
                    TESTReading = false;
                    break;
                }

                //!!WNCVER
                if (s.Contains("MODEM="))
                {
                    string WORD;
                    int WORDLEN = s.Length;
                    WORD = s.Substring(WORDLEN - 37);

                    if(WORD == textBox_WNC.Text )
                    {
                        textBox_memo.Text = "WNC MODEM VERSION OK";
                        textBox_memo.Update();
                    }
                    else
                    {
                        textBox_memo.Text = "WNC MODEM VERSION ERROR";
                        textBox_memo.Update();
                        TESTMODE = false;
                    }
                    TESTReading = false;
                    //TESTMODE = false;
                    break;
                }

                //!!VERSION
                if (s.Contains("FWVER="))
                {
                    string WORD;
                    int WORDLEN = s.Length;
                    WORD = s.Substring(WORDLEN - 4);

                    if (WORD == textBox_STFWVER.Text)
                    {
                        textBox_STFW.Text = WORD;
                        textBox_STFW.Update();
                        textBox_memo.Text = "ST FW VERSION OK";
                        textBox_memo.Update();
                    }
                    else
                    {
                        textBox_memo.Text = "ST FW VERSION ERROR";
                        textBox_memo.Update();
                        TESTMODE = false;
                    }
                    TESTReading = false;
                    //TESTMODE = false;
                    break;
                }

                //!!TEMP
                if (s.Contains("TEMP="))
                {
                    string WORD;
                    int WORDLEN = s.Length;
                    WORD = s.Substring(5);

                    textBox_TEMP.Text = WORD;
                    textBox_TEMP.Update();

                    TESTReading = false;
                    //TESTMODE = false;
                    break;
                }

                //!!VATT
                if (s.Contains("ADC="))
                {
                    string WORD;
                    int WORDLEN = s.Length;
                    WORD = s.Substring(4,4);

                    double a = double.Parse(WORD);
                    double b = double.Parse(textBox_voltage.Text);

                    textBox_VOLT.Text = WORD;
                    textBox_VOLT.Update();

                    if (a > b)
                    {
                        textBox_memo.Text = "BATTERY OK";
                        textBox_memo.Update();
                    }
                    else
                    {
                        textBox_memo.Text = "BATTERY FAIL";
                        textBox_memo.Update();
                        TESTMODE = false;
                    }

                    TESTReading = false;
                    //END
                    //TESTMODE = false;
                    break;
                }

                //!!SENSOR
                if (s.Contains("AVE="))
                {
                    string WORD, DIST;
                    int WORDLEN = s.Length;
                    WORD = s.Substring(4);
                    DIST = textBox_TESTDIS.Text;

                    double a = double.Parse (WORD);
                    double b = double.Parse(DIST);

                    textBox_DIST.Text = WORD;
                    textBox_DIST.Update();

                    if (a >= b)
                    { 
                        textBox_memo.Text = "SENSOR DISTANCE OK";
                        textBox_memo.Update();
                    }
                    else
                    {
                        textBox_memo.Text = "SENSOR DISTANCE FAIL";
                        textBox_memo.Update();
                        TESTMODE = false;
                    }
                    

                    TESTReading = false;
                    //END
                    //TESTMODE = false;
                    break;
                }

                if (s.StartsWith("CITYCODE="))
                {
                    string WORD;
                    int WORDLEN = s.Length;
                    WORD = s.Substring(9);

                    if (WORD == textBox_CITYID.Text)
                    {
                        textBox_memo.Text = "CITY CODE OK";
                        textBox_memo.Update();
                    }
                    else
                    {
                        textBox_memo.Text = "CITY CODE ERROR";
                        textBox_memo.Update();
                        TESTMODE = false;
                        break;
                    }
                    //TESTReading = false;
                    //TESTMODE = false;
                    //break;
                }
                if (s.StartsWith("SENSORNO="))
                {
                    string WORD;
                    int WORDLEN = s.Length;
                    WORD = s.Substring(9);

                    if (WORD == textBox_terminalID.Text)
                    {
                        textBox_memo.Text = "SENSOR NO OK";
                        textBox_memo.Update();
                        TESTRESULTS = true;
                    }
                    else
                    {
                        textBox_memo.Text = "SENSOR NO ERROR";
                        textBox_memo.Update();
                        TESTMODE = false;
                    }
                    TESTReading = false;
                    //TESTMODE = false;
                    break;
                }

            }
        }

        private void TESTREAD()
        {
            if (serialPort1.IsOpen)
            {


                while (TESTReading == true)
                {
                    this.Activate();
                    Application.DoEvents();

                    if (ATH == true)
                    {
                        DateTime endDT = DateTime.Now;
                        TimeSpan ts = endDT - startDT;

                        if (ts.TotalSeconds > 20)
                        {
                            textBox_memo.Text = "ATTACHできませんでした。";
                            textBox_memo.Update();
                            ATH = false;
                            TESTMODE = false;
                            TESTReading = false;

                        }
                    }

                    try
                    {
                        if (serialPort1.BytesToRead > 0)
                        {
                            dataIN = serialPort1.ReadExisting();
                            Rxline = dataIN.Split('\n');
                            this.Invoke(new EventHandler(TESTData1));
                        }
                    }
                    catch
                    {
                        textBox_memo.Text = "切断しました。途中停止しました。";
                        textBox_memo.Update();
                    }
                }
            }
            
        }

        private void ATTEST()
        {
            TESTReading = true;
            string s;
            s = "!!AT" + Environment.NewLine;
            serialPort1.WriteLine(s);
            //System.Threading.Thread.Sleep(100);
        }
        private void IMEITEST()
        {
            TESTReading = true;
            string s;
            s = "!!IMEI" + Environment.NewLine;
            serialPort1.WriteLine(s);
            System.Threading.Thread.Sleep(100);
        }
        private void WNCTEST()
        {
            TESTReading = true;
            string s;
            s = "!!WNCVER" + Environment.NewLine;
            serialPort1.WriteLine(s);
            System.Threading.Thread.Sleep(100);
        }
        private void VERSION()
        {
            TESTReading = true;
            string s;
            s = "!!VERSION" + Environment.NewLine;
            serialPort1.WriteLine(s);
            System.Threading.Thread.Sleep(100);
        }
        private void VATT()
        {
            TESTReading = true;
            string s;
            s = "!!VATT" + Environment.NewLine;
            serialPort1.WriteLine(s);
            System.Threading.Thread.Sleep(100);
        }
        private void TEMP()
        {
            TESTReading = true;
            string s;
            s = "!!TEMP" + Environment.NewLine;
            serialPort1.WriteLine(s);
            System.Threading.Thread.Sleep(100);
        }
        private void SENSOR()
        {
            TESTReading = true;
            string s;
            s = "!!SENSOR" + Environment.NewLine;
            serialPort1.WriteLine(s);
            System.Threading.Thread.Sleep(500);
        }
        private void WRITESENS()
        {
            TESTReading = true;
            string SENSORCODE;
            SENSORCODE = "!!SENSORNO=" + textBox_terminalID.Text + Environment.NewLine;
            serialPort1.WriteLine(SENSORCODE);
        }
        private void WRITECITY()
        {
            TESTReading = true;
            string CITYCODE;
            CITYCODE = "!!CITYCODE=" + textBox_CITYID.Text + Environment.NewLine;
            serialPort1.WriteLine(CITYCODE);
        }
        private void CHECKID()
        {
            TESTReading = true;
            string INFO;
            INFO = "!!INFO" + Environment.NewLine;
            serialPort1.WriteLine(INFO);
        }
        private void ATTACH()
        {
            TESTReading = true;
            string ATT;
            ATT = "!!ATTACH" + Environment.NewLine;
            serialPort1.WriteLine(ATT);
        }

        private void textBox_TESTNUM_TextChanged(object sender, EventArgs e)
        {
            if(NUMS == true)
            {
                NUMS = false;

                ProcessStartInfo pinfo = new ProcessStartInfo();

                pinfo.FileName = "C:\\LTEW\\tools\\search.bat";
                pinfo.Arguments = string.Format(textBox_TESTNUM.Text);
                pinfo.UseShellExecute = true;

                Process p = Process.Start(pinfo);
                p.WaitForExit();


                StreamReader pth = new StreamReader("C:\\LTEW\\tools\\path.txt", Encoding.Default);
                string path;
                path = pth.ReadLine();
                textBox_memo.Text = path;
                pth.Close();


                try
                {
                    StreamReader sr = new StreamReader(path + "\\" + textBox_TESTNUM.Text + ".txt", Encoding.Default);
                    string dat;
                    while ((dat = sr.ReadLine()) != null)
                    {
                        string[] sbuf = dat.Split(',');
                        textBox_USER.Text = sbuf[0];
                        textBox_CITYID.Text = sbuf[1];
                        textBox_terminalID.Text = sbuf[2];
                        textBox_TELLNUM.Text = sbuf[3];
                        textBox_NAME.Text = sbuf[10];
                        textBox_ADDRESS.Text = sbuf[13] + sbuf[14] + sbuf[15];
                        textBox_VENDER.Text = sbuf[45];
                        textBox_VENDERAD.Text = sbuf[46];
                        textBox_RECEIVER.Text = sbuf[47];
                        textBox_RECEIVEAD.Text = sbuf[48];

                    }
                    sr.Close();
                    TESTMODE = true;
                    textBox_SIMNUM.Focus();
                    textBox_SIMNUM.SelectAll();
                }
                catch
                {
                    textBox_memo.Text = "台帳に登録がありません。";
                }

                
            }
            //NUMS = true;


        }

        private void button_STFW_Click(object sender, EventArgs e)
        {
            ProcessStartInfo pinfo = new ProcessStartInfo();

            pinfo.FileName = "C:\\LTEW\\STFW\\LTEW_ST.bat";
            pinfo.Arguments = string.Format(textBox_STFWPASS.Text);
            pinfo.UseShellExecute = true;

            Process p = Process.Start(pinfo);
            p.WaitForExit();


            //System.Diagnostics.Process p = 
            //    System.Diagnostics.Process.Start("C:\\LTEW\\STFW\\LTEW_ST.bat", @"textBox_STFWPASS.Text");

            try
            {
                string[] name = Directory.GetFiles("C:\\LTEW\\STFW", "ERROR_ST.log");
                textBox_memo.Text = "FWを書き込み出来ませんでした。";
                textBox_IMEI.Focus();
                textBox_IMEI.SelectAll();
            }
            catch
            {
                textBox_memo.Text = "FW書込み完了　IMEIを読み込んでください。";
                textBox_IMEI.Focus();
                textBox_IMEI.SelectAll();

            }

        }

        private void TESTLOG()
        {
            try
            {
                StreamWriter LOG = new StreamWriter("C:\\LTEW\\" + textBox_CITYID.Text + "\\" + textBox_TESTNUM.Text + "\\" + textBox_TESTNUM.Text + ".log", false, Encoding.Default);
                for (int i = 0; i < listBox_LOG.Items.Count; i++)
                {
                    listBox_LOG.SelectedIndices.Add(i);
                    LOG.WriteLine(listBox_LOG.SelectedItem);
                }
                LOG.Close();
            }
            catch
            {
                textBox_memo.Text = "電話番号が読み込まれていません。";
                textBox_IMEI.Focus();
                textBox_IMEI.SelectAll();
            }
        }

        private void LOGOUTPUT()
        {
            string TEXTDATA = null;

            DateTime dt = DateTime.Now;
            string datetime = dt.ToString("yyyyMMddHHmmss");


            string[] results = {datetime, textBox_USER.Text, textBox_TELLNUM.Text, textBox_SIMNUM.Text,
            textBox_IMEI.Text, textBox_CITYID.Text,textBox_terminalID.Text,textBox_WNC.Text,
            textBox_STFW.Text,textBox_TEMP.Text,textBox_VOLT.Text ,textBox_DIST.Text,textBox_NAME.Text,
            textBox_ADDRESS.Text, textBox_VENDER.Text,textBox_VENDERAD.Text,textBox_RECEIVER.Text,textBox_RECEIVEAD.Text};

            try
            {
                StreamWriter prow = new StreamWriter("C:\\LTEW\\tools\\Product.csv", true, Encoding.Default);
                for (int i = 0; i < results.Length; i++)
                {
                    if (i == 0)
                    {
                        TEXTDATA = results[i] + ",";
                    }
                    else
                    {
                        TEXTDATA = TEXTDATA + results[i] + ",";
                    }

                }
                prow.WriteLine(TEXTDATA);
                prow.Close();



                TESTLOG();



                StreamReader pror = new StreamReader("C:\\LTEW\\tools\\Product.csv", Encoding.Default);
                string PRONUM;
                int j = 0;
                while ((PRONUM = pror.ReadLine()) != null)
                {
                    j++;
                }
                j = j - 1;
                textBox_COUNT.Text = j.ToString();
                pror.Close();



            }
            catch
            {

            }

            textBox_memo.Text = "ログに結果が記載されました。テストは合格で終了です。";
            listBox_LOG.Items.Clear();
            //textBox_SIMNUM.Enabled = false;
            textBox_IMEI.Focus();
            textBox_IMEI.SelectAll();

        }

    }

    
}
