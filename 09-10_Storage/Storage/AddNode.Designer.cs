﻿
namespace Storage
{
    partial class AddNode
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.NameLanel = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.textBoxNameSection = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.NameLanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonOk);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxNameSection);
            this.splitContainer1.Size = new System.Drawing.Size(414, 136);
            this.splitContainer1.SplitterDistance = 138;
            this.splitContainer1.TabIndex = 0;
            // 
            // NameLanel
            // 
            this.NameLanel.Location = new System.Drawing.Point(32, 60);
            this.NameLanel.Name = "NameLanel";
            this.NameLanel.Size = new System.Drawing.Size(80, 15);
            this.NameLanel.TabIndex = 0;
            this.NameLanel.Text = "Имя раздела:";
            this.NameLanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(179, 99);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // textBoxNameSection
            // 
            this.textBoxNameSection.Location = new System.Drawing.Point(3, 57);
            this.textBoxNameSection.Name = "textBoxNameSection";
            this.textBoxNameSection.Size = new System.Drawing.Size(251, 23);
            this.textBoxNameSection.TabIndex = 0;
            this.textBoxNameSection.Enter += new System.EventHandler(this.textBoxNameSection_Enter);
            this.textBoxNameSection.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNameSection_KeyPress);
            // 
            // AddNode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 136);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(430, 175);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(430, 175);
            this.Name = "AddNode";
            this.Text = "Добавление раздела";
            this.Load += new System.EventHandler(this.AddNode_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label NameLanel;
        private System.Windows.Forms.TextBox textBoxNameSection;
        private System.Windows.Forms.Button buttonOk;
    }
}