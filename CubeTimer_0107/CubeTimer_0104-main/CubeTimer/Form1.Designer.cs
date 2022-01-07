namespace CubeTimer
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.L_time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.L_scramble = new System.Windows.Forms.Label();
            this.B_change = new System.Windows.Forms.Button();
            this.B_show = new System.Windows.Forms.Button();
            this.L_average = new System.Windows.Forms.Label();
            this.L_best = new System.Windows.Forms.Label();
            this.L_worst = new System.Windows.Forms.Label();
            this.L_avg_num = new System.Windows.Forms.Label();
            this.L_best_num = new System.Windows.Forms.Label();
            this.L_worst_num = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.L_count_num = new System.Windows.Forms.Label();
            this.L_count = new System.Windows.Forms.Label();
            this.L_ao5_num = new System.Windows.Forms.Label();
            this.L_ao5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.登入登出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.網頁版ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cstimernetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mingZesYouTubeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.客製文字ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foreColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foreColorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.backColorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backColorToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.videoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.T_history = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // L_time
            // 
            this.L_time.AutoSize = true;
            this.L_time.Font = new System.Drawing.Font("Segoe UI", 108F);
            this.L_time.Location = new System.Drawing.Point(221, 143);
            this.L_time.Name = "L_time";
            this.L_time.Size = new System.Drawing.Size(515, 286);
            this.L_time.TabIndex = 0;
            this.L_time.Text = "0.00";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // L_scramble
            // 
            this.L_scramble.AutoSize = true;
            this.L_scramble.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.L_scramble.Location = new System.Drawing.Point(198, 80);
            this.L_scramble.Name = "L_scramble";
            this.L_scramble.Size = new System.Drawing.Size(0, 67);
            this.L_scramble.TabIndex = 1;
            this.L_scramble.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // B_change
            // 
            this.B_change.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.B_change.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_change.Location = new System.Drawing.Point(48, 635);
            this.B_change.Name = "B_change";
            this.B_change.Size = new System.Drawing.Size(170, 100);
            this.B_change.TabIndex = 3;
            this.B_change.TabStop = false;
            this.B_change.Text = "new";
            this.B_change.UseVisualStyleBackColor = false;
            this.B_change.Click += new System.EventHandler(this.B_change_Click);
            // 
            // B_show
            // 
            this.B_show.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.B_show.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_show.Location = new System.Drawing.Point(228, 635);
            this.B_show.Name = "B_show";
            this.B_show.Size = new System.Drawing.Size(170, 100);
            this.B_show.TabIndex = 7;
            this.B_show.TabStop = false;
            this.B_show.Text = "hide";
            this.B_show.UseVisualStyleBackColor = false;
            this.B_show.Click += new System.EventHandler(this.B_show_Click);
            // 
            // L_average
            // 
            this.L_average.AutoSize = true;
            this.L_average.Location = new System.Drawing.Point(13, 180);
            this.L_average.Name = "L_average";
            this.L_average.Size = new System.Drawing.Size(236, 65);
            this.L_average.TabIndex = 0;
            this.L_average.Text = "Average : ";
            // 
            // L_best
            // 
            this.L_best.AutoSize = true;
            this.L_best.Location = new System.Drawing.Point(13, 290);
            this.L_best.Name = "L_best";
            this.L_best.Size = new System.Drawing.Size(153, 65);
            this.L_best.TabIndex = 1;
            this.L_best.Text = "Best : ";
            // 
            // L_worst
            // 
            this.L_worst.AutoSize = true;
            this.L_worst.Location = new System.Drawing.Point(13, 400);
            this.L_worst.Name = "L_worst";
            this.L_worst.Size = new System.Drawing.Size(188, 65);
            this.L_worst.TabIndex = 3;
            this.L_worst.Text = "Worst : ";
            // 
            // L_avg_num
            // 
            this.L_avg_num.AutoSize = true;
            this.L_avg_num.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_avg_num.Location = new System.Drawing.Point(220, 180);
            this.L_avg_num.Name = "L_avg_num";
            this.L_avg_num.Size = new System.Drawing.Size(66, 65);
            this.L_avg_num.TabIndex = 5;
            this.L_avg_num.Text = "--";
            // 
            // L_best_num
            // 
            this.L_best_num.AutoSize = true;
            this.L_best_num.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_best_num.Location = new System.Drawing.Point(220, 290);
            this.L_best_num.Name = "L_best_num";
            this.L_best_num.Size = new System.Drawing.Size(66, 65);
            this.L_best_num.TabIndex = 6;
            this.L_best_num.Text = "--";
            // 
            // L_worst_num
            // 
            this.L_worst_num.AutoSize = true;
            this.L_worst_num.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_worst_num.Location = new System.Drawing.Point(220, 400);
            this.L_worst_num.Name = "L_worst_num";
            this.L_worst_num.Size = new System.Drawing.Size(66, 65);
            this.L_worst_num.TabIndex = 8;
            this.L_worst_num.Text = "--";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.L_count_num);
            this.groupBox1.Controls.Add(this.L_count);
            this.groupBox1.Controls.Add(this.L_ao5_num);
            this.groupBox1.Controls.Add(this.L_ao5);
            this.groupBox1.Controls.Add(this.L_worst_num);
            this.groupBox1.Controls.Add(this.L_best_num);
            this.groupBox1.Controls.Add(this.L_avg_num);
            this.groupBox1.Controls.Add(this.L_worst);
            this.groupBox1.Controls.Add(this.L_best);
            this.groupBox1.Controls.Add(this.L_average);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(942, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 613);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statistics";
            // 
            // L_count_num
            // 
            this.L_count_num.AutoSize = true;
            this.L_count_num.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_count_num.Location = new System.Drawing.Point(220, 70);
            this.L_count_num.Name = "L_count_num";
            this.L_count_num.Size = new System.Drawing.Size(54, 65);
            this.L_count_num.TabIndex = 12;
            this.L_count_num.Text = "0";
            // 
            // L_count
            // 
            this.L_count.AutoSize = true;
            this.L_count.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_count.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.L_count.Location = new System.Drawing.Point(13, 70);
            this.L_count.Name = "L_count";
            this.L_count.Size = new System.Drawing.Size(184, 65);
            this.L_count.TabIndex = 11;
            this.L_count.Text = "count : ";
            // 
            // L_ao5_num
            // 
            this.L_ao5_num.AutoSize = true;
            this.L_ao5_num.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_ao5_num.Location = new System.Drawing.Point(220, 520);
            this.L_ao5_num.Name = "L_ao5_num";
            this.L_ao5_num.Size = new System.Drawing.Size(66, 65);
            this.L_ao5_num.TabIndex = 10;
            this.L_ao5_num.Text = "--";
            // 
            // L_ao5
            // 
            this.L_ao5.AutoSize = true;
            this.L_ao5.Location = new System.Drawing.Point(13, 520);
            this.L_ao5.Name = "L_ao5";
            this.L_ao5.Size = new System.Drawing.Size(149, 65);
            this.L_ao5.TabIndex = 9;
            this.L_ao5.Text = "Ao5 : ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.登入登出ToolStripMenuItem,
            this.statisticsToolStripMenuItem,
            this.網頁版ToolStripMenuItem,
            this.客製文字ToolStripMenuItem,
            this.instructionToolStripMenuItem,
            this.creditsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1328, 46);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 登入登出ToolStripMenuItem
            // 
            this.登入登出ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logInToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.登入登出ToolStripMenuItem.Name = "登入登出ToolStripMenuItem";
            this.登入登出ToolStripMenuItem.Size = new System.Drawing.Size(93, 42);
            this.登入登出ToolStripMenuItem.Text = "User";
            // 
            // logInToolStripMenuItem
            // 
            this.logInToolStripMenuItem.Name = "logInToolStripMenuItem";
            this.logInToolStripMenuItem.Size = new System.Drawing.Size(303, 42);
            this.logInToolStripMenuItem.Text = "Log In";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(303, 42);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.B_logout_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(303, 42);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.ExportToolStripMenuItem_Click);
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staticsToolStripMenuItem,
            this.historyToolStripMenuItem});
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(154, 42);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            // 
            // staticsToolStripMenuItem
            // 
            this.staticsToolStripMenuItem.Name = "staticsToolStripMenuItem";
            this.staticsToolStripMenuItem.Size = new System.Drawing.Size(208, 42);
            this.staticsToolStripMenuItem.Text = "Statics";
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(208, 42);
            this.historyToolStripMenuItem.Text = "History";
            // 
            // 網頁版ToolStripMenuItem
            // 
            this.網頁版ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cstimernetToolStripMenuItem,
            this.mingZesYouTubeToolStripMenuItem});
            this.網頁版ToolStripMenuItem.Name = "網頁版ToolStripMenuItem";
            this.網頁版ToolStripMenuItem.Size = new System.Drawing.Size(159, 42);
            this.網頁版ToolStripMenuItem.Text = "Websites";
            // 
            // cstimernetToolStripMenuItem
            // 
            this.cstimernetToolStripMenuItem.Name = "cstimernetToolStripMenuItem";
            this.cstimernetToolStripMenuItem.Size = new System.Drawing.Size(263, 42);
            this.cstimernetToolStripMenuItem.Text = "cstimer.net";
            this.cstimernetToolStripMenuItem.Click += new System.EventHandler(this.CstimernetToolStripMenuItem_Click);
            // 
            // mingZesYouTubeToolStripMenuItem
            // 
            this.mingZesYouTubeToolStripMenuItem.Name = "mingZesYouTubeToolStripMenuItem";
            this.mingZesYouTubeToolStripMenuItem.Size = new System.Drawing.Size(263, 42);
            this.mingZesYouTubeToolStripMenuItem.Text = "YouTube";
            this.mingZesYouTubeToolStripMenuItem.Click += new System.EventHandler(this.MingZesYouTubeToolStripMenuItem_Click);
            // 
            // 客製文字ToolStripMenuItem
            // 
            this.客製文字ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeColorToolStripMenuItem,
            this.changeFontToolStripMenuItem,
            this.buttonColorToolStripMenuItem,
            this.buttonFontToolStripMenuItem,
            this.backColorToolStripMenuItem2});
            this.客製文字ToolStripMenuItem.Name = "客製文字ToolStripMenuItem";
            this.客製文字ToolStripMenuItem.Size = new System.Drawing.Size(179, 42);
            this.客製文字ToolStripMenuItem.Text = "Customize";
            // 
            // changeColorToolStripMenuItem
            // 
            this.changeColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.foreColorToolStripMenuItem,
            this.backColorToolStripMenuItem});
            this.changeColorToolStripMenuItem.Name = "changeColorToolStripMenuItem";
            this.changeColorToolStripMenuItem.Size = new System.Drawing.Size(360, 42);
            this.changeColorToolStripMenuItem.Text = "Text Color";
            // 
            // foreColorToolStripMenuItem
            // 
            this.foreColorToolStripMenuItem.Name = "foreColorToolStripMenuItem";
            this.foreColorToolStripMenuItem.Size = new System.Drawing.Size(256, 42);
            this.foreColorToolStripMenuItem.Text = "Fore Color";
            this.foreColorToolStripMenuItem.Click += new System.EventHandler(this.ForeColorToolStripMenuItem_Click);
            // 
            // backColorToolStripMenuItem
            // 
            this.backColorToolStripMenuItem.Name = "backColorToolStripMenuItem";
            this.backColorToolStripMenuItem.Size = new System.Drawing.Size(256, 42);
            this.backColorToolStripMenuItem.Text = "Back Color";
            this.backColorToolStripMenuItem.Click += new System.EventHandler(this.BackColorToolStripMenuItem_Click);
            // 
            // changeFontToolStripMenuItem
            // 
            this.changeFontToolStripMenuItem.Name = "changeFontToolStripMenuItem";
            this.changeFontToolStripMenuItem.Size = new System.Drawing.Size(360, 42);
            this.changeFontToolStripMenuItem.Text = "Text Font";
            this.changeFontToolStripMenuItem.Click += new System.EventHandler(this.ChangeFontToolStripMenuItem_Click);
            // 
            // buttonColorToolStripMenuItem
            // 
            this.buttonColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.foreColorToolStripMenuItem1,
            this.backColorToolStripMenuItem1});
            this.buttonColorToolStripMenuItem.Name = "buttonColorToolStripMenuItem";
            this.buttonColorToolStripMenuItem.Size = new System.Drawing.Size(360, 42);
            this.buttonColorToolStripMenuItem.Text = "Button Color";
            // 
            // foreColorToolStripMenuItem1
            // 
            this.foreColorToolStripMenuItem1.Name = "foreColorToolStripMenuItem1";
            this.foreColorToolStripMenuItem1.Size = new System.Drawing.Size(256, 42);
            this.foreColorToolStripMenuItem1.Text = "Fore Color";
            this.foreColorToolStripMenuItem1.Click += new System.EventHandler(this.ForeColorToolStripMenuItem1_Click);
            // 
            // backColorToolStripMenuItem1
            // 
            this.backColorToolStripMenuItem1.Name = "backColorToolStripMenuItem1";
            this.backColorToolStripMenuItem1.Size = new System.Drawing.Size(256, 42);
            this.backColorToolStripMenuItem1.Text = "Back Color";
            this.backColorToolStripMenuItem1.Click += new System.EventHandler(this.BackColorToolStripMenuItem1_Click);
            // 
            // buttonFontToolStripMenuItem
            // 
            this.buttonFontToolStripMenuItem.Name = "buttonFontToolStripMenuItem";
            this.buttonFontToolStripMenuItem.Size = new System.Drawing.Size(360, 42);
            this.buttonFontToolStripMenuItem.Text = "Button Font";
            this.buttonFontToolStripMenuItem.Click += new System.EventHandler(this.ButtonFontToolStripMenuItem_Click);
            // 
            // backColorToolStripMenuItem2
            // 
            this.backColorToolStripMenuItem2.Name = "backColorToolStripMenuItem2";
            this.backColorToolStripMenuItem2.Size = new System.Drawing.Size(360, 42);
            this.backColorToolStripMenuItem2.Text = "Background Color";
            this.backColorToolStripMenuItem2.Click += new System.EventHandler(this.BackColorToolStripMenuItem2_Click);
            // 
            // instructionToolStripMenuItem
            // 
            this.instructionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionToolStripMenuItem1,
            this.videoToolStripMenuItem});
            this.instructionToolStripMenuItem.Name = "instructionToolStripMenuItem";
            this.instructionToolStripMenuItem.Size = new System.Drawing.Size(195, 42);
            this.instructionToolStripMenuItem.Text = "Instructions";
            // 
            // instructionToolStripMenuItem1
            // 
            this.instructionToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textToolStripMenuItem,
            this.videoToolStripMenuItem1});
            this.instructionToolStripMenuItem1.Name = "instructionToolStripMenuItem1";
            this.instructionToolStripMenuItem1.Size = new System.Drawing.Size(368, 42);
            this.instructionToolStripMenuItem1.Text = "Instructions";
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(189, 42);
            this.textToolStripMenuItem.Text = "Text";
            this.textToolStripMenuItem.Click += new System.EventHandler(this.TextToolStripMenuItem_Click);
            // 
            // videoToolStripMenuItem1
            // 
            this.videoToolStripMenuItem1.Name = "videoToolStripMenuItem1";
            this.videoToolStripMenuItem1.Size = new System.Drawing.Size(189, 42);
            this.videoToolStripMenuItem1.Text = "Video";
            this.videoToolStripMenuItem1.Click += new System.EventHandler(this.VideoToolStripMenuItem1_Click);
            // 
            // videoToolStripMenuItem
            // 
            this.videoToolStripMenuItem.Name = "videoToolStripMenuItem";
            this.videoToolStripMenuItem.Size = new System.Drawing.Size(368, 42);
            this.videoToolStripMenuItem.Text = "Competition Rules";
            this.videoToolStripMenuItem.Click += new System.EventHandler(this.VideoToolStripMenuItem_Click);
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditsToolStripMenuItem1});
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(129, 42);
            this.creditsToolStripMenuItem.Text = "Credits";
            // 
            // creditsToolStripMenuItem1
            // 
            this.creditsToolStripMenuItem1.Name = "creditsToolStripMenuItem1";
            this.creditsToolStripMenuItem1.Size = new System.Drawing.Size(206, 42);
            this.creditsToolStripMenuItem1.Text = "Credits";
            this.creditsToolStripMenuItem1.Click += new System.EventHandler(this.CreditsToolStripMenuItem1_Click);
            // 
            // T_history
            // 
            this.T_history.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_history.Location = new System.Drawing.Point(48, 122);
            this.T_history.Multiline = true;
            this.T_history.Name = "T_history";
            this.T_history.ReadOnly = true;
            this.T_history.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.T_history.Size = new System.Drawing.Size(350, 507);
            this.T_history.TabIndex = 11;
            this.T_history.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1328, 760);
            this.Controls.Add(this.T_history);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.B_show);
            this.Controls.Add(this.B_change);
            this.Controls.Add(this.L_scramble);
            this.Controls.Add(this.L_time);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CubeTimer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label L_scramble;
        private System.Windows.Forms.Button B_change;
        private System.Windows.Forms.Button B_show;
        private System.Windows.Forms.Label L_average;
        private System.Windows.Forms.Label L_best;
        private System.Windows.Forms.Label L_worst;
        private System.Windows.Forms.Label L_avg_num;
        private System.Windows.Forms.Label L_best_num;
        private System.Windows.Forms.Label L_worst_num;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 登入登出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 網頁版ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cstimernetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 客製文字ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mingZesYouTubeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem videoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeFontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foreColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buttonColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foreColorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem backColorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem buttonFontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem videoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem backColorToolStripMenuItem2;
        private System.Windows.Forms.Label L_ao5_num;
        private System.Windows.Forms.Label L_ao5;
        private System.Windows.Forms.TextBox T_history;
        private System.Windows.Forms.Label L_count;
        private System.Windows.Forms.Label L_count_num;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.Timer timer2;
    }
}

