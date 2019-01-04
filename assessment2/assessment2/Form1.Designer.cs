namespace assessment2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtempname = new System.Windows.Forms.TextBox();
            this.employeeDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cDACData = new assessment2.CDACData();
            this.lblempname = new System.Windows.Forms.Label();
            this.lblempage = new System.Windows.Forms.Label();
            this.txtempage = new System.Windows.Forms.TextBox();
            this.Department = new System.Windows.Forms.Label();
            this.txtdeapartment = new System.Windows.Forms.TextBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cDACDataSet = new assessment2.CDACDataSet();
            this.cDACDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cDACDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employeeDetailsTableAdapter = new assessment2.CDACDataTableAdapters.EmployeeDetailsTableAdapter();
            this.empIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDACData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDACDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDACDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDACDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtempname
            // 
            this.txtempname.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.employeeDetailsBindingSource, "EmpName", true));
            this.txtempname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeDetailsBindingSource, "EmpName", true));
            this.txtempname.Location = new System.Drawing.Point(211, 69);
            this.txtempname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtempname.Name = "txtempname";
            this.txtempname.Size = new System.Drawing.Size(132, 22);
            this.txtempname.TabIndex = 1;
            this.txtempname.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // employeeDetailsBindingSource
            // 
            this.employeeDetailsBindingSource.DataMember = "EmployeeDetails";
            this.employeeDetailsBindingSource.DataSource = this.cDACData;
            // 
            // cDACData
            // 
            this.cDACData.DataSetName = "CDACData";
            this.cDACData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblempname
            // 
            this.lblempname.AutoSize = true;
            this.lblempname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempname.Location = new System.Drawing.Point(47, 69);
            this.lblempname.Name = "lblempname";
            this.lblempname.Size = new System.Drawing.Size(80, 16);
            this.lblempname.TabIndex = 2;
            this.lblempname.Text = "EmpName";
            // 
            // lblempage
            // 
            this.lblempage.AutoSize = true;
            this.lblempage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempage.Location = new System.Drawing.Point(47, 134);
            this.lblempage.Name = "lblempage";
            this.lblempage.Size = new System.Drawing.Size(67, 16);
            this.lblempage.TabIndex = 3;
            this.lblempage.Text = "EmpAge";
            // 
            // txtempage
            // 
            this.txtempage.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.employeeDetailsBindingSource, "EmpAge", true));
            this.txtempage.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeDetailsBindingSource, "EmpAge", true));
            this.txtempage.Location = new System.Drawing.Point(211, 126);
            this.txtempage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtempage.Name = "txtempage";
            this.txtempage.Size = new System.Drawing.Size(132, 22);
            this.txtempage.TabIndex = 4;
            this.txtempage.TextChanged += new System.EventHandler(this.txtampage_TextChanged);
            // 
            // Department
            // 
            this.Department.AutoSize = true;
            this.Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Department.Location = new System.Drawing.Point(39, 197);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(88, 16);
            this.Department.TabIndex = 5;
            this.Department.Text = "Department";
            // 
            // txtdeapartment
            // 
            this.txtdeapartment.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.employeeDetailsBindingSource, "Department", true));
            this.txtdeapartment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeDetailsBindingSource, "Department", true));
            this.txtdeapartment.Location = new System.Drawing.Point(211, 197);
            this.txtdeapartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtdeapartment.Name = "txtdeapartment";
            this.txtdeapartment.Size = new System.Drawing.Size(132, 22);
            this.txtdeapartment.TabIndex = 6;
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(166, 263);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(99, 28);
            this.btnupdate.TabIndex = 7;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(291, 263);
            this.btndelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(99, 28);
            this.btndelete.TabIndex = 8;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btninsert
            // 
            this.btninsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsert.Location = new System.Drawing.Point(42, 263);
            this.btninsert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(99, 28);
            this.btninsert.TabIndex = 9;
            this.btninsert.Text = "Insert";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empIdDataGridViewTextBoxColumn,
            this.empNameDataGridViewTextBoxColumn,
            this.empAgeDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeeDetailsBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(444, 69);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Size = new System.Drawing.Size(444, 185);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cDACDataSet
            // 
            this.cDACDataSet.DataSetName = "CDACDataSet";
            this.cDACDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cDACDataSetBindingSource
            // 
            this.cDACDataSetBindingSource.DataSource = this.cDACDataSet;
            this.cDACDataSetBindingSource.Position = 0;
            // 
            // cDACDataSetBindingSource1
            // 
            this.cDACDataSetBindingSource1.DataSource = this.cDACDataSet;
            this.cDACDataSetBindingSource1.Position = 0;
            // 
            // employeeDetailsTableAdapter
            // 
            this.employeeDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // empIdDataGridViewTextBoxColumn
            // 
            this.empIdDataGridViewTextBoxColumn.DataPropertyName = "EmpId";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empIdDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.empIdDataGridViewTextBoxColumn.HeaderText = "EmpId";
            this.empIdDataGridViewTextBoxColumn.Name = "empIdDataGridViewTextBoxColumn";
            this.empIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empNameDataGridViewTextBoxColumn
            // 
            this.empNameDataGridViewTextBoxColumn.DataPropertyName = "EmpName";
            this.empNameDataGridViewTextBoxColumn.HeaderText = "EmpName";
            this.empNameDataGridViewTextBoxColumn.Name = "empNameDataGridViewTextBoxColumn";
            // 
            // empAgeDataGridViewTextBoxColumn
            // 
            this.empAgeDataGridViewTextBoxColumn.DataPropertyName = "EmpAge";
            this.empAgeDataGridViewTextBoxColumn.HeaderText = "EmpAge";
            this.empAgeDataGridViewTextBoxColumn.Name = "empAgeDataGridViewTextBoxColumn";
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1029, 554);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.txtdeapartment);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.txtempage);
            this.Controls.Add(this.lblempage);
            this.Controls.Add(this.lblempname);
            this.Controls.Add(this.txtempname);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Employee Details";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDACData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDACDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDACDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDACDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtempname;
        private System.Windows.Forms.Label lblempname;
        private System.Windows.Forms.Label lblempage;
        private System.Windows.Forms.TextBox txtempage;
        private System.Windows.Forms.Label Department;
        private System.Windows.Forms.TextBox txtdeapartment;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource cDACDataSetBindingSource;
        private CDACDataSet cDACDataSet;
        private System.Windows.Forms.BindingSource cDACDataSetBindingSource1;
        private CDACData cDACData;
        private System.Windows.Forms.BindingSource employeeDetailsBindingSource;
        private CDACDataTableAdapters.EmployeeDetailsTableAdapter employeeDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
    }
}

