
namespace HeatMap
{
    partial class AddPoints
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
            this.panPopUp = new System.Windows.Forms.Panel();
            this.lblBoxTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbArea = new System.Windows.Forms.ComboBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtSAPID = new System.Windows.Forms.TextBox();
            this.panMain = new System.Windows.Forms.Panel();
            this.panDotInfo = new System.Windows.Forms.Panel();
            this.lblSapNo = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbFactory = new System.Windows.Forms.PictureBox();
            this.pSideBar = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAnal = new System.Windows.Forms.Button();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.panPopUp.SuspendLayout();
            this.panMain.SuspendLayout();
            this.panDotInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFactory)).BeginInit();
            this.pSideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panPopUp
            // 
            this.panPopUp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panPopUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panPopUp.Controls.Add(this.lblBoxTitle);
            this.panPopUp.Controls.Add(this.btnClose);
            this.panPopUp.Controls.Add(this.btnAdd);
            this.panPopUp.Controls.Add(this.cbArea);
            this.panPopUp.Controls.Add(this.txtDesc);
            this.panPopUp.Controls.Add(this.txtSAPID);
            this.panPopUp.Location = new System.Drawing.Point(281, 101);
            this.panPopUp.Name = "panPopUp";
            this.panPopUp.Size = new System.Drawing.Size(330, 350);
            this.panPopUp.TabIndex = 0;
            // 
            // lblBoxTitle
            // 
            this.lblBoxTitle.AutoSize = true;
            this.lblBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoxTitle.Location = new System.Drawing.Point(103, 15);
            this.lblBoxTitle.Name = "lblBoxTitle";
            this.lblBoxTitle.Size = new System.Drawing.Size(124, 29);
            this.lblBoxTitle.TabIndex = 4;
            this.lblBoxTitle.Text = "New Point";
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(15, 281);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(116, 39);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(194, 281);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 39);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbArea
            // 
            this.cbArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbArea.FormattingEnabled = true;
            this.cbArea.Location = new System.Drawing.Point(15, 74);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(295, 37);
            this.cbArea.TabIndex = 2;
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(15, 217);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(295, 34);
            this.txtDesc.TabIndex = 1;
            this.txtDesc.Text = "Item Description";
            // 
            // txtSAPID
            // 
            this.txtSAPID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSAPID.Location = new System.Drawing.Point(15, 149);
            this.txtSAPID.Name = "txtSAPID";
            this.txtSAPID.Size = new System.Drawing.Size(295, 34);
            this.txtSAPID.TabIndex = 0;
            this.txtSAPID.Text = "SAP ID";
            // 
            // panMain
            // 
            this.panMain.Controls.Add(this.panDotInfo);
            this.panMain.Controls.Add(this.pbFactory);
            this.panMain.Controls.Add(this.panPopUp);
            this.panMain.Location = new System.Drawing.Point(193, 1);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(1632, 913);
            this.panMain.TabIndex = 1;
            // 
            // panDotInfo
            // 
            this.panDotInfo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panDotInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panDotInfo.Controls.Add(this.lblSapNo);
            this.panDotInfo.Controls.Add(this.lblDesc);
            this.panDotInfo.Controls.Add(this.lblArea);
            this.panDotInfo.Controls.Add(this.label1);
            this.panDotInfo.Location = new System.Drawing.Point(810, 176);
            this.panDotInfo.Name = "panDotInfo";
            this.panDotInfo.Size = new System.Drawing.Size(355, 146);
            this.panDotInfo.TabIndex = 2;
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
            this.lblDesc.Location = new System.Drawing.Point(15, 76);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(76, 25);
            this.lblDesc.TabIndex = 7;
            this.lblDesc.Text = "lblDesc";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(15, 41);
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
            // pbFactory
            // 
            this.pbFactory.Location = new System.Drawing.Point(7, 12);
            this.pbFactory.Name = "pbFactory";
            this.pbFactory.Size = new System.Drawing.Size(100, 50);
            this.pbFactory.TabIndex = 1;
            this.pbFactory.TabStop = false;
            this.pbFactory.Paint += new System.Windows.Forms.PaintEventHandler(this.pbFactory_Paint);
            this.pbFactory.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbFactory_MouseDown);
            this.pbFactory.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbFactory_MouseMove);
            this.pbFactory.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbFactory_MouseUp);
            // 
            // pSideBar
            // 
            this.pSideBar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pSideBar.Controls.Add(this.btnExit);
            this.pSideBar.Controls.Add(this.btnAnal);
            this.pSideBar.Controls.Add(this.btnZoomOut);
            this.pSideBar.Controls.Add(this.btnZoomIn);
            this.pSideBar.Location = new System.Drawing.Point(-1, 1);
            this.pSideBar.Name = "pSideBar";
            this.pSideBar.Size = new System.Drawing.Size(195, 913);
            this.pSideBar.TabIndex = 2;
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
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAnal
            // 
            this.btnAnal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnal.Location = new System.Drawing.Point(13, 25);
            this.btnAnal.Name = "btnAnal";
            this.btnAnal.Size = new System.Drawing.Size(171, 39);
            this.btnAnal.TabIndex = 5;
            this.btnAnal.Text = "Analyise Data";
            this.btnAnal.UseVisualStyleBackColor = true;
            this.btnAnal.Click += new System.EventHandler(this.btnAnal_Click);
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
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
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
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // AddPoints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1825, 914);
            this.Controls.Add(this.pSideBar);
            this.Controls.Add(this.panMain);
            this.Name = "AddPoints";
            this.Text = "AddPoints";
            this.panPopUp.ResumeLayout(false);
            this.panPopUp.PerformLayout();
            this.panMain.ResumeLayout(false);
            this.panDotInfo.ResumeLayout(false);
            this.panDotInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFactory)).EndInit();
            this.pSideBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panPopUp;
        private System.Windows.Forms.Label lblBoxTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbArea;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtSAPID;
        private System.Windows.Forms.Panel panMain;
        private System.Windows.Forms.PictureBox pbFactory;
        private System.Windows.Forms.Panel pSideBar;
        private System.Windows.Forms.Panel panDotInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSapNo;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAnal;
    }
}