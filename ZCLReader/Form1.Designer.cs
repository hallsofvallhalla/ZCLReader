namespace ZCLReader
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.UploadButton = new System.Windows.Forms.Button();
            this.FTLabel = new System.Windows.Forms.Label();
            this.MCLabel = new System.Windows.Forms.Label();
            this.DirectionLabel = new System.Windows.Forms.Label();
            this.ResponseLabel = new System.Windows.Forms.Label();
            this.IFMClabel = new System.Windows.Forms.Label();
            this.TransLabel = new System.Windows.Forms.Label();
            this.ClusterLabel = new System.Windows.Forms.Label();
            this.CommandLabel = new System.Windows.Forms.Label();
            this.PayloadLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // UploadButton
            // 
            this.UploadButton.Location = new System.Drawing.Point(230, 33);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(123, 41);
            this.UploadButton.TabIndex = 0;
            this.UploadButton.Text = "Upload A File";
            this.UploadButton.UseVisualStyleBackColor = true;
            this.UploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // FTLabel
            // 
            this.FTLabel.AutoSize = true;
            this.FTLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FTLabel.Location = new System.Drawing.Point(48, 127);
            this.FTLabel.Name = "FTLabel";
            this.FTLabel.Size = new System.Drawing.Size(62, 15);
            this.FTLabel.TabIndex = 1;
            this.FTLabel.Text = "FrameType";
            // 
            // MCLabel
            // 
            this.MCLabel.AutoSize = true;
            this.MCLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MCLabel.Location = new System.Drawing.Point(116, 128);
            this.MCLabel.Name = "MCLabel";
            this.MCLabel.Size = new System.Drawing.Size(106, 15);
            this.MCLabel.TabIndex = 2;
            this.MCLabel.Text = "Manufacturer Code?";
            // 
            // DirectionLabel
            // 
            this.DirectionLabel.AutoSize = true;
            this.DirectionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DirectionLabel.Location = new System.Drawing.Point(454, 127);
            this.DirectionLabel.Name = "DirectionLabel";
            this.DirectionLabel.Size = new System.Drawing.Size(51, 15);
            this.DirectionLabel.TabIndex = 3;
            this.DirectionLabel.Text = "Direction";
            // 
            // ResponseLabel
            // 
            this.ResponseLabel.AutoSize = true;
            this.ResponseLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResponseLabel.Location = new System.Drawing.Point(508, 127);
            this.ResponseLabel.Name = "ResponseLabel";
            this.ResponseLabel.Size = new System.Drawing.Size(94, 15);
            this.ResponseLabel.TabIndex = 4;
            this.ResponseLabel.Text = "Default Response";
            // 
            // IFMClabel
            // 
            this.IFMClabel.AutoSize = true;
            this.IFMClabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IFMClabel.Location = new System.Drawing.Point(228, 128);
            this.IFMClabel.Name = "IFMClabel";
            this.IFMClabel.Size = new System.Drawing.Size(100, 15);
            this.IFMClabel.TabIndex = 5;
            this.IFMClabel.Text = "Manufacturer Code";
            // 
            // TransLabel
            // 
            this.TransLabel.AutoSize = true;
            this.TransLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TransLabel.Location = new System.Drawing.Point(608, 127);
            this.TransLabel.Name = "TransLabel";
            this.TransLabel.Size = new System.Drawing.Size(65, 15);
            this.TransLabel.TabIndex = 6;
            this.TransLabel.Text = "Transaction";
            // 
            // ClusterLabel
            // 
            this.ClusterLabel.AutoSize = true;
            this.ClusterLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClusterLabel.Location = new System.Drawing.Point(1, 127);
            this.ClusterLabel.Name = "ClusterLabel";
            this.ClusterLabel.Size = new System.Drawing.Size(41, 15);
            this.ClusterLabel.TabIndex = 7;
            this.ClusterLabel.Text = "Cluster";
            // 
            // CommandLabel
            // 
            this.CommandLabel.AutoSize = true;
            this.CommandLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CommandLabel.Location = new System.Drawing.Point(679, 127);
            this.CommandLabel.Name = "CommandLabel";
            this.CommandLabel.Size = new System.Drawing.Size(56, 15);
            this.CommandLabel.TabIndex = 8;
            this.CommandLabel.Text = "Command";
            // 
            // PayloadLabel
            // 
            this.PayloadLabel.AutoSize = true;
            this.PayloadLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PayloadLabel.Location = new System.Drawing.Point(879, 128);
            this.PayloadLabel.Name = "PayloadLabel";
            this.PayloadLabel.Size = new System.Drawing.Size(47, 15);
            this.PayloadLabel.TabIndex = 9;
            this.PayloadLabel.Text = "Payload";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.Location = new System.Drawing.Point(359, 54);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(243, 20);
            this.DescriptionLabel.TabIndex = 10;
            this.DescriptionLabel.Text = "Select the ZCL File to upload";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(968, 562);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.PayloadLabel);
            this.Controls.Add(this.CommandLabel);
            this.Controls.Add(this.ClusterLabel);
            this.Controls.Add(this.TransLabel);
            this.Controls.Add(this.IFMClabel);
            this.Controls.Add(this.ResponseLabel);
            this.Controls.Add(this.DirectionLabel);
            this.Controls.Add(this.MCLabel);
            this.Controls.Add(this.FTLabel);
            this.Controls.Add(this.UploadButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button UploadButton;
        private System.Windows.Forms.Label FTLabel;
        private System.Windows.Forms.Label MCLabel;
        private System.Windows.Forms.Label DirectionLabel;
        private System.Windows.Forms.Label ResponseLabel;
        private System.Windows.Forms.Label IFMClabel;
        private System.Windows.Forms.Label TransLabel;
        private System.Windows.Forms.Label ClusterLabel;
        private System.Windows.Forms.Label CommandLabel;
        private System.Windows.Forms.Label PayloadLabel;
        private System.Windows.Forms.Label DescriptionLabel;

    }
}

