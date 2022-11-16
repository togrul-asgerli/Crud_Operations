namespace SQL
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
            this.Grid_tab = new System.Windows.Forms.DataGridView();
            this.lbl_nam = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_gender = new System.Windows.Forms.TextBox();
            this.lbl_gen = new System.Windows.Forms.Label();
            this.txt_subject = new System.Windows.Forms.TextBox();
            this.lbl_sub = new System.Windows.Forms.Label();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.lbl_surnm = new System.Windows.Forms.Label();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.btn_find = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_tab)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid_tab
            // 
            this.Grid_tab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_tab.Location = new System.Drawing.Point(440, 397);
            this.Grid_tab.Name = "Grid_tab";
            this.Grid_tab.RowHeadersWidth = 51;
            this.Grid_tab.RowTemplate.Height = 24;
            this.Grid_tab.Size = new System.Drawing.Size(509, 206);
            this.Grid_tab.TabIndex = 0;
            // 
            // lbl_nam
            // 
            this.lbl_nam.AutoSize = true;
            this.lbl_nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nam.Location = new System.Drawing.Point(19, 86);
            this.lbl_nam.Name = "lbl_nam";
            this.lbl_nam.Size = new System.Drawing.Size(142, 25);
            this.lbl_nam.TabIndex = 1;
            this.lbl_nam.Text = "Teacher Name";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(191, 83);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(158, 57);
            this.txt_name.TabIndex = 2;
            this.txt_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_gender
            // 
            this.txt_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gender.Location = new System.Drawing.Point(191, 337);
            this.txt_gender.Multiline = true;
            this.txt_gender.Name = "txt_gender";
            this.txt_gender.Size = new System.Drawing.Size(158, 57);
            this.txt_gender.TabIndex = 4;
            // 
            // lbl_gen
            // 
            this.lbl_gen.AutoSize = true;
            this.lbl_gen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gen.Location = new System.Drawing.Point(15, 353);
            this.lbl_gen.Name = "lbl_gen";
            this.lbl_gen.Size = new System.Drawing.Size(155, 25);
            this.lbl_gen.TabIndex = 3;
            this.lbl_gen.Text = "Teacher Gender";
            // 
            // txt_subject
            // 
            this.txt_subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_subject.Location = new System.Drawing.Point(191, 250);
            this.txt_subject.Multiline = true;
            this.txt_subject.Name = "txt_subject";
            this.txt_subject.Size = new System.Drawing.Size(158, 57);
            this.txt_subject.TabIndex = 6;
            // 
            // lbl_sub
            // 
            this.lbl_sub.AutoSize = true;
            this.lbl_sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sub.Location = new System.Drawing.Point(15, 265);
            this.lbl_sub.Name = "lbl_sub";
            this.lbl_sub.Size = new System.Drawing.Size(156, 25);
            this.lbl_sub.TabIndex = 5;
            this.lbl_sub.Text = "Teacher Subject";
            // 
            // txt_surname
            // 
            this.txt_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_surname.Location = new System.Drawing.Point(191, 169);
            this.txt_surname.Multiline = true;
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(158, 57);
            this.txt_surname.TabIndex = 8;
            // 
            // lbl_surnm
            // 
            this.lbl_surnm.AutoSize = true;
            this.lbl_surnm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_surnm.Location = new System.Drawing.Point(15, 184);
            this.lbl_surnm.Name = "lbl_surnm";
            this.lbl_surnm.Size = new System.Drawing.Size(170, 25);
            this.lbl_surnm.TabIndex = 7;
            this.lbl_surnm.Text = "Teacher Surname";
            // 
            // txt_mail
            // 
            this.txt_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mail.Location = new System.Drawing.Point(191, 424);
            this.txt_mail.Multiline = true;
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(158, 57);
            this.txt_mail.TabIndex = 10;
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mail.Location = new System.Drawing.Point(19, 425);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(140, 25);
            this.lbl_mail.TabIndex = 9;
            this.lbl_mail.Text = "Teacher Gmail";
            // 
            // btn_find
            // 
            this.btn_find.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_find.Location = new System.Drawing.Point(545, 56);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(107, 55);
            this.btn_find.TabIndex = 11;
            this.btn_find.Text = "List";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(545, 235);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(107, 55);
            this.btn_update.TabIndex = 12;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(545, 323);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(107, 55);
            this.btn_delete.TabIndex = 13;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.Location = new System.Drawing.Point(545, 142);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(107, 55);
            this.btn_insert.TabIndex = 14;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(191, 5);
            this.txt_id.Multiline = true;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(158, 57);
            this.txt_id.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Teacher_Id";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 615);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.lbl_mail);
            this.Controls.Add(this.txt_surname);
            this.Controls.Add(this.lbl_surnm);
            this.Controls.Add(this.txt_subject);
            this.Controls.Add(this.lbl_sub);
            this.Controls.Add(this.txt_gender);
            this.Controls.Add(this.lbl_gen);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_nam);
            this.Controls.Add(this.Grid_tab);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_tab)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid_tab;
        private System.Windows.Forms.Label lbl_nam;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_gender;
        private System.Windows.Forms.Label lbl_gen;
        private System.Windows.Forms.TextBox txt_subject;
        private System.Windows.Forms.Label lbl_sub;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.Label lbl_surnm;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label1;
    }
}

