namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.svnm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.indx = new System.Windows.Forms.TextBox();
            this.t = new System.Windows.Forms.TextBox();
            this.pnlPatients = new System.Windows.Forms.Panel();
            this.show_time = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.time1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.p = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.eff = new System.Windows.Forms.TextBox();
            this.prop = new System.Windows.Forms.TextBox();
            this.service = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.users = new System.Windows.Forms.CheckBox();
            this.hours = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.l = new System.Windows.Forms.Label();
            this.part = new System.Windows.Forms.TextBox();
            this.randserv = new System.Windows.Forms.CheckBox();
            this.servpri = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tgrba = new System.Windows.Forms.Label();
            this.dataGrid1 = new System.Windows.Forms.DataGridView();
            this.gridout = new System.Windows.Forms.DataGridView();
            this.big = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlPatients.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(0, 532);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 62);
            this.button1.TabIndex = 2;
            this.button1.Text = "System_output";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(0, 464);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 62);
            this.button2.TabIndex = 3;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(464, 115);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(107, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Time_distribution";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // svnm
            // 
            this.svnm.Location = new System.Drawing.Point(568, 11);
            this.svnm.Name = "svnm";
            this.svnm.Size = new System.Drawing.Size(100, 20);
            this.svnm.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(471, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "number_of_servers";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(690, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Done";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // indx
            // 
            this.indx.Location = new System.Drawing.Point(472, 248);
            this.indx.Name = "indx";
            this.indx.Size = new System.Drawing.Size(100, 20);
            this.indx.TabIndex = 8;
            // 
            // t
            // 
            this.t.Location = new System.Drawing.Point(97, 23);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(100, 20);
            this.t.TabIndex = 10;
            // 
            // pnlPatients
            // 
            this.pnlPatients.Controls.Add(this.show_time);
            this.pnlPatients.Controls.Add(this.button6);
            this.pnlPatients.Controls.Add(this.button4);
            this.pnlPatients.Controls.Add(this.time1);
            this.pnlPatients.Controls.Add(this.label3);
            this.pnlPatients.Controls.Add(this.p);
            this.pnlPatients.Controls.Add(this.t);
            this.pnlPatients.Location = new System.Drawing.Point(612, 40);
            this.pnlPatients.Name = "pnlPatients";
            this.pnlPatients.Size = new System.Drawing.Size(264, 178);
            this.pnlPatients.TabIndex = 11;
            // 
            // show_time
            // 
            this.show_time.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.show_time.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.show_time.Location = new System.Drawing.Point(176, 112);
            this.show_time.Name = "show_time";
            this.show_time.Size = new System.Drawing.Size(75, 33);
            this.show_time.TabIndex = 17;
            this.show_time.Text = "Show";
            this.show_time.UseVisualStyleBackColor = false;
            this.show_time.Click += new System.EventHandler(this.show_time1);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(15, 112);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 33);
            this.button6.TabIndex = 16;
            this.button6.Text = "Save";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(96, 112);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 33);
            this.button4.TabIndex = 12;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // time1
            // 
            this.time1.AutoSize = true;
            this.time1.Location = new System.Drawing.Point(3, 26);
            this.time1.Name = "time1";
            this.time1.Size = new System.Drawing.Size(89, 13);
            this.time1.TabIndex = 15;
            this.time1.Text = "Interarrival_Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Probablilty";
            // 
            // p
            // 
            this.p.Location = new System.Drawing.Point(97, 73);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(100, 20);
            this.p.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.eff);
            this.panel1.Controls.Add(this.prop);
            this.panel1.Controls.Add(this.service);
            this.panel1.Location = new System.Drawing.Point(603, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 248);
            this.panel1.TabIndex = 12;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Location = new System.Drawing.Point(98, 201);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 33);
            this.button8.TabIndex = 18;
            this.button8.Text = "new";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Name";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(97, 3);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 19;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button9.Location = new System.Drawing.Point(186, 166);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 33);
            this.button9.TabIndex = 18;
            this.button9.Text = "Show";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Location = new System.Drawing.Point(17, 166);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 33);
            this.button7.TabIndex = 17;
            this.button7.Text = "Save";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(98, 166);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 33);
            this.button5.TabIndex = 12;
            this.button5.Text = "Add";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "service_time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Probablilty";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Efficency";
            // 
            // eff
            // 
            this.eff.Location = new System.Drawing.Point(97, 123);
            this.eff.Name = "eff";
            this.eff.Size = new System.Drawing.Size(100, 20);
            this.eff.TabIndex = 12;
            // 
            // prop
            // 
            this.prop.Location = new System.Drawing.Point(98, 85);
            this.prop.Name = "prop";
            this.prop.Size = new System.Drawing.Size(100, 20);
            this.prop.TabIndex = 11;
            // 
            // service
            // 
            this.service.Location = new System.Drawing.Point(97, 43);
            this.service.Name = "service";
            this.service.Size = new System.Drawing.Size(100, 20);
            this.service.TabIndex = 10;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(467, 286);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(117, 17);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.Text = "Server_distribution";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // users
            // 
            this.users.AutoSize = true;
            this.users.Location = new System.Drawing.Point(272, 578);
            this.users.Name = "users";
            this.users.Size = new System.Drawing.Size(76, 17);
            this.users.TabIndex = 14;
            this.users.Text = "End_users";
            this.users.UseVisualStyleBackColor = true;
            this.users.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // hours
            // 
            this.hours.AutoSize = true;
            this.hours.Location = new System.Drawing.Point(377, 578);
            this.hours.Name = "hours";
            this.hours.Size = new System.Drawing.Size(78, 17);
            this.hours.TabIndex = 15;
            this.hours.Text = "End_Hours";
            this.hours.UseVisualStyleBackColor = true;
            this.hours.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(461, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Server_number";
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button10.Location = new System.Drawing.Point(249, 461);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(160, 62);
            this.button10.TabIndex = 17;
            this.button10.Text = "Output_Graphicly";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button11.Location = new System.Drawing.Point(120, 464);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(114, 62);
            this.button11.TabIndex = 18;
            this.button11.Text = "Output";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(467, 309);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 19;
            this.button12.Text = "mo";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(471, 181);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(101, 13);
            this.l.TabIndex = 20;
            this.l.Text = "number_of_servers";
            // 
            // part
            // 
            this.part.Location = new System.Drawing.Point(272, 529);
            this.part.Name = "part";
            this.part.Size = new System.Drawing.Size(100, 20);
            this.part.TabIndex = 21;
            // 
            // randserv
            // 
            this.randserv.AutoSize = true;
            this.randserv.Location = new System.Drawing.Point(381, 555);
            this.randserv.Name = "randserv";
            this.randserv.Size = new System.Drawing.Size(107, 17);
            this.randserv.TabIndex = 22;
            this.randserv.Text = "Random_servers";
            this.randserv.UseVisualStyleBackColor = true;
            // 
            // servpri
            // 
            this.servpri.AutoSize = true;
            this.servpri.Location = new System.Drawing.Point(272, 555);
            this.servpri.Name = "servpri";
            this.servpri.Size = new System.Drawing.Size(103, 17);
            this.servpri.TabIndex = 23;
            this.servpri.Text = "Servers_priority";
            this.servpri.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 529);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Max 100 Customer";
            // 
            // tgrba
            // 
            this.tgrba.AutoSize = true;
            this.tgrba.Location = new System.Drawing.Point(567, 314);
            this.tgrba.Name = "tgrba";
            this.tgrba.Size = new System.Drawing.Size(81, 13);
            this.tgrba.TabIndex = 25;
            this.tgrba.Text = "Server_number";
            // 
            // dataGrid1
            // 
            this.dataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid1.Location = new System.Drawing.Point(0, 3);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(455, 431);
            this.dataGrid1.TabIndex = 0;
            // 
            // gridout
            // 
            this.gridout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridout.Location = new System.Drawing.Point(0, 600);
            this.gridout.Name = "gridout";
            this.gridout.Size = new System.Drawing.Size(455, 106);
            this.gridout.TabIndex = 26;
            // 
            // big
            // 
            this.big.Location = new System.Drawing.Point(120, 555);
            this.big.Name = "big";
            this.big.Size = new System.Drawing.Size(100, 20);
            this.big.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(139, 578);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Server_number";
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(32, 15);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "server";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(388, 387);
            this.chart1.TabIndex = 29;
            this.chart1.Text = "chart1";
            title3.Name = "Title1";
            title3.Text = "service chrt";
            this.chart1.Titles.Add(title3);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 750);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.big);
            this.Controls.Add(this.gridout);
            this.Controls.Add(this.tgrba);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.servpri);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.randserv);
            this.Controls.Add(this.part);
            this.Controls.Add(this.l);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.hours);
            this.Controls.Add(this.users);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.pnlPatients);
            this.Controls.Add(this.indx);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.svnm);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGrid1);
            this.Name = "Form1";
            this.Text = "Task";
            this.pnlPatients.ResumeLayout(false);
            this.pnlPatients.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox svnm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox indx;
        private System.Windows.Forms.TextBox t;
        private System.Windows.Forms.Panel pnlPatients;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox p;
        private System.Windows.Forms.Label time1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox eff;
        private System.Windows.Forms.TextBox prop;
        private System.Windows.Forms.TextBox service;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button show_time;
        private System.Windows.Forms.CheckBox users;
        private System.Windows.Forms.CheckBox hours;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.TextBox part;
        private System.Windows.Forms.CheckBox randserv;
        private System.Windows.Forms.CheckBox servpri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label tgrba;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridView dataGrid1;
        private System.Windows.Forms.DataGridView gridout;
        private System.Windows.Forms.TextBox big;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

