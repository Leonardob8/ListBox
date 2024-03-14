namespace SchiffeUndBoote
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
            lbxBesitzer = new ListBox();
            labelvorname = new Label();
            labelnachname = new Label();
            labelstrasse = new Label();
            Labelhausnummer = new Label();
            labelpostleitzahl = new Label();
            labelort = new Label();
            label1 = new Label();
            tbxVorname = new TextBox();
            tbxNachname = new TextBox();
            tbxStrasse = new TextBox();
            tbxHausnummer = new TextBox();
            tbxPlz = new TextBox();
            tbxOrt = new TextBox();
            btnNeuBesitzer = new Button();
            btnBearbeitenBesitzer = new Button();
            menuStrip1 = new MenuStrip();
            besitzerToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            schiffeToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lbxBesitzer
            // 
            lbxBesitzer.FormattingEnabled = true;
            lbxBesitzer.ItemHeight = 20;
            lbxBesitzer.Location = new Point(12, 46);
            lbxBesitzer.Name = "lbxBesitzer";
            lbxBesitzer.Size = new Size(150, 224);
            lbxBesitzer.TabIndex = 0;
            lbxBesitzer.SelectedIndexChanged += lbxbesitzer_SelectedIndexChanged;
            // 
            // labelvorname
            // 
            labelvorname.AutoSize = true;
            labelvorname.Location = new Point(190, 46);
            labelvorname.Name = "labelvorname";
            labelvorname.Size = new Size(68, 20);
            labelvorname.TabIndex = 1;
            labelvorname.Text = "Vorname";
            // 
            // labelnachname
            // 
            labelnachname.AutoSize = true;
            labelnachname.Location = new Point(190, 91);
            labelnachname.Name = "labelnachname";
            labelnachname.Size = new Size(80, 20);
            labelnachname.TabIndex = 2;
            labelnachname.Text = "Nachname";
            // 
            // labelstrasse
            // 
            labelstrasse.AutoSize = true;
            labelstrasse.Location = new Point(190, 132);
            labelstrasse.Name = "labelstrasse";
            labelstrasse.Size = new Size(55, 20);
            labelstrasse.TabIndex = 3;
            labelstrasse.Text = "Strasse";
            // 
            // Labelhausnummer
            // 
            Labelhausnummer.AutoSize = true;
            Labelhausnummer.Location = new Point(190, 170);
            Labelhausnummer.Name = "Labelhausnummer";
            Labelhausnummer.Size = new Size(97, 20);
            Labelhausnummer.TabIndex = 4;
            Labelhausnummer.Text = "Hausnummer";
            // 
            // labelpostleitzahl
            // 
            labelpostleitzahl.AutoSize = true;
            labelpostleitzahl.Location = new Point(190, 209);
            labelpostleitzahl.Name = "labelpostleitzahl";
            labelpostleitzahl.Size = new Size(84, 20);
            labelpostleitzahl.TabIndex = 5;
            labelpostleitzahl.Text = "Postleitzahl";
            // 
            // labelort
            // 
            labelort.AutoSize = true;
            labelort.Location = new Point(190, 250);
            labelort.Name = "labelort";
            labelort.Size = new Size(30, 20);
            labelort.TabIndex = 6;
            labelort.Text = "Ort";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(350, 300);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 7;
            // 
            // tbxVorname
            // 
            tbxVorname.Location = new Point(325, 46);
            tbxVorname.Name = "tbxVorname";
            tbxVorname.Size = new Size(125, 27);
            tbxVorname.TabIndex = 9;
            // 
            // tbxNachname
            // 
            tbxNachname.Location = new Point(325, 88);
            tbxNachname.Name = "tbxNachname";
            tbxNachname.Size = new Size(125, 27);
            tbxNachname.TabIndex = 10;
            // 
            // tbxStrasse
            // 
            tbxStrasse.Location = new Point(325, 132);
            tbxStrasse.Name = "tbxStrasse";
            tbxStrasse.Size = new Size(125, 27);
            tbxStrasse.TabIndex = 11;
            // 
            // tbxHausnummer
            // 
            tbxHausnummer.Location = new Point(325, 167);
            tbxHausnummer.Name = "tbxHausnummer";
            tbxHausnummer.Size = new Size(125, 27);
            tbxHausnummer.TabIndex = 12;
            // 
            // tbxPlz
            // 
            tbxPlz.Location = new Point(325, 206);
            tbxPlz.Name = "tbxPlz";
            tbxPlz.Size = new Size(125, 27);
            tbxPlz.TabIndex = 13;
            // 
            // tbxOrt
            // 
            tbxOrt.Location = new Point(325, 243);
            tbxOrt.Name = "tbxOrt";
            tbxOrt.Size = new Size(125, 27);
            tbxOrt.TabIndex = 14;
            // 
            // btnNeuBesitzer
            // 
            btnNeuBesitzer.Location = new Point(27, 276);
            btnNeuBesitzer.Name = "btnNeuBesitzer";
            btnNeuBesitzer.Size = new Size(120, 46);
            btnNeuBesitzer.TabIndex = 15;
            btnNeuBesitzer.Text = "Neu";
            btnNeuBesitzer.UseVisualStyleBackColor = true;
            btnNeuBesitzer.Click += btnneubesitzer_Click;
            // 
            // btnBearbeitenBesitzer
            // 
            btnBearbeitenBesitzer.Location = new Point(27, 328);
            btnBearbeitenBesitzer.Name = "btnBearbeitenBesitzer";
            btnBearbeitenBesitzer.Size = new Size(120, 46);
            btnBearbeitenBesitzer.TabIndex = 16;
            btnBearbeitenBesitzer.Text = "Bearbeiten";
            btnBearbeitenBesitzer.UseVisualStyleBackColor = true;
            btnBearbeitenBesitzer.Click += btnBearbeitenBesitzer_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { besitzerToolStripMenuItem, toolStripMenuItem1, toolStripMenuItem2, schiffeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(710, 28);
            menuStrip1.TabIndex = 17;
            menuStrip1.Text = "menuStrip1";
            // 
            // besitzerToolStripMenuItem
            // 
            besitzerToolStripMenuItem.Name = "besitzerToolStripMenuItem";
            besitzerToolStripMenuItem.Size = new Size(75, 24);
            besitzerToolStripMenuItem.Text = "Besitzer";
            besitzerToolStripMenuItem.Click += mubesitzer;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(14, 24);
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(14, 24);
            // 
            // schiffeToolStripMenuItem
            // 
            schiffeToolStripMenuItem.Name = "schiffeToolStripMenuItem";
            schiffeToolStripMenuItem.Size = new Size(68, 24);
            schiffeToolStripMenuItem.Text = "Schiffe";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 434);
            Controls.Add(btnBearbeitenBesitzer);
            Controls.Add(btnNeuBesitzer);
            Controls.Add(tbxOrt);
            Controls.Add(tbxPlz);
            Controls.Add(tbxHausnummer);
            Controls.Add(tbxStrasse);
            Controls.Add(tbxNachname);
            Controls.Add(tbxVorname);
            Controls.Add(label1);
            Controls.Add(labelort);
            Controls.Add(labelpostleitzahl);
            Controls.Add(Labelhausnummer);
            Controls.Add(labelstrasse);
            Controls.Add(labelnachname);
            Controls.Add(labelvorname);
            Controls.Add(lbxBesitzer);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbxBesitzer;
        private Label labelvorname;
        private Label labelnachname;
        private Label labelstrasse;
        private Label Labelhausnummer;
        private Label labelpostleitzahl;
        private Label labelort;
        private Label label1;
        private TextBox tbxVorname;
        private TextBox tbxNachname;
        private TextBox tbxStrasse;
        private TextBox tbxHausnummer;
        private TextBox tbxPlz;
        private TextBox tbxOrt;
        private Button btnNeuBesitzer;
        private Button btnBearbeitenBesitzer;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem besitzerToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem schiffeToolStripMenuItem;
    }
}