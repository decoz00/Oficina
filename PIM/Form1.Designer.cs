namespace PIM
{
    partial class Form1
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
            this.textBoxTarefa = new System.Windows.Forms.TextBox();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.listBoxTarefas = new System.Windows.Forms.ListBox();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightYellow;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20F);
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(436, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite uma tarefa:";
            // 
            // textBoxTarefa
            // 
            this.textBoxTarefa.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxTarefa.Font = new System.Drawing.Font("Courier New", 16F);
            this.textBoxTarefa.Location = new System.Drawing.Point(333, 138);
            this.textBoxTarefa.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxTarefa.Name = "textBoxTarefa";
            this.textBoxTarefa.Size = new System.Drawing.Size(664, 32);
            this.textBoxTarefa.TabIndex = 1;
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.BackColor = System.Drawing.Color.Blue;
            this.buttonAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdicionar.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.buttonAdicionar.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAdicionar.Location = new System.Drawing.Point(1010, 123);
            this.buttonAdicionar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(250, 55);
            this.buttonAdicionar.TabIndex = 2;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = false;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // listBoxTarefas
            // 
            this.listBoxTarefas.BackColor = System.Drawing.Color.LightGray;
            this.listBoxTarefas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxTarefas.Font = new System.Drawing.Font("Courier New", 14F);
            this.listBoxTarefas.FormattingEnabled = true;
            this.listBoxTarefas.ItemHeight = 21;
            this.listBoxTarefas.Location = new System.Drawing.Point(167, 222);
            this.listBoxTarefas.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.listBoxTarefas.Name = "listBoxTarefas";
            this.listBoxTarefas.Size = new System.Drawing.Size(997, 527);
            this.listBoxTarefas.TabIndex = 3;
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.BackColor = System.Drawing.Color.Blue;
            this.buttonLimpar.Font = new System.Drawing.Font("Comic Sans MS", 16F);
            this.buttonLimpar.ForeColor = System.Drawing.Color.White;
            this.buttonLimpar.Location = new System.Drawing.Point(583, 803);
            this.buttonLimpar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(167, 55);
            this.buttonLimpar.TabIndex = 4;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = false;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1307, 1054);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.listBoxTarefas);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.textBoxTarefa);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Courier New", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "To-Do List Feia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTarefa;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.ListBox listBoxTarefas;
        private System.Windows.Forms.Button buttonLimpar;
    }
}

