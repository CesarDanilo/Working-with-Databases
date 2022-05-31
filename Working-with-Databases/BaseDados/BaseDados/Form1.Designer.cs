namespace BaseDados
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
            this.label_resultado = new System.Windows.Forms.Label();
            this.List_results = new System.Windows.Forms.DataGridView();
            this.label_name = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label_cell = new System.Windows.Forms.Label();
            this.label_documents = new System.Windows.Forms.Label();
            this.textBox_documents = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox_cell = new System.Windows.Forms.TextBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_createTable = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.List_results)).BeginInit();
            this.SuspendLayout();
            // 
            // label_resultado
            // 
            this.label_resultado.Font = new System.Drawing.Font("Roboto Mono Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_resultado.Location = new System.Drawing.Point(12, 9);
            this.label_resultado.Name = "label_resultado";
            this.label_resultado.Size = new System.Drawing.Size(776, 108);
            this.label_resultado.TabIndex = 0;
            this.label_resultado.Text = "Resultado";
            this.label_resultado.Click += new System.EventHandler(this.label_resultado_Click);
            // 
            // List_results
            // 
            this.List_results.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.List_results.BackgroundColor = System.Drawing.SystemColors.Control;
            this.List_results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.List_results.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.email,
            this.cell,
            this.documents});
            this.List_results.Location = new System.Drawing.Point(16, 213);
            this.List_results.MultiSelect = false;
            this.List_results.Name = "List_results";
            this.List_results.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.List_results.Size = new System.Drawing.Size(646, 225);
            this.List_results.TabIndex = 1;
            // 
            // label_name
            // 
            this.label_name.Font = new System.Drawing.Font("Roboto Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(12, 135);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(56, 23);
            this.label_name.TabIndex = 2;
            this.label_name.Text = "Name";
            // 
            // label_email
            // 
            this.label_email.Font = new System.Drawing.Font("Roboto Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.Location = new System.Drawing.Point(12, 167);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(74, 23);
            this.label_email.TabIndex = 3;
            this.label_email.Text = "E-mail";
            this.label_email.Click += new System.EventHandler(this.label_email_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(92, 138);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(350, 20);
            this.textBox_name.TabIndex = 4;
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(92, 167);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(350, 20);
            this.textBox_email.TabIndex = 5;
            // 
            // label_cell
            // 
            this.label_cell.Font = new System.Drawing.Font("Roboto Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cell.Location = new System.Drawing.Point(448, 138);
            this.label_cell.Name = "label_cell";
            this.label_cell.Size = new System.Drawing.Size(52, 23);
            this.label_cell.TabIndex = 6;
            this.label_cell.Text = "Cell";
            // 
            // label_documents
            // 
            this.label_documents.Font = new System.Drawing.Font("Roboto Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_documents.Location = new System.Drawing.Point(448, 167);
            this.label_documents.Name = "label_documents";
            this.label_documents.Size = new System.Drawing.Size(70, 23);
            this.label_documents.TabIndex = 8;
            this.label_documents.Text = "RG/CPF";
            // 
            // textBox_documents
            // 
            this.textBox_documents.Location = new System.Drawing.Point(524, 170);
            this.textBox_documents.Name = "textBox_documents";
            this.textBox_documents.Size = new System.Drawing.Size(138, 20);
            this.textBox_documents.TabIndex = 9;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // name
            // 
            this.name.HeaderText = "NAME";
            this.name.Name = "name";
            // 
            // email
            // 
            this.email.HeaderText = "E-MAIL";
            this.email.Name = "email";
            // 
            // cell
            // 
            this.cell.HeaderText = "CELL";
            this.cell.Name = "cell";
            // 
            // documents
            // 
            this.documents.HeaderText = "RG/CPF";
            this.documents.Name = "documents";
            // 
            // textBox_cell
            // 
            this.textBox_cell.Location = new System.Drawing.Point(524, 138);
            this.textBox_cell.Name = "textBox_cell";
            this.textBox_cell.Size = new System.Drawing.Size(138, 20);
            this.textBox_cell.TabIndex = 7;
            // 
            // btn_connect
            // 
            this.btn_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_connect.Location = new System.Drawing.Point(669, 138);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(119, 45);
            this.btn_connect.TabIndex = 10;
            this.btn_connect.Text = "TO CONNECT";
            this.btn_connect.UseVisualStyleBackColor = true;
            // 
            // btn_createTable
            // 
            this.btn_createTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createTable.Location = new System.Drawing.Point(669, 189);
            this.btn_createTable.Name = "btn_createTable";
            this.btn_createTable.Size = new System.Drawing.Size(119, 45);
            this.btn_createTable.TabIndex = 11;
            this.btn_createTable.Text = "CREATE TABLE";
            this.btn_createTable.UseVisualStyleBackColor = true;
            // 
            // btn_insert
            // 
            this.btn_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.Location = new System.Drawing.Point(669, 240);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(119, 45);
            this.btn_insert.TabIndex = 12;
            this.btn_insert.Text = "INSERT";
            this.btn_insert.UseVisualStyleBackColor = true;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(669, 291);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(119, 45);
            this.btn_search.TabIndex = 13;
            this.btn_search.Text = "SEARCH";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(669, 342);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(119, 45);
            this.btn_delete.TabIndex = 14;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(669, 393);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(119, 45);
            this.btn_edit.TabIndex = 15;
            this.btn_edit.Text = "EDIT";
            this.btn_edit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.btn_createTable);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.textBox_documents);
            this.Controls.Add(this.label_documents);
            this.Controls.Add(this.textBox_cell);
            this.Controls.Add(this.label_cell);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.List_results);
            this.Controls.Add(this.label_resultado);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.List_results)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_resultado;
        private System.Windows.Forms.DataGridView List_results;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label_cell;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn cell;
        private System.Windows.Forms.DataGridViewTextBoxColumn documents;
        private System.Windows.Forms.Label label_documents;
        private System.Windows.Forms.TextBox textBox_documents;
        private System.Windows.Forms.TextBox textBox_cell;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_createTable;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
    }
}

