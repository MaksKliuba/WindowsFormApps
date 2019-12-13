namespace ConvertFromTXT
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.buttonConvert = new System.Windows.Forms.PictureBox();
            this.buttonSave = new System.Windows.Forms.PictureBox();
            this.openFileButton = new System.Windows.Forms.PictureBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.buttonConvert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openFileButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(62, 18);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.ReadOnly = true;
            this.textBoxPath.Size = new System.Drawing.Size(363, 22);
            this.textBoxPath.TabIndex = 7;
            // 
            // buttonConvert
            // 
            this.buttonConvert.BackColor = System.Drawing.Color.White;
            this.buttonConvert.Image = global::ConvertFromTXT.Properties.Resources.Royalflushxx_Systematrix_Text;
            this.buttonConvert.Location = new System.Drawing.Point(431, 11);
            this.buttonConvert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(39, 37);
            this.buttonConvert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonConvert.TabIndex = 10;
            this.buttonConvert.TabStop = false;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.White;
            this.buttonSave.Image = global::ConvertFromTXT.Properties.Resources.save;
            this.buttonSave.Location = new System.Drawing.Point(477, 11);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(38, 37);
            this.buttonSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonSave.TabIndex = 9;
            this.buttonSave.TabStop = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // openFileButton
            // 
            this.openFileButton.BackColor = System.Drawing.Color.White;
            this.openFileButton.Image = global::ConvertFromTXT.Properties.Resources.folder_out_archive_open_512;
            this.openFileButton.Location = new System.Drawing.Point(9, 8);
            this.openFileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(48, 40);
            this.openFileButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.openFileButton.TabIndex = 8;
            this.openFileButton.TabStop = false;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Black;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(12, 58);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(504, 390);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 460);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.pictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(544, 507);
            this.MinimumSize = new System.Drawing.Size(544, 507);
            this.Name = "Form1";
            this.Text = "ConvertFromTXT";
            ((System.ComponentModel.ISupportInitialize)(this.buttonConvert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openFileButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.PictureBox buttonConvert;
        private System.Windows.Forms.PictureBox buttonSave;
        private System.Windows.Forms.PictureBox openFileButton;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

