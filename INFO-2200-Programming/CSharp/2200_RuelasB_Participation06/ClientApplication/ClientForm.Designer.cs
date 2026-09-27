namespace ClientApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GroupBoxREQUEST = new System.Windows.Forms.GroupBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.TxtBoxRequest = new System.Windows.Forms.TextBox();
            this.GroupBoxRESPONSE = new System.Windows.Forms.GroupBox();
            this.TxtBoxResposne = new System.Windows.Forms.TextBox();
            this.GroupBoxREQUEST.SuspendLayout();
            this.GroupBoxRESPONSE.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxREQUEST
            // 
            this.GroupBoxREQUEST.Controls.Add(this.Label1);
            this.GroupBoxREQUEST.Controls.Add(this.BtnSubmit);
            this.GroupBoxREQUEST.Controls.Add(this.TxtBoxRequest);
            this.GroupBoxREQUEST.Location = new System.Drawing.Point(22, 33);
            this.GroupBoxREQUEST.Name = "GroupBoxREQUEST";
            this.GroupBoxREQUEST.Size = new System.Drawing.Size(685, 185);
            this.GroupBoxREQUEST.TabIndex = 0;
            this.GroupBoxREQUEST.TabStop = false;
            this.GroupBoxREQUEST.Text = "REQUEST";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(31, 62);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(413, 25);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Message The Server (conspiracy or joke):";
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Location = new System.Drawing.Point(560, 111);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(109, 35);
            this.BtnSubmit.TabIndex = 1;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // TxtBoxRequest
            // 
            this.TxtBoxRequest.Location = new System.Drawing.Point(36, 113);
            this.TxtBoxRequest.Name = "TxtBoxRequest";
            this.TxtBoxRequest.Size = new System.Drawing.Size(493, 31);
            this.TxtBoxRequest.TabIndex = 0;
            // 
            // GroupBoxRESPONSE
            // 
            this.GroupBoxRESPONSE.Controls.Add(this.TxtBoxResposne);
            this.GroupBoxRESPONSE.Location = new System.Drawing.Point(22, 250);
            this.GroupBoxRESPONSE.Name = "GroupBoxRESPONSE";
            this.GroupBoxRESPONSE.Size = new System.Drawing.Size(685, 233);
            this.GroupBoxRESPONSE.TabIndex = 1;
            this.GroupBoxRESPONSE.TabStop = false;
            this.GroupBoxRESPONSE.Text = "RESPONSE";
            // 
            // TxtBoxResposne
            // 
            this.TxtBoxResposne.Location = new System.Drawing.Point(16, 41);
            this.TxtBoxResposne.Multiline = true;
            this.TxtBoxResposne.Name = "TxtBoxResposne";
            this.TxtBoxResposne.ReadOnly = true;
            this.TxtBoxResposne.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtBoxResposne.Size = new System.Drawing.Size(653, 173);
            this.TxtBoxResposne.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 513);
            this.Controls.Add(this.GroupBoxRESPONSE);
            this.Controls.Add(this.GroupBoxREQUEST);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Ask the Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBoxREQUEST.ResumeLayout(false);
            this.GroupBoxREQUEST.PerformLayout();
            this.GroupBoxRESPONSE.ResumeLayout(false);
            this.GroupBoxRESPONSE.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxREQUEST;
        private System.Windows.Forms.GroupBox GroupBoxRESPONSE;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.TextBox TxtBoxRequest;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox TxtBoxResposne;
    }
}

