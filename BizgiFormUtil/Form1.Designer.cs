﻿namespace BizgiFormUtil
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
            this.txtCaso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAply = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pgWorkItem = new System.Windows.Forms.PropertyGrid();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbProcessos = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCaso
            // 
            this.txtCaso.Location = new System.Drawing.Point(12, 31);
            this.txtCaso.Name = "txtCaso";
            this.txtCaso.Size = new System.Drawing.Size(100, 20);
            this.txtCaso.TabIndex = 0;
            this.txtCaso.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCaso_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Caso";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tarefa Atual:";
            // 
            // btnAply
            // 
            this.btnAply.BackColor = System.Drawing.SystemColors.Control;
            this.btnAply.Location = new System.Drawing.Point(12, 191);
            this.btnAply.Name = "btnAply";
            this.btnAply.Size = new System.Drawing.Size(181, 23);
            this.btnAply.TabIndex = 5;
            this.btnAply.Text = "PerformActivity";
            this.btnAply.UseVisualStyleBackColor = false;
            this.btnAply.Click += new System.EventHandler(this.btnAply_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(12, 165);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(57, 13);
            this.lblType.TabIndex = 7;
            this.lblType.Text = "xxxxxxxxxx";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "CurrentWorkItem:";
            // 
            // pgWorkItem
            // 
            this.pgWorkItem.HelpVisible = false;
            this.pgWorkItem.Location = new System.Drawing.Point(232, 21);
            this.pgWorkItem.Name = "pgWorkItem";
            this.pgWorkItem.Size = new System.Drawing.Size(689, 620);
            this.pgWorkItem.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(12, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Exportar casos";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbProcessos
            // 
            this.cmbProcessos.FormattingEnabled = true;
            this.cmbProcessos.Location = new System.Drawing.Point(15, 85);
            this.cmbProcessos.Name = "cmbProcessos";
            this.cmbProcessos.Size = new System.Drawing.Size(178, 21);
            this.cmbProcessos.TabIndex = 11;
            this.cmbProcessos.SelectedIndexChanged += new System.EventHandler(this.cmbProcessos_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Processos";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(15, 249);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(181, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Exportar usuarios";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 648);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbProcessos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pgWorkItem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.btnAply);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCaso);
            this.Name = "Form1";
            this.Text = "Bizagi Util";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCaso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAply;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PropertyGrid pgWorkItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbProcessos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
    }
}

