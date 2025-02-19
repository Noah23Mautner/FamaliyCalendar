namespace Family_Calendar.NewFolder1
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.listEvents = new System.Windows.Forms.ListBox();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnUčitaj = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 75);
            this.panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.SteelBlue;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(180, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(270, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Family Calendar";
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(22, 100);
            this.calendar.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 1;
            // 
            // listEvents
            // 
            this.listEvents.FormattingEnabled = true;
            this.listEvents.ItemHeight = 20;
            this.listEvents.Location = new System.Drawing.Point(22, 365);
            this.listEvents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listEvents.Name = "listEvents";
            this.listEvents.Size = new System.Drawing.Size(483, 184);
            this.listEvents.TabIndex = 2;
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddEvent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddEvent.Location = new System.Drawing.Point(378, 116);
            this.btnAddEvent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(150, 54);
            this.btnAddEvent.TabIndex = 3;
            this.btnAddEvent.Text = "Dodaj događaj";
            this.btnAddEvent.UseVisualStyleBackColor = false;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(378, 236);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 54);
            this.button1.TabIndex = 4;
            this.button1.Text = "Obriši događaj";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogout.Location = new System.Drawing.Point(599, 116);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(150, 54);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "LogOut";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.BackColor = System.Drawing.Color.YellowGreen;
            this.btnSpremi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSpremi.Location = new System.Drawing.Point(543, 365);
            this.btnSpremi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(150, 54);
            this.btnSpremi.TabIndex = 6;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnUčitaj
            // 
            this.btnUčitaj.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnUčitaj.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUčitaj.Location = new System.Drawing.Point(543, 437);
            this.btnUčitaj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUčitaj.Name = "btnUčitaj";
            this.btnUčitaj.Size = new System.Drawing.Size(150, 54);
            this.btnUčitaj.TabIndex = 7;
            this.btnUčitaj.Text = "Učitaj";
            this.btnUčitaj.UseVisualStyleBackColor = false;
            this.btnUčitaj.Click += new System.EventHandler(this.btnUčitaj_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.btnUčitaj);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddEvent);
            this.Controls.Add(this.listEvents);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.ListBox listEvents;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnUčitaj;
    }
}