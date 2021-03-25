
namespace Inlupp3
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
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.pNumberTextBox = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.RichTextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.showNameLabel = new System.Windows.Forms.Label();
            this.showPNoLabel = new System.Windows.Forms.Label();
            this.showGenderLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.pNoLabel = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.infoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(141, 84);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(147, 20);
            this.firstNameTextBox.TabIndex = 0;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(141, 110);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(147, 20);
            this.LastNameTextBox.TabIndex = 1;
            // 
            // pNumberTextBox
            // 
            this.pNumberTextBox.Location = new System.Drawing.Point(141, 136);
            this.pNumberTextBox.Name = "pNumberTextBox";
            this.pNumberTextBox.Size = new System.Drawing.Size(147, 20);
            this.pNumberTextBox.TabIndex = 2;
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(141, 196);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(147, 96);
            this.outputTextBox.TabIndex = 3;
            this.outputTextBox.Text = "";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(160, 161);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(61, 19);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(227, 161);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(61, 19);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // showNameLabel
            // 
            this.showNameLabel.AutoSize = true;
            this.showNameLabel.Location = new System.Drawing.Point(158, 212);
            this.showNameLabel.Name = "showNameLabel";
            this.showNameLabel.Size = new System.Drawing.Size(0, 13);
            this.showNameLabel.TabIndex = 9;
            // 
            // showPNoLabel
            // 
            this.showPNoLabel.AutoSize = true;
            this.showPNoLabel.Location = new System.Drawing.Point(158, 234);
            this.showPNoLabel.Name = "showPNoLabel";
            this.showPNoLabel.Size = new System.Drawing.Size(0, 13);
            this.showPNoLabel.TabIndex = 10;
            // 
            // showGenderLabel
            // 
            this.showGenderLabel.AutoSize = true;
            this.showGenderLabel.Location = new System.Drawing.Point(158, 258);
            this.showGenderLabel.Name = "showGenderLabel";
            this.showGenderLabel.Size = new System.Drawing.Size(0, 13);
            this.showGenderLabel.TabIndex = 11;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(45, 87);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.firstNameLabel.TabIndex = 12;
            this.firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(44, 113);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.lastNameLabel.TabIndex = 13;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // pNoLabel
            // 
            this.pNoLabel.AutoSize = true;
            this.pNoLabel.Location = new System.Drawing.Point(44, 139);
            this.pNoLabel.Name = "pNoLabel";
            this.pNoLabel.Size = new System.Drawing.Size(91, 13);
            this.pNoLabel.TabIndex = 14;
            this.pNoLabel.Text = "Personal Number:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(376, 170);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 13);
            this.linkLabel1.TabIndex = 15;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.BackColor = System.Drawing.SystemColors.Info;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.infoLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.infoLabel.Location = new System.Drawing.Point(136, 24);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(280, 25);
            this.infoLabel.TabIndex = 16;
            this.infoLabel.Text = "Please add your information";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pNoLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.showGenderLabel);
            this.Controls.Add(this.showPNoLabel);
            this.Controls.Add(this.showNameLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.pNumberTextBox);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox pNumberTextBox;
        private System.Windows.Forms.RichTextBox outputTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label showNameLabel;
        private System.Windows.Forms.Label showPNoLabel;
        private System.Windows.Forms.Label showGenderLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label pNoLabel;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label infoLabel;
    }
}

