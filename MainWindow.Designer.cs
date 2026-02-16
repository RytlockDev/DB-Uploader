namespace DB_Uploader
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            panel1 = new System.Windows.Forms.Panel();
            btnClrFields = new System.Windows.Forms.Button();
            btnDBConnect = new System.Windows.Forms.Button();
            TBIp = new System.Windows.Forms.TextBox();
            TBDBName = new System.Windows.Forms.TextBox();
            TBPassword = new System.Windows.Forms.TextBox();
            TBUsername = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            TCDB = new System.Windows.Forms.TabControl();
            TabTables = new System.Windows.Forms.TabPage();
            TabTableContent = new System.Windows.Forms.TabPage();
            TabLoadedDS = new System.Windows.Forms.TabPage();
            meldungen = new System.Windows.Forms.Label();
            btnDSSave = new System.Windows.Forms.Button();
            btnDSRemove = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dateiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            dateiSpeichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dateiSchliesenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            anmeldedatenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            anmeldedatenSpeichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            anmeldedatenLadenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            anmeldedatenLoschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            panel1.SuspendLayout();
            TCDB.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnClrFields);
            panel1.Controls.Add(btnDBConnect);
            panel1.Controls.Add(TBIp);
            panel1.Controls.Add(TBDBName);
            panel1.Controls.Add(TBPassword);
            panel1.Controls.Add(TBUsername);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new System.Drawing.Point(12, 27);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(876, 60);
            panel1.TabIndex = 1;
            // 
            // btnClrFields
            // 
            btnClrFields.Location = new System.Drawing.Point(742, 28);
            btnClrFields.Name = "btnClrFields";
            btnClrFields.Size = new System.Drawing.Size(93, 23);
            btnClrFields.TabIndex = 8;
            btnClrFields.Text = "Ferlder Leeren";
            btnClrFields.UseVisualStyleBackColor = true;
            btnClrFields.Click += btnClrFields_Click;
            // 
            // btnDBConnect
            // 
            btnDBConnect.Location = new System.Drawing.Point(643, 29);
            btnDBConnect.Name = "btnDBConnect";
            btnDBConnect.Size = new System.Drawing.Size(93, 23);
            btnDBConnect.TabIndex = 4;
            btnDBConnect.Text = "Verbinden";
            btnDBConnect.UseVisualStyleBackColor = true;
            btnDBConnect.Click += btnDBConnect_Click;
            // 
            // TBIp
            // 
            TBIp.Location = new System.Drawing.Point(323, 29);
            TBIp.Name = "TBIp";
            TBIp.Size = new System.Drawing.Size(154, 23);
            TBIp.TabIndex = 7;
            // 
            // TBDBName
            // 
            TBDBName.Location = new System.Drawing.Point(483, 29);
            TBDBName.Name = "TBDBName";
            TBDBName.Size = new System.Drawing.Size(154, 23);
            TBDBName.TabIndex = 6;
            // 
            // TBPassword
            // 
            TBPassword.Location = new System.Drawing.Point(163, 29);
            TBPassword.Name = "TBPassword";
            TBPassword.Size = new System.Drawing.Size(154, 23);
            TBPassword.TabIndex = 5;
            // 
            // TBUsername
            // 
            TBUsername.Location = new System.Drawing.Point(3, 29);
            TBUsername.Name = "TBUsername";
            TBUsername.Size = new System.Drawing.Size(154, 23);
            TBUsername.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(483, 11);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(62, 15);
            label4.TabIndex = 3;
            label4.Text = "DB-Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(323, 11);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(86, 15);
            label3.TabIndex = 2;
            label3.Text = "Server Adresse:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(163, 11);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(88, 15);
            label2.TabIndex = 1;
            label2.Text = "User-Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(3, 11);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // TCDB
            // 
            TCDB.Controls.Add(TabTables);
            TCDB.Controls.Add(TabTableContent);
            TCDB.Controls.Add(TabLoadedDS);
            TCDB.Location = new System.Drawing.Point(12, 93);
            TCDB.Name = "TCDB";
            TCDB.SelectedIndex = 0;
            TCDB.Size = new System.Drawing.Size(876, 385);
            TCDB.TabIndex = 2;
            // 
            // TabTables
            // 
            TabTables.Location = new System.Drawing.Point(4, 24);
            TabTables.Name = "TabTables";
            TabTables.Padding = new System.Windows.Forms.Padding(3);
            TabTables.Size = new System.Drawing.Size(868, 357);
            TabTables.TabIndex = 0;
            TabTables.Text = "Tabellen";
            TabTables.UseVisualStyleBackColor = true;
            TabTables.Click += TabTables_Click;
            // 
            // TabTableContent
            // 
            TabTableContent.Location = new System.Drawing.Point(4, 24);
            TabTableContent.Name = "TabTableContent";
            TabTableContent.Padding = new System.Windows.Forms.Padding(3);
            TabTableContent.Size = new System.Drawing.Size(868, 357);
            TabTableContent.TabIndex = 1;
            TabTableContent.Text = "Tabelleninhalt";
            TabTableContent.UseVisualStyleBackColor = true;
            // 
            // TabLoadedDS
            // 
            TabLoadedDS.Location = new System.Drawing.Point(4, 24);
            TabLoadedDS.Name = "TabLoadedDS";
            TabLoadedDS.Padding = new System.Windows.Forms.Padding(3);
            TabLoadedDS.Size = new System.Drawing.Size(868, 357);
            TabLoadedDS.TabIndex = 2;
            TabLoadedDS.Text = "Geladene DS";
            TabLoadedDS.UseVisualStyleBackColor = true;
            // 
            // meldungen
            // 
            meldungen.AutoSize = true;
            meldungen.Location = new System.Drawing.Point(416, 526);
            meldungen.Name = "meldungen";
            meldungen.Size = new System.Drawing.Size(0, 15);
            meldungen.TabIndex = 3;
            // 
            // btnDSSave
            // 
            btnDSSave.Location = new System.Drawing.Point(556, 484);
            btnDSSave.Name = "btnDSSave";
            btnDSSave.Size = new System.Drawing.Size(93, 23);
            btnDSSave.TabIndex = 9;
            btnDSSave.Text = "DS Speichern";
            btnDSSave.UseVisualStyleBackColor = true;
            btnDSSave.Click += btnDSSave_Click;
            // 
            // btnDSRemove
            // 
            btnDSRemove.Location = new System.Drawing.Point(655, 484);
            btnDSRemove.Name = "btnDSRemove";
            btnDSRemove.RightToLeft = System.Windows.Forms.RightToLeft.No;
            btnDSRemove.Size = new System.Drawing.Size(93, 23);
            btnDSRemove.TabIndex = 10;
            btnDSRemove.Text = "DS Abwahlen";
            btnDSRemove.UseVisualStyleBackColor = true;
            btnDSRemove.Click += btnDSRemove_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(754, 484);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(93, 23);
            btnExit.TabIndex = 11;
            btnExit.Text = "Beenden";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // dateiToolStripMenuItem
            // 
            dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { dateiToolStripMenuItem1, dateiSpeichernToolStripMenuItem, dateiSchliesenToolStripMenuItem });
            dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            dateiToolStripMenuItem.Text = "Datei";
            // 
            // dateiToolStripMenuItem1
            // 
            dateiToolStripMenuItem1.Name = "dateiToolStripMenuItem1";
            dateiToolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
            dateiToolStripMenuItem1.Text = "Datei Öffnen";
            // 
            // dateiSpeichernToolStripMenuItem
            // 
            dateiSpeichernToolStripMenuItem.Name = "dateiSpeichernToolStripMenuItem";
            dateiSpeichernToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            dateiSpeichernToolStripMenuItem.Text = "Datei Speichern";
            // 
            // dateiSchliesenToolStripMenuItem
            // 
            dateiSchliesenToolStripMenuItem.Name = "dateiSchliesenToolStripMenuItem";
            dateiSchliesenToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            dateiSchliesenToolStripMenuItem.Text = "Datei Schliesen";
            // 
            // anmeldedatenToolStripMenuItem
            // 
            anmeldedatenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { anmeldedatenSpeichernToolStripMenuItem, anmeldedatenLadenToolStripMenuItem, anmeldedatenLoschenToolStripMenuItem });
            anmeldedatenToolStripMenuItem.Name = "anmeldedatenToolStripMenuItem";
            anmeldedatenToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            anmeldedatenToolStripMenuItem.Text = "Anmeldedaten";
            // 
            // anmeldedatenSpeichernToolStripMenuItem
            // 
            anmeldedatenSpeichernToolStripMenuItem.Name = "anmeldedatenSpeichernToolStripMenuItem";
            anmeldedatenSpeichernToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            anmeldedatenSpeichernToolStripMenuItem.Text = "Anmeldedaten Speichern";
            // 
            // anmeldedatenLadenToolStripMenuItem
            // 
            anmeldedatenLadenToolStripMenuItem.Name = "anmeldedatenLadenToolStripMenuItem";
            anmeldedatenLadenToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            anmeldedatenLadenToolStripMenuItem.Text = "Anmeldedaten Laden";
            // 
            // anmeldedatenLoschenToolStripMenuItem
            // 
            anmeldedatenLoschenToolStripMenuItem.Name = "anmeldedatenLoschenToolStripMenuItem";
            anmeldedatenLoschenToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            anmeldedatenLoschenToolStripMenuItem.Text = "Anmeldedaten Löschen";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { dateiToolStripMenuItem, anmeldedatenToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(900, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(900, 550);
            Controls.Add(btnExit);
            Controls.Add(btnDSRemove);
            Controls.Add(btnDSSave);
            Controls.Add(meldungen);
            Controls.Add(TCDB);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Text = "DB Uploader";
            Load += MainWindow_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            TCDB.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btnDSRemove;

        private System.Windows.Forms.Button btnDBConnect;
        private System.Windows.Forms.Button btnClrFields;

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem anmeldedatenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateiSpeichernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateiSchliesenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anmeldedatenSpeichernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anmeldedatenLadenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anmeldedatenLoschenToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private Label label1;
        private System.Windows.Forms.Label label3;
        private Label label2;
        private System.Windows.Forms.Label label4;
        private TextBox TBIp;
        private TextBox TBDBName;
        private TextBox TBPassword;
        private TextBox TBUsername;
        private TabControl TCDB;
        private System.Windows.Forms.TabPage TabTables;
        private TabPage TabTableContent;
        private TabPage TabLoadedDS;
        public Label meldungen;
        private System.Windows.Forms.Button btnDSSave;
        private System.Windows.Forms.Button btnExit;
    }
}
