using System;
using System.Net;
using System.Net.Sockets;
using System.Drawing;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace vsXxpapp
{
    public partial class Form1 : Form
    {
        int HISTO_MIN = 0;
        int HISTO_YMAX = 256;
        int HISTO_XMAX = 31;
        int HISTO_YINT = 32;
        int HISTO_XINT = 1;
        int GRAPH_MIN = 0;
        int GRAPH_YMAX = 256;
        int GRAPH_XMAX = 1023;
        int GRAPH_YINT = 32;

        String[] buffer = new String[255];
        public bool _serverWork = true;
        int[] histogramData = new int[32];
        int[] graphicData = new int[1024];
        int histogramArrayStep = 0;
        bool graphicOn = false;
        bool graphicUpd = false;
        int graphicChan = 0;
        int graphicStep = 0;
        int packReceived = 0;
        string mode = "label";
        bool isLabelRAW = true;
        private List<byte[]> rawDataIn = new List<byte[]>();

        public void serverThread()
        {
            UdpClient udpClient = new UdpClient(Convert.ToInt16(tbEthPort.Text));
            while (_serverWork)
            {
                try
                {
                    IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, Convert.ToInt16(tbEthPort.Text));
                    Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);

                    if (mode == "label")
                    {
                        if ((receiveBytes[0] - 1 == packReceived) || (receiveBytes[0] == 0))
                        {
                            packReceived = receiveBytes[0];
                        }
                        else
                        {
                            Invoke(new Action(() =>
                            {
                                tbPackLoss.Text = (Convert.ToInt16(tbPackLoss.Text) + 1).ToString();
                                if (tbPackLoss.Text != "0")
                                {
                                    rtbTest.Text = (String.Format("Потеряли пакет(ы) в диапазоне {0}-{1} \r\n{2}", packReceived, receiveBytes[0], rtbTest.Text));
                                }
                                
                            }));
                            packReceived = receiveBytes[0];
                        }
                        if (receiveBytes.Length > 0)
                            lock (rawDataIn)
                                rawDataIn.Add(receiveBytes);
                    }
                    else if (mode == "lcm")
                    {
                        /*if (receiveBytes.Length > 0)
                            for (i = 0; i < receiveBytes.Length; i++)
                            {
                                bigDataIn[i] = receiveBytes[i];
                            }
                        */
                    }
                }
                catch
                {
                    MessageBox.Show("Пока закрывали программу - что-то пошло не так", "Некритическая ошибка");
                }
                graphicUpd = true;
                histogramArrayStep = 0;
            }
        }

        public Form1()
        {
            InitializeComponent();
            /*
            ToolTip ttMain = new ToolTip();
            // Set up the delays for the ToolTip.
            ttMain.AutoPopDelay = 5000;
            ttMain.InitialDelay = 500;
            ttMain.ReshowDelay = 100;
            // Force the ToolTip text to be displayed whether or not the form is active.
            ttMain.ShowAlways = true;
            // Set up the ToolTip texts here.
            ttMain.SetToolTip(this.rtbEthLog, tt_rtbEthLog);
            ttMain.SetToolTip(this.cbUARTMark, tT_cbUARTMark);
            */
            Thread thdUDPServer = new Thread(new ThreadStart(serverThread));
            thdUDPServer.IsBackground = true;
            thdUDPServer.Start();

        }

        private void Chart_Init()
        {
            int[] histogramEnum = new int[HISTO_XMAX + 1];
            int[] graphicEnum = new int[GRAPH_XMAX + 1];

            chartHistogram.ChartAreas[0].AxisY.Minimum = HISTO_MIN;
            chartHistogram.ChartAreas[0].AxisY.Maximum = HISTO_YMAX + 1;
            chartHistogram.ChartAreas[0].AxisY.Interval = HISTO_YINT;
            chartHistogram.ChartAreas[0].AxisX.Minimum = HISTO_MIN;
            chartHistogram.ChartAreas[0].AxisX.Maximum = HISTO_XMAX;
            chartHistogram.ChartAreas[0].AxisX.Interval = HISTO_XINT;
            chartHistogram.Series["DataHistogram"].IsVisibleInLegend = false;

            chartGraphic.ChartAreas[0].AxisY.Minimum = GRAPH_MIN;
            chartGraphic.ChartAreas[0].AxisY.Maximum = GRAPH_YMAX + 1;
            chartGraphic.ChartAreas[0].AxisY.Interval = GRAPH_YINT;
            chartGraphic.ChartAreas[0].AxisX.Minimum = GRAPH_MIN;
            chartGraphic.ChartAreas[0].AxisX.Maximum = GRAPH_XMAX;
            chartGraphic.ChartAreas[0].AxisX.Interval = GRAPH_YINT;
            chartGraphic.Series["DataGraphic"].IsVisibleInLegend = false;

            chartHistogram.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartHistogram.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartHistogram.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chartHistogram.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;

            chartGraphic.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartGraphic.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartGraphic.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chartGraphic.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;

            chartHistogram.ChartAreas[0].CursorX.IsUserEnabled = true;
            chartHistogram.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chartHistogram.ChartAreas[0].CursorX.SelectionColor = System.Drawing.Color.LightGray;

            chartGraphic.ChartAreas[0].CursorX.IsUserEnabled = true;
            chartGraphic.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chartGraphic.ChartAreas[0].CursorX.SelectionColor = System.Drawing.Color.Azure;

            chartGraphic.Series["DataGraphic"].Points.Clear();
            chartHistogram.Series["DataHistogram"].Points.Clear();

            if (mode == "label")
            {
                for (int i = 0; i < HISTO_XMAX + 1; i++)
                {
                    histogramEnum[i] = i;
                    chartHistogram.Series["DataHistogram"].Points.AddXY(histogramEnum[i], 0);
                }
                for (int i = 0; i < GRAPH_XMAX + 1; i++)
                {
                    chartGraphic.Series["DataGraphic"].Points.AddXY(graphicEnum[i], 0);
                }
            }
            else if (mode == "lcm")
            {
                for (int i = 0; i < HISTO_XMAX + 1; i++)
                {
                    histogramEnum[i] = i;
                    chartHistogram.Series["DataHistogram"].Points.AddXY(histogramEnum[i], 0);
                }
                for (int i = 0; i < GRAPH_XMAX + 1; i++)
                {
                    chartGraphic.Series["DataGraphic"].Points.AddXY(graphicEnum[i], 0);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mode = "label";
            Chart_Init();
            tmrHisto.Enabled = true;
        }

        private void tsmiEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
            _serverWork = false;
        }

        private void tmrHisto_Tick(object sender, EventArgs e)
        {
            byte[][] data;
            int[] graphicEnum = new int[1024];
            //short* pointer;

            lock (rawDataIn)
            {
                data = rawDataIn.ToArray();
                rawDataIn.Clear();
            }
            if (data.Length == 0)
                return;

            if (mode == "label")
            {
                if (isLabelRAW)
                {
                    int[] slice = new int[32];
                    foreach (byte[] item in data)
                    {
                        if (graphicUpd)
                            if (graphicOn)
                            {
                                for (int i = 0; i < 32; i++)
                                    graphicData[i + (graphicStep << 5)] = item[i * 32 + graphicChan + 1];
                                graphicStep++;
                                if (graphicStep == 32)
                                    graphicStep = 0;
                                chartGraphic.Series["DataGraphic"].Points.DataBindXY(graphicEnum, graphicData);
                            }
                        for (int i = 0; i < 32; i++)
                            slice[i] = item[i + histogramArrayStep *32 + 1];
                        
                    }
                    graphicUpd = false;

                    histogramArrayStep++;
                    if (histogramArrayStep == 32) histogramArrayStep = 0;
                    chartHistogram.Series["DataHistogram"].Points.Clear();
                    for (int i = 0; i < HISTO_XMAX + 1; i++)
                        chartHistogram.Series["DataHistogram"].Points.AddXY(i, slice[i]);
                }
                else
                {
                    foreach (byte[] item in data)
                    {
                        // this is what i should try
                        short[] sdata = new short[512];
                        Buffer.BlockCopy(item, 1, sdata, 0, item.Length-1);

//                        for (int i = 0; i < 16; i++)
//                            slice[i] = item[i << 1 + histogramArrayStep * 32 + 2] + (item[i << 1 + histogramArrayStep * 32 + 1] << 8);
                        if (graphicUpd)
                            if (graphicOn)
                            {

                            }
                    }
                    histogramArrayStep++;
                    if (histogramArrayStep == 32) histogramArrayStep = 0;
                    chartHistogram.Series["DataHistogram"].Points.Clear();
                    for (int i = 0; i < HISTO_XMAX + 1; i++)
                        chartHistogram.Series["DataHistogram"].Points.AddXY(i, slice[i]);

                }
            }
/*            else if (mode == "lcm")
            {
                foreach (byte[] item in data)
                    for (int i = 0; i < 32; i++)
                    {
                        slice[i] = item[i + 32 * histogramArrayStep + 1] + ((item[i + 32 * histogramArrayStep + 1] & 0x3) << 8);
                    }
                histogramArrayStep++;
                if (histogramArrayStep == 32) histogramArrayStep = 0;
                chartHistogram.Series["DataHistogram"].Points.Clear();
                for (int i = 0; i < 32; i++)
                {
                    chartHistogram.Series["DataHistogram"].Points.AddXY(i, slice[i]);//DataBindXY(histogramEnum, slice); // вывод на чарт собранного массива
                }
            }*/
        }

        private void chartHistogram_CursorPositionChanged(object sender, System.Windows.Forms.DataVisualization.Charting.CursorEventArgs e)
        {
            // find a point (this series only has Y values, so using position as index works
            // for a series with actual X values, you'd need to Find the closest point
            try
            {
                DataPoint pt = chartHistogram.Series[0].Points[(int)Math.Max(e.ChartArea.CursorX.Position, 0)];
                pt.MarkerStyle = MarkerStyle.Square;
                if (graphicChan == Convert.ToInt32(pt.XValue) && (graphicOn))
                {
                    graphicOn = false;
                    tssLblStatus.Text = String.Format("Последнее сообщение: Останавливаю вывод на график {0}-го канала", graphicChan);
                }
                else
                {
                    graphicOn = true;
                    graphicChan = Convert.ToInt32(pt.XValue);
                    tssLblStatus.Text = String.Format("Последнее сообщение: Вывожу на график {0}-й канал", graphicChan);
                }
            }
            catch
            {
                tssLblStatus.Text = "Последнее сообщение: Выбран диапазон значений гистограммы. Вывод на график остановлен.";
                graphicOn = false;
            }
        }

        private void btnDrawPause_Click(object sender, EventArgs e)
        {
            if (tmrHisto.Enabled)
            {
                tmrHisto.Enabled = false;
                graphicOn = false;
                btnDrawPause.Text = "Возобновить вывод";
            }
            else
            {
                Chart_Init();
                tmrHisto.Enabled = true;
                graphicOn = true;
                btnDrawPause.Text = "Приостановить вывод";
            }
        }

        private void tsmiLCM_Click(object sender, EventArgs e)
        {
            mode = "lcm";
            tssLblMode.Text = "Режим: МЛК";
            tsmiLabel.Checked = false;
            tsmiLabel.CheckState = CheckState.Unchecked;
            tbEthPort.Text = "2015";
            HISTO_XMAX = 49;
            Chart_Init();
        }

        private void chartGraphic_CursorPositionChanged(object sender, CursorEventArgs e)
        {
            try
            {
                DataPoint pt = chartGraphic.Series[0].Points[(int)Math.Max(e.ChartArea.CursorX.Position - 1, 0)];
                pt.MarkerStyle = MarkerStyle.Square;
                tbGraphicValue.Text = Convert.ToInt32(pt.YValues[0]).ToString();
            }
            catch
            {
            }
        }

        private void tsmiLabelRAW_Click(object sender, EventArgs e)
        {
            mode = "label";
            isLabelRAW = true;
            tssLblMode.Text = "Режим: Метка";
            tsmiLCM.CheckState = CheckState.Unchecked;
            tsmiLCM.Checked = false;
            tbEthPort.Text = "2016";
            HISTO_YMAX = 256;
            HISTO_XMAX = 31;
            Chart_Init();
        }

        private void tsmiLabelFix_Click(object sender, EventArgs e)
        {
            mode = "label";
            isLabelRAW = false;
            tssLblMode.Text = "Режим: Метка";
            tsmiLCM.CheckState = CheckState.Unchecked;
            tsmiLCM.Checked = false;
            tbEthPort.Text = "2016";
            HISTO_YMAX = 1024;
            HISTO_XMAX = 15;
            Chart_Init();
        }
    }
}
