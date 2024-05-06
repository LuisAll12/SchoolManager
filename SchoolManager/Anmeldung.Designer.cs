namespace SchoolManager
{
    partial class Anmeldung
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anmeldung));
            this.AnmeldungPasswortEing = new System.Windows.Forms.TextBox();
            this.OnApply = new System.Windows.Forms.Button();
            this.label1PasswortLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.AnmeldungEmailEing = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Showpassword_checkbox = new System.Windows.Forms.CheckBox();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.AnmeldungClearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AnmeldungPasswortEing
            // 
            this.AnmeldungPasswortEing.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.AnmeldungPasswortEing.Location = new System.Drawing.Point(546, 513);
            this.AnmeldungPasswortEing.Name = "AnmeldungPasswortEing";
            this.AnmeldungPasswortEing.PasswordChar = '*';
            this.AnmeldungPasswortEing.Size = new System.Drawing.Size(315, 40);
            this.AnmeldungPasswortEing.TabIndex = 2;
            // 
            // OnApply
            // 
            this.OnApply.BackColor = System.Drawing.Color.White;
            this.OnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OnApply.Font = new System.Drawing.Font("Arial Narrow", 15F);
            this.OnApply.Location = new System.Drawing.Point(772, 559);
            this.OnApply.Name = "OnApply";
            this.OnApply.Size = new System.Drawing.Size(89, 47);
            this.OnApply.TabIndex = 3;
            this.OnApply.Text = "Apply";
            this.OnApply.UseVisualStyleBackColor = false;
            this.OnApply.Click += new System.EventHandler(this.OnApplyClick);
            // 
            // label1PasswortLabel
            // 
            this.label1PasswortLabel.AutoSize = true;
            this.label1PasswortLabel.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label1PasswortLabel.ForeColor = System.Drawing.Color.Black;
            this.label1PasswortLabel.Location = new System.Drawing.Point(545, 484);
            this.label1PasswortLabel.Name = "label1PasswortLabel";
            this.label1PasswortLabel.Size = new System.Drawing.Size(95, 29);
            this.label1PasswortLabel.TabIndex = 2;
            this.label1PasswortLabel.Text = "Passwort";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.EmailLabel.ForeColor = System.Drawing.Color.Black;
            this.EmailLabel.Location = new System.Drawing.Point(541, 410);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(61, 29);
            this.EmailLabel.TabIndex = 3;
            this.EmailLabel.Text = "Email";
            this.EmailLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // AnmeldungEmailEing
            // 
            this.AnmeldungEmailEing.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.AnmeldungEmailEing.Location = new System.Drawing.Point(546, 435);
            this.AnmeldungEmailEing.Name = "AnmeldungEmailEing";
            this.AnmeldungEmailEing.Size = new System.Drawing.Size(315, 40);
            this.AnmeldungEmailEing.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkViolet;
            this.panel1.BackgroundImage = global::SchoolManager.Properties.Resources.Bild_2024_04_26_133245901_removebg_preview;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 619);
            this.panel1.TabIndex = 4;
            // 
            // Showpassword_checkbox
            // 
            this.Showpassword_checkbox.AutoSize = true;
            this.Showpassword_checkbox.Location = new System.Drawing.Point(671, 481);
            this.Showpassword_checkbox.Name = "Showpassword_checkbox";
            this.Showpassword_checkbox.Size = new System.Drawing.Size(190, 30);
            this.Showpassword_checkbox.TabIndex = 5;
            this.Showpassword_checkbox.Text = "Passwort anzeigen";
            this.Showpassword_checkbox.UseVisualStyleBackColor = true;
            this.Showpassword_checkbox.CheckedChanged += new System.EventHandler(this.Showpassword_checkbox_CheckedChanged);
            // 
            // Exitbtn
            // 
            this.Exitbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exitbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exitbtn.Location = new System.Drawing.Point(847, 0);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(54, 44);
            this.Exitbtn.TabIndex = 6;
            this.Exitbtn.Text = "X";
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.Click += new System.EventHandler(this.OnExitBtn);
            // 
            // AnmeldungClearBtn
            // 
            this.AnmeldungClearBtn.BackColor = System.Drawing.Color.White;
            this.AnmeldungClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnmeldungClearBtn.Font = new System.Drawing.Font("Arial Narrow", 15F);
            this.AnmeldungClearBtn.Location = new System.Drawing.Point(677, 559);
            this.AnmeldungClearBtn.Name = "AnmeldungClearBtn";
            this.AnmeldungClearBtn.Size = new System.Drawing.Size(89, 47);
            this.AnmeldungClearBtn.TabIndex = 7;
            this.AnmeldungClearBtn.Text = "Clear";
            this.AnmeldungClearBtn.UseVisualStyleBackColor = false;
            this.AnmeldungClearBtn.Click += new System.EventHandler(this.ClearAll);
            // 
            // Anmeldung
            // 
            this.AcceptButton = this.OnApply;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.Exitbtn;
            this.ClientSize = new System.Drawing.Size(900, 619);
            this.ControlBox = false;
            this.Controls.Add(this.AnmeldungClearBtn);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.Showpassword_checkbox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AnmeldungEmailEing);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.label1PasswortLabel);
            this.Controls.Add(this.OnApply);
            this.Controls.Add(this.AnmeldungPasswortEing);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(922, 641);
            this.MinimumSize = new System.Drawing.Size(922, 641);
            this.Name = "Anmeldung";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.Anmeldung_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AnmeldungPasswortEing;
        private System.Windows.Forms.Button OnApply;
        private System.Windows.Forms.Label label1PasswortLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox AnmeldungEmailEing;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox Showpassword_checkbox;
        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.Button AnmeldungClearBtn;
    }
}

