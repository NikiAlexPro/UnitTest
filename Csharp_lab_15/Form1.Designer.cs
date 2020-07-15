namespace Csharp_lab_15
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxPHONE = new System.Windows.Forms.MaskedTextBox();
            this.textBoxEXP = new System.Windows.Forms.TextBox();
            this.textBoxLSTNAME = new System.Windows.Forms.TextBox();
            this.textBoxNAME = new System.Windows.Forms.TextBox();
            this.buttonTeacher = new System.Windows.Forms.Button();
            this.labelGROUP = new System.Windows.Forms.Label();
            this.comboBoxGROUP = new System.Windows.Forms.ComboBox();
            this.labelEXP = new System.Windows.Forms.Label();
            this.labelPHONE = new System.Windows.Forms.Label();
            this.labelLSTNAME = new System.Windows.Forms.Label();
            this.labelNAME = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxAnswerNumb = new System.Windows.Forms.TextBox();
            this.textBoxAnswerDepart = new System.Windows.Forms.TextBox();
            this.textBoxAnswerSpec = new System.Windows.Forms.TextBox();
            this.textBoxAnswerExp = new System.Windows.Forms.TextBox();
            this.textBoxAnswerPhone = new System.Windows.Forms.TextBox();
            this.textBoxAnswerLstName = new System.Windows.Forms.TextBox();
            this.textBoxAnswerName = new System.Windows.Forms.TextBox();
            this.labelSearchNumb = new System.Windows.Forms.Label();
            this.labelSearchDepart = new System.Windows.Forms.Label();
            this.labelSearchSPEC = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelSearchEXP = new System.Windows.Forms.Label();
            this.textBoxSearchText = new System.Windows.Forms.TextBox();
            this.labelSearchPhone = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelSearchLSTName = new System.Windows.Forms.Label();
            this.labelSearchName = new System.Windows.Forms.Label();
            this.labelSPECIALITY = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxNMB = new System.Windows.Forms.TextBox();
            this.textBoxDEPARTMENT = new System.Windows.Forms.TextBox();
            this.buttonGroup = new System.Windows.Forms.Button();
            this.textBoxSP = new System.Windows.Forms.TextBox();
            this.labelNMB = new System.Windows.Forms.Label();
            this.labelDEPARTMENT = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxPHONE);
            this.groupBox1.Controls.Add(this.textBoxEXP);
            this.groupBox1.Controls.Add(this.textBoxLSTNAME);
            this.groupBox1.Controls.Add(this.textBoxNAME);
            this.groupBox1.Controls.Add(this.buttonTeacher);
            this.groupBox1.Controls.Add(this.labelGROUP);
            this.groupBox1.Controls.Add(this.comboBoxGROUP);
            this.groupBox1.Controls.Add(this.labelEXP);
            this.groupBox1.Controls.Add(this.labelPHONE);
            this.groupBox1.Controls.Add(this.labelLSTNAME);
            this.groupBox1.Controls.Add(this.labelNAME);
            this.groupBox1.Location = new System.Drawing.Point(6, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить Преподавателя";
            // 
            // textBoxPHONE
            // 
            this.textBoxPHONE.Location = new System.Drawing.Point(122, 91);
            this.textBoxPHONE.Mask = "(999) 000-0000";
            this.textBoxPHONE.Name = "textBoxPHONE";
            this.textBoxPHONE.Size = new System.Drawing.Size(100, 20);
            this.textBoxPHONE.TabIndex = 10;
            // 
            // textBoxEXP
            // 
            this.textBoxEXP.Location = new System.Drawing.Point(122, 121);
            this.textBoxEXP.Name = "textBoxEXP";
            this.textBoxEXP.Size = new System.Drawing.Size(100, 20);
            this.textBoxEXP.TabIndex = 9;
            // 
            // textBoxLSTNAME
            // 
            this.textBoxLSTNAME.Location = new System.Drawing.Point(122, 60);
            this.textBoxLSTNAME.Name = "textBoxLSTNAME";
            this.textBoxLSTNAME.Size = new System.Drawing.Size(100, 20);
            this.textBoxLSTNAME.TabIndex = 7;
            // 
            // textBoxNAME
            // 
            this.textBoxNAME.Location = new System.Drawing.Point(122, 31);
            this.textBoxNAME.Name = "textBoxNAME";
            this.textBoxNAME.Size = new System.Drawing.Size(100, 20);
            this.textBoxNAME.TabIndex = 6;
            // 
            // buttonTeacher
            // 
            this.buttonTeacher.Location = new System.Drawing.Point(273, 145);
            this.buttonTeacher.Name = "buttonTeacher";
            this.buttonTeacher.Size = new System.Drawing.Size(75, 23);
            this.buttonTeacher.TabIndex = 5;
            this.buttonTeacher.Text = "Добавить";
            this.buttonTeacher.UseVisualStyleBackColor = true;
            this.buttonTeacher.Click += new System.EventHandler(this.buttonTeacher_Click);
            // 
            // labelGROUP
            // 
            this.labelGROUP.AutoSize = true;
            this.labelGROUP.Location = new System.Drawing.Point(17, 150);
            this.labelGROUP.Name = "labelGROUP";
            this.labelGROUP.Size = new System.Drawing.Size(42, 13);
            this.labelGROUP.TabIndex = 4;
            this.labelGROUP.Text = "Группа";
            // 
            // comboBoxGROUP
            // 
            this.comboBoxGROUP.FormattingEnabled = true;
            this.comboBoxGROUP.Location = new System.Drawing.Point(122, 147);
            this.comboBoxGROUP.Name = "comboBoxGROUP";
            this.comboBoxGROUP.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGROUP.TabIndex = 0;
            this.comboBoxGROUP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.comboBoxGROUP_MouseDown);
            // 
            // labelEXP
            // 
            this.labelEXP.AutoSize = true;
            this.labelEXP.Location = new System.Drawing.Point(19, 122);
            this.labelEXP.Name = "labelEXP";
            this.labelEXP.Size = new System.Drawing.Size(34, 13);
            this.labelEXP.TabIndex = 3;
            this.labelEXP.Text = "Опыт";
            // 
            // labelPHONE
            // 
            this.labelPHONE.AutoSize = true;
            this.labelPHONE.Location = new System.Drawing.Point(15, 91);
            this.labelPHONE.Name = "labelPHONE";
            this.labelPHONE.Size = new System.Drawing.Size(52, 13);
            this.labelPHONE.TabIndex = 2;
            this.labelPHONE.Text = "Телефон";
            // 
            // labelLSTNAME
            // 
            this.labelLSTNAME.AutoSize = true;
            this.labelLSTNAME.Location = new System.Drawing.Point(15, 60);
            this.labelLSTNAME.Name = "labelLSTNAME";
            this.labelLSTNAME.Size = new System.Drawing.Size(56, 13);
            this.labelLSTNAME.TabIndex = 1;
            this.labelLSTNAME.Text = "Фамилия";
            // 
            // labelNAME
            // 
            this.labelNAME.AutoSize = true;
            this.labelNAME.Location = new System.Drawing.Point(16, 31);
            this.labelNAME.Name = "labelNAME";
            this.labelNAME.Size = new System.Drawing.Size(29, 13);
            this.labelNAME.TabIndex = 0;
            this.labelNAME.Text = "Имя";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxAnswerNumb);
            this.groupBox2.Controls.Add(this.textBoxAnswerDepart);
            this.groupBox2.Controls.Add(this.textBoxAnswerSpec);
            this.groupBox2.Controls.Add(this.textBoxAnswerExp);
            this.groupBox2.Controls.Add(this.textBoxAnswerPhone);
            this.groupBox2.Controls.Add(this.textBoxAnswerLstName);
            this.groupBox2.Controls.Add(this.textBoxAnswerName);
            this.groupBox2.Controls.Add(this.labelSearchNumb);
            this.groupBox2.Controls.Add(this.labelSearchDepart);
            this.groupBox2.Controls.Add(this.labelSearchSPEC);
            this.groupBox2.Controls.Add(this.buttonSearch);
            this.groupBox2.Controls.Add(this.labelSearchEXP);
            this.groupBox2.Controls.Add(this.textBoxSearchText);
            this.groupBox2.Controls.Add(this.labelSearchPhone);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.labelSearchLSTName);
            this.groupBox2.Controls.Add(this.labelSearchName);
            this.groupBox2.Location = new System.Drawing.Point(401, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(381, 321);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Найти Преподавателя";
            // 
            // textBoxAnswerNumb
            // 
            this.textBoxAnswerNumb.Location = new System.Drawing.Point(136, 241);
            this.textBoxAnswerNumb.Name = "textBoxAnswerNumb";
            this.textBoxAnswerNumb.ReadOnly = true;
            this.textBoxAnswerNumb.Size = new System.Drawing.Size(100, 20);
            this.textBoxAnswerNumb.TabIndex = 25;
            // 
            // textBoxAnswerDepart
            // 
            this.textBoxAnswerDepart.Location = new System.Drawing.Point(136, 211);
            this.textBoxAnswerDepart.Name = "textBoxAnswerDepart";
            this.textBoxAnswerDepart.ReadOnly = true;
            this.textBoxAnswerDepart.Size = new System.Drawing.Size(100, 20);
            this.textBoxAnswerDepart.TabIndex = 24;
            // 
            // textBoxAnswerSpec
            // 
            this.textBoxAnswerSpec.Location = new System.Drawing.Point(136, 179);
            this.textBoxAnswerSpec.Name = "textBoxAnswerSpec";
            this.textBoxAnswerSpec.ReadOnly = true;
            this.textBoxAnswerSpec.Size = new System.Drawing.Size(100, 20);
            this.textBoxAnswerSpec.TabIndex = 23;
            // 
            // textBoxAnswerExp
            // 
            this.textBoxAnswerExp.Location = new System.Drawing.Point(136, 147);
            this.textBoxAnswerExp.Name = "textBoxAnswerExp";
            this.textBoxAnswerExp.ReadOnly = true;
            this.textBoxAnswerExp.Size = new System.Drawing.Size(100, 20);
            this.textBoxAnswerExp.TabIndex = 21;
            // 
            // textBoxAnswerPhone
            // 
            this.textBoxAnswerPhone.Location = new System.Drawing.Point(136, 116);
            this.textBoxAnswerPhone.Name = "textBoxAnswerPhone";
            this.textBoxAnswerPhone.ReadOnly = true;
            this.textBoxAnswerPhone.Size = new System.Drawing.Size(100, 20);
            this.textBoxAnswerPhone.TabIndex = 20;
            // 
            // textBoxAnswerLstName
            // 
            this.textBoxAnswerLstName.Location = new System.Drawing.Point(136, 85);
            this.textBoxAnswerLstName.Name = "textBoxAnswerLstName";
            this.textBoxAnswerLstName.ReadOnly = true;
            this.textBoxAnswerLstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxAnswerLstName.TabIndex = 19;
            // 
            // textBoxAnswerName
            // 
            this.textBoxAnswerName.Location = new System.Drawing.Point(136, 53);
            this.textBoxAnswerName.Name = "textBoxAnswerName";
            this.textBoxAnswerName.ReadOnly = true;
            this.textBoxAnswerName.Size = new System.Drawing.Size(100, 20);
            this.textBoxAnswerName.TabIndex = 18;
            // 
            // labelSearchNumb
            // 
            this.labelSearchNumb.AutoSize = true;
            this.labelSearchNumb.Location = new System.Drawing.Point(26, 241);
            this.labelSearchNumb.Name = "labelSearchNumb";
            this.labelSearchNumb.Size = new System.Drawing.Size(101, 13);
            this.labelSearchNumb.TabIndex = 17;
            this.labelSearchNumb.Text = "Кол - во студентов";
            // 
            // labelSearchDepart
            // 
            this.labelSearchDepart.AutoSize = true;
            this.labelSearchDepart.Location = new System.Drawing.Point(26, 211);
            this.labelSearchDepart.Name = "labelSearchDepart";
            this.labelSearchDepart.Size = new System.Drawing.Size(52, 13);
            this.labelSearchDepart.TabIndex = 16;
            this.labelSearchDepart.Text = "Кафедра";
            // 
            // labelSearchSPEC
            // 
            this.labelSearchSPEC.AutoSize = true;
            this.labelSearchSPEC.Location = new System.Drawing.Point(26, 179);
            this.labelSearchSPEC.Name = "labelSearchSPEC";
            this.labelSearchSPEC.Size = new System.Drawing.Size(85, 13);
            this.labelSearchSPEC.TabIndex = 15;
            this.labelSearchSPEC.Text = "Специальность";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(276, 20);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Найти";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelSearchEXP
            // 
            this.labelSearchEXP.AutoSize = true;
            this.labelSearchEXP.Location = new System.Drawing.Point(26, 147);
            this.labelSearchEXP.Name = "labelSearchEXP";
            this.labelSearchEXP.Size = new System.Drawing.Size(34, 13);
            this.labelSearchEXP.TabIndex = 13;
            this.labelSearchEXP.Text = "Опыт";
            // 
            // textBoxSearchText
            // 
            this.textBoxSearchText.Location = new System.Drawing.Point(122, 20);
            this.textBoxSearchText.Name = "textBoxSearchText";
            this.textBoxSearchText.Size = new System.Drawing.Size(137, 20);
            this.textBoxSearchText.TabIndex = 2;
            // 
            // labelSearchPhone
            // 
            this.labelSearchPhone.AutoSize = true;
            this.labelSearchPhone.Location = new System.Drawing.Point(22, 116);
            this.labelSearchPhone.Name = "labelSearchPhone";
            this.labelSearchPhone.Size = new System.Drawing.Size(52, 13);
            this.labelSearchPhone.TabIndex = 12;
            this.labelSearchPhone.Text = "Телефон";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Имя преподавателя";
            // 
            // labelSearchLSTName
            // 
            this.labelSearchLSTName.AutoSize = true;
            this.labelSearchLSTName.Location = new System.Drawing.Point(22, 85);
            this.labelSearchLSTName.Name = "labelSearchLSTName";
            this.labelSearchLSTName.Size = new System.Drawing.Size(56, 13);
            this.labelSearchLSTName.TabIndex = 11;
            this.labelSearchLSTName.Text = "Фамилия";
            // 
            // labelSearchName
            // 
            this.labelSearchName.AutoSize = true;
            this.labelSearchName.Location = new System.Drawing.Point(23, 56);
            this.labelSearchName.Name = "labelSearchName";
            this.labelSearchName.Size = new System.Drawing.Size(29, 13);
            this.labelSearchName.TabIndex = 10;
            this.labelSearchName.Text = "Имя";
            // 
            // labelSPECIALITY
            // 
            this.labelSPECIALITY.AutoSize = true;
            this.labelSPECIALITY.Location = new System.Drawing.Point(17, 35);
            this.labelSPECIALITY.Name = "labelSPECIALITY";
            this.labelSPECIALITY.Size = new System.Drawing.Size(85, 13);
            this.labelSPECIALITY.TabIndex = 4;
            this.labelSPECIALITY.Text = "Специальность";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxNMB);
            this.groupBox3.Controls.Add(this.textBoxDEPARTMENT);
            this.groupBox3.Controls.Add(this.buttonGroup);
            this.groupBox3.Controls.Add(this.textBoxSP);
            this.groupBox3.Controls.Add(this.labelNMB);
            this.groupBox3.Controls.Add(this.labelDEPARTMENT);
            this.groupBox3.Controls.Add(this.labelSPECIALITY);
            this.groupBox3.Location = new System.Drawing.Point(6, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(383, 126);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Добавить Группу";
            // 
            // textBoxNMB
            // 
            this.textBoxNMB.Location = new System.Drawing.Point(122, 95);
            this.textBoxNMB.Name = "textBoxNMB";
            this.textBoxNMB.Size = new System.Drawing.Size(100, 20);
            this.textBoxNMB.TabIndex = 10;
            // 
            // textBoxDEPARTMENT
            // 
            this.textBoxDEPARTMENT.Location = new System.Drawing.Point(122, 65);
            this.textBoxDEPARTMENT.Name = "textBoxDEPARTMENT";
            this.textBoxDEPARTMENT.Size = new System.Drawing.Size(100, 20);
            this.textBoxDEPARTMENT.TabIndex = 9;
            // 
            // buttonGroup
            // 
            this.buttonGroup.Location = new System.Drawing.Point(273, 91);
            this.buttonGroup.Name = "buttonGroup";
            this.buttonGroup.Size = new System.Drawing.Size(75, 23);
            this.buttonGroup.TabIndex = 8;
            this.buttonGroup.Text = "Добавить";
            this.buttonGroup.UseVisualStyleBackColor = true;
            this.buttonGroup.Click += new System.EventHandler(this.buttonGroup_Click);
            // 
            // textBoxSP
            // 
            this.textBoxSP.Location = new System.Drawing.Point(122, 35);
            this.textBoxSP.Name = "textBoxSP";
            this.textBoxSP.Size = new System.Drawing.Size(100, 20);
            this.textBoxSP.TabIndex = 7;
            // 
            // labelNMB
            // 
            this.labelNMB.AutoSize = true;
            this.labelNMB.Location = new System.Drawing.Point(17, 97);
            this.labelNMB.Name = "labelNMB";
            this.labelNMB.Size = new System.Drawing.Size(101, 13);
            this.labelNMB.TabIndex = 6;
            this.labelNMB.Text = "Кол - во студентов";
            // 
            // labelDEPARTMENT
            // 
            this.labelDEPARTMENT.AutoSize = true;
            this.labelDEPARTMENT.Location = new System.Drawing.Point(17, 67);
            this.labelDEPARTMENT.Name = "labelDEPARTMENT";
            this.labelDEPARTMENT.Size = new System.Drawing.Size(52, 13);
            this.labelDEPARTMENT.TabIndex = 5;
            this.labelDEPARTMENT.Text = "Кафедра";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 334);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelNMB;
        private System.Windows.Forms.Label labelDEPARTMENT;
        private System.Windows.Forms.Label labelSPECIALITY;
        private System.Windows.Forms.Label labelEXP;
        private System.Windows.Forms.Label labelPHONE;
        private System.Windows.Forms.Label labelLSTNAME;
        private System.Windows.Forms.Label labelNAME;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxGROUP;
        private System.Windows.Forms.TextBox textBoxEXP;
        private System.Windows.Forms.TextBox textBoxLSTNAME;
        private System.Windows.Forms.TextBox textBoxNAME;
        private System.Windows.Forms.Button buttonTeacher;
        private System.Windows.Forms.Label labelGROUP;
        private System.Windows.Forms.TextBox textBoxSearchText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxNMB;
        private System.Windows.Forms.TextBox textBoxDEPARTMENT;
        private System.Windows.Forms.Button buttonGroup;
        private System.Windows.Forms.TextBox textBoxSP;
        private System.Windows.Forms.Label labelSearchNumb;
        private System.Windows.Forms.Label labelSearchDepart;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelSearchEXP;
        private System.Windows.Forms.Label labelSearchPhone;
        private System.Windows.Forms.Label labelSearchLSTName;
        private System.Windows.Forms.Label labelSearchName;
        private System.Windows.Forms.TextBox textBoxAnswerNumb;
        private System.Windows.Forms.TextBox textBoxAnswerDepart;
        private System.Windows.Forms.TextBox textBoxAnswerExp;
        private System.Windows.Forms.TextBox textBoxAnswerPhone;
        private System.Windows.Forms.TextBox textBoxAnswerLstName;
        private System.Windows.Forms.TextBox textBoxAnswerName;
        private System.Windows.Forms.TextBox textBoxAnswerSpec;
        private System.Windows.Forms.Label labelSearchSPEC;
        private System.Windows.Forms.MaskedTextBox textBoxPHONE;
    }
}

