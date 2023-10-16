using System;
using System.Windows.Forms;
using System.IO;
using DataProvider;
using System.Security.Cryptography.X509Certificates;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;

namespace SampleNetPlugin
{
    public partial class FormPlugin : Form
    {
        public string nDetail;
        public int countDetail = 0;
        public List<string> Staff = new List<string>();
        public List<string> Detail = new List<string>();
        public List<string> NameObj = new List<string>();
        public List<string> FileExtension = new List<string>();
        public List<string> FilePath = new List<string>();
        public List<string> FileTempPath = new List<string>();
        public List<string> Division = new List<string>();
        
        public FormPlugin()
        {
            InitializeComponent();
            richTBoxHint.Text = "Начальный шаг!\nЗагрузите файл сборки!";
        }

        private void btnDownloadFile_Click(object sender, EventArgs e)
        {
            LoadFile(); // вызов метода для загрузки файла
        }

        public int LoadFile()
        {
            if (oFdDetail.ShowDialog() == DialogResult.OK)
            {
                TBoxFileName.Text = Path.GetFullPath(oFdDetail.FileName); // полный путь к файлу
                FilePath.Add(TBoxFileName.Text); // добавление пути в список FilePath
                FileExtension.Add(Path.GetExtension(oFdDetail.FileName)); // добавление расширения с точкой в список FileExtension
                FileTempPath.Add(Path.GetDirectoryName(oFdDetail.FileName));  // добавление пути без имени файла в список FileTempPath
                var nDetail = Path.GetFileName(oFdDetail.FileName); // присваивание переменной nDetail имени файла с расширением
                if (richTBoxAddProduct.Text == "")
                {
                    richTBoxAddProduct.Text = richTBoxAddProduct.Text += nDetail;
                    Detail.Add(nDetail);
                }
                else
                {
                    richTBoxAddProduct.Text = richTBoxAddProduct.Text += Environment.NewLine + nDetail;
                    Detail.Add(nDetail);
                }
                richTBoxHint.Text = "";
                richTBoxHint.Text = "Следующий шаг!\nВведите название объекта!";
                countDetail++;
            }
            else
                MessageBox.Show("Ошибка при загрузке объекта", "Внимание!", MessageBoxButtons.OK);
            return countDetail;
        }

        private void btnCreateProject_Click(object sender, EventArgs e)
        {
            if (TBoxNameProject.Text == "")
                MessageBox.Show("Название проекта не может быть пустым. \nВведите название проекта!", "Предупреждение!", MessageBoxButtons.OK);
            else
                Close();
        }

        private void FormPlugin_Load(object sender, EventArgs e)
        {
            this.employeeTableAdapter.Fill(this.staffDataSet1.Employee);
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            this.tableAdapterManager.EmployeeTableAdapter.InsertQuery(nameTB.Text, divisionTB.Text, postTB.Text);
            FormPlugin_Load(sender, e);
        }

        private void btnChangeStaff_Click(object sender, EventArgs e)
        {
            this.tableAdapterManager.EmployeeTableAdapter.UpdateQuery(divisionTB.Text, postTB.Text, nameTB.Text);
            FormPlugin_Load(sender, e);
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {

            this.tableAdapterManager.EmployeeTableAdapter.DeleteQuery(nameTB.Text);
            FormPlugin_Load(sender, e);
        }

        private void btnSelectStaff_Click(object sender, EventArgs e)
        {
            string staffSelect = nameTB.Text;
            string divisionSelect = divisionTB.Text;
            if (TBoxFileName.Text == "")
                MessageBox.Show("Ошибка при добавлении!", "Внимание!", MessageBoxButtons.OK);
            else
            {
                richTBoxAddProduct.Text = richTBoxAddProduct.Text += "\t\tРазработал: " + staffSelect + "\t\tПодразделение: " + divisionSelect;
                Staff.Add(staffSelect);
                Division.Add(divisionSelect);
                richTBoxHint.Text = "";
                richTBoxHint.Text = "Следующий шаг!\nВведите название проекта или загрузите следующий файл!";
            }
        }

        private void btnApplyNameObj_Click(object sender, EventArgs e)
        {
            string nameObj = TBoxNameObj.Text;
            if (TBoxNameObj.Text == "" || TBoxFileName.Text == "")
                MessageBox.Show("Ошибка при добавлении!", "Внимание!", MessageBoxButtons.OK);
            else
            {
                richTBoxAddProduct.Text = richTBoxAddProduct.Text += "\t\tОбъект: " + nameObj;
                NameObj.Add(nameObj);
                richTBoxHint.Text = "";
                richTBoxHint.Text = "Следующий шаг!\nВыберите разработчика объекта!";
            }
        }
    }
}
