
namespace LibraryApp.UserControls
{
    partial class BooksUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooksUC));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookedUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnerUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnael_search = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.panel_user = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gb_dgv = new System.Windows.Forms.GroupBox();
            this.panel_admin = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_exit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_authors = new System.Windows.Forms.Button();
            this.btn_genres = new System.Windows.Forms.Button();
            this.btn_Journal = new System.Windows.Forms.Button();
            this.btn_handBook = new System.Windows.Forms.Button();
            this.btn_order = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.pnael_search.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel_user.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.gb_dgv.SuspendLayout();
            this.panel_admin.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sqliteCommand1
            // 
            this.sqliteCommand1.CommandTimeout = 30;
            this.sqliteCommand1.Connection = null;
            this.sqliteCommand1.Transaction = null;
            this.sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoGenerateColumns = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.Genre,
            this.Author,
            this.BookedUser,
            this.OwnerUser});
            this.dgv.DataSource = this.bookBindingSource;
            this.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv.Location = new System.Drawing.Point(6, 22);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv.RowHeadersVisible = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(741, 244);
            this.dgv.TabIndex = 1;
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            // 
            // Genre
            // 
            this.Genre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Genre.DataPropertyName = "Genre.Name";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Genre.DefaultCellStyle = dataGridViewCellStyle5;
            this.Genre.FillWeight = 17.13198F;
            this.Genre.HeaderText = "Жанр";
            this.Genre.Name = "Genre";
            this.Genre.ReadOnly = true;
            // 
            // Author
            // 
            this.Author.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Author.DataPropertyName = "Author.Name";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Author.DefaultCellStyle = dataGridViewCellStyle6;
            this.Author.FillWeight = 17.13198F;
            this.Author.HeaderText = "Автор";
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            // 
            // BookedUser
            // 
            this.BookedUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.BookedUser.DefaultCellStyle = dataGridViewCellStyle7;
            this.BookedUser.FillWeight = 17.13198F;
            this.BookedUser.HeaderText = "Забронирована";
            this.BookedUser.Name = "BookedUser";
            this.BookedUser.ReadOnly = true;
            this.BookedUser.Width = 137;
            // 
            // OwnerUser
            // 
            this.OwnerUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.OwnerUser.DefaultCellStyle = dataGridViewCellStyle8;
            this.OwnerUser.FillWeight = 17.13198F;
            this.OwnerUser.HeaderText = "В пользовании";
            this.OwnerUser.Name = "OwnerUser";
            this.OwnerUser.ReadOnly = true;
            this.OwnerUser.Width = 120;
            // 
            // pnael_search
            // 
            this.pnael_search.Controls.Add(this.flowLayoutPanel2);
            this.pnael_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pnael_search.Location = new System.Drawing.Point(14, 281);
            this.pnael_search.Name = "pnael_search";
            this.pnael_search.Size = new System.Drawing.Size(328, 55);
            this.pnael_search.TabIndex = 3;
            this.pnael_search.TabStop = false;
            this.pnael_search.Text = "Поиск";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel2.Controls.Add(this.txt_search);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(6, 21);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(277, 28);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(49, 3);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(216, 22);
            this.txt_search.TabIndex = 1;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // panel_user
            // 
            this.panel_user.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_user.Controls.Add(this.flowLayoutPanel1);
            this.panel_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel_user.Location = new System.Drawing.Point(417, 281);
            this.panel_user.Name = "panel_user";
            this.panel_user.Size = new System.Drawing.Size(278, 55);
            this.panel_user.TabIndex = 3;
            this.panel_user.TabStop = false;
            this.panel_user.Text = "Панель пользователя";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_order);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 21);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(217, 28);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // gb_dgv
            // 
            this.gb_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_dgv.Controls.Add(this.dgv);
            this.gb_dgv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.gb_dgv.Location = new System.Drawing.Point(14, 3);
            this.gb_dgv.Name = "gb_dgv";
            this.gb_dgv.Size = new System.Drawing.Size(753, 272);
            this.gb_dgv.TabIndex = 4;
            this.gb_dgv.TabStop = false;
            this.gb_dgv.Text = "Книги:";
            // 
            // panel_admin
            // 
            this.panel_admin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_admin.Controls.Add(this.flowLayoutPanel3);
            this.panel_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel_admin.Location = new System.Drawing.Point(444, 440);
            this.panel_admin.Name = "panel_admin";
            this.panel_admin.Size = new System.Drawing.Size(317, 55);
            this.panel_admin.TabIndex = 3;
            this.panel_admin.TabStop = false;
            this.panel_admin.Text = "Панель администратора";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.button1);
            this.flowLayoutPanel3.Controls.Add(this.button2);
            this.flowLayoutPanel3.Controls.Add(this.button3);
            this.flowLayoutPanel3.Controls.Add(this.btn_authors);
            this.flowLayoutPanel3.Controls.Add(this.btn_genres);
            this.flowLayoutPanel3.Controls.Add(this.btn_Journal);
            this.flowLayoutPanel3.Controls.Add(this.btn_handBook);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(6, 21);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(305, 28);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Author";
            this.dataGridViewTextBoxColumn1.HeaderText = "Автор";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 167;
            // 
            // btn_exit
            // 
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.Location = new System.Drawing.Point(701, 305);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(66, 31);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "Выход";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 25);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(44, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 25);
            this.button2.TabIndex = 0;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(85, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 25);
            this.button3.TabIndex = 0;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_authors
            // 
            this.btn_authors.Image = ((System.Drawing.Image)(resources.GetObject("btn_authors.Image")));
            this.btn_authors.Location = new System.Drawing.Point(126, 3);
            this.btn_authors.Name = "btn_authors";
            this.btn_authors.Size = new System.Drawing.Size(36, 25);
            this.btn_authors.TabIndex = 1;
            this.btn_authors.UseVisualStyleBackColor = true;
            this.btn_authors.Click += new System.EventHandler(this.btn_authors_Click);
            // 
            // btn_genres
            // 
            this.btn_genres.Image = ((System.Drawing.Image)(resources.GetObject("btn_genres.Image")));
            this.btn_genres.Location = new System.Drawing.Point(168, 3);
            this.btn_genres.Name = "btn_genres";
            this.btn_genres.Size = new System.Drawing.Size(36, 25);
            this.btn_genres.TabIndex = 1;
            this.btn_genres.UseVisualStyleBackColor = true;
            this.btn_genres.Click += new System.EventHandler(this.btn_genres_Click);
            // 
            // btn_Journal
            // 
            this.btn_Journal.Image = ((System.Drawing.Image)(resources.GetObject("btn_Journal.Image")));
            this.btn_Journal.Location = new System.Drawing.Point(210, 3);
            this.btn_Journal.Name = "btn_Journal";
            this.btn_Journal.Size = new System.Drawing.Size(36, 25);
            this.btn_Journal.TabIndex = 1;
            this.btn_Journal.UseVisualStyleBackColor = true;
            this.btn_Journal.Click += new System.EventHandler(this.btn_Journal_Click);
            // 
            // btn_handBook
            // 
            this.btn_handBook.Image = ((System.Drawing.Image)(resources.GetObject("btn_handBook.Image")));
            this.btn_handBook.Location = new System.Drawing.Point(252, 3);
            this.btn_handBook.Name = "btn_handBook";
            this.btn_handBook.Size = new System.Drawing.Size(36, 25);
            this.btn_handBook.TabIndex = 1;
            this.btn_handBook.UseVisualStyleBackColor = true;
            this.btn_handBook.Click += new System.EventHandler(this.btn_handBook_Click);
            // 
            // btn_order
            // 
            this.btn_order.Image = ((System.Drawing.Image)(resources.GetObject("btn_order.Image")));
            this.btn_order.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_order.Location = new System.Drawing.Point(3, 3);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(148, 25);
            this.btn_order.TabIndex = 0;
            this.btn_order.Text = "Заказать книгу";
            this.btn_order.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_order.UseVisualStyleBackColor = true;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.titleDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.titleDataGridViewTextBoxColumn.FillWeight = 431.4721F;
            this.titleDataGridViewTextBoxColumn.HeaderText = "Название";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 170;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.Width = 170;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(LibraryApp.Models.Book);
            // 
            // BooksUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gb_dgv);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.panel_admin);
            this.Controls.Add(this.panel_user);
            this.Controls.Add(this.pnael_search);
            this.Name = "BooksUC";
            this.Size = new System.Drawing.Size(783, 521);
            this.Load += new System.EventHandler(this.BooksUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.pnael_search.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.panel_user.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.gb_dgv.ResumeLayout(false);
            this.panel_admin.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox pnael_search;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.GroupBox panel_user;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.GroupBox gb_dgv;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.GroupBox panel_admin;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_handBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btn_authors;
        private System.Windows.Forms.Button btn_genres;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookedUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnerUser;
        private System.Windows.Forms.Button btn_Journal;
    }
}
