namespace ExercicioBD5
{
    partial class Form1
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
            this.datagrid1 = new System.Windows.Forms.DataGridView();
            this.btn_exibiralunos = new System.Windows.Forms.Button();
            this.btn_exibirsetores = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_exibirsalas = new System.Windows.Forms.Button();
            this.btn_buscaalunos = new System.Windows.Forms.Button();
            this.btn_buscasetores = new System.Windows.Forms.Button();
            this.btn_buscasalas = new System.Windows.Forms.Button();
            this.txtb_ID = new System.Windows.Forms.TextBox();
            this.lab_ID = new System.Windows.Forms.Label();
            this.lab_nome = new System.Windows.Forms.Label();
            this.txtb_nome = new System.Windows.Forms.TextBox();
            this.btn_buscarsetores = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid1
            // 
            this.datagrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid1.Location = new System.Drawing.Point(12, 65);
            this.datagrid1.Name = "datagrid1";
            this.datagrid1.Size = new System.Drawing.Size(580, 273);
            this.datagrid1.TabIndex = 1;
            this.datagrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_exibiralunos
            // 
            this.btn_exibiralunos.Location = new System.Drawing.Point(12, 12);
            this.btn_exibiralunos.Name = "btn_exibiralunos";
            this.btn_exibiralunos.Size = new System.Drawing.Size(141, 23);
            this.btn_exibiralunos.TabIndex = 2;
            this.btn_exibiralunos.Text = "Exibir alunos";
            this.btn_exibiralunos.UseVisualStyleBackColor = true;
            this.btn_exibiralunos.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_exibirsetores
            // 
            this.btn_exibirsetores.Location = new System.Drawing.Point(159, 12);
            this.btn_exibirsetores.Name = "btn_exibirsetores";
            this.btn_exibirsetores.Size = new System.Drawing.Size(141, 23);
            this.btn_exibirsetores.TabIndex = 3;
            this.btn_exibirsetores.Text = "Exibir Setores";
            this.btn_exibirsetores.UseVisualStyleBackColor = true;
            this.btn_exibirsetores.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(453, 12);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(141, 23);
            this.btn_buscar.TabIndex = 4;
            this.btn_buscar.Text = "Busca";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_exibirsalas
            // 
            this.btn_exibirsalas.Location = new System.Drawing.Point(306, 12);
            this.btn_exibirsalas.Name = "btn_exibirsalas";
            this.btn_exibirsalas.Size = new System.Drawing.Size(141, 23);
            this.btn_exibirsalas.TabIndex = 5;
            this.btn_exibirsalas.Text = "Exibir Salas";
            this.btn_exibirsalas.UseVisualStyleBackColor = true;
            this.btn_exibirsalas.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_buscaalunos
            // 
            this.btn_buscaalunos.Location = new System.Drawing.Point(240, 175);
            this.btn_buscaalunos.Name = "btn_buscaalunos";
            this.btn_buscaalunos.Size = new System.Drawing.Size(141, 23);
            this.btn_buscaalunos.TabIndex = 6;
            this.btn_buscaalunos.Text = "Alunos";
            this.btn_buscaalunos.UseVisualStyleBackColor = true;
            this.btn_buscaalunos.Visible = false;
            // 
            // btn_buscasetores
            // 
            this.btn_buscasetores.Location = new System.Drawing.Point(240, 204);
            this.btn_buscasetores.Name = "btn_buscasetores";
            this.btn_buscasetores.Size = new System.Drawing.Size(141, 23);
            this.btn_buscasetores.TabIndex = 7;
            this.btn_buscasetores.Text = "Setores";
            this.btn_buscasetores.UseVisualStyleBackColor = true;
            this.btn_buscasetores.Visible = false;
            this.btn_buscasetores.Click += new System.EventHandler(this.btn_buscasetores_Click);
            // 
            // btn_buscasalas
            // 
            this.btn_buscasalas.Location = new System.Drawing.Point(240, 233);
            this.btn_buscasalas.Name = "btn_buscasalas";
            this.btn_buscasalas.Size = new System.Drawing.Size(141, 23);
            this.btn_buscasalas.TabIndex = 8;
            this.btn_buscasalas.Text = "Salas";
            this.btn_buscasalas.UseVisualStyleBackColor = true;
            this.btn_buscasalas.Visible = false;
            // 
            // txtb_ID
            // 
            this.txtb_ID.Location = new System.Drawing.Point(38, 15);
            this.txtb_ID.Name = "txtb_ID";
            this.txtb_ID.Size = new System.Drawing.Size(32, 20);
            this.txtb_ID.TabIndex = 9;
            this.txtb_ID.Visible = false;
            this.txtb_ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtb_ID_KeyDown);
            // 
            // lab_ID
            // 
            this.lab_ID.AutoSize = true;
            this.lab_ID.Location = new System.Drawing.Point(14, 18);
            this.lab_ID.Name = "lab_ID";
            this.lab_ID.Size = new System.Drawing.Size(18, 13);
            this.lab_ID.TabIndex = 10;
            this.lab_ID.Text = "ID";
            this.lab_ID.Visible = false;
            this.lab_ID.Click += new System.EventHandler(this.label1_Click);
            // 
            // lab_nome
            // 
            this.lab_nome.AutoSize = true;
            this.lab_nome.Location = new System.Drawing.Point(76, 18);
            this.lab_nome.Name = "lab_nome";
            this.lab_nome.Size = new System.Drawing.Size(35, 13);
            this.lab_nome.TabIndex = 11;
            this.lab_nome.Text = "Nome";
            this.lab_nome.Visible = false;
            this.lab_nome.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtb_nome
            // 
            this.txtb_nome.Location = new System.Drawing.Point(117, 15);
            this.txtb_nome.Name = "txtb_nome";
            this.txtb_nome.Size = new System.Drawing.Size(225, 20);
            this.txtb_nome.TabIndex = 12;
            this.txtb_nome.Visible = false;
            // 
            // btn_buscarsetores
            // 
            this.btn_buscarsetores.Location = new System.Drawing.Point(453, 80);
            this.btn_buscarsetores.Name = "btn_buscarsetores";
            this.btn_buscarsetores.Size = new System.Drawing.Size(141, 23);
            this.btn_buscarsetores.TabIndex = 13;
            this.btn_buscarsetores.Text = "Buscar";
            this.btn_buscarsetores.UseVisualStyleBackColor = true;
            this.btn_buscarsetores.Visible = false;
            this.btn_buscarsetores.Click += new System.EventHandler(this.btn_buscarsetores_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(453, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 447);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_buscarsetores);
            this.Controls.Add(this.txtb_nome);
            this.Controls.Add(this.lab_nome);
            this.Controls.Add(this.lab_ID);
            this.Controls.Add(this.txtb_ID);
            this.Controls.Add(this.btn_buscasalas);
            this.Controls.Add(this.btn_buscasetores);
            this.Controls.Add(this.btn_buscaalunos);
            this.Controls.Add(this.btn_exibirsalas);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_exibirsetores);
            this.Controls.Add(this.btn_exibiralunos);
            this.Controls.Add(this.datagrid1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrid1;
        private System.Windows.Forms.Button btn_exibiralunos;
        private System.Windows.Forms.Button btn_exibirsetores;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_exibirsalas;
        private System.Windows.Forms.Button btn_buscaalunos;
        private System.Windows.Forms.Button btn_buscasetores;
        private System.Windows.Forms.Button btn_buscasalas;
        private System.Windows.Forms.TextBox txtb_ID;
        private System.Windows.Forms.Label lab_ID;
        private System.Windows.Forms.Label lab_nome;
        private System.Windows.Forms.TextBox txtb_nome;
        private System.Windows.Forms.Button btn_buscarsetores;
        private System.Windows.Forms.Button button1;
    }
}

