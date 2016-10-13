namespace vsXxpapp
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            try
            {
                base.Dispose(disposing);
            }
            catch { }
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chartHistogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartGraphic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbEthPort = new System.Windows.Forms.TextBox();
            this.rtbTest = new System.Windows.Forms.RichTextBox();
            this.tbPackLoss = new System.Windows.Forms.TextBox();
            this.tmrHisto = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssLblMode = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssLblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnDrawPause = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLabel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLCM = new System.Windows.Forms.ToolStripMenuItem();
            this.tbGraphicValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartHistogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraphic)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartHistogram
            // 
            chartArea1.Name = "ChartArea1";
            this.chartHistogram.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartHistogram.Legends.Add(legend1);
            this.chartHistogram.Location = new System.Drawing.Point(12, 27);
            this.chartHistogram.Name = "chartHistogram";
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "DataHistogram";
            this.chartHistogram.Series.Add(series1);
            this.chartHistogram.Size = new System.Drawing.Size(956, 300);
            this.chartHistogram.TabIndex = 0;
            this.chartHistogram.Text = "chart1";
            this.chartHistogram.CursorPositionChanged += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.CursorEventArgs>(this.chartHistogram_CursorPositionChanged);
            // 
            // chartGraphic
            // 
            chartArea2.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.None;
            chartArea2.Name = "ChartArea1";
            this.chartGraphic.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartGraphic.Legends.Add(legend2);
            this.chartGraphic.Location = new System.Drawing.Point(12, 333);
            this.chartGraphic.Name = "chartGraphic";
            this.chartGraphic.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Legend = "Legend1";
            series2.Name = "DataGraphic";
            this.chartGraphic.Series.Add(series2);
            this.chartGraphic.Size = new System.Drawing.Size(1176, 338);
            this.chartGraphic.TabIndex = 1;
            this.chartGraphic.Text = "chart1";
            this.chartGraphic.CursorPositionChanged += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.CursorEventArgs>(this.chartGraphic_CursorPositionChanged);
            // 
            // tbEthPort
            // 
            this.tbEthPort.Location = new System.Drawing.Point(1137, 27);
            this.tbEthPort.Name = "tbEthPort";
            this.tbEthPort.Size = new System.Drawing.Size(51, 20);
            this.tbEthPort.TabIndex = 2;
            this.tbEthPort.Text = "2016";
            // 
            // rtbTest
            // 
            this.rtbTest.Location = new System.Drawing.Point(974, 126);
            this.rtbTest.Name = "rtbTest";
            this.rtbTest.Size = new System.Drawing.Size(214, 96);
            this.rtbTest.TabIndex = 3;
            this.rtbTest.Text = "";
            // 
            // tbPackLoss
            // 
            this.tbPackLoss.Location = new System.Drawing.Point(1136, 228);
            this.tbPackLoss.Name = "tbPackLoss";
            this.tbPackLoss.Size = new System.Drawing.Size(52, 20);
            this.tbPackLoss.TabIndex = 4;
            this.tbPackLoss.Text = "-1";
            // 
            // tmrHisto
            // 
            this.tmrHisto.Tick += new System.EventHandler(this.tmrHisto_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssLblMode,
            this.tssLblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 672);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1200, 24);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssLblMode
            // 
            this.tssLblMode.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tssLblMode.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.tssLblMode.Name = "tssLblMode";
            this.tssLblMode.Size = new System.Drawing.Size(89, 19);
            this.tssLblMode.Text = "Режим: Метка";
            // 
            // tssLblStatus
            // 
            this.tssLblStatus.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tssLblStatus.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.tssLblStatus.Name = "tssLblStatus";
            this.tssLblStatus.Size = new System.Drawing.Size(274, 19);
            this.tssLblStatus.Text = "Последнее сообщение: Приложение запущено";
            // 
            // btnDrawPause
            // 
            this.btnDrawPause.Location = new System.Drawing.Point(974, 277);
            this.btnDrawPause.Name = "btnDrawPause";
            this.btnDrawPause.Size = new System.Drawing.Size(214, 24);
            this.btnDrawPause.TabIndex = 6;
            this.btnDrawPause.Text = "Приостановить вывод";
            this.btnDrawPause.UseVisualStyleBackColor = true;
            this.btnDrawPause.Click += new System.EventHandler(this.btnDrawPause_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.modeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.mainToolStripMenuItem.Text = "Файл";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Ч";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.tsmiEXIT_Click);
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLabel,
            this.tsmiLCM});
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            this.modeToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.modeToolStripMenuItem.Text = "Режим";
            // 
            // tsmiLabel
            // 
            this.tsmiLabel.Name = "tsmiLabel";
            this.tsmiLabel.Size = new System.Drawing.Size(108, 22);
            this.tsmiLabel.Text = "Метка";
            this.tsmiLabel.Click += new System.EventHandler(this.tsmiLabel_Click);
            // 
            // tsmiLCM
            // 
            this.tsmiLCM.Name = "tsmiLCM";
            this.tsmiLCM.Size = new System.Drawing.Size(108, 22);
            this.tsmiLCM.Text = "МЛК";
            this.tsmiLCM.Click += new System.EventHandler(this.tsmiLCM_Click);
            // 
            // tbGraphicValue
            // 
            this.tbGraphicValue.Location = new System.Drawing.Point(1136, 307);
            this.tbGraphicValue.Name = "tbGraphicValue";
            this.tbGraphicValue.Size = new System.Drawing.Size(52, 20);
            this.tbGraphicValue.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1099, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Порт";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1074, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Потеряно";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1072, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Значение:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(974, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Журнал";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 696);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbGraphicValue);
            this.Controls.Add(this.btnDrawPause);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tbPackLoss);
            this.Controls.Add(this.rtbTest);
            this.Controls.Add(this.tbEthPort);
            this.Controls.Add(this.chartGraphic);
            this.Controls.Add(this.chartHistogram);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "UDP-to-Chart v.0.2b";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartHistogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraphic)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartHistogram;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraphic;
        private System.Windows.Forms.TextBox tbEthPort;
        private System.Windows.Forms.RichTextBox rtbTest;
        private System.Windows.Forms.TextBox tbPackLoss;
        private System.Windows.Forms.Timer tmrHisto;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssLblStatus;
        private System.Windows.Forms.ToolStripStatusLabel tssLblMode;
        private System.Windows.Forms.Button btnDrawPause;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiLabel;
        private System.Windows.Forms.ToolStripMenuItem tsmiLCM;
        private System.Windows.Forms.TextBox tbGraphicValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

