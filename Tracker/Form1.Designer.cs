namespace Tracker
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTracker = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.lblSTATE = new System.Windows.Forms.Label();
            this.cbxSTATE = new System.Windows.Forms.ComboBox();
            this.lblIni = new System.Windows.Forms.Label();
            this.nudINI = new System.Windows.Forms.NumericUpDown();
            this.lblHP = new System.Windows.Forms.Label();
            this.nudHP = new System.Windows.Forms.NumericUpDown();
            this.btnADD = new System.Windows.Forms.Button();
            this.btnREMOVE = new System.Windows.Forms.Button();
            this.btnCLEAR = new System.Windows.Forms.Button();
            this.btnSAVE = new System.Windows.Forms.Button();
            this.btnLOAD = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudINI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHP)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTracker
            // 
            this.lbTracker.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbTracker.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbTracker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbTracker.FormattingEnabled = true;
            this.lbTracker.ItemHeight = 25;
            this.lbTracker.Location = new System.Drawing.Point(13, 13);
            this.lbTracker.Name = "lbTracker";
            this.lbTracker.Size = new System.Drawing.Size(430, 404);
            this.lbTracker.TabIndex = 0;
            this.lbTracker.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbTracker_DrawItem);
            this.lbTracker.SelectedIndexChanged += new System.EventHandler(this.lbTracker_SelectedIndexChanged);
            this.lbTracker.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.lbTracker_Format);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.lblName);
            this.flowLayoutPanel1.Controls.Add(this.txtbxName);
            this.flowLayoutPanel1.Controls.Add(this.lblSTATE);
            this.flowLayoutPanel1.Controls.Add(this.cbxSTATE);
            this.flowLayoutPanel1.Controls.Add(this.lblIni);
            this.flowLayoutPanel1.Controls.Add(this.nudINI);
            this.flowLayoutPanel1.Controls.Add(this.lblHP);
            this.flowLayoutPanel1.Controls.Add(this.nudHP);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(462, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 404);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblName.Location = new System.Drawing.Point(3, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(70, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbxName
            // 
            this.txtbxName.Location = new System.Drawing.Point(3, 28);
            this.txtbxName.MaxLength = 50;
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(191, 26);
            this.txtbxName.TabIndex = 1;
            this.txtbxName.Leave += new System.EventHandler(this.txtbxName_Leave);
            // 
            // lblSTATE
            // 
            this.lblSTATE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSTATE.AutoSize = true;
            this.lblSTATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSTATE.Location = new System.Drawing.Point(3, 57);
            this.lblSTATE.Name = "lblSTATE";
            this.lblSTATE.Size = new System.Drawing.Size(64, 25);
            this.lblSTATE.TabIndex = 6;
            this.lblSTATE.Text = "State:";
            // 
            // cbxSTATE
            // 
            this.cbxSTATE.FormattingEnabled = true;
            this.cbxSTATE.Location = new System.Drawing.Point(3, 85);
            this.cbxSTATE.Name = "cbxSTATE";
            this.cbxSTATE.Size = new System.Drawing.Size(188, 28);
            this.cbxSTATE.TabIndex = 7;
            this.cbxSTATE.SelectedValueChanged += new System.EventHandler(this.cbxSTATE_SelectedValueChanged);
            // 
            // lblIni
            // 
            this.lblIni.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIni.AutoSize = true;
            this.lblIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIni.Location = new System.Drawing.Point(3, 116);
            this.lblIni.Name = "lblIni";
            this.lblIni.Size = new System.Drawing.Size(88, 32);
            this.lblIni.TabIndex = 2;
            this.lblIni.Text = "Initiative:";
            this.lblIni.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudINI
            // 
            this.nudINI.Location = new System.Drawing.Point(97, 119);
            this.nudINI.Name = "nudINI";
            this.nudINI.Size = new System.Drawing.Size(73, 26);
            this.nudINI.TabIndex = 2;
            this.nudINI.ValueChanged += new System.EventHandler(this.nudINI_ValueChanged);
            // 
            // lblHP
            // 
            this.lblHP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHP.AutoSize = true;
            this.lblHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHP.Location = new System.Drawing.Point(3, 148);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(74, 32);
            this.lblHP.TabIndex = 4;
            this.lblHP.Text = "Health:";
            this.lblHP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudHP
            // 
            this.nudHP.Location = new System.Drawing.Point(83, 151);
            this.nudHP.Name = "nudHP";
            this.nudHP.Size = new System.Drawing.Size(71, 26);
            this.nudHP.TabIndex = 8;
            this.nudHP.ValueChanged += new System.EventHandler(this.nudHP_ValueChanged);
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(690, 14);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(93, 49);
            this.btnADD.TabIndex = 2;
            this.btnADD.Text = "ADD";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btnREMOVE
            // 
            this.btnREMOVE.Location = new System.Drawing.Point(690, 93);
            this.btnREMOVE.Name = "btnREMOVE";
            this.btnREMOVE.Size = new System.Drawing.Size(93, 56);
            this.btnREMOVE.TabIndex = 3;
            this.btnREMOVE.Text = "REMOVE";
            this.btnREMOVE.UseVisualStyleBackColor = true;
            this.btnREMOVE.Click += new System.EventHandler(this.btnREMOVE_Click);
            // 
            // btnCLEAR
            // 
            this.btnCLEAR.Location = new System.Drawing.Point(690, 179);
            this.btnCLEAR.Name = "btnCLEAR";
            this.btnCLEAR.Size = new System.Drawing.Size(93, 53);
            this.btnCLEAR.TabIndex = 4;
            this.btnCLEAR.Text = "CLEAR";
            this.btnCLEAR.UseVisualStyleBackColor = true;
            this.btnCLEAR.Click += new System.EventHandler(this.btnCLEAR_Click);
            // 
            // btnSAVE
            // 
            this.btnSAVE.Location = new System.Drawing.Point(690, 267);
            this.btnSAVE.Name = "btnSAVE";
            this.btnSAVE.Size = new System.Drawing.Size(93, 56);
            this.btnSAVE.TabIndex = 5;
            this.btnSAVE.Text = "SAVE";
            this.btnSAVE.UseVisualStyleBackColor = true;
            this.btnSAVE.Click += new System.EventHandler(this.btnSAVE_Click);
            // 
            // btnLOAD
            // 
            this.btnLOAD.Location = new System.Drawing.Point(690, 355);
            this.btnLOAD.Name = "btnLOAD";
            this.btnLOAD.Size = new System.Drawing.Size(93, 53);
            this.btnLOAD.TabIndex = 6;
            this.btnLOAD.Text = "LOAD";
            this.btnLOAD.UseVisualStyleBackColor = true;
            this.btnLOAD.Click += new System.EventHandler(this.btnLOAD_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLOAD);
            this.Controls.Add(this.btnSAVE);
            this.Controls.Add(this.btnCLEAR);
            this.Controls.Add(this.btnREMOVE);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lbTracker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Initiative Tracker 0.1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudINI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbTracker;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtbxName;
        private System.Windows.Forms.Label lblIni;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.Label lblSTATE;
        private System.Windows.Forms.ComboBox cbxSTATE;
        private System.Windows.Forms.NumericUpDown nudINI;
        private System.Windows.Forms.NumericUpDown nudHP;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button btnREMOVE;
        private System.Windows.Forms.Button btnCLEAR;
        private System.Windows.Forms.Button btnSAVE;
        private System.Windows.Forms.Button btnLOAD;
    }
}

