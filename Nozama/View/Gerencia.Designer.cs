namespace Nozama.View
{
    partial class Gerencia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gerencia));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gridPaciente = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.gridProfissional = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Idpaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataNacemiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apagar1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cpf2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereco2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apagar2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Profissao2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridPaciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProfissional)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu da gerencia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(435, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Todos os Clientes cadastrados";
            // 
            // gridPaciente
            // 
            this.gridPaciente.AllowUserToOrderColumns = true;
            this.gridPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPaciente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Idpaciente,
            this.Nome,
            this.Cpf,
            this.DataNacemiento,
            this.Sexo,
            this.Celular,
            this.Endereco,
            this.Apagar1});
            this.gridPaciente.Location = new System.Drawing.Point(39, 125);
            this.gridPaciente.Name = "gridPaciente";
            this.gridPaciente.ReadOnly = true;
            this.gridPaciente.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridPaciente.Size = new System.Drawing.Size(696, 179);
            this.gridPaciente.TabIndex = 2;
            this.gridPaciente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPaciente_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(385, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(350, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Todos os Profissionais cadastrados";
            // 
            // gridProfissional
            // 
            this.gridProfissional.AllowUserToOrderColumns = true;
            this.gridProfissional.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProfissional.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID2,
            this.Nome2,
            this.Cpf2,
            this.Data2,
            this.Sexo2,
            this.Celular2,
            this.Endereco2,
            this.Apagar2,
            this.Profissao2});
            this.gridProfissional.Location = new System.Drawing.Point(39, 344);
            this.gridProfissional.Name = "gridProfissional";
            this.gridProfissional.ReadOnly = true;
            this.gridProfissional.Size = new System.Drawing.Size(696, 184);
            this.gridProfissional.TabIndex = 4;
            this.gridProfissional.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProfissional_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(129, 534);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(24, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cliente";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(202, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "Profissional";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(565, 567);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(99, 38);
            this.button5.TabIndex = 8;
            this.button5.Text = "Voltar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Idpaciente
            // 
            this.Idpaciente.DataPropertyName = "Idpaciente";
            this.Idpaciente.HeaderText = "ID";
            this.Idpaciente.Name = "Idpaciente";
            this.Idpaciente.ReadOnly = true;
            this.Idpaciente.Visible = false;
            this.Idpaciente.Width = 30;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 112;
            // 
            // Cpf
            // 
            this.Cpf.DataPropertyName = "Cpf";
            this.Cpf.HeaderText = "CPF";
            this.Cpf.Name = "Cpf";
            this.Cpf.ReadOnly = true;
            this.Cpf.Width = 80;
            // 
            // DataNacemiento
            // 
            this.DataNacemiento.DataPropertyName = "Datanascimento";
            this.DataNacemiento.HeaderText = "Data de Nascimento";
            this.DataNacemiento.Name = "DataNacemiento";
            this.DataNacemiento.ReadOnly = true;
            this.DataNacemiento.Width = 70;
            // 
            // Sexo
            // 
            this.Sexo.DataPropertyName = "Sexo";
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            this.Sexo.Width = 98;
            // 
            // Celular
            // 
            this.Celular.DataPropertyName = "Celular";
            this.Celular.HeaderText = "Celular";
            this.Celular.Name = "Celular";
            this.Celular.ReadOnly = true;
            // 
            // Endereco
            // 
            this.Endereco.DataPropertyName = "Endereco";
            this.Endereco.HeaderText = "Endereço";
            this.Endereco.Name = "Endereco";
            this.Endereco.ReadOnly = true;
            // 
            // Apagar1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Apagar1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Apagar1.HeaderText = "Apagar";
            this.Apagar1.Name = "Apagar1";
            this.Apagar1.ReadOnly = true;
            this.Apagar1.Text = "Deletar";
            this.Apagar1.UseColumnTextForButtonValue = true;
            this.Apagar1.Width = 75;
            // 
            // ID2
            // 
            this.ID2.DataPropertyName = "Idprofissional";
            this.ID2.HeaderText = "ID";
            this.ID2.Name = "ID2";
            this.ID2.ReadOnly = true;
            this.ID2.Visible = false;
            this.ID2.Width = 30;
            // 
            // Nome2
            // 
            this.Nome2.DataPropertyName = "Nome";
            this.Nome2.HeaderText = "Nome";
            this.Nome2.Name = "Nome2";
            this.Nome2.ReadOnly = true;
            this.Nome2.Width = 112;
            // 
            // Cpf2
            // 
            this.Cpf2.DataPropertyName = "Cpf";
            this.Cpf2.HeaderText = "CPF";
            this.Cpf2.Name = "Cpf2";
            this.Cpf2.ReadOnly = true;
            this.Cpf2.Width = 80;
            // 
            // Data2
            // 
            this.Data2.DataPropertyName = "DataNascimento";
            this.Data2.HeaderText = "Data de Nascimento";
            this.Data2.Name = "Data2";
            this.Data2.ReadOnly = true;
            this.Data2.Width = 70;
            // 
            // Sexo2
            // 
            this.Sexo2.DataPropertyName = "Sexo";
            this.Sexo2.HeaderText = "Sexo";
            this.Sexo2.Name = "Sexo2";
            this.Sexo2.ReadOnly = true;
            this.Sexo2.Width = 98;
            // 
            // Celular2
            // 
            this.Celular2.DataPropertyName = "Celular";
            this.Celular2.HeaderText = "Celular";
            this.Celular2.Name = "Celular2";
            this.Celular2.ReadOnly = true;
            // 
            // Endereco2
            // 
            this.Endereco2.DataPropertyName = "Endereco";
            this.Endereco2.HeaderText = "Endereço";
            this.Endereco2.Name = "Endereco2";
            this.Endereco2.ReadOnly = true;
            // 
            // Apagar2
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Apagar2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Apagar2.HeaderText = "Apagar";
            this.Apagar2.Name = "Apagar2";
            this.Apagar2.ReadOnly = true;
            this.Apagar2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Apagar2.Text = "Deletar";
            this.Apagar2.UseColumnTextForButtonValue = true;
            this.Apagar2.Width = 75;
            // 
            // Profissao2
            // 
            this.Profissao2.DataPropertyName = "Profissao";
            this.Profissao2.HeaderText = "Profissão";
            this.Profissao2.Name = "Profissao2";
            this.Profissao2.ReadOnly = true;
            this.Profissao2.Width = 125;
            // 
            // Gerencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 658);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridProfissional);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gridPaciente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Gerencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Gerencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPaciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProfissional)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridPaciente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridProfissional;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idpaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataNacemiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereco;
        private System.Windows.Forms.DataGridViewButtonColumn Apagar1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cpf2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereco2;
        private System.Windows.Forms.DataGridViewButtonColumn Apagar2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profissao2;
    }
}