namespace Tracker
{
    partial class AddForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblAddName = new System.Windows.Forms.Label();
            this.txtbxAddName = new System.Windows.Forms.TextBox();
            this.lblAddINI = new System.Windows.Forms.Label();
            this.nudAddINI = new System.Windows.Forms.NumericUpDown();
            this.lblAddHP = new System.Windows.Forms.Label();
            this.nudAddHP = new System.Windows.Forms.NumericUpDown();
            this.btnOK = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddINI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddHP)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblAddName);
            this.flowLayoutPanel1.Controls.Add(this.txtbxAddName);
            this.flowLayoutPanel1.Controls.Add(this.lblAddINI);
            this.flowLayoutPanel1.Controls.Add(this.nudAddINI);
            this.flowLayoutPanel1.Controls.Add(this.lblAddHP);
            this.flowLayoutPanel1.Controls.Add(this.nudAddHP);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 15);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(316, 77);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lblAddName
            // 
            this.lblAddName.AutoSize = true;
            this.lblAddName.Location = new System.Drawing.Point(3, 0);
            this.lblAddName.Name = "lblAddName";
            this.lblAddName.Size = new System.Drawing.Size(55, 20);
            this.lblAddName.TabIndex = 0;
            this.lblAddName.Text = "Name:";
            // 
            // txtbxAddName
            // 
            this.txtbxAddName.Location = new System.Drawing.Point(64, 3);
            this.txtbxAddName.Name = "txtbxAddName";
            this.txtbxAddName.Size = new System.Drawing.Size(236, 26);
            this.txtbxAddName.TabIndex = 1;
            // 
            // lblAddINI
            // 
            this.lblAddINI.AutoSize = true;
            this.lblAddINI.Location = new System.Drawing.Point(3, 32);
            this.lblAddINI.Name = "lblAddINI";
            this.lblAddINI.Size = new System.Drawing.Size(71, 20);
            this.lblAddINI.TabIndex = 2;
            this.lblAddINI.Text = "Initiative:";
            // 
            // nudAddINI
            // 
            this.nudAddINI.Location = new System.Drawing.Point(80, 35);
            this.nudAddINI.Name = "nudAddINI";
            this.nudAddINI.Size = new System.Drawing.Size(67, 26);
            this.nudAddINI.TabIndex = 3;
            // 
            // lblAddHP
            // 
            this.lblAddHP.AutoSize = true;
            this.lblAddHP.Location = new System.Drawing.Point(153, 32);
            this.lblAddHP.Name = "lblAddHP";
            this.lblAddHP.Size = new System.Drawing.Size(35, 20);
            this.lblAddHP.TabIndex = 4;
            this.lblAddHP.Text = "HP:";
            // 
            // nudAddHP
            // 
            this.nudAddHP.Location = new System.Drawing.Point(194, 35);
            this.nudAddHP.Name = "nudAddHP";
            this.nudAddHP.Size = new System.Drawing.Size(71, 26);
            this.nudAddHP.TabIndex = 5;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(104, 147);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(123, 43);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 202);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddINI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddHP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblAddName;
        private System.Windows.Forms.TextBox txtbxAddName;
        private System.Windows.Forms.Label lblAddINI;
        private System.Windows.Forms.NumericUpDown nudAddINI;
        private System.Windows.Forms.Label lblAddHP;
        private System.Windows.Forms.NumericUpDown nudAddHP;
        private System.Windows.Forms.Button btnOK;
    }
}