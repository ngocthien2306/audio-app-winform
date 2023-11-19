
namespace Rec_radio.FormDesign
{
    partial class Result
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
            this.btnResult = new System.Windows.Forms.Button();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.labelClass = new System.Windows.Forms.Label();
            this.labelConf = new System.Windows.Forms.Label();
            this.txtConf = new System.Windows.Forms.TextBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnSaveTN = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnResult
            // 
            this.btnResult.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnResult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResult.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnResult.Location = new System.Drawing.Point(12, 19);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(246, 249);
            this.btnResult.TabIndex = 0;
            this.btnResult.Text = "OK";
            this.btnResult.UseVisualStyleBackColor = false;
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(364, 24);
            this.txtClass.Name = "txtClass";
            this.txtClass.ReadOnly = true;
            this.txtClass.Size = new System.Drawing.Size(129, 20);
            this.txtClass.TabIndex = 1;
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Location = new System.Drawing.Point(279, 29);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(35, 13);
            this.labelClass.TabIndex = 2;
            this.labelClass.Text = "Class:";
            // 
            // labelConf
            // 
            this.labelConf.AutoSize = true;
            this.labelConf.Location = new System.Drawing.Point(279, 65);
            this.labelConf.Name = "labelConf";
            this.labelConf.Size = new System.Drawing.Size(64, 13);
            this.labelConf.TabIndex = 4;
            this.labelConf.Text = "Confidence:";
            // 
            // txtConf
            // 
            this.txtConf.Location = new System.Drawing.Point(364, 65);
            this.txtConf.Name = "txtConf";
            this.txtConf.ReadOnly = true;
            this.txtConf.Size = new System.Drawing.Size(129, 20);
            this.txtConf.TabIndex = 3;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(279, 103);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(71, 13);
            this.labelTime.TabIndex = 6;
            this.labelTime.Text = "Execute time:";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(364, 103);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(129, 20);
            this.txtTime.TabIndex = 5;
            // 
            // btnSaveTN
            // 
            this.btnSaveTN.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSaveTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSaveTN.Location = new System.Drawing.Point(282, 228);
            this.btnSaveTN.Name = "btnSaveTN";
            this.btnSaveTN.Size = new System.Drawing.Size(211, 39);
            this.btnSaveTN.TabIndex = 7;
            this.btnSaveTN.Text = "Save File";
            this.btnSaveTN.UseVisualStyleBackColor = false;
            this.btnSaveTN.Click += new System.EventHandler(this.btnSaveTN_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(364, 143);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(129, 20);
            this.txtPath.TabIndex = 9;
            this.txtPath.Visible = false;
            this.txtPath.TextChanged += new System.EventHandler(this.txtPath_TextChanged);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPlay.Location = new System.Drawing.Point(282, 177);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(211, 39);
            this.btnPlay.TabIndex = 10;
            this.btnPlay.Text = "Play Audio";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 280);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnSaveTN);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.labelConf);
            this.Controls.Add(this.txtConf);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.btnResult);
            this.Name = "Result";
            this.Text = "Result";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.Label labelConf;
        private System.Windows.Forms.Label labelTime;
        public System.Windows.Forms.Button btnResult;
        public System.Windows.Forms.TextBox txtClass;
        public System.Windows.Forms.TextBox txtConf;
        public System.Windows.Forms.TextBox txtTime;
        public System.Windows.Forms.Button btnSaveTN;
        public System.Windows.Forms.TextBox txtPath;
        public System.Windows.Forms.Button btnPlay;
    }
}