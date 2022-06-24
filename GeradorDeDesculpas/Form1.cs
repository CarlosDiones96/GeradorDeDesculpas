using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GeradorDeDesculpas
{
    public partial class ExcuseManagerForm : Form
    {
        private Excuse currentExcuse = new Excuse();
        private string selectedFolder = string.Empty;
        private bool formChanged = false;
        Random random = new Random();

        public ExcuseManagerForm()
        {
            InitializeComponent();
            currentExcuse.LastUsed = lastUsedDatePicker.Value; // test code
        }

        private void UpdateForm(bool changed)
        {
            if (!changed)
            {
                this.descriptionTxtBox.Text = currentExcuse.Description;
                this.resultsTxtBox.Text = currentExcuse.Results;
                this.lastUsedDatePicker.Value = currentExcuse.LastUsed; // Error here
                if(!String.IsNullOrEmpty(currentExcuse.ExcusePath))
                {
                    fileDateLabel.Text = File.GetLastWriteTime(currentExcuse.ExcusePath).ToString();
                }
                this.Text = "Gerenciador de Desculpas";
            }
            else
            {
                this.Text = "Gerenciador de Desculpas*";
            }
            this.formChanged = changed;
        }

        private bool CheckChanged()
        {
            if (formChanged)
            {
                DialogResult result = MessageBox.Show(
                    "A desculpa atual ainda não foi salva. Deseja continuar?",
                    "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return false;
                }
            }
            return true;
        }

        private void folderBtn_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = selectedFolder;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                selectedFolder = folderBrowserDialog1.SelectedPath;
                saveBtn.Enabled = true;
                openBtn.Enabled = true;
                randomBtn.Enabled = true;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(descriptionTxtBox.Text) || 
                String.IsNullOrEmpty(resultsTxtBox.Text))
            {
                MessageBox.Show("Por favor especifique uma desculpa e um resultado",
                    "Não foi possível salvar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            saveFileDialog1.InitialDirectory = selectedFolder;
            saveFileDialog1.Filter = "Arquivos de Desculpa (*.excuse)|*.excuse|Todos os arquivos (*.*)|*.*";
            saveFileDialog1.FileName = descriptionTxtBox.Text + ".excuse";
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                currentExcuse.Save(saveFileDialog1.FileName);
                UpdateForm(false);
                MessageBox.Show("Desculpa registrada");
            }
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            if (CheckChanged())
            {
                openFileDialog1.InitialDirectory = selectedFolder;
                openFileDialog1.Filter = "Arquivos de Desculpa (*.excuse)|*.excuse|Todos os arquivos (*.*)|*.*";
                openFileDialog1.FileName = descriptionTxtBox.Text + ".excuse";
                DialogResult result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    bool clearForm = false;
                    try
                    {
                        currentExcuse = new Excuse(openFileDialog1.FileName);
                        try
                        {
                            UpdateForm(false);
                        }
                        catch
                        {
                            MessageBox.Show("O arquivo '" + openFileDialog1.FileName + "'não é válido",
                                "Não é possível abrir a desculpa");
                            clearForm = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro enquanto o arquivo estava sendo carregado", "Deu um erro",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
                        clearForm = true;
                    }
                    finally
                    {
                        if (clearForm)
                        {
                            descriptionTxtBox.Text = string.Empty;
                            resultsTxtBox.Text = string.Empty;
                            lastUsedDatePicker.Value = DateTime.Now;
                        }
                    }
                }
            }
        }

        private void randomBtn_Click(object sender, EventArgs e)
        {
            if (CheckChanged())
            {
                currentExcuse = new Excuse(random, selectedFolder);
                UpdateForm(false);
            }
        }

        private void descriptionTxtBox_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Description = descriptionTxtBox.Text;
            UpdateForm(true);
        }

        private void resultsTxtBox_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Results = resultsTxtBox.Text;
            UpdateForm(true);
        }

        private void lastUsedDatePicker_ValueChanged(object sender, EventArgs e)
        {
            currentExcuse.LastUsed = lastUsedDatePicker.Value;
            UpdateForm(true);
        }
    }
}
