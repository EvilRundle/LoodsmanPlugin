namespace SampleNetPlugin
{
    partial class FormPlugin
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
            System.Windows.Forms.Label lblName;
            System.Windows.Forms.Label lblDivision;
            System.Windows.Forms.Label lblPost;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlugin));
            this.btnDownloadFile = new System.Windows.Forms.Button();
            this.oFdDetail = new System.Windows.Forms.OpenFileDialog();
            this.TBoxFileName = new System.Windows.Forms.TextBox();
            this.lblNameFile = new System.Windows.Forms.Label();
            this.gBSelectStaff = new System.Windows.Forms.GroupBox();
            this.btnApplyNameObj = new System.Windows.Forms.Button();
            this.TBoxNameObj = new System.Windows.Forms.TextBox();
            this.lblNameObject = new System.Windows.Forms.Label();
            this.btnSelectStaff = new System.Windows.Forms.Button();
            this.gBSelectedEmployee = new System.Windows.Forms.GroupBox();
            this.postTB = new System.Windows.Forms.TextBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffDataSet1 = new SampleNetPlugin.StaffDataSet1();
            this.divisionTB = new System.Windows.Forms.TextBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.dGvTableStaff = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.divisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteStaff = new System.Windows.Forms.Button();
            this.btnChangeStaff = new System.Windows.Forms.Button();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.richTBoxAddProduct = new System.Windows.Forms.RichTextBox();
            this.btnCreateProject = new System.Windows.Forms.Button();
            this.TBoxNameProject = new System.Windows.Forms.TextBox();
            this.lblNameProject = new System.Windows.Forms.Label();
            this.employeeTableAdapter = new SampleNetPlugin.StaffDataSet1TableAdapters.EmployeeTableAdapter();
            this.tableAdapterManager = new SampleNetPlugin.StaffDataSet1TableAdapters.TableAdapterManager();
            this.lblHint = new System.Windows.Forms.Label();
            this.richTBoxHint = new System.Windows.Forms.RichTextBox();
            lblName = new System.Windows.Forms.Label();
            lblDivision = new System.Windows.Forms.Label();
            lblPost = new System.Windows.Forms.Label();
            this.gBSelectStaff.SuspendLayout();
            this.gBSelectedEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGvTableStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new System.Drawing.Point(61, 29);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(80, 19);
            lblName.TabIndex = 0;
            lblName.Text = "Фамилия:";
            // 
            // lblDivision
            // 
            lblDivision.AutoSize = true;
            lblDivision.Location = new System.Drawing.Point(11, 62);
            lblDivision.Name = "lblDivision";
            lblDivision.Size = new System.Drawing.Size(130, 19);
            lblDivision.TabIndex = 2;
            lblDivision.Text = "Подразделение:";
            // 
            // lblPost
            // 
            lblPost.AutoSize = true;
            lblPost.Location = new System.Drawing.Point(43, 94);
            lblPost.Name = "lblPost";
            lblPost.Size = new System.Drawing.Size(98, 19);
            lblPost.TabIndex = 4;
            lblPost.Text = "Должность:";
            // 
            // btnDownloadFile
            // 
            this.btnDownloadFile.Font = new System.Drawing.Font("GOST Type BU", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDownloadFile.Location = new System.Drawing.Point(764, 12);
            this.btnDownloadFile.Name = "btnDownloadFile";
            this.btnDownloadFile.Size = new System.Drawing.Size(233, 28);
            this.btnDownloadFile.TabIndex = 1;
            this.btnDownloadFile.Text = "Загрузить сборку(деталь)";
            this.btnDownloadFile.UseVisualStyleBackColor = true;
            this.btnDownloadFile.Click += new System.EventHandler(this.btnDownloadFile_Click);
            // 
            // TBoxFileName
            // 
            this.TBoxFileName.Font = new System.Drawing.Font("GOST type B", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBoxFileName.Location = new System.Drawing.Point(172, 12);
            this.TBoxFileName.Name = "TBoxFileName";
            this.TBoxFileName.Size = new System.Drawing.Size(586, 28);
            this.TBoxFileName.TabIndex = 2;
            // 
            // lblNameFile
            // 
            this.lblNameFile.AutoSize = true;
            this.lblNameFile.Font = new System.Drawing.Font("GOST Type BU", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNameFile.Location = new System.Drawing.Point(29, 14);
            this.lblNameFile.Name = "lblNameFile";
            this.lblNameFile.Size = new System.Drawing.Size(137, 23);
            this.lblNameFile.TabIndex = 3;
            this.lblNameFile.Text = "Путь к файлу:";
            // 
            // gBSelectStaff
            // 
            this.gBSelectStaff.Controls.Add(this.richTBoxHint);
            this.gBSelectStaff.Controls.Add(this.lblHint);
            this.gBSelectStaff.Controls.Add(this.btnApplyNameObj);
            this.gBSelectStaff.Controls.Add(this.TBoxNameObj);
            this.gBSelectStaff.Controls.Add(this.lblNameObject);
            this.gBSelectStaff.Controls.Add(this.btnSelectStaff);
            this.gBSelectStaff.Controls.Add(this.gBSelectedEmployee);
            this.gBSelectStaff.Controls.Add(this.dGvTableStaff);
            this.gBSelectStaff.Controls.Add(this.btnDeleteStaff);
            this.gBSelectStaff.Controls.Add(this.btnChangeStaff);
            this.gBSelectStaff.Controls.Add(this.btnAddStaff);
            this.gBSelectStaff.Font = new System.Drawing.Font("GOST Type BU", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gBSelectStaff.Location = new System.Drawing.Point(16, 46);
            this.gBSelectStaff.Name = "gBSelectStaff";
            this.gBSelectStaff.Size = new System.Drawing.Size(985, 321);
            this.gBSelectStaff.TabIndex = 4;
            this.gBSelectStaff.TabStop = false;
            this.gBSelectStaff.Text = "Выбрать сотрудника";
            // 
            // btnApplyNameObj
            // 
            this.btnApplyNameObj.Font = new System.Drawing.Font("GOST Type BU", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnApplyNameObj.Location = new System.Drawing.Point(594, 255);
            this.btnApplyNameObj.Name = "btnApplyNameObj";
            this.btnApplyNameObj.Size = new System.Drawing.Size(168, 37);
            this.btnApplyNameObj.TabIndex = 9;
            this.btnApplyNameObj.Text = "Применить название";
            this.btnApplyNameObj.UseVisualStyleBackColor = true;
            this.btnApplyNameObj.Click += new System.EventHandler(this.btnApplyNameObj_Click);
            // 
            // TBoxNameObj
            // 
            this.TBoxNameObj.Font = new System.Drawing.Font("GOST Type BU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBoxNameObj.Location = new System.Drawing.Point(594, 222);
            this.TBoxNameObj.MaxLength = 15;
            this.TBoxNameObj.Name = "TBoxNameObj";
            this.TBoxNameObj.Size = new System.Drawing.Size(168, 27);
            this.TBoxNameObj.TabIndex = 8;
            // 
            // lblNameObject
            // 
            this.lblNameObject.AutoSize = true;
            this.lblNameObject.Location = new System.Drawing.Point(566, 200);
            this.lblNameObject.Name = "lblNameObject";
            this.lblNameObject.Size = new System.Drawing.Size(225, 19);
            this.lblNameObject.TabIndex = 7;
            this.lblNameObject.Text = "Введите название объекта";
            // 
            // btnSelectStaff
            // 
            this.btnSelectStaff.Font = new System.Drawing.Font("GOST Type BU", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelectStaff.Location = new System.Drawing.Point(858, 72);
            this.btnSelectStaff.Name = "btnSelectStaff";
            this.btnSelectStaff.Size = new System.Drawing.Size(109, 66);
            this.btnSelectStaff.TabIndex = 6;
            this.btnSelectStaff.Text = "Выбрать сотрудника";
            this.btnSelectStaff.UseVisualStyleBackColor = true;
            this.btnSelectStaff.Click += new System.EventHandler(this.btnSelectStaff_Click);
            // 
            // gBSelectedEmployee
            // 
            this.gBSelectedEmployee.Controls.Add(lblPost);
            this.gBSelectedEmployee.Controls.Add(this.postTB);
            this.gBSelectedEmployee.Controls.Add(lblDivision);
            this.gBSelectedEmployee.Controls.Add(this.divisionTB);
            this.gBSelectedEmployee.Controls.Add(lblName);
            this.gBSelectedEmployee.Controls.Add(this.nameTB);
            this.gBSelectedEmployee.Location = new System.Drawing.Point(9, 182);
            this.gBSelectedEmployee.Name = "gBSelectedEmployee";
            this.gBSelectedEmployee.Size = new System.Drawing.Size(404, 127);
            this.gBSelectedEmployee.TabIndex = 4;
            this.gBSelectedEmployee.TabStop = false;
            this.gBSelectedEmployee.Text = "Выбранный сотрудник:";
            // 
            // postTB
            // 
            this.postTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Post", true));
            this.postTB.Location = new System.Drawing.Point(147, 91);
            this.postTB.Name = "postTB";
            this.postTB.Size = new System.Drawing.Size(250, 27);
            this.postTB.TabIndex = 5;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.staffDataSet1;
            // 
            // staffDataSet1
            // 
            this.staffDataSet1.DataSetName = "StaffDataSet1";
            this.staffDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // divisionTB
            // 
            this.divisionTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Division", true));
            this.divisionTB.Location = new System.Drawing.Point(147, 59);
            this.divisionTB.Name = "divisionTB";
            this.divisionTB.Size = new System.Drawing.Size(250, 27);
            this.divisionTB.TabIndex = 3;
            // 
            // nameTB
            // 
            this.nameTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Name", true));
            this.nameTB.Location = new System.Drawing.Point(147, 26);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(250, 27);
            this.nameTB.TabIndex = 1;
            // 
            // dGvTableStaff
            // 
            this.dGvTableStaff.AllowUserToOrderColumns = true;
            this.dGvTableStaff.AutoGenerateColumns = false;
            this.dGvTableStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGvTableStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.divisionDataGridViewTextBoxColumn,
            this.postDataGridViewTextBoxColumn});
            this.dGvTableStaff.DataSource = this.employeeBindingSource;
            this.dGvTableStaff.Location = new System.Drawing.Point(6, 26);
            this.dGvTableStaff.Name = "dGvTableStaff";
            this.dGvTableStaff.Size = new System.Drawing.Size(837, 150);
            this.dGvTableStaff.TabIndex = 3;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Фамилия И.О.";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 240;
            // 
            // divisionDataGridViewTextBoxColumn
            // 
            this.divisionDataGridViewTextBoxColumn.DataPropertyName = "Division";
            this.divisionDataGridViewTextBoxColumn.HeaderText = "Подразделение";
            this.divisionDataGridViewTextBoxColumn.Name = "divisionDataGridViewTextBoxColumn";
            this.divisionDataGridViewTextBoxColumn.Width = 240;
            // 
            // postDataGridViewTextBoxColumn
            // 
            this.postDataGridViewTextBoxColumn.DataPropertyName = "Post";
            this.postDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.postDataGridViewTextBoxColumn.Name = "postDataGridViewTextBoxColumn";
            this.postDataGridViewTextBoxColumn.Width = 300;
            // 
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.Location = new System.Drawing.Point(419, 266);
            this.btnDeleteStaff.Name = "btnDeleteStaff";
            this.btnDeleteStaff.Size = new System.Drawing.Size(130, 35);
            this.btnDeleteStaff.TabIndex = 2;
            this.btnDeleteStaff.Text = "Удалить";
            this.btnDeleteStaff.UseVisualStyleBackColor = true;
            this.btnDeleteStaff.Click += new System.EventHandler(this.btnDeleteStaff_Click);
            // 
            // btnChangeStaff
            // 
            this.btnChangeStaff.Location = new System.Drawing.Point(419, 225);
            this.btnChangeStaff.Name = "btnChangeStaff";
            this.btnChangeStaff.Size = new System.Drawing.Size(130, 35);
            this.btnChangeStaff.TabIndex = 5;
            this.btnChangeStaff.Text = "Изменить";
            this.btnChangeStaff.Click += new System.EventHandler(this.btnChangeStaff_Click);
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Location = new System.Drawing.Point(419, 182);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(130, 37);
            this.btnAddStaff.TabIndex = 0;
            this.btnAddStaff.Text = "Добавить";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // richTBoxAddProduct
            // 
            this.richTBoxAddProduct.Font = new System.Drawing.Font("GOST type B", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTBoxAddProduct.Location = new System.Drawing.Point(16, 373);
            this.richTBoxAddProduct.Name = "richTBoxAddProduct";
            this.richTBoxAddProduct.Size = new System.Drawing.Size(985, 191);
            this.richTBoxAddProduct.TabIndex = 5;
            this.richTBoxAddProduct.Text = "";
            // 
            // btnCreateProject
            // 
            this.btnCreateProject.Font = new System.Drawing.Font("GOST type B", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateProject.Location = new System.Drawing.Point(838, 570);
            this.btnCreateProject.Name = "btnCreateProject";
            this.btnCreateProject.Size = new System.Drawing.Size(159, 36);
            this.btnCreateProject.TabIndex = 6;
            this.btnCreateProject.Text = "Создать проект";
            this.btnCreateProject.UseVisualStyleBackColor = true;
            this.btnCreateProject.Click += new System.EventHandler(this.btnCreateProject_Click);
            // 
            // TBoxNameProject
            // 
            this.TBoxNameProject.Font = new System.Drawing.Font("GOST type B", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBoxNameProject.Location = new System.Drawing.Point(286, 574);
            this.TBoxNameProject.Name = "TBoxNameProject";
            this.TBoxNameProject.Size = new System.Drawing.Size(546, 28);
            this.TBoxNameProject.TabIndex = 7;
            // 
            // lblNameProject
            // 
            this.lblNameProject.AutoSize = true;
            this.lblNameProject.Font = new System.Drawing.Font("GOST type B", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNameProject.Location = new System.Drawing.Point(21, 577);
            this.lblNameProject.Name = "lblNameProject";
            this.lblNameProject.Size = new System.Drawing.Size(259, 21);
            this.lblNameProject.TabIndex = 8;
            this.lblNameProject.Text = "Введите название проекта:";
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeeTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager.UpdateOrder = SampleNetPlugin.StaffDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Location = new System.Drawing.Point(838, 182);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(93, 19);
            this.lblHint.TabIndex = 10;
            this.lblHint.Text = "Подсказка!";
            // 
            // richTBoxHint
            // 
            this.richTBoxHint.Location = new System.Drawing.Point(797, 211);
            this.richTBoxHint.Name = "richTBoxHint";
            this.richTBoxHint.Size = new System.Drawing.Size(182, 104);
            this.richTBoxHint.TabIndex = 11;
            this.richTBoxHint.Text = "";
            // 
            // FormPlugin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 615);
            this.Controls.Add(this.lblNameProject);
            this.Controls.Add(this.TBoxNameProject);
            this.Controls.Add(this.btnCreateProject);
            this.Controls.Add(this.richTBoxAddProduct);
            this.Controls.Add(this.gBSelectStaff);
            this.Controls.Add(this.lblNameFile);
            this.Controls.Add(this.TBoxFileName);
            this.Controls.Add(this.btnDownloadFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormPlugin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "САПР управления данными об изделии";
            this.Load += new System.EventHandler(this.FormPlugin_Load);
            this.gBSelectStaff.ResumeLayout(false);
            this.gBSelectStaff.PerformLayout();
            this.gBSelectedEmployee.ResumeLayout(false);
            this.gBSelectedEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGvTableStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDownloadFile;
        private System.Windows.Forms.OpenFileDialog oFdDetail;
        public System.Windows.Forms.TextBox TBoxFileName;
        private System.Windows.Forms.Label lblNameFile;
        private System.Windows.Forms.GroupBox gBSelectStaff;
        private System.Windows.Forms.RichTextBox richTBoxAddProduct;
        private System.Windows.Forms.Button btnCreateProject;
        private System.Windows.Forms.DataGridView dGvTableStaff;
        private System.Windows.Forms.Button btnDeleteStaff;
        private System.Windows.Forms.Button btnChangeStaff;
        private System.Windows.Forms.Button btnAddStaff;
        public System.Windows.Forms.TextBox TBoxNameProject;
        private System.Windows.Forms.Label lblNameProject;
        private StaffDataSet1 staffDataSet1;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private StaffDataSet1TableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.GroupBox gBSelectedEmployee;
        private System.Windows.Forms.TextBox postTB;
        private System.Windows.Forms.TextBox divisionTB;
        private System.Windows.Forms.TextBox nameTB;
        private StaffDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnSelectStaff;
        private System.Windows.Forms.Button btnApplyNameObj;
        public System.Windows.Forms.TextBox TBoxNameObj;
        private System.Windows.Forms.Label lblNameObject;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn divisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.RichTextBox richTBoxHint;
    }
}