using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



//
//
//
// Тестирование ПО. Лабораторная 15
//
//
//


namespace Csharp_lab_15
{
    public partial class Form1 : Form
    {

        /*ModelTeachers modelTeacher = new ModelTeachers();
        List<Group> Groups
        {
            get
            {
                try
                {
                    return modelTeacher.Groups.ToList();
                }
                catch
                {
                    MessageBox.Show("Не удалось подключить коллекцию Group. Проверьте подключение к БД.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return new List<Group>();
                }
                
            }
        }*/
        List<Group> Groups = new List<Group>();

        Group groupAdd = new Group();

        public Form1()
        {
            InitializeComponent();

            try
            {
                Groups = Mock.DownloadMock.GetGroups();
                comboBoxGROUP.DataSource = Groups;
            }
            catch(Exception)
            {
                MessageBox.Show("Ошибка при загрузке групп");
                return;
            }
            //Mock.AddTeacherMock
            //comboBoxGROUP.DataSource = Groups;
        }


        //========================================================================================
        //Добавление учителя
        private void buttonTeacher_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher { Group = new Group() };
            var gr = Groups[comboBoxGROUP.SelectedIndex];
            teacher.Group = gr;
            //teacher.special = gr.special;
            try
            {
                Mock.AddTeacherMock.AddTeacher(textBoxNAME.Text, textBoxLSTNAME.Text, textBoxPHONE.Text, textBoxEXP.Text, gr.special, gr.department, gr.nmb);

            }
            catch(Exception)
            {
                MessageBox.Show("Ошибка при добавлении учителя");
            }

            /*Teacher teacher = new Teacher { Group = new Group() };
            teacher.first_name = textBoxNAME.Text;
            teacher.last_name = textBoxLSTNAME.Text;
            teacher.phone = textBoxPHONE.Text;
            teacher.exp = textBoxEXP.Text;

            if (comboBoxGROUP.SelectedIndex < 0)
            {
                throw new Exception("Загрузка группы не удалась");
            }

            var gr = Groups[comboBoxGROUP.SelectedIndex];
            teacher.Group = gr;
            teacher.special = gr.special;

            var forbiddenCharacters = new char[] { '@', '#', '%', '$', '&', '*' };

            //Проверка на заполнение полей
            if (string.IsNullOrWhiteSpace(teacher.first_name)
                || string.IsNullOrWhiteSpace(teacher.last_name)
                || string.IsNullOrWhiteSpace(teacher.exp)
                )
            {
                MessageBox.Show($"Заполните все поля группы!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Проверка для поля First_name
            if (teacher.first_name.Any(x => forbiddenCharacters.Contains(x))
                )
            {
                MessageBox.Show($"{teacher.first_name} - некорректный ввод", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Проверка для поля Last_name
            if (teacher.last_name.Any(x => forbiddenCharacters.Contains(x))
                )
            {
                MessageBox.Show($"{teacher.last_name} - некорректный ввод", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Проверка для поля Exp
            if (teacher.exp.Any(x => forbiddenCharacters.Contains(x))
                )
            {
                MessageBox.Show($"{teacher.exp} - некорректный ввод", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            //Запись в БД
            try
            {
                modelTeacher.Teachers.Add(teacher);
                modelTeacher.SaveChanges();
                MessageBox.Show("Преподаватель добавлен в БД", "База Данных", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("Не удалось выполнить запись преподавателя в БД. Проверьте вводимые данные и подключение к БД.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            textBoxNAME.Text = " ";
            textBoxLSTNAME.Text = " ";
            textBoxPHONE.Text = " ";
            textBoxEXP.Text = " ";

            //IObservableColletion!!!!*/

        }


        //========================================================================================
        //Поиск Преподавателя
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var teacher = Mock.SearchMock.GetTeacher(textBoxSearchText.Text);
                if(teacher != null)
                {
                    textBoxAnswerName.Text = teacher.first_name;
                    textBoxAnswerLstName.Text = teacher.last_name;
                    textBoxAnswerPhone.Text = teacher.phone;
                    textBoxAnswerExp.Text = teacher.exp;
                    textBoxAnswerSpec.Text = teacher.Group.special;
                    textBoxAnswerDepart.Text = teacher.Group.department;
                    textBoxAnswerNumb.Text = Convert.ToString(teacher.Group.nmb);
                }
                else
                {
                    MessageBox.Show("Книга не найдена");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Во время поиска произошла ошибка");
            }

