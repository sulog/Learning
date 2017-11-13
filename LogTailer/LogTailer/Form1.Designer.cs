namespace LogTailer
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
            this.txtLogFilePath = new System.Windows.Forms.TextBox();
            this.btnWatch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.rtbLogContent = new System.Windows.Forms.RichTextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLogFilePath
            // 
            this.txtLogFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogFilePath.Location = new System.Drawing.Point(12, 12);
            this.txtLogFilePath.Name = "txtLogFilePath";
            this.txtLogFilePath.Size = new System.Drawing.Size(278, 23);
            this.txtLogFilePath.TabIndex = 0;
            // 
            // btnWatch
            // 
            this.btnWatch.Location = new System.Drawing.Point(296, 12);
            this.btnWatch.Name = "btnWatch";
            this.btnWatch.Size = new System.Drawing.Size(75, 23);
            this.btnWatch.TabIndex = 1;
            this.btnWatch.Text = "Watch";
            this.btnWatch.UseVisualStyleBackColor = true;
            this.btnWatch.Click += new System.EventHandler(this.btnWatch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(458, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // rtbLogContent
            // 
            this.rtbLogContent.Location = new System.Drawing.Point(12, 41);
            this.rtbLogContent.Name = "rtbLogContent";
            this.rtbLogContent.Size = new System.Drawing.Size(521, 271);
            this.rtbLogContent.TabIndex = 4;
            this.rtbLogContent.Text = "";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(377, 12);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 324);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.rtbLogContent);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnWatch);
            this.Controls.Add(this.txtLogFilePath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "LogTailer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLogFilePath;
        private System.Windows.Forms.Button btnWatch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RichTextBox rtbLogContent;
        private System.Windows.Forms.Button btnStop;
    }
}

