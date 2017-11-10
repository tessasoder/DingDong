namespace project_dingdong
{
    partial class Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_beer = new System.Windows.Forms.Button();
            this.btn_wine = new System.Windows.Forms.Button();
            this.btn_shots = new System.Windows.Forms.Button();
            this.btn_specials = new System.Windows.Forms.Button();
            this.btn_babies = new System.Windows.Forms.Button();
            this.btn_mixed_drinks = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(12, 647);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 71);
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_save.Location = new System.Drawing.Point(795, 669);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(113, 35);
            this.btn_save.TabIndex = 54;
            this.btn_save.Text = "save";
            this.btn_save.UseVisualStyleBackColor = false;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_exit.Location = new System.Drawing.Point(1015, 18);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(54, 48);
            this.btn_exit.TabIndex = 53;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_logout.Location = new System.Drawing.Point(956, 669);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(113, 35);
            this.btn_logout.TabIndex = 52;
            this.btn_logout.Text = "logout";
            this.btn_logout.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(84, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 51;
            this.label1.Text = "Username";
            // 
            // btn_beer
            // 
            this.btn_beer.BackColor = System.Drawing.Color.White;
            this.btn_beer.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_beer.Location = new System.Drawing.Point(113, 102);
            this.btn_beer.Name = "btn_beer";
            this.btn_beer.Size = new System.Drawing.Size(293, 220);
            this.btn_beer.TabIndex = 56;
            this.btn_beer.Text = "Beer";
            this.btn_beer.UseVisualStyleBackColor = false;
            // 
            // btn_wine
            // 
            this.btn_wine.BackColor = System.Drawing.Color.White;
            this.btn_wine.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_wine.Location = new System.Drawing.Point(427, 102);
            this.btn_wine.Name = "btn_wine";
            this.btn_wine.Size = new System.Drawing.Size(293, 220);
            this.btn_wine.TabIndex = 57;
            this.btn_wine.Text = "Wine";
            this.btn_wine.UseVisualStyleBackColor = false;
            // 
            // btn_shots
            // 
            this.btn_shots.BackColor = System.Drawing.Color.White;
            this.btn_shots.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_shots.Location = new System.Drawing.Point(113, 335);
            this.btn_shots.Name = "btn_shots";
            this.btn_shots.Size = new System.Drawing.Size(293, 220);
            this.btn_shots.TabIndex = 58;
            this.btn_shots.Text = "Shots";
            this.btn_shots.UseVisualStyleBackColor = false;
            // 
            // btn_specials
            // 
            this.btn_specials.BackColor = System.Drawing.Color.White;
            this.btn_specials.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_specials.Location = new System.Drawing.Point(427, 335);
            this.btn_specials.Name = "btn_specials";
            this.btn_specials.Size = new System.Drawing.Size(293, 220);
            this.btn_specials.TabIndex = 59;
            this.btn_specials.Text = "Specials";
            this.btn_specials.UseVisualStyleBackColor = false;
            // 
            // btn_babies
            // 
            this.btn_babies.BackColor = System.Drawing.Color.White;
            this.btn_babies.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_babies.Location = new System.Drawing.Point(742, 335);
            this.btn_babies.Name = "btn_babies";
            this.btn_babies.Size = new System.Drawing.Size(293, 220);
            this.btn_babies.TabIndex = 60;
            this.btn_babies.Text = "non-alcoholic";
            this.btn_babies.UseVisualStyleBackColor = false;
            // 
            // btn_mixed_drinks
            // 
            this.btn_mixed_drinks.BackColor = System.Drawing.Color.White;
            this.btn_mixed_drinks.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mixed_drinks.Location = new System.Drawing.Point(742, 102);
            this.btn_mixed_drinks.Name = "btn_mixed_drinks";
            this.btn_mixed_drinks.Size = new System.Drawing.Size(293, 220);
            this.btn_mixed_drinks.TabIndex = 61;
            this.btn_mixed_drinks.Text = "Mixed drinks";
            this.btn_mixed_drinks.UseVisualStyleBackColor = false;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1084, 730);
            this.Controls.Add(this.btn_mixed_drinks);
            this.Controls.Add(this.btn_babies);
            this.Controls.Add(this.btn_specials);
            this.Controls.Add(this.btn_shots);
            this.Controls.Add(this.btn_wine);
            this.Controls.Add(this.btn_beer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Order";
            this.Text = "Order";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_beer;
        private System.Windows.Forms.Button btn_wine;
        private System.Windows.Forms.Button btn_shots;
        private System.Windows.Forms.Button btn_specials;
        private System.Windows.Forms.Button btn_babies;
        private System.Windows.Forms.Button btn_mixed_drinks;
    }
}