            /*
            var forbiddenCharacters = new char[] { '@', '#', '%', '$', '&', '*' };

          
            //поиск
            string searchname = textBoxSearchText.Text;

            //Проверка для поля First_name
            if (string.IsNullOrWhiteSpace(searchname) 
                || searchname == "@"
                || searchname == "#"
                || searchname == "%"
                || searchname == "$"
                || searchname == "&"
                || searchname == "*")
            {
                MessageBox.Show($"{searchname} - некорректный ввод в поле поиска", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            try
            {
                //поиск похожего имени в БД
                var teach = modelTeacher.Teachers.FirstOrDefault(b => b.first_name.Contains(searchname));
                textBoxAnswerName.Text = teach.first_name;
                textBoxAnswerLstName.Text = teach.last_name;
                textBoxAnswerPhone.Text = teach.phone;
                textBoxAnswerExp.Text = teach.exp;
                textBoxAnswerSpec.Text = teach.Group.special;
                textBoxAnswerDepart.Text = teach.Group.department;
                textBoxAnswerNumb.Text = Convert.ToString(teach.Group.nmb);
            }
            catch
            {
                MessageBox.Show("Не удалось выполнить поиск преподавателя в БД. Проверьте подключение к БД.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            */

        }

        
        //========================================================================================
        //Добавление группы
        private void buttonGroup_Click(object sender, EventArgs e)
        { 
            groupAdd = new Group
            {
                department = textBoxDEPARTMENT.Text ?? "",
                nmb = Int32.TryParse(textBoxNMB.Text, out int result) ? result : 0,
                special = textBoxSP.Text ?? ""
            };

            /*
            //Проверка на заполнение полей
            if (string.IsNullOrWhiteSpace(groupAdd.department)
                || string.IsNullOrWhiteSpace(groupAdd.special)
                || string.IsNullOrWhiteSpace(Convert.ToString(groupAdd.nmb)))
            {
                MessageBox.Show($"Заполните все поля группы!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Массив недопустимых символов
            var forbiddenCharacters = new char[] { '@', '#', '%', '$', '&', '*' };
            
            //Проверка для поля Special
            if (groupAdd.special.Any(x => forbiddenCharacters.Contains(x)))
            {
                MessageBox.Show($"{groupAdd.special} - некорректный ввод", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Проверка для поля Department
            if (groupAdd.department.Any(x => forbiddenCharacters.Contains(x)))
            {
                MessageBox.Show($"{groupAdd.department} - некорректный ввод", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Проверка для поля numberOfStudents
            if (groupAdd.nmb == '@' 
                || groupAdd.nmb == '#' 
                || groupAdd.nmb == '%' 
                || groupAdd.nmb == '$' 
                || groupAdd.nmb == '&' 
                || groupAdd.nmb == '*')
            {
                MessageBox.Show("Кол-во студентов - некорректный ввод", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            

            

            try
            {
                //Проверка на наличие похожего объекта в БД
                if (modelTeacher.Groups.Find(groupAdd.special) != null)
                {
                    MessageBox.Show($"Группа {groupAdd.special} уже добавлена!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Запись в БД
                modelTeacher.Groups.Add(groupAdd);
                modelTeacher.SaveChanges();

                MessageBox.Show("Группа добавлена в БД", "База Данных", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Не удалось выполнить запись группы в БД. Проверьте подключение к БД.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            textBoxDEPARTMENT.Text = " ";
            textBoxNMB.Text = " ";
            textBoxSP.Text = " ";
            */
        }

        private void comboBoxGROUP_MouseDown(object sender, MouseEventArgs e)
        {
            ComboBox groupsBox = sender as ComboBox;
            groupsBox.DataSource = Groups;
        }

    }
}
