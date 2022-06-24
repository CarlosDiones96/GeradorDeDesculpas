namespace GeradorDeDesculpas
{
    partial class ExcuseManagerForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.descriptionTxtBox = new System.Windows.Forms.TextBox();
            this.lastUsedDatePicker = new System.Windows.Forms.DateTimePicker();
            this.fileDateLabel = new System.Windows.Forms.Label();
            this.resultsTxtBox = new System.Windows.Forms.TextBox();
            this.folderBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.openBtn = new System.Windows.Forms.Button();
            this.randomBtn = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desculpa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Resultado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Último uso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Data do arquivo";
            // 
            // descriptionTxtBox
            // 
            this.descriptionTxtBox.Location = new System.Drawing.Point(124, 29);
            this.descriptionTxtBox.Name = "descriptionTxtBox";
            this.descriptionTxtBox.Size = new System.Drawing.Size(259, 20);
            this.descriptionTxtBox.TabIndex = 1;
            this.descriptionTxtBox.TextChanged += new System.EventHandler(this.descriptionTxtBox_TextChanged);
            // 
            // lastUsedDatePicker
            // 
            this.lastUsedDatePicker.Location = new System.Drawing.Point(124, 90);
            this.lastUsedDatePicker.Name = "lastUsedDatePicker";
            this.lastUsedDatePicker.Size = new System.Drawing.Size(259, 20);
            this.lastUsedDatePicker.TabIndex = 2;
            this.lastUsedDatePicker.ValueChanged += new System.EventHandler(this.lastUsedDatePicker_ValueChanged);
            // 
            // fileDateLabel
            // 
            this.fileDateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fileDateLabel.Location = new System.Drawing.Point(124, 127);
            this.fileDateLabel.Name = "fileDateLabel";
            this.fileDateLabel.Size = new System.Drawing.Size(259, 23);
            this.fileDateLabel.TabIndex = 3;
            this.fileDateLabel.Text = " ";
            // 
            // resultsTxtBox
            // 
            this.resultsTxtBox.Location = new System.Drawing.Point(124, 54);
            this.resultsTxtBox.Name = "resultsTxtBox";
            this.resultsTxtBox.Size = new System.Drawing.Size(259, 20);
            this.resultsTxtBox.TabIndex = 1;
            this.resultsTxtBox.TextChanged += new System.EventHandler(this.resultsTxtBox_TextChanged);
            // 
            // folderBtn
            // 
            this.folderBtn.Location = new System.Drawing.Point(15, 196);
            this.folderBtn.Name = "folderBtn";
            this.folderBtn.Size = new System.Drawing.Size(75, 23);
            this.folderBtn.TabIndex = 4;
            this.folderBtn.Text = "Pasta";
            this.folderBtn.UseVisualStyleBackColor = true;
            this.folderBtn.Click += new System.EventHandler(this.folderBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Enabled = false;
            this.saveBtn.Location = new System.Drawing.Point(96, 196);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Salvar";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // openBtn
            // 
            this.openBtn.Enabled = false;
            this.openBtn.Location = new System.Drawing.Point(177, 196);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(75, 23);
            this.openBtn.TabIndex = 4;
            this.openBtn.Text = "Abrir";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // randomBtn
            // 
            this.randomBtn.Enabled = false;
            this.randomBtn.Location = new System.Drawing.Point(258, 196);
            this.randomBtn.Name = "randomBtn";
            this.randomBtn.Size = new System.Drawing.Size(75, 23);
            this.randomBtn.TabIndex = 4;
            this.randomBtn.Text = "Aleatório";
            this.randomBtn.UseVisualStyleBackColor = true;
            this.randomBtn.Click += new System.EventHandler(this.randomBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ExcuseManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 244);
            this.Controls.Add(this.randomBtn);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.folderBtn);
            this.Controls.Add(this.fileDateLabel);
            this.Controls.Add(this.lastUsedDatePicker);
            this.Controls.Add(this.resultsTxtBox);
            this.Controls.Add(this.descriptionTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ExcuseManagerForm";
            this.Text = "Gerador de Desculpas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox descriptionTxtBox;
        private System.Windows.Forms.DateTimePicker lastUsedDatePicker;
        private System.Windows.Forms.Label fileDateLabel;
        private System.Windows.Forms.TextBox resultsTxtBox;
        private System.Windows.Forms.Button folderBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.Button randomBtn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

