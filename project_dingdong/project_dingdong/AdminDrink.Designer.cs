namespace project_dingdong
{
    partial class AdminDrink
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDrink));
            this.rdb_delete = new System.Windows.Forms.RadioButton();
            this.btn_search = new System.Windows.Forms.Button();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.rdb_edit = new System.Windows.Forms.RadioButton();
            this.rdb_new = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_drink = new System.Windows.Forms.TextBox();
            this.daten_drinks = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_category = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.daten_drinks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rdb_delete
            // 
            this.rdb_delete.AutoSize = true;
            this.rdb_delete.Location = new System.Drawing.Point(195, 53);
            this.rdb_delete.Name = "rdb_delete";
            this.rdb_delete.Size = new System.Drawing.Size(56, 17);
            this.rdb_delete.TabIndex = 77;
            this.rdb_delete.TabStop = true;
            this.rdb_delete.Text = "Delete";
            this.rdb_delete.UseVisualStyleBackColor = true;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_search.Location = new System.Drawing.Point(17, 513);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(91, 35);
            this.btn_search.TabIndex = 76;
            this.btn_search.Text = "search";
            this.btn_search.UseVisualStyleBackColor = false;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(21, 84);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(18, 13);
            this.lbl_id.TabIndex = 75;
            this.lbl_id.Text = "ID";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(21, 100);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(177, 20);
            this.txt_id.TabIndex = 74;
            // 
            // rdb_edit
            // 
            this.rdb_edit.AutoSize = true;
            this.rdb_edit.Location = new System.Drawing.Point(121, 53);
            this.rdb_edit.Name = "rdb_edit";
            this.rdb_edit.Size = new System.Drawing.Size(43, 17);
            this.rdb_edit.TabIndex = 73;
            this.rdb_edit.TabStop = true;
            this.rdb_edit.Text = "Edit";
            this.rdb_edit.UseVisualStyleBackColor = true;
            // 
            // rdb_new
            // 
            this.rdb_new.AutoSize = true;
            this.rdb_new.Location = new System.Drawing.Point(43, 53);
            this.rdb_new.Name = "rdb_new";
            this.rdb_new.Size = new System.Drawing.Size(47, 17);
            this.rdb_new.TabIndex = 72;
            this.rdb_new.TabStop = true;
            this.rdb_new.Text = "New";
            this.rdb_new.UseVisualStyleBackColor = true;
            this.rdb_new.CheckedChanged += new System.EventHandler(this.rdb_new_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "Drink";
            // 
            // txt_drink
            // 
            this.txt_drink.Location = new System.Drawing.Point(21, 139);
            this.txt_drink.Name = "txt_drink";
            this.txt_drink.Size = new System.Drawing.Size(177, 20);
            this.txt_drink.TabIndex = 68;
            // 
            // daten_drinks
            // 
            this.daten_drinks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.daten_drinks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.daten_drinks.Location = new System.Drawing.Point(222, 100);
            this.daten_drinks.Name = "daten_drinks";
            this.daten_drinks.Size = new System.Drawing.Size(445, 479);
            this.daten_drinks.TabIndex = 67;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(-9, 554);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 71);
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_update.Location = new System.Drawing.Point(121, 513);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(91, 35);
            this.btn_update.TabIndex = 65;
            this.btn_update.Text = "save";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_exit.Location = new System.Drawing.Point(613, 22);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(54, 48);
            this.btn_exit.TabIndex = 64;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_logout.Location = new System.Drawing.Point(554, 578);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(113, 35);
            this.btn_logout.TabIndex = 63;
            this.btn_logout.Text = "logout";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 62;
            this.label1.Text = "Username";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "beer",
            "cola",
            "sprite",
            "fanta",
            "sparkling_water",
            "vodka",
            "w_wine",
            "r_wine",
            "mango_j",
            "orange_j",
            "redbull",
            "bacardi",
            "tequila",
            "applesourz",
            "jaegermeister",
            "gin",
            "tonic_water",
            "pineapple_j",
            "cherryl"});
            this.comboBox2.Location = new System.Drawing.Point(21, 269);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 79;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "beer",
            "cola",
            "sprite",
            "fanta",
            "sparkling_water",
            "vodka",
            "w_wine",
            "r_wine",
            "mango_j",
            "orange_j",
            "redbull",
            "bacardi",
            "tequila",
            "applesourz",
            "jaegermeister",
            "gin",
            "tonic_water",
            "pineapple_j",
            "cherryl"});
            this.comboBox3.Location = new System.Drawing.Point(21, 296);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(100, 21);
            this.comboBox3.TabIndex = 80;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "beer",
            "cola",
            "sprite",
            "fanta",
            "sparkling_water",
            "vodka",
            "w_wine",
            "r_wine",
            "mango_j",
            "orange_j",
            "redbull",
            "bacardi",
            "tequila",
            "applesourz",
            "jaegermeister",
            "gin",
            "tonic_water",
            "pineapple_j",
            "cherryl"});
            this.comboBox4.Location = new System.Drawing.Point(21, 323);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(100, 21);
            this.comboBox4.TabIndex = 81;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "beer",
            "cola",
            "sprite",
            "fanta",
            "sparkling_water",
            "vodka",
            "w_wine",
            "r_wine",
            "mango_j",
            "orange_j",
            "redbull",
            "bacardi",
            "tequila",
            "applesourz",
            "jaegermeister",
            "gin",
            "tonic_water",
            "pineapple_j",
            "cherryl"});
            this.comboBox5.Location = new System.Drawing.Point(21, 404);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(100, 21);
            this.comboBox5.TabIndex = 84;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "beer",
            "cola",
            "sprite",
            "fanta",
            "sparkling_water",
            "vodka",
            "w_wine",
            "r_wine",
            "mango_j",
            "orange_j",
            "redbull",
            "bacardi",
            "tequila",
            "applesourz",
            "jaegermeister",
            "gin",
            "tonic_water",
            "pineapple_j",
            "cherryl"});
            this.comboBox6.Location = new System.Drawing.Point(21, 377);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(100, 21);
            this.comboBox6.TabIndex = 83;
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            "beer",
            "cola",
            "sprite",
            "fanta",
            "sparkling_water",
            "vodka",
            "w_wine",
            "r_wine",
            "mango_j",
            "orange_j",
            "redbull",
            "bacardi",
            "tequila",
            "applesourz",
            "jaegermeister",
            "gin",
            "tonic_water",
            "pineapple_j",
            "cherryl"});
            this.comboBox7.Location = new System.Drawing.Point(21, 350);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(100, 21);
            this.comboBox7.TabIndex = 82;
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Items.AddRange(new object[] {
            "beer",
            "cola",
            "sprite",
            "fanta",
            "sparkling_water",
            "vodka",
            "w_wine",
            "r_wine",
            "mango_j",
            "orange_j",
            "redbull",
            "bacardi",
            "tequila",
            "applesourz",
            "jaegermeister",
            "gin",
            "tonic_water",
            "pineapple_j",
            "cherryl"});
            this.comboBox8.Location = new System.Drawing.Point(21, 485);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(100, 21);
            this.comboBox8.TabIndex = 87;
            // 
            // comboBox9
            // 
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Items.AddRange(new object[] {
            "beer",
            "cola",
            "sprite",
            "fanta",
            "sparkling_water",
            "vodka",
            "w_wine",
            "r_wine",
            "mango_j",
            "orange_j",
            "redbull",
            "bacardi",
            "tequila",
            "applesourz",
            "jaegermeister",
            "gin",
            "tonic_water",
            "pineapple_j",
            "cherryl"});
            this.comboBox9.Location = new System.Drawing.Point(21, 458);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(100, 21);
            this.comboBox9.TabIndex = 86;
            // 
            // comboBox10
            // 
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Items.AddRange(new object[] {
            "beer",
            "cola",
            "sprite",
            "fanta",
            "sparkling_water",
            "vodka",
            "w_wine",
            "r_wine",
            "mango_j",
            "orange_j",
            "redbull",
            "bacardi",
            "tequila",
            "applesourz",
            "jaegermeister",
            "gin",
            "tonic_water",
            "pineapple_j",
            "cherryl"});
            this.comboBox10.Location = new System.Drawing.Point(21, 431);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(100, 21);
            this.comboBox10.TabIndex = 85;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 89;
            this.label4.Text = "Category";
            // 
            // txt_category
            // 
            this.txt_category.Location = new System.Drawing.Point(21, 222);
            this.txt_category.Name = "txt_category";
            this.txt_category.Size = new System.Drawing.Size(177, 20);
            this.txt_category.TabIndex = 88;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 90;
            this.label5.Text = "Liquids";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(127, 269);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(71, 20);
            this.textBox2.TabIndex = 91;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(127, 296);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(71, 20);
            this.textBox3.TabIndex = 92;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(127, 323);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(71, 20);
            this.textBox4.TabIndex = 93;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(127, 403);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(71, 20);
            this.textBox5.TabIndex = 96;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(127, 376);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(71, 20);
            this.textBox6.TabIndex = 95;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(127, 349);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(71, 20);
            this.textBox7.TabIndex = 94;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(127, 486);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(71, 20);
            this.textBox8.TabIndex = 99;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(127, 459);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(71, 20);
            this.textBox9.TabIndex = 98;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(127, 432);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(71, 20);
            this.textBox10.TabIndex = 97;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 100;
            this.label6.Text = "Centiliter ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 102;
            this.label3.Text = "Price";
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(21, 178);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(177, 20);
            this.txt_price.TabIndex = 101;
            // 
            // AdminDrink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(679, 625);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_category);
            this.Controls.Add(this.comboBox8);
            this.Controls.Add(this.comboBox9);
            this.Controls.Add(this.comboBox10);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.rdb_delete);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.rdb_edit);
            this.Controls.Add(this.rdb_new);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_drink);
            this.Controls.Add(this.daten_drinks);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDrink";
            this.Text = "AdminDrink";
            this.Load += new System.EventHandler(this.AdminDrink_Load);
            ((System.ComponentModel.ISupportInitialize)(this.daten_drinks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdb_delete;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.RadioButton rdb_edit;
        private System.Windows.Forms.RadioButton rdb_new;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_drink;
        private System.Windows.Forms.DataGridView daten_drinks;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.ComboBox comboBox10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_category;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_price;
    }
}