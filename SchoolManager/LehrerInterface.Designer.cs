namespace SchoolManager
{
    partial class LehrerInterface
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LehrerInterface));
            this.panel1 = new System.Windows.Forms.Panel();
            this.XExitbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuIcon = new System.Windows.Forms.PictureBox();
            this.SideBarContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.MainMenuNavIch = new System.Windows.Forms.Button();
            this.MainMenuNavNews = new System.Windows.Forms.Button();
            this.MainMenuNavNoten = new System.Windows.Forms.Button();
            this.MainMenuNavStundenplan = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MainMenuNavAbsenz = new System.Windows.Forms.Button();
            this.ExitBTN = new System.Windows.Forms.Button();
            this.SidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MainIchKlasse1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuIcon)).BeginInit();
            this.SideBarContainer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.XExitbtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.MenuIcon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1139, 43);
            this.panel1.TabIndex = 0;
            // 
            // XExitbtn
            // 
            this.XExitbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.XExitbtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XExitbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.XExitbtn.Location = new System.Drawing.Point(1082, 0);
            this.XExitbtn.Name = "XExitbtn";
            this.XExitbtn.Size = new System.Drawing.Size(57, 43);
            this.XExitbtn.TabIndex = 2;
            this.XExitbtn.Text = "X";
            this.XExitbtn.UseVisualStyleBackColor = true;
            this.XExitbtn.Click += new System.EventHandler(this.OnExit);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Schoolmanager";
            // 
            // MenuIcon
            // 
            this.MenuIcon.Image = global::SchoolManager.Properties.Resources._134216_menu_lines_hamburger_icon;
            this.MenuIcon.InitialImage = ((System.Drawing.Image)(resources.GetObject("MenuIcon.InitialImage")));
            this.MenuIcon.Location = new System.Drawing.Point(8, 3);
            this.MenuIcon.Name = "MenuIcon";
            this.MenuIcon.Size = new System.Drawing.Size(43, 40);
            this.MenuIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuIcon.TabIndex = 1;
            this.MenuIcon.TabStop = false;
            this.MenuIcon.Click += new System.EventHandler(this.OnmenuTransaktion);
            // 
            // SideBarContainer
            // 
            this.SideBarContainer.BackColor = System.Drawing.Color.LightSlateGray;
            this.SideBarContainer.Controls.Add(this.MainMenuNavIch);
            this.SideBarContainer.Controls.Add(this.MainMenuNavNews);
            this.SideBarContainer.Controls.Add(this.MainMenuNavNoten);
            this.SideBarContainer.Controls.Add(this.MainMenuNavStundenplan);
            this.SideBarContainer.Controls.Add(this.panel2);
            this.SideBarContainer.Controls.Add(this.ExitBTN);
            this.SideBarContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBarContainer.Location = new System.Drawing.Point(0, 43);
            this.SideBarContainer.MaximumSize = new System.Drawing.Size(242, 777);
            this.SideBarContainer.MinimumSize = new System.Drawing.Size(87, 777);
            this.SideBarContainer.Name = "SideBarContainer";
            this.SideBarContainer.Size = new System.Drawing.Size(87, 777);
            this.SideBarContainer.TabIndex = 1;
            // 
            // MainMenuNavIch
            // 
            this.MainMenuNavIch.BackColor = System.Drawing.Color.LightSlateGray;
            this.MainMenuNavIch.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.MainMenuNavIch.FlatAppearance.BorderSize = 0;
            this.MainMenuNavIch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainMenuNavIch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuNavIch.Image = global::SchoolManager.Properties.Resources._3643745_human_man_people_person_profile_icon;
            this.MainMenuNavIch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainMenuNavIch.Location = new System.Drawing.Point(3, 3);
            this.MainMenuNavIch.Name = "MainMenuNavIch";
            this.MainMenuNavIch.Size = new System.Drawing.Size(239, 88);
            this.MainMenuNavIch.TabIndex = 0;
            this.MainMenuNavIch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MainMenuNavIch.UseVisualStyleBackColor = false;
            this.MainMenuNavIch.Click += new System.EventHandler(this.IchBtn_click);
            // 
            // MainMenuNavNews
            // 
            this.MainMenuNavNews.BackColor = System.Drawing.Color.LightSlateGray;
            this.MainMenuNavNews.FlatAppearance.BorderSize = 0;
            this.MainMenuNavNews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainMenuNavNews.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuNavNews.Image = global::SchoolManager.Properties.Resources._115708_news_newspaper_subscribe_icon;
            this.MainMenuNavNews.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainMenuNavNews.Location = new System.Drawing.Point(3, 97);
            this.MainMenuNavNews.Name = "MainMenuNavNews";
            this.MainMenuNavNews.Size = new System.Drawing.Size(239, 88);
            this.MainMenuNavNews.TabIndex = 1;
            this.MainMenuNavNews.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MainMenuNavNews.UseVisualStyleBackColor = false;
            this.MainMenuNavNews.Click += new System.EventHandler(this.Newsbtn_click);
            // 
            // MainMenuNavNoten
            // 
            this.MainMenuNavNoten.BackColor = System.Drawing.Color.LightSlateGray;
            this.MainMenuNavNoten.FlatAppearance.BorderSize = 0;
            this.MainMenuNavNoten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainMenuNavNoten.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuNavNoten.Image = global::SchoolManager.Properties.Resources._9025825_list_numbers_icon;
            this.MainMenuNavNoten.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainMenuNavNoten.Location = new System.Drawing.Point(3, 191);
            this.MainMenuNavNoten.Name = "MainMenuNavNoten";
            this.MainMenuNavNoten.Size = new System.Drawing.Size(239, 88);
            this.MainMenuNavNoten.TabIndex = 2;
            this.MainMenuNavNoten.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MainMenuNavNoten.UseVisualStyleBackColor = false;
            // 
            // MainMenuNavStundenplan
            // 
            this.MainMenuNavStundenplan.BackColor = System.Drawing.Color.LightSlateGray;
            this.MainMenuNavStundenplan.FlatAppearance.BorderSize = 0;
            this.MainMenuNavStundenplan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainMenuNavStundenplan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuNavStundenplan.Image = global::SchoolManager.Properties.Resources._465050_calendar_schedule_date_day_event_icon;
            this.MainMenuNavStundenplan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainMenuNavStundenplan.Location = new System.Drawing.Point(3, 285);
            this.MainMenuNavStundenplan.Name = "MainMenuNavStundenplan";
            this.MainMenuNavStundenplan.Size = new System.Drawing.Size(239, 88);
            this.MainMenuNavStundenplan.TabIndex = 4;
            this.MainMenuNavStundenplan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MainMenuNavStundenplan.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.MainMenuNavAbsenz);
            this.panel2.Location = new System.Drawing.Point(3, 379);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 301);
            this.panel2.TabIndex = 2;
            // 
            // MainMenuNavAbsenz
            // 
            this.MainMenuNavAbsenz.BackColor = System.Drawing.Color.LightSlateGray;
            this.MainMenuNavAbsenz.FlatAppearance.BorderSize = 0;
            this.MainMenuNavAbsenz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainMenuNavAbsenz.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuNavAbsenz.Image = global::SchoolManager.Properties.Resources._8666798_clock_watch_icon;
            this.MainMenuNavAbsenz.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainMenuNavAbsenz.Location = new System.Drawing.Point(0, 4);
            this.MainMenuNavAbsenz.Name = "MainMenuNavAbsenz";
            this.MainMenuNavAbsenz.Size = new System.Drawing.Size(239, 88);
            this.MainMenuNavAbsenz.TabIndex = 3;
            this.MainMenuNavAbsenz.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MainMenuNavAbsenz.UseVisualStyleBackColor = false;
            // 
            // ExitBTN
            // 
            this.ExitBTN.BackColor = System.Drawing.Color.LightSlateGray;
            this.ExitBTN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ExitBTN.FlatAppearance.BorderSize = 0;
            this.ExitBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBTN.Image = global::SchoolManager.Properties.Resources._3005766_account_door_exit_logout_icon;
            this.ExitBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitBTN.Location = new System.Drawing.Point(3, 686);
            this.ExitBTN.Name = "ExitBTN";
            this.ExitBTN.Size = new System.Drawing.Size(239, 86);
            this.ExitBTN.TabIndex = 7;
            this.ExitBTN.Text = "Exit";
            this.ExitBTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExitBTN.UseVisualStyleBackColor = false;
            this.ExitBTN.Click += new System.EventHandler(this.OnExit);
            // 
            // SidebarTimer
            // 
            this.SidebarTimer.Interval = 25;
            this.SidebarTimer.Tick += new System.EventHandler(this.Sidebartimer_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.MainIchKlasse1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(161, 92);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(854, 536);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // MainIchKlasse1
            // 
            this.MainIchKlasse1.AutoSize = true;
            this.MainIchKlasse1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainIchKlasse1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MainIchKlasse1.Location = new System.Drawing.Point(3, 0);
            this.MainIchKlasse1.Name = "MainIchKlasse1";
            this.MainIchKlasse1.Size = new System.Drawing.Size(848, 53);
            this.MainIchKlasse1.TabIndex = 0;
            this.MainIchKlasse1.Click += new System.EventHandler(this.Klasse1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Location = new System.Drawing.Point(3, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(848, 53);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Location = new System.Drawing.Point(3, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(848, 53);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Location = new System.Drawing.Point(3, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(848, 53);
            this.label4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Location = new System.Drawing.Point(3, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(848, 53);
            this.label5.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Location = new System.Drawing.Point(3, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(848, 53);
            this.label6.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Location = new System.Drawing.Point(3, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(848, 53);
            this.label7.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label8.Location = new System.Drawing.Point(3, 371);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(848, 53);
            this.label8.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label9.Location = new System.Drawing.Point(3, 424);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(848, 53);
            this.label9.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label10.Location = new System.Drawing.Point(3, 477);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(848, 59);
            this.label10.TabIndex = 9;
            // 
            // LehrerInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1139, 820);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.SideBarContainer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1599, 820);
            this.Name = "LehrerInterface";
            this.Text = "SchoolManager";
            this.Load += new System.EventHandler(this.SchoolmanagerMainMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuIcon)).EndInit();
            this.SideBarContainer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox MenuIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel SideBarContainer;
        private System.Windows.Forms.Button MainMenuNavIch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button MainMenuNavNews;
        private System.Windows.Forms.Button MainMenuNavNoten;
        private System.Windows.Forms.Button MainMenuNavStundenplan;
        private System.Windows.Forms.Button MainMenuNavAbsenz;
        private System.Windows.Forms.Button ExitBTN;
        private System.Windows.Forms.Button XExitbtn;
        private System.Windows.Forms.Timer SidebarTimer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label MainIchKlasse1;
    }
}