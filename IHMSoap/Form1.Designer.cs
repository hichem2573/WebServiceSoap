namespace IHMSoap
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.salarieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deptnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salarieBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deptnoDataGridViewTextBoxColumn,
            this.dnameDataGridViewTextBoxColumn,
            this.empnoDataGridViewTextBoxColumn,
            this.enameDataGridViewTextBoxColumn,
            this.salDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.salarieBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 336);
            this.dataGridView1.TabIndex = 0;
            // 
            // salarieBindingSource
            // 
            this.salarieBindingSource.DataSource = typeof(IHMSoap.SerSalarie.Salarie);
            // 
            // deptnoDataGridViewTextBoxColumn
            // 
            this.deptnoDataGridViewTextBoxColumn.DataPropertyName = "Deptno";
            this.deptnoDataGridViewTextBoxColumn.HeaderText = "Deptno";
            this.deptnoDataGridViewTextBoxColumn.Name = "deptnoDataGridViewTextBoxColumn";
            // 
            // dnameDataGridViewTextBoxColumn
            // 
            this.dnameDataGridViewTextBoxColumn.DataPropertyName = "Dname";
            this.dnameDataGridViewTextBoxColumn.HeaderText = "Dname";
            this.dnameDataGridViewTextBoxColumn.Name = "dnameDataGridViewTextBoxColumn";
            // 
            // empnoDataGridViewTextBoxColumn
            // 
            this.empnoDataGridViewTextBoxColumn.DataPropertyName = "Empno";
            this.empnoDataGridViewTextBoxColumn.HeaderText = "Empno";
            this.empnoDataGridViewTextBoxColumn.Name = "empnoDataGridViewTextBoxColumn";
            // 
            // enameDataGridViewTextBoxColumn
            // 
            this.enameDataGridViewTextBoxColumn.DataPropertyName = "Ename";
            this.enameDataGridViewTextBoxColumn.HeaderText = "Ename";
            this.enameDataGridViewTextBoxColumn.Name = "enameDataGridViewTextBoxColumn";
            // 
            // salDataGridViewTextBoxColumn
            // 
            this.salDataGridViewTextBoxColumn.DataPropertyName = "Sal";
            this.salDataGridViewTextBoxColumn.HeaderText = "Sal";
            this.salDataGridViewTextBoxColumn.Name = "salDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 591);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salarieBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource salarieBindingSource;
    }
}

