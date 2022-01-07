
namespace HeatMap
{
    partial class AnalData
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
            this.panMain = new System.Windows.Forms.Panel();
            this.pbFactory = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblItemDesc = new System.Windows.Forms.Label();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnAnal = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pSideBar = new System.Windows.Forms.Panel();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.panDotInfo = new System.Windows.Forms.Panel();
            this.lblSapNo = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblJobsNo = new System.Windows.Forms.Label();
            this.panMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFactory)).BeginInit();
            this.panel2.SuspendLayout();
            this.pSideBar.SuspendLayout();
            this.panDotInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panMain
            // 
            this.panMain.Controls.Add(this.panDotInfo);
            this.panMain.Controls.Add(this.pbFactory);
            this.panMain.Location = new System.Drawing.Point(193, 1);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(1632, 913);
            this.panMain.TabIndex = 0;
            // 
            // pbFactory
            // 
            this.pbFactory.Location = new System.Drawing.Point(13, 14);
            this.pbFactory.Name = "pbFactory";
            this.pbFactory.Size = new System.Drawing.Size(390, 213);
            this.pbFactory.TabIndex = 1;
            this.pbFactory.TabStop = false;
            this.pbFactory.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pbFactory.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseClick);
            this.pbFactory.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.lblItemDesc);
            this.panel2.Location = new System.Drawing.Point(0, 997);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1178, 71);
            this.panel2.TabIndex = 1;
            // 
            // lblItemDesc
            // 
            this.lblItemDesc.AutoSize = true;
            this.lblItemDesc.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemDesc.Location = new System.Drawing.Point(12, 29);
            this.lblItemDesc.Name = "lblItemDesc";
            this.lblItemDesc.Size = new System.Drawing.Size(0, 29);
            this.lblItemDesc.TabIndex = 0;
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoomIn.Location = new System.Drawing.Point(13, 225);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(80, 45);
            this.btnZoomIn.TabIndex = 0;
            this.btnZoomIn.Text = "+";
            this.btnZoomIn.UseVisualStyleBackColor = true;
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoomOut.Location = new System.Drawing.Point(103, 225);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(80, 45);
            this.btnZoomOut.TabIndex = 1;
            this.btnZoomOut.Text = "-";
            this.btnZoomOut.UseVisualStyleBackColor = true;
            // 
            // btnAnal
            // 
            this.btnAnal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnal.Location = new System.Drawing.Point(13, 25);
            this.btnAnal.Name = "btnAnal";
            this.btnAnal.Size = new System.Drawing.Size(171, 39);
            this.btnAnal.TabIndex = 5;
            this.btnAnal.Text = "Add Areas";
            this.btnAnal.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(13, 862);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(171, 39);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // pSideBar
            // 
            this.pSideBar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pSideBar.Controls.Add(this.btnExit);
            this.pSideBar.Controls.Add(this.btnLoadFile);
            this.pSideBar.Controls.Add(this.btnAnal);
            this.pSideBar.Controls.Add(this.btnZoomOut);
            this.pSideBar.Controls.Add(this.btnZoomIn);
            this.pSideBar.Location = new System.Drawing.Point(0, 0);
            this.pSideBar.Name = "pSideBar";
            this.pSideBar.Size = new System.Drawing.Size(195, 913);
            this.pSideBar.TabIndex = 3;
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadFile.Location = new System.Drawing.Point(13, 125);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(171, 39);
            this.btnLoadFile.TabIndex = 6;
            this.btnLoadFile.Text = "Load File";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // panDotInfo
            // 
            this.panDotInfo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panDotInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panDotInfo.Controls.Add(this.lblJobsNo);
            this.panDotInfo.Controls.Add(this.lblSapNo);
            this.panDotInfo.Controls.Add(this.lblDesc);
            this.panDotInfo.Controls.Add(this.lblArea);
            this.panDotInfo.Controls.Add(this.label1);
            this.panDotInfo.Location = new System.Drawing.Point(639, 383);
            this.panDotInfo.Name = "panDotInfo";
            this.panDotInfo.Size = new System.Drawing.Size(355, 191);
            this.panDotInfo.TabIndex = 3;
            this.panDotInfo.Visible = false;
            // 
            // lblSapNo
            // 
            this.lblSapNo.AutoSize = true;
            this.lblSapNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSapNo.Location = new System.Drawing.Point(15, 110);
            this.lblSapNo.Name = "lblSapNo";
            this.lblSapNo.Size = new System.Drawing.Size(92, 25);
            this.lblSapNo.TabIndex = 8;
            this.lblSapNo.Text = "lblSapNo";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(15, 75);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(76, 25);
            this.lblDesc.TabIndex = 7;
            this.lblDesc.Text = "lblDesc";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(15, 40);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(73, 25);
            this.lblArea.TabIndex = 6;
            this.lblArea.Text = "lblArea";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Information";
            // 
            // lblJobsNo
            // 
            this.lblJobsNo.AutoSize = true;
            this.lblJobsNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobsNo.Location = new System.Drawing.Point(15, 145);
            this.lblJobsNo.Name = "lblJobsNo";
            this.lblJobsNo.Size = new System.Drawing.Size(99, 25);
            this.lblJobsNo.TabIndex = 9;
            this.lblJobsNo.Text = "lblJobsNo";
            // 
            // AnalData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1825, 914);
            this.Controls.Add(this.pSideBar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panMain);
            this.Name = "AnalData";
            this.Text = "Analyise Data";
            this.panMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFactory)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pSideBar.ResumeLayout(false);
            this.panDotInfo.ResumeLayout(false);
            this.panDotInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panMain;
        private System.Windows.Forms.PictureBox pbFactory;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblItemDesc;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnAnal;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pSideBar;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Panel panDotInfo;
        private System.Windows.Forms.Label lblJobsNo;
        private System.Windows.Forms.Label lblSapNo;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label label1;
    }
}

