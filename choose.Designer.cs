using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace battle
{
    partial class choose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(choose));
            this.swordsman = new System.Windows.Forms.Button();
            this.armored = new System.Windows.Forms.Button();
            this.magician = new System.Windows.Forms.Button();
            this.archer = new System.Windows.Forms.Button();
            this.invisible = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.random_heroes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // swordsman
            // 
            this.swordsman.BackColor = System.Drawing.Color.Transparent;
            this.swordsman.BackgroundImage = global::battle.Properties.Resources.swordsman;
            this.swordsman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.swordsman.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.swordsman.Location = new System.Drawing.Point(122, 217);
            this.swordsman.Name = "swordsman";
            this.swordsman.Size = new System.Drawing.Size(172, 273);
            this.swordsman.TabIndex = 0;
            this.swordsman.UseVisualStyleBackColor = false;
            this.swordsman.Click += new System.EventHandler(this.swordsman_Click);
            // 
            // armored
            // 
            this.armored.BackColor = System.Drawing.Color.Transparent;
            this.armored.BackgroundImage = global::battle.Properties.Resources.armored;
            this.armored.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.armored.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.armored.Location = new System.Drawing.Point(338, 217);
            this.armored.Name = "armored";
            this.armored.Size = new System.Drawing.Size(172, 273);
            this.armored.TabIndex = 1;
            this.armored.UseVisualStyleBackColor = false;
            this.armored.Click += new System.EventHandler(this.armored_Click);
            // 
            // magician
            // 
            this.magician.BackColor = System.Drawing.Color.Transparent;
            this.magician.BackgroundImage = global::battle.Properties.Resources.magician;
            this.magician.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.magician.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.magician.Location = new System.Drawing.Point(554, 217);
            this.magician.Name = "magician";
            this.magician.Size = new System.Drawing.Size(172, 273);
            this.magician.TabIndex = 2;
            this.magician.UseVisualStyleBackColor = false;
            this.magician.Click += new System.EventHandler(this.magician_Click);
            // 
            // archer
            // 
            this.archer.BackColor = System.Drawing.Color.Transparent;
            this.archer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("archer.BackgroundImage")));
            this.archer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.archer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.archer.Location = new System.Drawing.Point(770, 217);
            this.archer.Name = "archer";
            this.archer.Size = new System.Drawing.Size(172, 273);
            this.archer.TabIndex = 3;
            this.archer.UseVisualStyleBackColor = false;
            this.archer.Click += new System.EventHandler(this.archer_Click);
            // 
            // invisible
            // 
            this.invisible.BackColor = System.Drawing.Color.Transparent;
            this.invisible.BackgroundImage = global::battle.Properties.Resources.invisible;
            this.invisible.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.invisible.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.invisible.Location = new System.Drawing.Point(986, 217);
            this.invisible.Name = "invisible";
            this.invisible.Size = new System.Drawing.Size(172, 273);
            this.invisible.TabIndex = 4;
            this.invisible.UseVisualStyleBackColor = false;
            this.invisible.Click += new System.EventHandler(this.invisible_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.Font = new System.Drawing.Font("Myriad Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.back.Location = new System.Drawing.Point(235, 579);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(250, 60);
            this.back.TabIndex = 6;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.Transparent;
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.start.Font = new System.Drawing.Font("Myriad Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.start.Location = new System.Drawing.Point(795, 579);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(250, 60);
            this.start.TabIndex = 7;
            this.start.Text = "Начать";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // random_heroes
            // 
            this.random_heroes.BackColor = System.Drawing.Color.Transparent;
            this.random_heroes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.random_heroes.Font = new System.Drawing.Font("Myriad Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.random_heroes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.random_heroes.Location = new System.Drawing.Point(515, 579);
            this.random_heroes.Name = "random_heroes";
            this.random_heroes.Size = new System.Drawing.Size(250, 60);
            this.random_heroes.TabIndex = 8;
            this.random_heroes.Text = "Случайные герои";
            this.random_heroes.UseVisualStyleBackColor = false;
            this.random_heroes.Click += new System.EventHandler(this.random_heroes_Click);
            // 
            // choose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::battle.Properties.Resources.choose;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.random_heroes);
            this.Controls.Add(this.start);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.invisible);
            this.Controls.Add(this.archer);
            this.Controls.Add(this.magician);
            this.Controls.Add(this.armored);
            this.Controls.Add(this.swordsman);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "choose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "The battle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button swordsman;
        private System.Windows.Forms.Button armored;
        private System.Windows.Forms.Button magician;
        private System.Windows.Forms.Button archer;
        private System.Windows.Forms.Button invisible;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button random_heroes;


        
    }
}