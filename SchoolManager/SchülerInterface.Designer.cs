﻿namespace SchoolManager
{
    partial class SchuelerInterface
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchuelerInterface));
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
      this.MainMenuNavDaten = new System.Windows.Forms.Button();
      this.MainMenuNavAbsenz = new System.Windows.Forms.Button();
      this.ExitBTN = new System.Windows.Forms.Button();
      this.IchTableManager = new System.Windows.Forms.TableLayoutPanel();
      this.MainIchTel = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.MainIchStrasse = new System.Windows.Forms.Label();
      this.Strasselbl = new System.Windows.Forms.Label();
      this.MainIchOrt = new System.Windows.Forms.Label();
      this.Ortlbl = new System.Windows.Forms.Label();
      this.MainIchPLZ = new System.Windows.Forms.Label();
      this.PLZlbl = new System.Windows.Forms.Label();
      this.MainIchKlasse = new System.Windows.Forms.Label();
      this.Klasselbl = new System.Windows.Forms.Label();
      this.MainIchStufe = new System.Windows.Forms.Label();
      this.Stufelbl = new System.Windows.Forms.Label();
      this.MainIchGebDate = new System.Windows.Forms.Label();
      this.Gebdatelbl = new System.Windows.Forms.Label();
      this.MainIchNachname = new System.Windows.Forms.Label();
      this.Nachnamelbl = new System.Windows.Forms.Label();
      this.MainIchVorname = new System.Windows.Forms.Label();
      this.Vornamelbl = new System.Windows.Forms.Label();
      this.MainIchEmail = new System.Windows.Forms.Label();
      this.EmailLBL = new System.Windows.Forms.Label();
      this.SidebarTimer = new System.Windows.Forms.Timer(this.components);
      this.imageList1 = new System.Windows.Forms.ImageList(this.components);
      this.StundenplanPB = new System.Windows.Forms.PictureBox();
      this.Noten_table = new System.Windows.Forms.TableLayoutPanel();
      this.Fach_Franz_lbl = new System.Windows.Forms.Label();
      this.Note_Deu_lbl = new System.Windows.Forms.Label();
      this.Fach_Deutsch_lbl = new System.Windows.Forms.Label();
      this.Note_Mathe_lbl = new System.Windows.Forms.Label();
      this.Fach_Mathe_lbl = new System.Windows.Forms.Label();
      this.Note_Info_lbl = new System.Windows.Forms.Label();
      this.Fach_lbl = new System.Windows.Forms.Label();
      this.Note_Franz_lbl = new System.Windows.Forms.Label();
      this.Info_Chb = new System.Windows.Forms.CheckBox();
      this.label3 = new System.Windows.Forms.Label();
      this.Mathe_Chb = new System.Windows.Forms.CheckBox();
      this.Deu_Chb = new System.Windows.Forms.CheckBox();
      this.Franz_Chb = new System.Windows.Forms.CheckBox();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.MenuIcon)).BeginInit();
      this.SideBarContainer.SuspendLayout();
      this.panel2.SuspendLayout();
      this.IchTableManager.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.StundenplanPB)).BeginInit();
      this.Noten_table.SuspendLayout();
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
      this.panel1.Size = new System.Drawing.Size(1138, 43);
      this.panel1.TabIndex = 0;
      // 
      // XExitbtn
      // 
      this.XExitbtn.Dock = System.Windows.Forms.DockStyle.Right;
      this.XExitbtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.XExitbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.XExitbtn.Location = new System.Drawing.Point(1081, 0);
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
      this.label1.Location = new System.Drawing.Point(58, 9);
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
      this.MenuIcon.Size = new System.Drawing.Size(44, 40);
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
      this.MainMenuNavIch.Size = new System.Drawing.Size(238, 88);
      this.MainMenuNavIch.TabIndex = 0;
      this.MainMenuNavIch.Text = "Ich";
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
      this.MainMenuNavNews.Size = new System.Drawing.Size(238, 88);
      this.MainMenuNavNews.TabIndex = 1;
      this.MainMenuNavNews.Text = "News";
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
      this.MainMenuNavNoten.Size = new System.Drawing.Size(238, 88);
      this.MainMenuNavNoten.TabIndex = 2;
      this.MainMenuNavNoten.Text = "Noten";
      this.MainMenuNavNoten.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.MainMenuNavNoten.UseVisualStyleBackColor = false;
      this.MainMenuNavNoten.Click += new System.EventHandler(this.On_Noten_Click);
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
      this.MainMenuNavStundenplan.Size = new System.Drawing.Size(238, 88);
      this.MainMenuNavStundenplan.TabIndex = 4;
      this.MainMenuNavStundenplan.Text = "Stundenplan";
      this.MainMenuNavStundenplan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.MainMenuNavStundenplan.UseVisualStyleBackColor = false;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.MainMenuNavDaten);
      this.panel2.Controls.Add(this.MainMenuNavAbsenz);
      this.panel2.Location = new System.Drawing.Point(3, 379);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(238, 302);
      this.panel2.TabIndex = 2;
      // 
      // MainMenuNavDaten
      // 
      this.MainMenuNavDaten.BackColor = System.Drawing.Color.LightSlateGray;
      this.MainMenuNavDaten.FlatAppearance.BorderSize = 0;
      this.MainMenuNavDaten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.MainMenuNavDaten.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.MainMenuNavDaten.Image = global::SchoolManager.Properties.Resources._8468590_pen_office_vector_pencil_write_icon;
      this.MainMenuNavDaten.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.MainMenuNavDaten.Location = new System.Drawing.Point(0, 102);
      this.MainMenuNavDaten.Name = "MainMenuNavDaten";
      this.MainMenuNavDaten.Size = new System.Drawing.Size(238, 88);
      this.MainMenuNavDaten.TabIndex = 4;
      this.MainMenuNavDaten.Text = "Daten";
      this.MainMenuNavDaten.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.MainMenuNavDaten.UseVisualStyleBackColor = false;
      this.MainMenuNavDaten.Click += new System.EventHandler(this.MainMenuNavDaten_Click);
      // 
      // MainMenuNavAbsenz
      // 
      this.MainMenuNavAbsenz.BackColor = System.Drawing.Color.LightSlateGray;
      this.MainMenuNavAbsenz.FlatAppearance.BorderSize = 0;
      this.MainMenuNavAbsenz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.MainMenuNavAbsenz.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.MainMenuNavAbsenz.Image = global::SchoolManager.Properties.Resources._8666798_clock_watch_icon;
      this.MainMenuNavAbsenz.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.MainMenuNavAbsenz.Location = new System.Drawing.Point(0, 5);
      this.MainMenuNavAbsenz.Name = "MainMenuNavAbsenz";
      this.MainMenuNavAbsenz.Size = new System.Drawing.Size(238, 88);
      this.MainMenuNavAbsenz.TabIndex = 3;
      this.MainMenuNavAbsenz.Text = "Absenz";
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
      this.ExitBTN.Location = new System.Drawing.Point(3, 687);
      this.ExitBTN.Name = "ExitBTN";
      this.ExitBTN.Size = new System.Drawing.Size(238, 86);
      this.ExitBTN.TabIndex = 7;
      this.ExitBTN.Text = "Exit";
      this.ExitBTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.ExitBTN.UseVisualStyleBackColor = false;
      this.ExitBTN.Click += new System.EventHandler(this.OnExit);
      // 
      // IchTableManager
      // 
      this.IchTableManager.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
      this.IchTableManager.ColumnCount = 2;
      this.IchTableManager.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.33464F));
      this.IchTableManager.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.66536F));
      this.IchTableManager.Controls.Add(this.MainIchTel, 1, 9);
      this.IchTableManager.Controls.Add(this.label2, 0, 9);
      this.IchTableManager.Controls.Add(this.MainIchStrasse, 1, 8);
      this.IchTableManager.Controls.Add(this.Strasselbl, 0, 8);
      this.IchTableManager.Controls.Add(this.MainIchOrt, 1, 7);
      this.IchTableManager.Controls.Add(this.Ortlbl, 0, 7);
      this.IchTableManager.Controls.Add(this.MainIchPLZ, 1, 6);
      this.IchTableManager.Controls.Add(this.PLZlbl, 0, 6);
      this.IchTableManager.Controls.Add(this.MainIchKlasse, 1, 5);
      this.IchTableManager.Controls.Add(this.Klasselbl, 0, 5);
      this.IchTableManager.Controls.Add(this.MainIchStufe, 1, 4);
      this.IchTableManager.Controls.Add(this.Stufelbl, 0, 4);
      this.IchTableManager.Controls.Add(this.MainIchGebDate, 1, 3);
      this.IchTableManager.Controls.Add(this.Gebdatelbl, 0, 3);
      this.IchTableManager.Controls.Add(this.MainIchNachname, 1, 2);
      this.IchTableManager.Controls.Add(this.Nachnamelbl, 0, 2);
      this.IchTableManager.Controls.Add(this.MainIchVorname, 1, 1);
      this.IchTableManager.Controls.Add(this.Vornamelbl, 0, 1);
      this.IchTableManager.Controls.Add(this.MainIchEmail, 1, 0);
      this.IchTableManager.Controls.Add(this.EmailLBL, 0, 0);
      this.IchTableManager.Location = new System.Drawing.Point(274, 186);
      this.IchTableManager.Name = "IchTableManager";
      this.IchTableManager.RowCount = 10;
      this.IchTableManager.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
      this.IchTableManager.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
      this.IchTableManager.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
      this.IchTableManager.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
      this.IchTableManager.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
      this.IchTableManager.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
      this.IchTableManager.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
      this.IchTableManager.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
      this.IchTableManager.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
      this.IchTableManager.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
      this.IchTableManager.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.IchTableManager.Size = new System.Drawing.Size(748, 426);
      this.IchTableManager.TabIndex = 2;
      this.IchTableManager.Paint += new System.Windows.Forms.PaintEventHandler(this.IchTableManager_Paint);
      // 
      // MainIchTel
      // 
      this.MainIchTel.AutoSize = true;
      this.MainIchTel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.MainIchTel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.MainIchTel.Location = new System.Drawing.Point(298, 380);
      this.MainIchTel.Name = "MainIchTel";
      this.MainIchTel.Size = new System.Drawing.Size(445, 44);
      this.MainIchTel.TabIndex = 22;
      this.MainIchTel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(5, 380);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(285, 44);
      this.label2.TabIndex = 21;
      this.label2.Text = "Telefonnummer";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // MainIchStrasse
      // 
      this.MainIchStrasse.AutoSize = true;
      this.MainIchStrasse.Dock = System.Windows.Forms.DockStyle.Fill;
      this.MainIchStrasse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.MainIchStrasse.Location = new System.Drawing.Point(298, 338);
      this.MainIchStrasse.Name = "MainIchStrasse";
      this.MainIchStrasse.Size = new System.Drawing.Size(445, 40);
      this.MainIchStrasse.TabIndex = 17;
      this.MainIchStrasse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // Strasselbl
      // 
      this.Strasselbl.AutoSize = true;
      this.Strasselbl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.Strasselbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Strasselbl.Location = new System.Drawing.Point(5, 338);
      this.Strasselbl.Name = "Strasselbl";
      this.Strasselbl.Size = new System.Drawing.Size(285, 40);
      this.Strasselbl.TabIndex = 16;
      this.Strasselbl.Text = "Strasse";
      this.Strasselbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // MainIchOrt
      // 
      this.MainIchOrt.AutoSize = true;
      this.MainIchOrt.Dock = System.Windows.Forms.DockStyle.Fill;
      this.MainIchOrt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.MainIchOrt.Location = new System.Drawing.Point(298, 296);
      this.MainIchOrt.Name = "MainIchOrt";
      this.MainIchOrt.Size = new System.Drawing.Size(445, 40);
      this.MainIchOrt.TabIndex = 15;
      this.MainIchOrt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // Ortlbl
      // 
      this.Ortlbl.AutoSize = true;
      this.Ortlbl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.Ortlbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Ortlbl.Location = new System.Drawing.Point(5, 296);
      this.Ortlbl.Name = "Ortlbl";
      this.Ortlbl.Size = new System.Drawing.Size(285, 40);
      this.Ortlbl.TabIndex = 14;
      this.Ortlbl.Text = "Ort";
      this.Ortlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // MainIchPLZ
      // 
      this.MainIchPLZ.AutoSize = true;
      this.MainIchPLZ.Dock = System.Windows.Forms.DockStyle.Fill;
      this.MainIchPLZ.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.MainIchPLZ.Location = new System.Drawing.Point(298, 254);
      this.MainIchPLZ.Name = "MainIchPLZ";
      this.MainIchPLZ.Size = new System.Drawing.Size(445, 40);
      this.MainIchPLZ.TabIndex = 13;
      this.MainIchPLZ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // PLZlbl
      // 
      this.PLZlbl.AutoSize = true;
      this.PLZlbl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.PLZlbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.PLZlbl.Location = new System.Drawing.Point(5, 254);
      this.PLZlbl.Name = "PLZlbl";
      this.PLZlbl.Size = new System.Drawing.Size(285, 40);
      this.PLZlbl.TabIndex = 12;
      this.PLZlbl.Text = "Postleitzahl";
      this.PLZlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // MainIchKlasse
      // 
      this.MainIchKlasse.AutoSize = true;
      this.MainIchKlasse.Dock = System.Windows.Forms.DockStyle.Fill;
      this.MainIchKlasse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.MainIchKlasse.Location = new System.Drawing.Point(298, 212);
      this.MainIchKlasse.Name = "MainIchKlasse";
      this.MainIchKlasse.Size = new System.Drawing.Size(445, 40);
      this.MainIchKlasse.TabIndex = 11;
      this.MainIchKlasse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // Klasselbl
      // 
      this.Klasselbl.AutoSize = true;
      this.Klasselbl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.Klasselbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Klasselbl.Location = new System.Drawing.Point(5, 212);
      this.Klasselbl.Name = "Klasselbl";
      this.Klasselbl.Size = new System.Drawing.Size(285, 40);
      this.Klasselbl.TabIndex = 10;
      this.Klasselbl.Text = "Klasse";
      this.Klasselbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // MainIchStufe
      // 
      this.MainIchStufe.AutoSize = true;
      this.MainIchStufe.Dock = System.Windows.Forms.DockStyle.Fill;
      this.MainIchStufe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.MainIchStufe.Location = new System.Drawing.Point(298, 170);
      this.MainIchStufe.Name = "MainIchStufe";
      this.MainIchStufe.Size = new System.Drawing.Size(445, 40);
      this.MainIchStufe.TabIndex = 9;
      this.MainIchStufe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // Stufelbl
      // 
      this.Stufelbl.AutoSize = true;
      this.Stufelbl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.Stufelbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Stufelbl.Location = new System.Drawing.Point(5, 170);
      this.Stufelbl.Name = "Stufelbl";
      this.Stufelbl.Size = new System.Drawing.Size(285, 40);
      this.Stufelbl.TabIndex = 8;
      this.Stufelbl.Text = "Stufe";
      this.Stufelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // MainIchGebDate
      // 
      this.MainIchGebDate.AutoSize = true;
      this.MainIchGebDate.Dock = System.Windows.Forms.DockStyle.Fill;
      this.MainIchGebDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.MainIchGebDate.Location = new System.Drawing.Point(298, 128);
      this.MainIchGebDate.Name = "MainIchGebDate";
      this.MainIchGebDate.Size = new System.Drawing.Size(445, 40);
      this.MainIchGebDate.TabIndex = 7;
      this.MainIchGebDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // Gebdatelbl
      // 
      this.Gebdatelbl.AutoSize = true;
      this.Gebdatelbl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.Gebdatelbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Gebdatelbl.Location = new System.Drawing.Point(5, 128);
      this.Gebdatelbl.Name = "Gebdatelbl";
      this.Gebdatelbl.Size = new System.Drawing.Size(285, 40);
      this.Gebdatelbl.TabIndex = 6;
      this.Gebdatelbl.Text = "Geburtstags Datum";
      this.Gebdatelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // MainIchNachname
      // 
      this.MainIchNachname.AutoSize = true;
      this.MainIchNachname.Dock = System.Windows.Forms.DockStyle.Fill;
      this.MainIchNachname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.MainIchNachname.Location = new System.Drawing.Point(298, 86);
      this.MainIchNachname.Name = "MainIchNachname";
      this.MainIchNachname.Size = new System.Drawing.Size(445, 40);
      this.MainIchNachname.TabIndex = 5;
      this.MainIchNachname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // Nachnamelbl
      // 
      this.Nachnamelbl.AutoSize = true;
      this.Nachnamelbl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.Nachnamelbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Nachnamelbl.Location = new System.Drawing.Point(5, 86);
      this.Nachnamelbl.Name = "Nachnamelbl";
      this.Nachnamelbl.Size = new System.Drawing.Size(285, 40);
      this.Nachnamelbl.TabIndex = 4;
      this.Nachnamelbl.Text = "Nachname";
      this.Nachnamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // MainIchVorname
      // 
      this.MainIchVorname.AutoSize = true;
      this.MainIchVorname.Dock = System.Windows.Forms.DockStyle.Fill;
      this.MainIchVorname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.MainIchVorname.Location = new System.Drawing.Point(298, 44);
      this.MainIchVorname.Name = "MainIchVorname";
      this.MainIchVorname.Size = new System.Drawing.Size(445, 40);
      this.MainIchVorname.TabIndex = 3;
      this.MainIchVorname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // Vornamelbl
      // 
      this.Vornamelbl.AutoSize = true;
      this.Vornamelbl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.Vornamelbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Vornamelbl.Location = new System.Drawing.Point(5, 44);
      this.Vornamelbl.Name = "Vornamelbl";
      this.Vornamelbl.Size = new System.Drawing.Size(285, 40);
      this.Vornamelbl.TabIndex = 2;
      this.Vornamelbl.Text = "Vorname";
      this.Vornamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // MainIchEmail
      // 
      this.MainIchEmail.AutoSize = true;
      this.MainIchEmail.Dock = System.Windows.Forms.DockStyle.Fill;
      this.MainIchEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.MainIchEmail.Location = new System.Drawing.Point(298, 2);
      this.MainIchEmail.Name = "MainIchEmail";
      this.MainIchEmail.Size = new System.Drawing.Size(445, 40);
      this.MainIchEmail.TabIndex = 1;
      this.MainIchEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // EmailLBL
      // 
      this.EmailLBL.AutoSize = true;
      this.EmailLBL.Dock = System.Windows.Forms.DockStyle.Fill;
      this.EmailLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.EmailLBL.Location = new System.Drawing.Point(5, 2);
      this.EmailLBL.Name = "EmailLBL";
      this.EmailLBL.Size = new System.Drawing.Size(285, 40);
      this.EmailLBL.TabIndex = 0;
      this.EmailLBL.Text = "Email";
      this.EmailLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // SidebarTimer
      // 
      this.SidebarTimer.Interval = 25;
      this.SidebarTimer.Tick += new System.EventHandler(this.Sidebartimer_Tick);
      // 
      // imageList1
      // 
      this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
      this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
      this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
      // 
      // StundenplanPB
      // 
      this.StundenplanPB.Location = new System.Drawing.Point(302, 68);
      this.StundenplanPB.MaximumSize = new System.Drawing.Size(602, 769);
      this.StundenplanPB.Name = "StundenplanPB";
      this.StundenplanPB.Size = new System.Drawing.Size(602, 769);
      this.StundenplanPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.StundenplanPB.TabIndex = 3;
      this.StundenplanPB.TabStop = false;
      // 
      // Noten_table
      // 
      this.Noten_table.ColumnCount = 3;
      this.Noten_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.Noten_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.Noten_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.Noten_table.Controls.Add(this.Franz_Chb, 2, 3);
      this.Noten_table.Controls.Add(this.Deu_Chb, 2, 2);
      this.Noten_table.Controls.Add(this.Mathe_Chb, 2, 1);
      this.Noten_table.Controls.Add(this.Fach_Franz_lbl, 0, 3);
      this.Noten_table.Controls.Add(this.Note_Deu_lbl, 1, 2);
      this.Noten_table.Controls.Add(this.Fach_Deutsch_lbl, 0, 2);
      this.Noten_table.Controls.Add(this.Note_Mathe_lbl, 1, 1);
      this.Noten_table.Controls.Add(this.Fach_Mathe_lbl, 0, 1);
      this.Noten_table.Controls.Add(this.Note_Info_lbl, 1, 0);
      this.Noten_table.Controls.Add(this.Fach_lbl, 0, 0);
      this.Noten_table.Controls.Add(this.Note_Franz_lbl, 1, 3);
      this.Noten_table.Controls.Add(this.Info_Chb, 2, 0);
      this.Noten_table.Location = new System.Drawing.Point(274, 260);
      this.Noten_table.Name = "Noten_table";
      this.Noten_table.RowCount = 4;
      this.Noten_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.Noten_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.Noten_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.Noten_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.Noten_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.Noten_table.Size = new System.Drawing.Size(598, 255);
      this.Noten_table.TabIndex = 4;
      this.Noten_table.Paint += new System.Windows.Forms.PaintEventHandler(this.Noten_table_Paint);
      // 
      // Fach_Franz_lbl
      // 
      this.Fach_Franz_lbl.AutoSize = true;
      this.Fach_Franz_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.Fach_Franz_lbl.Location = new System.Drawing.Point(3, 189);
      this.Fach_Franz_lbl.Name = "Fach_Franz_lbl";
      this.Fach_Franz_lbl.Size = new System.Drawing.Size(293, 66);
      this.Fach_Franz_lbl.TabIndex = 16;
      this.Fach_Franz_lbl.Text = "Französisch";
      // 
      // Note_Deu_lbl
      // 
      this.Note_Deu_lbl.AutoSize = true;
      this.Note_Deu_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.Note_Deu_lbl.Location = new System.Drawing.Point(302, 126);
      this.Note_Deu_lbl.Name = "Note_Deu_lbl";
      this.Note_Deu_lbl.Size = new System.Drawing.Size(143, 63);
      this.Note_Deu_lbl.TabIndex = 14;
      // 
      // Fach_Deutsch_lbl
      // 
      this.Fach_Deutsch_lbl.AutoSize = true;
      this.Fach_Deutsch_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.Fach_Deutsch_lbl.Location = new System.Drawing.Point(3, 126);
      this.Fach_Deutsch_lbl.Name = "Fach_Deutsch_lbl";
      this.Fach_Deutsch_lbl.Size = new System.Drawing.Size(293, 63);
      this.Fach_Deutsch_lbl.TabIndex = 13;
      this.Fach_Deutsch_lbl.Text = "Deutsch";
      // 
      // Note_Mathe_lbl
      // 
      this.Note_Mathe_lbl.AutoSize = true;
      this.Note_Mathe_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.Note_Mathe_lbl.Location = new System.Drawing.Point(302, 63);
      this.Note_Mathe_lbl.Name = "Note_Mathe_lbl";
      this.Note_Mathe_lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.Note_Mathe_lbl.Size = new System.Drawing.Size(143, 63);
      this.Note_Mathe_lbl.TabIndex = 11;
      // 
      // Fach_Mathe_lbl
      // 
      this.Fach_Mathe_lbl.AutoSize = true;
      this.Fach_Mathe_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.Fach_Mathe_lbl.Location = new System.Drawing.Point(3, 63);
      this.Fach_Mathe_lbl.Name = "Fach_Mathe_lbl";
      this.Fach_Mathe_lbl.Size = new System.Drawing.Size(293, 63);
      this.Fach_Mathe_lbl.TabIndex = 10;
      this.Fach_Mathe_lbl.Text = "Mathematik";
      // 
      // Note_Info_lbl
      // 
      this.Note_Info_lbl.AutoSize = true;
      this.Note_Info_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.Note_Info_lbl.Location = new System.Drawing.Point(302, 0);
      this.Note_Info_lbl.Name = "Note_Info_lbl";
      this.Note_Info_lbl.Size = new System.Drawing.Size(143, 63);
      this.Note_Info_lbl.TabIndex = 8;
      // 
      // Fach_lbl
      // 
      this.Fach_lbl.AutoSize = true;
      this.Fach_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.Fach_lbl.Location = new System.Drawing.Point(3, 0);
      this.Fach_lbl.Name = "Fach_lbl";
      this.Fach_lbl.Size = new System.Drawing.Size(293, 63);
      this.Fach_lbl.TabIndex = 7;
      this.Fach_lbl.Text = "Informatik";
      // 
      // Note_Franz_lbl
      // 
      this.Note_Franz_lbl.AutoSize = true;
      this.Note_Franz_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.Note_Franz_lbl.Location = new System.Drawing.Point(302, 189);
      this.Note_Franz_lbl.Name = "Note_Franz_lbl";
      this.Note_Franz_lbl.Size = new System.Drawing.Size(143, 66);
      this.Note_Franz_lbl.TabIndex = 6;
      // 
      // Info_Chb
      // 
      this.Info_Chb.AutoSize = true;
      this.Info_Chb.Location = new System.Drawing.Point(452, 5);
      this.Info_Chb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Info_Chb.Name = "Info_Chb";
      this.Info_Chb.Size = new System.Drawing.Size(112, 24);
      this.Info_Chb.TabIndex = 21;
      this.Info_Chb.Text = "Bestätigen";
      this.Info_Chb.UseVisualStyleBackColor = true;
      this.Info_Chb.Click += new System.EventHandler(this.OnClickInfo_best);
      // 
      // label3
      // 
      this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(628, 888);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(51, 20);
      this.label3.TabIndex = 5;
      this.label3.Text = "label3";
      // 
      // Mathe_Chb
      // 
      this.Mathe_Chb.AutoSize = true;
      this.Mathe_Chb.Location = new System.Drawing.Point(452, 68);
      this.Mathe_Chb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Mathe_Chb.Name = "Mathe_Chb";
      this.Mathe_Chb.Size = new System.Drawing.Size(112, 24);
      this.Mathe_Chb.TabIndex = 22;
      this.Mathe_Chb.Text = "Bestätigen";
      this.Mathe_Chb.UseVisualStyleBackColor = true;
      this.Mathe_Chb.Click += new System.EventHandler(this.OnClickMathe_best);
      // 
      // Deu_Chb
      // 
      this.Deu_Chb.AutoSize = true;
      this.Deu_Chb.Location = new System.Drawing.Point(452, 131);
      this.Deu_Chb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Deu_Chb.Name = "Deu_Chb";
      this.Deu_Chb.Size = new System.Drawing.Size(112, 24);
      this.Deu_Chb.TabIndex = 23;
      this.Deu_Chb.Text = "Bestätigen";
      this.Deu_Chb.UseVisualStyleBackColor = true;
      this.Deu_Chb.Click += new System.EventHandler(this.OnClickDeu_best);
      // 
      // Franz_Chb
      // 
      this.Franz_Chb.AutoSize = true;
      this.Franz_Chb.Location = new System.Drawing.Point(452, 194);
      this.Franz_Chb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Franz_Chb.Name = "Franz_Chb";
      this.Franz_Chb.Size = new System.Drawing.Size(112, 24);
      this.Franz_Chb.TabIndex = 24;
      this.Franz_Chb.Text = "Bestätigen";
      this.Franz_Chb.UseVisualStyleBackColor = true;
      this.Franz_Chb.Click += new System.EventHandler(this.OnClickFranz_best);
      // 
      // SchuelerInterface
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.BackColor = System.Drawing.Color.GhostWhite;
      this.ClientSize = new System.Drawing.Size(1138, 820);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.Noten_table);
      this.Controls.Add(this.StundenplanPB);
      this.Controls.Add(this.IchTableManager);
      this.Controls.Add(this.SideBarContainer);
      this.Controls.Add(this.panel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximumSize = new System.Drawing.Size(1599, 820);
      this.Name = "SchuelerInterface";
      this.Text = "SchoolManager";
      this.Load += new System.EventHandler(this.SchoolmanagerMainMenu_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.MenuIcon)).EndInit();
      this.SideBarContainer.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.IchTableManager.ResumeLayout(false);
      this.IchTableManager.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.StundenplanPB)).EndInit();
      this.Noten_table.ResumeLayout(false);
      this.Noten_table.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

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
        private System.Windows.Forms.Button MainMenuNavDaten;
        private System.Windows.Forms.Button XExitbtn;
        private System.Windows.Forms.TableLayoutPanel IchTableManager;
        private System.Windows.Forms.Label MainIchStrasse;
        private System.Windows.Forms.Label Strasselbl;
        private System.Windows.Forms.Label MainIchOrt;
        private System.Windows.Forms.Label Ortlbl;
        private System.Windows.Forms.Label MainIchPLZ;
        private System.Windows.Forms.Label PLZlbl;
        private System.Windows.Forms.Label MainIchKlasse;
        private System.Windows.Forms.Label Klasselbl;
        private System.Windows.Forms.Label MainIchStufe;
        private System.Windows.Forms.Label Stufelbl;
        private System.Windows.Forms.Label MainIchGebDate;
        private System.Windows.Forms.Label Gebdatelbl;
        private System.Windows.Forms.Label MainIchNachname;
        private System.Windows.Forms.Label Nachnamelbl;
        private System.Windows.Forms.Label MainIchVorname;
        private System.Windows.Forms.Label Vornamelbl;
        private System.Windows.Forms.Label MainIchEmail;
        private System.Windows.Forms.Label EmailLBL;
        private System.Windows.Forms.Timer SidebarTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label MainIchTel;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox StundenplanPB;
    private System.Windows.Forms.TableLayoutPanel Noten_table;
    private System.Windows.Forms.Label Fach_Franz_lbl;
    private System.Windows.Forms.Label Note_Deu_lbl;
    private System.Windows.Forms.Label Fach_Deutsch_lbl;
    private System.Windows.Forms.Label Note_Mathe_lbl;
    private System.Windows.Forms.Label Note_Info_lbl;
    private System.Windows.Forms.Label Fach_lbl;
    private System.Windows.Forms.Label Note_Franz_lbl;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label Fach_Mathe_lbl;
    private System.Windows.Forms.CheckBox Info_Chb;
    private System.Windows.Forms.CheckBox Franz_Chb;
    private System.Windows.Forms.CheckBox Deu_Chb;
    private System.Windows.Forms.CheckBox Mathe_Chb;
  }
}