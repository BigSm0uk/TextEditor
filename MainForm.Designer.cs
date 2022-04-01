
namespace TextEditor
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
            this.label1 = new System.Windows.Forms.Label();
            this.PathBox = new System.Windows.Forms.TextBox();
            this.ButSelectFile = new System.Windows.Forms.Button();
            this.ButOpenFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numFont = new System.Windows.Forms.NumericUpDown();
            this.TextBoxContent = new System.Windows.Forms.TextBox();
            this.SaveBut = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.SymbolCountBox = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numFont)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите файл";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PathBox
            // 
            this.PathBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PathBox.Location = new System.Drawing.Point(105, 13);
            this.PathBox.Name = "PathBox";
            this.PathBox.Size = new System.Drawing.Size(534, 20);
            this.PathBox.TabIndex = 1;
            // 
            // ButSelectFile
            // 
            this.ButSelectFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButSelectFile.Location = new System.Drawing.Point(645, 13);
            this.ButSelectFile.Name = "ButSelectFile";
            this.ButSelectFile.Size = new System.Drawing.Size(75, 23);
            this.ButSelectFile.TabIndex = 2;
            this.ButSelectFile.Text = "Выбрать";
            this.ButSelectFile.UseVisualStyleBackColor = true;
            // 
            // ButOpenFile
            // 
            this.ButOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButOpenFile.Location = new System.Drawing.Point(726, 13);
            this.ButOpenFile.Name = "ButOpenFile";
            this.ButOpenFile.Size = new System.Drawing.Size(75, 23);
            this.ButOpenFile.TabIndex = 3;
            this.ButOpenFile.Text = "Открыть";
            this.ButOpenFile.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Шрифт";
            // 
            // numFont
            // 
            this.numFont.Location = new System.Drawing.Point(19, 65);
            this.numFont.Maximum = new decimal(new int[] {
            72,
            0,
            0,
            0});
            this.numFont.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numFont.Name = "numFont";
            this.numFont.Size = new System.Drawing.Size(120, 20);
            this.numFont.TabIndex = 5;
            this.numFont.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            // 
            // TextBoxContent
            // 
            this.TextBoxContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxContent.Location = new System.Drawing.Point(19, 91);
            this.TextBoxContent.Multiline = true;
            this.TextBoxContent.Name = "TextBoxContent";
            this.TextBoxContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBoxContent.Size = new System.Drawing.Size(782, 387);
            this.TextBoxContent.TabIndex = 6;
            // 
            // SaveBut
            // 
            this.SaveBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveBut.Location = new System.Drawing.Point(726, 499);
            this.SaveBut.Name = "SaveBut";
            this.SaveBut.Size = new System.Drawing.Size(75, 23);
            this.SaveBut.TabIndex = 7;
            this.SaveBut.Text = "Сохранить";
            this.SaveBut.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SymbolCountBox});
            this.statusStrip1.Location = new System.Drawing.Point(0, 580);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(826, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // SymbolCountBox
            // 
            this.SymbolCountBox.Name = "SymbolCountBox";
            this.SymbolCountBox.Size = new System.Drawing.Size(110, 17);
            this.SymbolCountBox.Text = "Кол-во символов: ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 602);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.SaveBut);
            this.Controls.Add(this.TextBoxContent);
            this.Controls.Add(this.numFont);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButOpenFile);
            this.Controls.Add(this.ButSelectFile);
            this.Controls.Add(this.PathBox);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1500, 900);
            this.MinimumSize = new System.Drawing.Size(350, 290);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FileEditor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numFont)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PathBox;
        private System.Windows.Forms.Button ButSelectFile;
        private System.Windows.Forms.Button ButOpenFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numFont;
        private System.Windows.Forms.TextBox TextBoxContent;
        private System.Windows.Forms.Button SaveBut;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel SymbolCountBox;
    }
}

