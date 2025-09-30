using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PIM
{
    public partial class Form1 : Form
    {
        private List<string> tarefas = new List<string>();

        public Form1()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.None;
            this.Size = new Size(700, 600);
            this.MinimumSize = new Size(700, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            listBoxTarefas.Items.Clear();
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            string novaTarefa = textBoxTarefa.Text.Trim();

            if (!string.IsNullOrEmpty(novaTarefa))
            {
                tarefas.Add(novaTarefa);

                AtualizarListBox();

                textBoxTarefa.Clear();

                MessageBox.Show("Tarefa adicionada! (Só fica na memória enquanto o app roda.)", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Digite algo válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            tarefas.Clear();
            AtualizarListBox();
            MessageBox.Show("Lista limpa! Dados perdidos para sempre (sem backend).", "Limpo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AtualizarListBox()
        {
            listBoxTarefas.Items.Clear();
            foreach (string tarefa in tarefas)
            {
                listBoxTarefas.Items.Add(tarefa);
            }
        }
    }
}
