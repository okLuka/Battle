namespace battle
{
    partial class game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(game));
            this.pc_1 = new System.Windows.Forms.PictureBox();
            this.pc_2 = new System.Windows.Forms.PictureBox();
            this.capitulate = new System.Windows.Forms.Button();
            this.move = new System.Windows.Forms.Button();
            this.move_counter = new System.Windows.Forms.Label();
            this.player_0 = new System.Windows.Forms.Button();
            this.player_1 = new System.Windows.Forms.Button();
            this.player_2 = new System.Windows.Forms.Button();
            this.pc_0 = new System.Windows.Forms.PictureBox();
            this.pc_name = new System.Windows.Forms.Label();
            this.player_name = new System.Windows.Forms.Label();
            this.player_health_0 = new System.Windows.Forms.PictureBox();
            this.player_health_1 = new System.Windows.Forms.PictureBox();
            this.player_health_2 = new System.Windows.Forms.PictureBox();
            this.pc_health_1 = new System.Windows.Forms.PictureBox();
            this.pc_health_2 = new System.Windows.Forms.PictureBox();
            this.pc_health_0 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pc_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_health_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_health_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_health_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_health_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_health_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_health_0)).BeginInit();
            this.SuspendLayout();
            // 
            // pc_1
            // 
            this.pc_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pc_1.BackColor = System.Drawing.Color.Transparent;
            this.pc_1.Image = global::battle.Properties.Resources.invisible_frame;
            this.pc_1.Location = new System.Drawing.Point(560, 50);
            this.pc_1.Name = "pc_1";
            this.pc_1.Size = new System.Drawing.Size(160, 260);
            this.pc_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pc_1.TabIndex = 1;
            this.pc_1.TabStop = false;
            // 
            // pc_2
            // 
            this.pc_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pc_2.BackColor = System.Drawing.Color.Transparent;
            this.pc_2.Image = global::battle.Properties.Resources.invisible_frame;
            this.pc_2.Location = new System.Drawing.Point(764, 50);
            this.pc_2.Name = "pc_2";
            this.pc_2.Size = new System.Drawing.Size(160, 260);
            this.pc_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pc_2.TabIndex = 2;
            this.pc_2.TabStop = false;
            // 
            // capitulate
            // 
            this.capitulate.BackColor = System.Drawing.Color.Transparent;
            this.capitulate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.capitulate.Font = new System.Drawing.Font("Myriad Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.capitulate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.capitulate.Location = new System.Drawing.Point(986, 578);
            this.capitulate.Name = "capitulate";
            this.capitulate.Size = new System.Drawing.Size(150, 60);
            this.capitulate.TabIndex = 7;
            this.capitulate.Text = "Сдаться";
            this.capitulate.UseVisualStyleBackColor = false;
            this.capitulate.Click += new System.EventHandler(this.capitulate_Click);
            // 
            // move
            // 
            this.move.BackColor = System.Drawing.Color.Transparent;
            this.move.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.move.Font = new System.Drawing.Font("Myriad Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.move.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.move.Location = new System.Drawing.Point(986, 428);
            this.move.Name = "move";
            this.move.Size = new System.Drawing.Size(150, 60);
            this.move.TabIndex = 8;
            this.move.Text = "Сделать ход";
            this.move.UseVisualStyleBackColor = false;
            this.move.Click += new System.EventHandler(this.move_Click);
            // 
            // move_counter
            // 
            this.move_counter.AutoSize = true;
            this.move_counter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.move_counter.Font = new System.Drawing.Font("Myriad Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.move_counter.ForeColor = System.Drawing.Color.Black;
            this.move_counter.Location = new System.Drawing.Point(977, 85);
            this.move_counter.Name = "move_counter";
            this.move_counter.Size = new System.Drawing.Size(163, 50);
            this.move_counter.TabIndex = 9;
            this.move_counter.Text = "Осталось ходов: \r\n10";
            this.move_counter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player_0
            // 
            this.player_0.BackColor = System.Drawing.Color.Transparent;
            this.player_0.BackgroundImage = global::battle.Properties.Resources.swordsman;
            this.player_0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.player_0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.player_0.Location = new System.Drawing.Point(338, 404);
            this.player_0.Name = "player_0";
            this.player_0.Size = new System.Drawing.Size(172, 273);
            this.player_0.TabIndex = 10;
            this.player_0.UseVisualStyleBackColor = false;
            this.player_0.Click += new System.EventHandler(this.player_0_Click);
            // 
            // player_1
            // 
            this.player_1.BackColor = System.Drawing.Color.Transparent;
            this.player_1.BackgroundImage = global::battle.Properties.Resources.swordsman;
            this.player_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.player_1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.player_1.Location = new System.Drawing.Point(554, 404);
            this.player_1.Name = "player_1";
            this.player_1.Size = new System.Drawing.Size(172, 273);
            this.player_1.TabIndex = 11;
            this.player_1.UseVisualStyleBackColor = false;
            this.player_1.Click += new System.EventHandler(this.player_1_Click);
            // 
            // player_2
            // 
            this.player_2.BackColor = System.Drawing.Color.Transparent;
            this.player_2.BackgroundImage = global::battle.Properties.Resources.swordsman;
            this.player_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.player_2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.player_2.Location = new System.Drawing.Point(770, 404);
            this.player_2.Name = "player_2";
            this.player_2.Size = new System.Drawing.Size(172, 273);
            this.player_2.TabIndex = 12;
            this.player_2.UseVisualStyleBackColor = false;
            this.player_2.Click += new System.EventHandler(this.player_2_Click);
            // 
            // pc_0
            // 
            this.pc_0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pc_0.BackColor = System.Drawing.Color.Transparent;
            this.pc_0.Image = global::battle.Properties.Resources.invisible_frame;
            this.pc_0.Location = new System.Drawing.Point(356, 50);
            this.pc_0.Name = "pc_0";
            this.pc_0.Size = new System.Drawing.Size(160, 260);
            this.pc_0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pc_0.TabIndex = 13;
            this.pc_0.TabStop = false;
            // 
            // pc_name
            // 
            this.pc_name.AutoSize = true;
            this.pc_name.BackColor = System.Drawing.Color.Transparent;
            this.pc_name.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pc_name.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pc_name.Location = new System.Drawing.Point(151, 158);
            this.pc_name.Name = "pc_name";
            this.pc_name.Size = new System.Drawing.Size(103, 23);
            this.pc_name.TabIndex = 14;
            this.pc_name.Text = "Компьютер";
            // 
            // player_name
            // 
            this.player_name.AutoSize = true;
            this.player_name.BackColor = System.Drawing.Color.Transparent;
            this.player_name.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.player_name.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.player_name.Location = new System.Drawing.Point(151, 527);
            this.player_name.Name = "player_name";
            this.player_name.Size = new System.Drawing.Size(58, 23);
            this.player_name.TabIndex = 15;
            this.player_name.Text = "label2";
            // 
            // player_health_0
            // 
            this.player_health_0.BackColor = System.Drawing.Color.Transparent;
            this.player_health_0.Image = global::battle.Properties.Resources.health_8;
            this.player_health_0.Location = new System.Drawing.Point(372, 374);
            this.player_health_0.Name = "player_health_0";
            this.player_health_0.Size = new System.Drawing.Size(104, 17);
            this.player_health_0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player_health_0.TabIndex = 16;
            this.player_health_0.TabStop = false;
            // 
            // player_health_1
            // 
            this.player_health_1.BackColor = System.Drawing.Color.Transparent;
            this.player_health_1.Image = global::battle.Properties.Resources.health_8;
            this.player_health_1.Location = new System.Drawing.Point(588, 374);
            this.player_health_1.Name = "player_health_1";
            this.player_health_1.Size = new System.Drawing.Size(104, 17);
            this.player_health_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player_health_1.TabIndex = 17;
            this.player_health_1.TabStop = false;
            // 
            // player_health_2
            // 
            this.player_health_2.BackColor = System.Drawing.Color.Transparent;
            this.player_health_2.Image = global::battle.Properties.Resources.health_8;
            this.player_health_2.Location = new System.Drawing.Point(804, 374);
            this.player_health_2.Name = "player_health_2";
            this.player_health_2.Size = new System.Drawing.Size(104, 17);
            this.player_health_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player_health_2.TabIndex = 18;
            this.player_health_2.TabStop = false;
            // 
            // pc_health_1
            // 
            this.pc_health_1.BackColor = System.Drawing.Color.Transparent;
            this.pc_health_1.Image = global::battle.Properties.Resources.health_8;
            this.pc_health_1.Location = new System.Drawing.Point(588, 20);
            this.pc_health_1.Name = "pc_health_1";
            this.pc_health_1.Size = new System.Drawing.Size(104, 17);
            this.pc_health_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pc_health_1.TabIndex = 19;
            this.pc_health_1.TabStop = false;
            // 
            // pc_health_2
            // 
            this.pc_health_2.BackColor = System.Drawing.Color.Transparent;
            this.pc_health_2.Image = global::battle.Properties.Resources.health_8;
            this.pc_health_2.Location = new System.Drawing.Point(792, 20);
            this.pc_health_2.Name = "pc_health_2";
            this.pc_health_2.Size = new System.Drawing.Size(104, 17);
            this.pc_health_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pc_health_2.TabIndex = 20;
            this.pc_health_2.TabStop = false;
            // 
            // pc_health_0
            // 
            this.pc_health_0.BackColor = System.Drawing.Color.Transparent;
            this.pc_health_0.Image = global::battle.Properties.Resources.health_8;
            this.pc_health_0.Location = new System.Drawing.Point(384, 20);
            this.pc_health_0.Name = "pc_health_0";
            this.pc_health_0.Size = new System.Drawing.Size(104, 17);
            this.pc_health_0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pc_health_0.TabIndex = 21;
            this.pc_health_0.TabStop = false;
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = global::battle.Properties.Resources.game;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pc_health_0);
            this.Controls.Add(this.pc_health_2);
            this.Controls.Add(this.pc_health_1);
            this.Controls.Add(this.player_health_2);
            this.Controls.Add(this.player_health_1);
            this.Controls.Add(this.player_health_0);
            this.Controls.Add(this.player_name);
            this.Controls.Add(this.pc_name);
            this.Controls.Add(this.pc_0);
            this.Controls.Add(this.player_2);
            this.Controls.Add(this.player_1);
            this.Controls.Add(this.player_0);
            this.Controls.Add(this.move_counter);
            this.Controls.Add(this.move);
            this.Controls.Add(this.capitulate);
            this.Controls.Add(this.pc_2);
            this.Controls.Add(this.pc_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The battle";
            ((System.ComponentModel.ISupportInitialize)(this.pc_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_health_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_health_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_health_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_health_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_health_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_health_0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pc_1;
        private System.Windows.Forms.PictureBox pc_2;
        private System.Windows.Forms.Button capitulate;
        private System.Windows.Forms.Button move;
        private System.Windows.Forms.Label move_counter;
        private System.Windows.Forms.Button player_0;
        private System.Windows.Forms.Button player_1;
        private System.Windows.Forms.Button player_2;
        private System.Windows.Forms.PictureBox pc_0;
        private System.Windows.Forms.Label pc_name;
        private System.Windows.Forms.Label player_name;
        private System.Windows.Forms.PictureBox player_health_0;
        private System.Windows.Forms.PictureBox player_health_1;
        private System.Windows.Forms.PictureBox player_health_2;
        private System.Windows.Forms.PictureBox pc_health_1;
        private System.Windows.Forms.PictureBox pc_health_2;
        private System.Windows.Forms.PictureBox pc_health_0;
    }
}