namespace project_dingdong
{
    partial class AdminStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminStart));
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_drinks = new System.Windows.Forms.Button();
            this.btn_emp = new System.Windows.Forms.Button();
            this.btn_stock = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_logout.Location = new System.Drawing.Point(1202, 512);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(113, 35);
            this.btn_logout.TabIndex = 0;
            this.btn_logout.Text = "logout";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_drinks
            // 
            this.btn_drinks.BackColor = System.Drawing.Color.White;
            this.btn_drinks.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_drinks.Location = new System.Drawing.Point(109, 203);
            this.btn_drinks.Name = "btn_drinks";
            this.btn_drinks.Size = new System.Drawing.Size(272, 179);
            this.btn_drinks.TabIndex = 1;
            this.btn_drinks.Text = "Drinks";
            this.btn_drinks.UseVisualStyleBackColor = false;
            this.btn_drinks.Click += new System.EventHandler(this.btn_drinks_Click);
            // 
            // btn_emp
            // 
            this.btn_emp.BackColor = System.Drawing.Color.White;
            this.btn_emp.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_emp.Location = new System.Drawing.Point(504, 203);
            this.btn_emp.Name = "btn_emp";
            this.btn_emp.Size = new System.Drawing.Size(272, 179);
            this.btn_emp.TabIndex = 2;
            this.btn_emp.Text = "Employees";
            this.btn_emp.UseVisualStyleBackColor = false;
            this.btn_emp.Click += new System.EventHandler(this.btn_emp_Click);
            // 
            // btn_stock
            // 
            this.btn_stock.BackColor = System.Drawing.Color.White;
            this.btn_stock.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stock.Location = new System.Drawing.Point(906, 203);
            this.btn_stock.Name = "btn_stock";
            this.btn_stock.Size = new System.Drawing.Size(272, 179);
            this.btn_stock.TabIndex = 3;
            this.btn_stock.Text = "Stock";
            this.btn_stock.UseVisualStyleBackColor = false;
            this.btn_stock.Click += new System.EventHandler(this.btn_stock_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(104, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_exit.Location = new System.Drawing.Point(1261, 36);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(54, 48);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 494);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 71);
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // AdminStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1346, 577);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_stock);
            this.Controls.Add(this.btn_emp);
            this.Controls.Add(this.btn_drinks);
            this.Controls.Add(this.btn_logout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminStart";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "AdminStart";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_drinks;
        private System.Windows.Forms.Button btn_emp;
        private System.Windows.Forms.Button btn_stock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}