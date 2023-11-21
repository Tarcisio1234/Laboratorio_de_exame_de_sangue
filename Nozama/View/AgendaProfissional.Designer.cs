namespace Nozama
{
    partial class gridAgenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gridAgenda));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gridAgenda2 = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apaga = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Coagulograma = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Tireoide = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Hiv = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Funcaohepatica = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Colesterol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Ureia = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Hemograma = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Glicose = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Creatinina = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.dataTeste = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridAgenda2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agenda do profissional";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(9, 50);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(152, 22);
            this.txtNome.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(420, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(185, 40);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 39);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gridAgenda2
            // 
            this.gridAgenda2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAgenda2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Data,
            this.Apaga,
            this.Coagulograma,
            this.Tireoide,
            this.Hiv,
            this.Funcaohepatica,
            this.Colesterol,
            this.Ureia,
            this.Hemograma,
            this.Glicose,
            this.Creatinina});
            this.gridAgenda2.Location = new System.Drawing.Point(121, 213);
            this.gridAgenda2.Name = "gridAgenda2";
            this.gridAgenda2.ReadOnly = true;
            this.gridAgenda2.Size = new System.Drawing.Size(555, 183);
            this.gridAgenda2.TabIndex = 11;
            this.gridAgenda2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAgenda2_CellContentClick);
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nome.DataPropertyName = "Nome";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.Nome.DefaultCellStyle = dataGridViewCellStyle1;
            this.Nome.HeaderText = "Nomes";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nome.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Nome.Width = 150;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "dataExame";
            this.Data.HeaderText = "Data do exame";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // Apaga
            // 
            this.Apaga.DataPropertyName = "Apagar";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.Apaga.DefaultCellStyle = dataGridViewCellStyle2;
            this.Apaga.HeaderText = "Apagar";
            this.Apaga.Name = "Apaga";
            this.Apaga.ReadOnly = true;
            this.Apaga.Text = "Deletar";
            this.Apaga.UseColumnTextForButtonValue = true;
            // 
            // Coagulograma
            // 
            this.Coagulograma.DataPropertyName = "Coagulograma";
            this.Coagulograma.HeaderText = "Coagulograma";
            this.Coagulograma.Name = "Coagulograma";
            this.Coagulograma.ReadOnly = true;
            // 
            // Tireoide
            // 
            this.Tireoide.DataPropertyName = "Tireoide";
            this.Tireoide.HeaderText = "Tireoide";
            this.Tireoide.Name = "Tireoide";
            this.Tireoide.ReadOnly = true;
            this.Tireoide.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Tireoide.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Hiv
            // 
            this.Hiv.DataPropertyName = "Hiv";
            this.Hiv.HeaderText = "HIV";
            this.Hiv.Name = "Hiv";
            this.Hiv.ReadOnly = true;
            this.Hiv.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Hiv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Funcaohepatica
            // 
            this.Funcaohepatica.DataPropertyName = "Funcaohepatica";
            this.Funcaohepatica.HeaderText = "Função Hepatica";
            this.Funcaohepatica.Name = "Funcaohepatica";
            this.Funcaohepatica.ReadOnly = true;
            this.Funcaohepatica.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Funcaohepatica.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Colesterol
            // 
            this.Colesterol.DataPropertyName = "Colesterol";
            this.Colesterol.HeaderText = "Colesterol";
            this.Colesterol.Name = "Colesterol";
            this.Colesterol.ReadOnly = true;
            this.Colesterol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Colesterol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Ureia
            // 
            this.Ureia.DataPropertyName = "Ureia";
            this.Ureia.HeaderText = "Ureia";
            this.Ureia.Name = "Ureia";
            this.Ureia.ReadOnly = true;
            // 
            // Hemograma
            // 
            this.Hemograma.DataPropertyName = "Hemograma";
            this.Hemograma.HeaderText = "Hemograma";
            this.Hemograma.Name = "Hemograma";
            this.Hemograma.ReadOnly = true;
            this.Hemograma.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Hemograma.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Glicose
            // 
            this.Glicose.DataPropertyName = "Glicose";
            this.Glicose.HeaderText = "Glicose";
            this.Glicose.Name = "Glicose";
            this.Glicose.ReadOnly = true;
            this.Glicose.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Glicose.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Creatinina
            // 
            this.Creatinina.DataPropertyName = "Creatinina";
            this.Creatinina.HeaderText = "Creatina";
            this.Creatinina.Name = "Creatinina";
            this.Creatinina.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(208, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 39);
            this.button2.TabIndex = 12;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataTeste
            // 
            this.dataTeste.CustomFormat = "dd/MM/yyyy";
            this.dataTeste.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataTeste.Location = new System.Drawing.Point(21, 48);
            this.dataTeste.Name = "dataTeste";
            this.dataTeste.Size = new System.Drawing.Size(166, 20);
            this.dataTeste.TabIndex = 13;
            this.dataTeste.Value = new System.DateTime(2023, 11, 23, 0, 0, 0, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(121, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 100);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nome";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.dataTeste);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(386, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(274, 409);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(96, 44);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Resetar";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // gridAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(787, 475);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridAgenda2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "gridAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AgendaProfissional_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAgenda2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView gridAgenda2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewButtonColumn Apaga;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Coagulograma;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Tireoide;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Hiv;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Funcaohepatica;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Colesterol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Ureia;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Hemograma;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Glicose;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Creatinina;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dataTeste;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnReset;
    }
}