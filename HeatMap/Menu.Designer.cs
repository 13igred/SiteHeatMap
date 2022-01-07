
namespace HeatMap
{
    partial class Menu
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
            this.bntUpdatePoint = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntUpdatePoint
            // 
            this.bntUpdatePoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntUpdatePoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntUpdatePoint.Location = new System.Drawing.Point(447, 167);
            this.bntUpdatePoint.Name = "bntUpdatePoint";
            this.bntUpdatePoint.Size = new System.Drawing.Size(250, 70);
            this.bntUpdatePoint.TabIndex = 0;
            this.bntUpdatePoint.Text = "Update Points";
            this.bntUpdatePoint.UseVisualStyleBackColor = true;
            // 
            // btnRun
            // 
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(447, 43);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(250, 70);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Analyise Points";
            this.btnRun.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(447, 618);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(250, 70);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 753);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.bntUpdatePoint);
            this.Name = "Menu";
            this.Text = "MainMenu";
            this.SizeChanged += new System.EventHandler(this.Form_SizedChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntUpdatePoint;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnQuit;
    }
}