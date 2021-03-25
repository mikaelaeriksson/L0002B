
namespace WindowsFormsAppInlupp1
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
            this.textBoxPris = new System.Windows.Forms.TextBox();
            this.textBoxBetalt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // textBoxPris
            // 
            this.textBoxPris.Location = new System.Drawing.Point(198, 45);
            this.textBoxPris.Name = "textBoxPris";
            this.textBoxPris.Size = new System.Drawing.Size(77, 20);
            this.textBoxPris.TabIndex = 0;
            this.textBoxPris.TextChanged += new System.EventHandler(this.textBoxPris_TextChanged);
            // 
            // textBoxBetalt
            // 
            this.textBoxBetalt.Location = new System.Drawing.Point(198, 93);
            this.textBoxBetalt.Name = "textBoxBetalt";
            this.textBoxBetalt.Size = new System.Drawing.Size(77, 20);
            this.textBoxBetalt.TabIndex = 1;
            this.textBoxBetalt.TextChanged += new System.EventHandler(this.textBoxBetalt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ange pris:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Betalt:";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(200, 171);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(141, 229);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(134, 110);
            this.textBoxResult.TabIndex = 5;
            this.textBoxResult.Text = "";
            this.textBoxResult.TextChanged += new System.EventHandler(this.textBoxResult_TextChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 369);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBetalt);
            this.Controls.Add(this.textBoxPris);
            this.Name = "Form1";
            this.Text = "Räknare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPris;
        private System.Windows.Forms.TextBox textBoxBetalt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.RichTextBox textBoxResult;
    }
}

