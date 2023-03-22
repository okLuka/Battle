namespace battle
{
    partial class battle
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(battle));
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.start_menu = new System.Windows.Forms.Button();
            this.results = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.name.Font = new System.Drawing.Font("Myriad Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(490, 207);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(300, 33);
            this.name.TabIndex = 0;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Myriad Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(283, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Укажите ваше имя:";
            // 
            // start_menu
            // 
            this.start_menu.BackColor = System.Drawing.Color.Transparent;
            this.start_menu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.start_menu.Font = new System.Drawing.Font("Myriad Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start_menu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.start_menu.Location = new System.Drawing.Point(515, 420);
            this.start_menu.Name = "start_menu";
            this.start_menu.Size = new System.Drawing.Size(250, 60);
            this.start_menu.TabIndex = 2;
            this.start_menu.Text = "Начать";
            this.start_menu.UseVisualStyleBackColor = false;
            this.start_menu.Click += new System.EventHandler(this.start_Click);
            // 
            // results
            // 
            this.results.BackColor = System.Drawing.Color.Transparent;
            this.results.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.results.Font = new System.Drawing.Font("Myriad Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.results.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.results.Location = new System.Drawing.Point(515, 500);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(250, 60);
            this.results.TabIndex = 3;
            this.results.Text = "Последние результаты";
            this.results.UseVisualStyleBackColor = false;
            this.results.Click += new System.EventHandler(this.results_Click);
            // 
            // battle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::battle.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.results);
            this.Controls.Add(this.start_menu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "battle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The battle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button start_menu;
        private System.Windows.Forms.Button results;
    }
}

