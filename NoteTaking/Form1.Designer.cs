﻿namespace NoteTaking
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bttNew = new System.Windows.Forms.Button();
            this.bttSave = new System.Windows.Forms.Button();
            this.bttRead = new System.Windows.Forms.Button();
            this.bttDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(86, 35);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(173, 23);
            this.txtTitle.TabIndex = 0;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(86, 159);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(206, 64);
            this.txtMessage.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Message";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // bttNew
            // 
            this.bttNew.Location = new System.Drawing.Point(11, 297);
            this.bttNew.Name = "bttNew";
            this.bttNew.Size = new System.Drawing.Size(79, 28);
            this.bttNew.TabIndex = 4;
            this.bttNew.Text = "New";
            this.bttNew.UseVisualStyleBackColor = true;
            this.bttNew.Click += new System.EventHandler(this.bttNew_Click);
            // 
            // bttSave
            // 
            this.bttSave.Location = new System.Drawing.Point(131, 297);
            this.bttSave.Name = "bttSave";
            this.bttSave.Size = new System.Drawing.Size(79, 31);
            this.bttSave.TabIndex = 5;
            this.bttSave.Text = "Save";
            this.bttSave.UseVisualStyleBackColor = true;
            this.bttSave.Click += new System.EventHandler(this.bttSave_Click);
            // 
            // bttRead
            // 
            this.bttRead.Location = new System.Drawing.Point(266, 297);
            this.bttRead.Name = "bttRead";
            this.bttRead.Size = new System.Drawing.Size(79, 33);
            this.bttRead.TabIndex = 6;
            this.bttRead.Text = "Read";
            this.bttRead.UseVisualStyleBackColor = true;
            this.bttRead.Click += new System.EventHandler(this.bttRead_Click);
            // 
            // bttDelete
            // 
            this.bttDelete.Location = new System.Drawing.Point(391, 297);
            this.bttDelete.Name = "bttDelete";
            this.bttDelete.Size = new System.Drawing.Size(79, 33);
            this.bttDelete.TabIndex = 7;
            this.bttDelete.Text = "Delete";
            this.bttDelete.UseVisualStyleBackColor = true;
            this.bttDelete.Click += new System.EventHandler(this.bttDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(376, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(245, 195);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 346);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bttDelete);
            this.Controls.Add(this.bttRead);
            this.Controls.Add(this.bttSave);
            this.Controls.Add(this.bttNew);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtTitle);
            this.Name = "Form1";
            this.Text = "NoteTakingApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtTitle;
        private TextBox txtMessage;
        private Label label1;
        private Label label2;
        private Button bttNew;
        private Button bttSave;
        private Button bttRead;
        private Button bttDelete;
        private DataGridView dataGridView1;
    }
}