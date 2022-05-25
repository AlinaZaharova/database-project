
namespace LibraryApp
{
    partial class AddEditBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditBook));
            this.btn_saveBook = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_Author = new System.Windows.Forms.ComboBox();
            this.cb_owned = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb_Genre = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_saveBook
            // 
            this.btn_saveBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btn_saveBook.Image = ((System.Drawing.Image)(resources.GetObject("btn_saveBook.Image")));
            this.btn_saveBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_saveBook.Location = new System.Drawing.Point(159, 241);
            this.btn_saveBook.Name = "btn_saveBook";
            this.btn_saveBook.Size = new System.Drawing.Size(104, 26);
            this.btn_saveBook.TabIndex = 2;
            this.btn_saveBook.Text = "Сохранить";
            this.btn_saveBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_saveBook.UseVisualStyleBackColor = true;
            this.btn_saveBook.Click += new System.EventHandler(this.btn_saveBook_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Title.Location = new System.Drawing.Point(12, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(66, 24);
            this.lbl_Title.TabIndex = 4;
            this.lbl_Title.Text = "TITLE";
            // 
            // txt_Title
            // 
            this.txt_Title.Location = new System.Drawing.Point(6, 21);
            this.txt_Title.Multiline = true;
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(246, 25);
            this.txt_Title.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Title);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(11, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 55);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Название:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_Author);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(11, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 55);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Автор:";
            // 
            // cb_Author
            // 
            this.cb_Author.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Author.FormattingEnabled = true;
            this.cb_Author.Location = new System.Drawing.Point(6, 21);
            this.cb_Author.Name = "cb_Author";
            this.cb_Author.Size = new System.Drawing.Size(246, 24);
            this.cb_Author.TabIndex = 0;
            // 
            // cb_owned
            // 
            this.cb_owned.AutoSize = true;
            this.cb_owned.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cb_owned.Location = new System.Drawing.Point(12, 246);
            this.cb_owned.Name = "cb_owned";
            this.cb_owned.Size = new System.Drawing.Size(125, 21);
            this.cb_owned.TabIndex = 5;
            this.cb_owned.Text = "В пользовании";
            this.cb_owned.UseVisualStyleBackColor = true;
            this.cb_owned.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cb_Genre);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(11, 169);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(258, 55);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Жанр:";
            // 
            // cb_Genre
            // 
            this.cb_Genre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Genre.FormattingEnabled = true;
            this.cb_Genre.Location = new System.Drawing.Point(6, 21);
            this.cb_Genre.Name = "cb_Genre";
            this.cb_Genre.Size = new System.Drawing.Size(246, 24);
            this.cb_Genre.TabIndex = 0;
            // 
            // AddEditBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 285);
            this.Controls.Add(this.cb_owned);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.btn_saveBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(315, 350);
            this.Name = "AddEditBook";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.AddEditBook_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label lbl_Title;
        public System.Windows.Forms.Button btn_saveBook;
        public System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.CheckBox cb_owned;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cb_Author;
        private System.Windows.Forms.ComboBox cb_Genre;
    }
}