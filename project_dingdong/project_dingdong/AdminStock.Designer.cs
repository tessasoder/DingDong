namespace project_dingdong
{
    partial class AdminStock
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminStock));
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.datagrid_set = new project_dingdong.datagrid_set();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockTableAdapter = new project_dingdong.datagrid_setTableAdapters.StockTableAdapter();
            this.daten_stock = new System.Windows.Forms.DataGridView();
            this.txt_drink = new System.Windows.Forms.TextBox();
            this.txt_centi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdb_new = new System.Windows.Forms.RadioButton();
            this.rdb_edit = new System.Windows.Forms.RadioButton();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.rdb_delete = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_set)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daten_stock)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_exit.Location = new System.Drawing.Point(629, 12);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(54, 48);
            this.btn_exit.TabIndex = 11;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_logout.Location = new System.Drawing.Point(570, 530);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(113, 35);
            this.btn_logout.TabIndex = 10;
            this.btn_logout.Text = "logout";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(72, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Username";
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_update.Location = new System.Drawing.Point(113, 230);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(91, 35);
            this.btn_update.TabIndex = 12;
            this.btn_update.Text = "save";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1, 505);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 71);
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // datagrid_set
            // 
            this.datagrid_set.DataSetName = "datagrid_set";
            this.datagrid_set.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.datagrid_set;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // daten_stock
            // 
            this.daten_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.daten_stock.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.daten_stock.Location = new System.Drawing.Point(352, 66);
            this.daten_stock.Name = "daten_stock";
            this.daten_stock.Size = new System.Drawing.Size(331, 446);
            this.daten_stock.TabIndex = 51;
            // 
            // txt_drink
            // 
            this.txt_drink.Location = new System.Drawing.Point(27, 165);
            this.txt_drink.Name = "txt_drink";
            this.txt_drink.Size = new System.Drawing.Size(177, 20);
            this.txt_drink.TabIndex = 52;
            // 
            // txt_centi
            // 
            this.txt_centi.Location = new System.Drawing.Point(27, 204);
            this.txt_centi.Name = "txt_centi";
            this.txt_centi.Size = new System.Drawing.Size(177, 20);
            this.txt_centi.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Drink";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Centiliter";
            // 
            // rdb_new
            // 
            this.rdb_new.AutoSize = true;
            this.rdb_new.Location = new System.Drawing.Point(49, 79);
            this.rdb_new.Name = "rdb_new";
            this.rdb_new.Size = new System.Drawing.Size(47, 17);
            this.rdb_new.TabIndex = 56;
            this.rdb_new.TabStop = true;
            this.rdb_new.Text = "New";
            this.rdb_new.UseVisualStyleBackColor = true;
            this.rdb_new.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdb_edit
            // 
            this.rdb_edit.AutoSize = true;
            this.rdb_edit.Location = new System.Drawing.Point(127, 79);
            this.rdb_edit.Name = "rdb_edit";
            this.rdb_edit.Size = new System.Drawing.Size(43, 17);
            this.rdb_edit.TabIndex = 57;
            this.rdb_edit.TabStop = true;
            this.rdb_edit.Text = "Edit";
            this.rdb_edit.UseVisualStyleBackColor = true;
            this.rdb_edit.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(27, 110);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(18, 13);
            this.lbl_id.TabIndex = 59;
            this.lbl_id.Text = "ID";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(27, 126);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(177, 20);
            this.txt_id.TabIndex = 58;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(224, 123);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 60;
            this.btn_search.Text = "search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // rdb_delete
            // 
            this.rdb_delete.AutoSize = true;
            this.rdb_delete.Location = new System.Drawing.Point(201, 79);
            this.rdb_delete.Name = "rdb_delete";
            this.rdb_delete.Size = new System.Drawing.Size(56, 17);
            this.rdb_delete.TabIndex = 61;
            this.rdb_delete.TabStop = true;
            this.rdb_delete.Text = "Delete";
            this.rdb_delete.UseVisualStyleBackColor = true;
            this.rdb_delete.CheckedChanged += new System.EventHandler(this.rdb_delete_CheckedChanged);
            // 
            // AdminStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(695, 577);
            this.Controls.Add(this.rdb_delete);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.rdb_edit);
            this.Controls.Add(this.rdb_new);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_centi);
            this.Controls.Add(this.txt_drink);
            this.Controls.Add(this.daten_stock);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminStock";
            this.Text = "AdminStock";
            this.Load += new System.EventHandler(this.AdminStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_set)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daten_stock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.PictureBox pictureBox1;
        private datagrid_set datagrid_set;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private datagrid_setTableAdapters.StockTableAdapter stockTableAdapter;
        private System.Windows.Forms.DataGridView daten_stock;
        private System.Windows.Forms.TextBox txt_drink;
        private System.Windows.Forms.TextBox txt_centi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdb_new;
        private System.Windows.Forms.RadioButton rdb_edit;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.RadioButton rdb_delete;
    }
}