﻿namespace project_dingdong
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
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_beer = new System.Windows.Forms.Button();
            this.btn_wine = new System.Windows.Forms.Button();
            this.btn_shots = new System.Windows.Forms.Button();
            this.btn_special = new System.Windows.Forms.Button();
            this.btn_non_a = new System.Windows.Forms.Button();
            this.btn_mixed = new System.Windows.Forms.Button();
            this.lbl_ordernum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_save.Location = new System.Drawing.Point(956, 683);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(113, 35);
            this.btn_save.TabIndex = 54;
            this.btn_save.Text = "bill";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
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
            this.btn_beer.Location = new System.Drawing.Point(42, 69);
            this.btn_beer.Name = "btn_beer";
            this.btn_beer.Size = new System.Drawing.Size(217, 48);
            this.btn_beer.TabIndex = 56;
            this.btn_beer.Text = "Beer";
            this.btn_beer.UseVisualStyleBackColor = false;
            this.btn_beer.Click += new System.EventHandler(this.btn_beer_Click);
            // 
            // btn_wine
            // 
            this.btn_wine.BackColor = System.Drawing.Color.White;
            this.btn_wine.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_wine.Location = new System.Drawing.Point(265, 69);
            this.btn_wine.Name = "btn_wine";
            this.btn_wine.Size = new System.Drawing.Size(217, 48);
            this.btn_wine.TabIndex = 57;
            this.btn_wine.Text = "Wine";
            this.btn_wine.UseVisualStyleBackColor = false;
            this.btn_wine.Click += new System.EventHandler(this.btn_wine_Click);
            // 
            // btn_shots
            // 
            this.btn_shots.BackColor = System.Drawing.Color.White;
            this.btn_shots.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_shots.Location = new System.Drawing.Point(42, 123);
            this.btn_shots.Name = "btn_shots";
            this.btn_shots.Size = new System.Drawing.Size(217, 48);
            this.btn_shots.TabIndex = 58;
            this.btn_shots.Text = "Shots";
            this.btn_shots.UseVisualStyleBackColor = false;
            this.btn_shots.Click += new System.EventHandler(this.btn_shots_Click);
            // 
            // btn_special
            // 
            this.btn_special.BackColor = System.Drawing.Color.White;
            this.btn_special.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_special.Location = new System.Drawing.Point(265, 123);
            this.btn_special.Name = "btn_special";
            this.btn_special.Size = new System.Drawing.Size(217, 48);
            this.btn_special.TabIndex = 59;
            this.btn_special.Text = "Specials";
            this.btn_special.UseVisualStyleBackColor = false;
            this.btn_special.Click += new System.EventHandler(this.btn_special_Click);
            // 
            // btn_non_a
            // 
            this.btn_non_a.BackColor = System.Drawing.Color.White;
            this.btn_non_a.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_non_a.Location = new System.Drawing.Point(265, 177);
            this.btn_non_a.Name = "btn_non_a";
            this.btn_non_a.Size = new System.Drawing.Size(217, 48);
            this.btn_non_a.TabIndex = 60;
            this.btn_non_a.Text = "non-alcoholic";
            this.btn_non_a.UseVisualStyleBackColor = false;
            this.btn_non_a.Click += new System.EventHandler(this.btn_non_a_Click);
            // 
            // btn_mixed
            // 
            this.btn_mixed.BackColor = System.Drawing.Color.White;
            this.btn_mixed.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mixed.Location = new System.Drawing.Point(42, 177);
            this.btn_mixed.Name = "btn_mixed";
            this.btn_mixed.Size = new System.Drawing.Size(217, 48);
            this.btn_mixed.TabIndex = 61;
            this.btn_mixed.Text = "Mixed drinks";
            this.btn_mixed.UseVisualStyleBackColor = false;
            this.btn_mixed.Click += new System.EventHandler(this.btn_mixed_Click);
            // 
            // lbl_ordernum
            // 
            this.lbl_ordernum.AutoSize = true;
            this.lbl_ordernum.Location = new System.Drawing.Point(595, 53);
            this.lbl_ordernum.Name = "lbl_ordernum";
            this.lbl_ordernum.Size = new System.Drawing.Size(56, 13);
            this.lbl_ordernum.TabIndex = 62;
            this.lbl_ordernum.Text = "Order No: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(896, 638);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Total:";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(937, 638);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(13, 13);
            this.lbl_total.TabIndex = 64;
            this.lbl_total.Text = "0";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1084, 730);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_ordernum);
            this.Controls.Add(this.btn_mixed);
            this.Controls.Add(this.btn_non_a);
            this.Controls.Add(this.btn_special);
            this.Controls.Add(this.btn_shots);
            this.Controls.Add(this.btn_wine);
            this.Controls.Add(this.btn_beer);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Order";
            this.Text = "-+";
            this.Load += new System.EventHandler(this.Order_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_beer;
        private System.Windows.Forms.Button btn_wine;
        private System.Windows.Forms.Button btn_shots;
        private System.Windows.Forms.Button btn_special;
        private System.Windows.Forms.Button btn_non_a;
        private System.Windows.Forms.Button btn_mixed;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lbl_ordernum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_total;
    }
}