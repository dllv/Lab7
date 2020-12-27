namespace AppConfig
{
    partial class MainForm
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBorderStyle = new System.Windows.Forms.ComboBox();
            this.chbMinimized = new System.Windows.Forms.CheckBox();
            this.chbMaximized = new System.Windows.Forms.CheckBox();
            this.lblBackColor = new System.Windows.Forms.Label();
            this.btnChangeColor = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Стиль рамки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Стиль строки заголовка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Цвет фона";
            // 
            // cmbBorderStyle
            // 
            this.cmbBorderStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBorderStyle.FormattingEnabled = true;
            this.cmbBorderStyle.Items.AddRange(new object[] {
            "рамка отсутствует",
            "фиксированная однострочная граница",
            "фиксированная трехмерная граница",
            "в стиле диалоговых окон",
            "изменяемая граница",
            "не изменяемая граница окна настроек",
            "изменяемая граница окна настроек"});
            this.cmbBorderStyle.Location = new System.Drawing.Point(165, 12);
            this.cmbBorderStyle.Name = "cmbBorderStyle";
            this.cmbBorderStyle.Size = new System.Drawing.Size(210, 21);
            this.cmbBorderStyle.TabIndex = 3;
            this.cmbBorderStyle.SelectedIndexChanged += new System.EventHandler(this.cmbBorderStyle_SelectedIndexChanged);
            // 
            // chbMinimized
            // 
            this.chbMinimized.AutoSize = true;
            this.chbMinimized.Location = new System.Drawing.Point(165, 44);
            this.chbMinimized.Name = "chbMinimized";
            this.chbMinimized.Size = new System.Drawing.Size(73, 17);
            this.chbMinimized.TabIndex = 4;
            this.chbMinimized.Text = "Свернуть";
            this.chbMinimized.UseVisualStyleBackColor = true;
            this.chbMinimized.CheckedChanged += new System.EventHandler(this.chbMinimized_CheckedChanged);
            // 
            // chbMaximized
            // 
            this.chbMaximized.AutoSize = true;
            this.chbMaximized.Location = new System.Drawing.Point(165, 74);
            this.chbMaximized.Name = "chbMaximized";
            this.chbMaximized.Size = new System.Drawing.Size(97, 17);
            this.chbMaximized.TabIndex = 5;
            this.chbMaximized.Text = "Восстановить";
            this.chbMaximized.UseVisualStyleBackColor = true;
            this.chbMaximized.CheckedChanged += new System.EventHandler(this.chbMaximized_CheckedChanged);
            // 
            // lblBackColor
            // 
            this.lblBackColor.AutoSize = true;
            this.lblBackColor.Location = new System.Drawing.Point(162, 103);
            this.lblBackColor.Name = "lblBackColor";
            this.lblBackColor.Size = new System.Drawing.Size(66, 13);
            this.lblBackColor.TabIndex = 6;
            this.lblBackColor.Text = "lblBackColor";
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AppConfig.Properties.Settings.Default, "Font", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnChangeColor.Font = global::AppConfig.Properties.Settings.Default.Font;
            this.btnChangeColor.Location = new System.Drawing.Point(274, 121);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(75, 23);
            this.btnChangeColor.TabIndex = 7;
            this.btnChangeColor.Text = "Изменить";
            this.btnChangeColor.UseVisualStyleBackColor = true;
            this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(274, 170);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(15, 170);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(75, 23);
            this.btnFont.TabIndex = 9;
            this.btnFont.Text = "Font";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::AppConfig.Properties.Settings.Default.BackColor;
            this.ClientSize = new System.Drawing.Size(387, 205);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnChangeColor);
            this.Controls.Add(this.lblBackColor);
            this.Controls.Add(this.chbMaximized);
            this.Controls.Add(this.chbMinimized);
            this.Controls.Add(this.cmbBorderStyle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("FormBorderStyle", global::AppConfig.Properties.Settings.Default, "BorderStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AppConfig.Properties.Settings.Default, "BackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("MinimizeBox", global::AppConfig.Properties.Settings.Default, "Minimize", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("MaximizeBox", global::AppConfig.Properties.Settings.Default, "Maximize", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = global::AppConfig.Properties.Settings.Default.BorderStyle;
            this.MaximizeBox = global::AppConfig.Properties.Settings.Default.Maximize;
            this.MinimizeBox = global::AppConfig.Properties.Settings.Default.Minimize;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBorderStyle;
        private System.Windows.Forms.CheckBox chbMinimized;
        private System.Windows.Forms.CheckBox chbMaximized;
        private System.Windows.Forms.Label lblBackColor;
        private System.Windows.Forms.Button btnChangeColor;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

