namespace WindowsFormsApp2.Forms
{
    partial class AdminDashboard
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
            this.PridetiNaudotoja = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.StudentoPanele = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AtsauktiConfirm = new System.Windows.Forms.Button();
            this.PridetiConfirm = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.GrupesPasirinkimas = new System.Windows.Forms.ComboBox();
            this.StudentoPavarde = new System.Windows.Forms.TextBox();
            this.StudentoVardas = new System.Windows.Forms.TextBox();
            this.DestytojoPanele = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.AtsauktiConfirm1 = new System.Windows.Forms.Button();
            this.DestytojoPatvirtinimoMygtukas = new System.Windows.Forms.Button();
            this.DestytojoPavarde = new System.Windows.Forms.TextBox();
            this.DestytojoVardas = new System.Windows.Forms.TextBox();
            this.AdminPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.AtsauktiConfirm2 = new System.Windows.Forms.Button();
            this.AdminoPatvirtinimoMygtukas = new System.Windows.Forms.Button();
            this.AdminoPavarde = new System.Windows.Forms.TextBox();
            this.AdminoVardas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GrupiuPanele = new System.Windows.Forms.Panel();
            this.MoveToRedactionForm = new System.Windows.Forms.Button();
            this.IstrintiGrupe = new System.Windows.Forms.Button();
            this.GrupesPasirinkimas3 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SukurtiGrupe = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.GrupesPavadinimas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.GrupiuPaneleAtsaukti = new System.Windows.Forms.Button();
            this.GrupiuPanelePatvirtinti = new System.Windows.Forms.Button();
            this.comboBoxGroupsCourses = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DalykuPanele = new System.Windows.Forms.Panel();
            this.SukurtiDalyka = new System.Windows.Forms.Button();
            this.DestytojuPasirinkimas = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.DalykoPavadinimas = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DalykuPaneleAtsaukti = new System.Windows.Forms.Button();
            this.DalykuPanelePatvirtinti = new System.Windows.Forms.Button();
            this.btnIstrintiDalyka = new System.Windows.Forms.Button();
            this.comboBoxIstrintiDalyka = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.StudentoPanele.SuspendLayout();
            this.DestytojoPanele.SuspendLayout();
            this.AdminPanel.SuspendLayout();
            this.GrupiuPanele.SuspendLayout();
            this.DalykuPanele.SuspendLayout();
            this.SuspendLayout();
            // 
            // PridetiNaudotoja
            // 
            this.PridetiNaudotoja.AutoSize = true;
            this.PridetiNaudotoja.Location = new System.Drawing.Point(27, 54);
            this.PridetiNaudotoja.Name = "PridetiNaudotoja";
            this.PridetiNaudotoja.Size = new System.Drawing.Size(86, 13);
            this.PridetiNaudotoja.TabIndex = 0;
            this.PridetiNaudotoja.Text = "Prideti naudotoja";
            this.PridetiNaudotoja.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(30, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // StudentoPanele
            // 
            this.StudentoPanele.BackColor = System.Drawing.SystemColors.ControlDark;
            this.StudentoPanele.Controls.Add(this.label6);
            this.StudentoPanele.Controls.Add(this.label5);
            this.StudentoPanele.Controls.Add(this.label2);
            this.StudentoPanele.Controls.Add(this.AtsauktiConfirm);
            this.StudentoPanele.Controls.Add(this.PridetiConfirm);
            this.StudentoPanele.Controls.Add(this.dateTimePicker1);
            this.StudentoPanele.Controls.Add(this.GrupesPasirinkimas);
            this.StudentoPanele.Controls.Add(this.StudentoPavarde);
            this.StudentoPanele.Controls.Add(this.StudentoVardas);
            this.StudentoPanele.Location = new System.Drawing.Point(30, 97);
            this.StudentoPanele.Name = "StudentoPanele";
            this.StudentoPanele.Size = new System.Drawing.Size(223, 311);
            this.StudentoPanele.TabIndex = 4;
            this.StudentoPanele.Paint += new System.Windows.Forms.PaintEventHandler(this.StudentoPanele_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Grupes priskirimas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Istojimo data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Prideti nauja studenta";
            // 
            // AtsauktiConfirm
            // 
            this.AtsauktiConfirm.Location = new System.Drawing.Point(10, 276);
            this.AtsauktiConfirm.Name = "AtsauktiConfirm";
            this.AtsauktiConfirm.Size = new System.Drawing.Size(93, 23);
            this.AtsauktiConfirm.TabIndex = 5;
            this.AtsauktiConfirm.Text = "Atsaukti";
            this.AtsauktiConfirm.UseVisualStyleBackColor = true;
            this.AtsauktiConfirm.Click += new System.EventHandler(this.AtsauktiConfirm_Click);
            // 
            // PridetiConfirm
            // 
            this.PridetiConfirm.Location = new System.Drawing.Point(117, 276);
            this.PridetiConfirm.Name = "PridetiConfirm";
            this.PridetiConfirm.Size = new System.Drawing.Size(93, 23);
            this.PridetiConfirm.TabIndex = 4;
            this.PridetiConfirm.Text = "Patvirtinti";
            this.PridetiConfirm.UseVisualStyleBackColor = true;
            this.PridetiConfirm.Click += new System.EventHandler(this.PridetiConfirm_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(10, 173);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // GrupesPasirinkimas
            // 
            this.GrupesPasirinkimas.FormattingEnabled = true;
            this.GrupesPasirinkimas.Location = new System.Drawing.Point(10, 120);
            this.GrupesPasirinkimas.Name = "GrupesPasirinkimas";
            this.GrupesPasirinkimas.Size = new System.Drawing.Size(200, 21);
            this.GrupesPasirinkimas.TabIndex = 2;
            this.GrupesPasirinkimas.Text = "Grupe";
            this.GrupesPasirinkimas.SelectedIndexChanged += new System.EventHandler(this.GrupesPasirinkimas_SelectedIndexChanged);
            // 
            // StudentoPavarde
            // 
            this.StudentoPavarde.Location = new System.Drawing.Point(10, 66);
            this.StudentoPavarde.Name = "StudentoPavarde";
            this.StudentoPavarde.Size = new System.Drawing.Size(200, 20);
            this.StudentoPavarde.TabIndex = 1;
            this.StudentoPavarde.Text = "Pavarde";
            this.StudentoPavarde.TextChanged += new System.EventHandler(this.StudentoPavarde_TextChanged);
            // 
            // StudentoVardas
            // 
            this.StudentoVardas.Location = new System.Drawing.Point(10, 39);
            this.StudentoVardas.Name = "StudentoVardas";
            this.StudentoVardas.Size = new System.Drawing.Size(200, 20);
            this.StudentoVardas.TabIndex = 0;
            this.StudentoVardas.Text = "Vardas";
            this.StudentoVardas.TextChanged += new System.EventHandler(this.StudentoVardas_TextChanged);
            // 
            // DestytojoPanele
            // 
            this.DestytojoPanele.BackColor = System.Drawing.SystemColors.ControlDark;
            this.DestytojoPanele.Controls.Add(this.label3);
            this.DestytojoPanele.Controls.Add(this.AtsauktiConfirm1);
            this.DestytojoPanele.Controls.Add(this.DestytojoPatvirtinimoMygtukas);
            this.DestytojoPanele.Controls.Add(this.DestytojoPavarde);
            this.DestytojoPanele.Controls.Add(this.DestytojoVardas);
            this.DestytojoPanele.Location = new System.Drawing.Point(30, 97);
            this.DestytojoPanele.Name = "DestytojoPanele";
            this.DestytojoPanele.Size = new System.Drawing.Size(223, 311);
            this.DestytojoPanele.TabIndex = 6;
            this.DestytojoPanele.Paint += new System.Windows.Forms.PaintEventHandler(this.DestytojoPanele_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Prideti nauja destytoja";
            // 
            // AtsauktiConfirm1
            // 
            this.AtsauktiConfirm1.Location = new System.Drawing.Point(10, 276);
            this.AtsauktiConfirm1.Name = "AtsauktiConfirm1";
            this.AtsauktiConfirm1.Size = new System.Drawing.Size(93, 23);
            this.AtsauktiConfirm1.TabIndex = 5;
            this.AtsauktiConfirm1.Text = "Atsaukti";
            this.AtsauktiConfirm1.UseVisualStyleBackColor = true;
            this.AtsauktiConfirm1.Click += new System.EventHandler(this.AtsauktiConfirm1_Click);
            // 
            // DestytojoPatvirtinimoMygtukas
            // 
            this.DestytojoPatvirtinimoMygtukas.Location = new System.Drawing.Point(117, 276);
            this.DestytojoPatvirtinimoMygtukas.Name = "DestytojoPatvirtinimoMygtukas";
            this.DestytojoPatvirtinimoMygtukas.Size = new System.Drawing.Size(93, 23);
            this.DestytojoPatvirtinimoMygtukas.TabIndex = 4;
            this.DestytojoPatvirtinimoMygtukas.Text = "Patvirtinti";
            this.DestytojoPatvirtinimoMygtukas.UseVisualStyleBackColor = true;
            this.DestytojoPatvirtinimoMygtukas.Click += new System.EventHandler(this.DestytojoPatvirtinimoMygtukas_Click);
            // 
            // DestytojoPavarde
            // 
            this.DestytojoPavarde.Location = new System.Drawing.Point(10, 66);
            this.DestytojoPavarde.Name = "DestytojoPavarde";
            this.DestytojoPavarde.Size = new System.Drawing.Size(200, 20);
            this.DestytojoPavarde.TabIndex = 1;
            this.DestytojoPavarde.Text = "Pavarde";
            // 
            // DestytojoVardas
            // 
            this.DestytojoVardas.Location = new System.Drawing.Point(10, 39);
            this.DestytojoVardas.Name = "DestytojoVardas";
            this.DestytojoVardas.Size = new System.Drawing.Size(200, 20);
            this.DestytojoVardas.TabIndex = 0;
            this.DestytojoVardas.Text = "Vardas";
            // 
            // AdminPanel
            // 
            this.AdminPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.AdminPanel.Controls.Add(this.label4);
            this.AdminPanel.Controls.Add(this.AtsauktiConfirm2);
            this.AdminPanel.Controls.Add(this.AdminoPatvirtinimoMygtukas);
            this.AdminPanel.Controls.Add(this.AdminoPavarde);
            this.AdminPanel.Controls.Add(this.AdminoVardas);
            this.AdminPanel.Location = new System.Drawing.Point(30, 97);
            this.AdminPanel.Name = "AdminPanel";
            this.AdminPanel.Size = new System.Drawing.Size(223, 311);
            this.AdminPanel.TabIndex = 7;
            this.AdminPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.AdminPanel_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Prideti nauja administratoriu";
            // 
            // AtsauktiConfirm2
            // 
            this.AtsauktiConfirm2.Location = new System.Drawing.Point(10, 276);
            this.AtsauktiConfirm2.Name = "AtsauktiConfirm2";
            this.AtsauktiConfirm2.Size = new System.Drawing.Size(93, 23);
            this.AtsauktiConfirm2.TabIndex = 5;
            this.AtsauktiConfirm2.Text = "Atsaukti";
            this.AtsauktiConfirm2.UseVisualStyleBackColor = true;
            this.AtsauktiConfirm2.Click += new System.EventHandler(this.AtsauktiConfirm2_Click);
            // 
            // AdminoPatvirtinimoMygtukas
            // 
            this.AdminoPatvirtinimoMygtukas.Location = new System.Drawing.Point(117, 276);
            this.AdminoPatvirtinimoMygtukas.Name = "AdminoPatvirtinimoMygtukas";
            this.AdminoPatvirtinimoMygtukas.Size = new System.Drawing.Size(93, 23);
            this.AdminoPatvirtinimoMygtukas.TabIndex = 4;
            this.AdminoPatvirtinimoMygtukas.Text = "Patvirtinti";
            this.AdminoPatvirtinimoMygtukas.UseVisualStyleBackColor = true;
            this.AdminoPatvirtinimoMygtukas.Click += new System.EventHandler(this.AdminoPatvirtinimoMygtukas_Click);
            // 
            // AdminoPavarde
            // 
            this.AdminoPavarde.Location = new System.Drawing.Point(10, 66);
            this.AdminoPavarde.Name = "AdminoPavarde";
            this.AdminoPavarde.Size = new System.Drawing.Size(200, 20);
            this.AdminoPavarde.TabIndex = 1;
            this.AdminoPavarde.Text = "Pavarde";
            this.AdminoPavarde.TextChanged += new System.EventHandler(this.AdminoPavarde_TextChanged);
            // 
            // AdminoVardas
            // 
            this.AdminoVardas.Location = new System.Drawing.Point(10, 39);
            this.AdminoVardas.Name = "AdminoVardas";
            this.AdminoVardas.Size = new System.Drawing.Size(200, 20);
            this.AdminoVardas.TabIndex = 0;
            this.AdminoVardas.Text = "Vardas";
            this.AdminoVardas.TextChanged += new System.EventHandler(this.AdminoVardas_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "AdminDashboard";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // GrupiuPanele
            // 
            this.GrupiuPanele.BackColor = System.Drawing.SystemColors.ControlDark;
            this.GrupiuPanele.Controls.Add(this.MoveToRedactionForm);
            this.GrupiuPanele.Controls.Add(this.IstrintiGrupe);
            this.GrupiuPanele.Controls.Add(this.GrupesPasirinkimas3);
            this.GrupiuPanele.Controls.Add(this.label12);
            this.GrupiuPanele.Controls.Add(this.label11);
            this.GrupiuPanele.Controls.Add(this.SukurtiGrupe);
            this.GrupiuPanele.Controls.Add(this.label10);
            this.GrupiuPanele.Controls.Add(this.GrupesPavadinimas);
            this.GrupiuPanele.Controls.Add(this.label7);
            this.GrupiuPanele.Controls.Add(this.GrupiuPaneleAtsaukti);
            this.GrupiuPanele.Controls.Add(this.GrupiuPanelePatvirtinti);
            this.GrupiuPanele.Location = new System.Drawing.Point(273, 97);
            this.GrupiuPanele.Name = "GrupiuPanele";
            this.GrupiuPanele.Size = new System.Drawing.Size(223, 311);
            this.GrupiuPanele.TabIndex = 9;
            this.GrupiuPanele.Paint += new System.Windows.Forms.PaintEventHandler(this.GrupiuPanele_Paint);
            // 
            // MoveToRedactionForm
            // 
            this.MoveToRedactionForm.Location = new System.Drawing.Point(10, 117);
            this.MoveToRedactionForm.Name = "MoveToRedactionForm";
            this.MoveToRedactionForm.Size = new System.Drawing.Size(200, 23);
            this.MoveToRedactionForm.TabIndex = 19;
            this.MoveToRedactionForm.Text = "Redaguoti";
            this.MoveToRedactionForm.UseVisualStyleBackColor = true;
            this.MoveToRedactionForm.Click += new System.EventHandler(this.MoveToRedactionForm_Click);
            // 
            // IstrintiGrupe
            // 
            this.IstrintiGrupe.Location = new System.Drawing.Point(135, 199);
            this.IstrintiGrupe.Name = "IstrintiGrupe";
            this.IstrintiGrupe.Size = new System.Drawing.Size(75, 23);
            this.IstrintiGrupe.TabIndex = 18;
            this.IstrintiGrupe.Text = "Istrinti";
            this.IstrintiGrupe.UseVisualStyleBackColor = true;
            this.IstrintiGrupe.Click += new System.EventHandler(this.IstrintiGrupe_Click);
            // 
            // GrupesPasirinkimas3
            // 
            this.GrupesPasirinkimas3.FormattingEnabled = true;
            this.GrupesPasirinkimas3.Location = new System.Drawing.Point(10, 172);
            this.GrupesPasirinkimas3.Name = "GrupesPasirinkimas3";
            this.GrupesPasirinkimas3.Size = new System.Drawing.Size(200, 21);
            this.GrupesPasirinkimas3.TabIndex = 17;
            this.GrupesPasirinkimas3.Text = "Pasirinkite grupe";
            this.GrupesPasirinkimas3.SelectedIndexChanged += new System.EventHandler(this.GrupesPasirinkimas3_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 157);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Istrinti grupe";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Studentu priskirimas ir salinimas";
            // 
            // SukurtiGrupe
            // 
            this.SukurtiGrupe.Location = new System.Drawing.Point(135, 78);
            this.SukurtiGrupe.Name = "SukurtiGrupe";
            this.SukurtiGrupe.Size = new System.Drawing.Size(75, 23);
            this.SukurtiGrupe.TabIndex = 12;
            this.SukurtiGrupe.Text = "Sukurti";
            this.SukurtiGrupe.UseVisualStyleBackColor = true;
            this.SukurtiGrupe.Click += new System.EventHandler(this.SukurtiGrupe_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Sukurti nauja grupe";
            // 
            // GrupesPavadinimas
            // 
            this.GrupesPavadinimas.Location = new System.Drawing.Point(10, 55);
            this.GrupesPavadinimas.Name = "GrupesPavadinimas";
            this.GrupesPavadinimas.Size = new System.Drawing.Size(200, 20);
            this.GrupesPavadinimas.TabIndex = 9;
            this.GrupesPavadinimas.Text = "Grupes pavadinimas";
            this.GrupesPavadinimas.TextChanged += new System.EventHandler(this.GrupesPavadinimas_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Grupiu redagavimas";
            // 
            // GrupiuPaneleAtsaukti
            // 
            this.GrupiuPaneleAtsaukti.Location = new System.Drawing.Point(10, 276);
            this.GrupiuPaneleAtsaukti.Name = "GrupiuPaneleAtsaukti";
            this.GrupiuPaneleAtsaukti.Size = new System.Drawing.Size(93, 23);
            this.GrupiuPaneleAtsaukti.TabIndex = 5;
            this.GrupiuPaneleAtsaukti.Text = "Atsaukti";
            this.GrupiuPaneleAtsaukti.UseVisualStyleBackColor = true;
            this.GrupiuPaneleAtsaukti.Click += new System.EventHandler(this.GrupiuPaneleAtsaukti_Click);
            // 
            // GrupiuPanelePatvirtinti
            // 
            this.GrupiuPanelePatvirtinti.Location = new System.Drawing.Point(117, 276);
            this.GrupiuPanelePatvirtinti.Name = "GrupiuPanelePatvirtinti";
            this.GrupiuPanelePatvirtinti.Size = new System.Drawing.Size(93, 23);
            this.GrupiuPanelePatvirtinti.TabIndex = 4;
            this.GrupiuPanelePatvirtinti.Text = "Patvirtinti";
            this.GrupiuPanelePatvirtinti.UseVisualStyleBackColor = true;
            this.GrupiuPanelePatvirtinti.Click += new System.EventHandler(this.GrupiuPanelePatvirtinti_Click);
            // 
            // comboBoxGroupsCourses
            // 
            this.comboBoxGroupsCourses.FormattingEnabled = true;
            this.comboBoxGroupsCourses.Location = new System.Drawing.Point(273, 70);
            this.comboBoxGroupsCourses.Name = "comboBoxGroupsCourses";
            this.comboBoxGroupsCourses.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGroupsCourses.TabIndex = 10;
            this.comboBoxGroupsCourses.SelectedIndexChanged += new System.EventHandler(this.comboBoxGroupsCourses_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(270, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Redaguoti";
            // 
            // DalykuPanele
            // 
            this.DalykuPanele.BackColor = System.Drawing.SystemColors.ControlDark;
            this.DalykuPanele.Controls.Add(this.label14);
            this.DalykuPanele.Controls.Add(this.comboBoxIstrintiDalyka);
            this.DalykuPanele.Controls.Add(this.btnIstrintiDalyka);
            this.DalykuPanele.Controls.Add(this.SukurtiDalyka);
            this.DalykuPanele.Controls.Add(this.DestytojuPasirinkimas);
            this.DalykuPanele.Controls.Add(this.label13);
            this.DalykuPanele.Controls.Add(this.DalykoPavadinimas);
            this.DalykuPanele.Controls.Add(this.label9);
            this.DalykuPanele.Controls.Add(this.DalykuPaneleAtsaukti);
            this.DalykuPanele.Controls.Add(this.DalykuPanelePatvirtinti);
            this.DalykuPanele.Location = new System.Drawing.Point(273, 97);
            this.DalykuPanele.Name = "DalykuPanele";
            this.DalykuPanele.Size = new System.Drawing.Size(223, 311);
            this.DalykuPanele.TabIndex = 10;
            this.DalykuPanele.Paint += new System.Windows.Forms.PaintEventHandler(this.DalykuPanele_Paint);
            // 
            // SukurtiDalyka
            // 
            this.SukurtiDalyka.Location = new System.Drawing.Point(135, 104);
            this.SukurtiDalyka.Name = "SukurtiDalyka";
            this.SukurtiDalyka.Size = new System.Drawing.Size(75, 23);
            this.SukurtiDalyka.TabIndex = 20;
            this.SukurtiDalyka.Text = "Sukurti";
            this.SukurtiDalyka.UseVisualStyleBackColor = true;
            this.SukurtiDalyka.Click += new System.EventHandler(this.SukurtiDalyka_Click);
            // 
            // DestytojuPasirinkimas
            // 
            this.DestytojuPasirinkimas.FormattingEnabled = true;
            this.DestytojuPasirinkimas.Location = new System.Drawing.Point(10, 81);
            this.DestytojuPasirinkimas.Name = "DestytojuPasirinkimas";
            this.DestytojuPasirinkimas.Size = new System.Drawing.Size(200, 21);
            this.DestytojuPasirinkimas.TabIndex = 22;
            this.DestytojuPasirinkimas.Text = "Priskirkite destytoja";
            this.DestytojuPasirinkimas.SelectedIndexChanged += new System.EventHandler(this.DestytojuPasirinkimas_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Sukurti nauja dalyka";
            // 
            // DalykoPavadinimas
            // 
            this.DalykoPavadinimas.Location = new System.Drawing.Point(10, 55);
            this.DalykoPavadinimas.Name = "DalykoPavadinimas";
            this.DalykoPavadinimas.Size = new System.Drawing.Size(200, 20);
            this.DalykoPavadinimas.TabIndex = 20;
            this.DalykoPavadinimas.Text = "Dalyko pavadinimas";
            this.DalykoPavadinimas.TextChanged += new System.EventHandler(this.DalykoPavadinimas_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Dalyku redagavimas";
            // 
            // DalykuPaneleAtsaukti
            // 
            this.DalykuPaneleAtsaukti.Location = new System.Drawing.Point(10, 276);
            this.DalykuPaneleAtsaukti.Name = "DalykuPaneleAtsaukti";
            this.DalykuPaneleAtsaukti.Size = new System.Drawing.Size(93, 23);
            this.DalykuPaneleAtsaukti.TabIndex = 5;
            this.DalykuPaneleAtsaukti.Text = "Atsaukti";
            this.DalykuPaneleAtsaukti.UseVisualStyleBackColor = true;
            this.DalykuPaneleAtsaukti.Click += new System.EventHandler(this.DalykuPaneleAtsaukti_Click);
            // 
            // DalykuPanelePatvirtinti
            // 
            this.DalykuPanelePatvirtinti.Location = new System.Drawing.Point(117, 276);
            this.DalykuPanelePatvirtinti.Name = "DalykuPanelePatvirtinti";
            this.DalykuPanelePatvirtinti.Size = new System.Drawing.Size(93, 23);
            this.DalykuPanelePatvirtinti.TabIndex = 4;
            this.DalykuPanelePatvirtinti.Text = "Patvirtinti";
            this.DalykuPanelePatvirtinti.UseVisualStyleBackColor = true;
            this.DalykuPanelePatvirtinti.Click += new System.EventHandler(this.DalykuPanelePatvirtinti_Click);
            // 
            // btnIstrintiDalyka
            // 
            this.btnIstrintiDalyka.Location = new System.Drawing.Point(136, 171);
            this.btnIstrintiDalyka.Name = "btnIstrintiDalyka";
            this.btnIstrintiDalyka.Size = new System.Drawing.Size(75, 23);
            this.btnIstrintiDalyka.TabIndex = 24;
            this.btnIstrintiDalyka.Text = "Istrinti";
            this.btnIstrintiDalyka.UseVisualStyleBackColor = true;
            this.btnIstrintiDalyka.Click += new System.EventHandler(this.btnIstrintiDalyka_Click);
            // 
            // comboBoxIstrintiDalyka
            // 
            this.comboBoxIstrintiDalyka.FormattingEnabled = true;
            this.comboBoxIstrintiDalyka.Location = new System.Drawing.Point(11, 145);
            this.comboBoxIstrintiDalyka.Name = "comboBoxIstrintiDalyka";
            this.comboBoxIstrintiDalyka.Size = new System.Drawing.Size(200, 21);
            this.comboBoxIstrintiDalyka.TabIndex = 25;
            this.comboBoxIstrintiDalyka.Text = "Pasirinkite dalyka";
            this.comboBoxIstrintiDalyka.SelectedIndexChanged += new System.EventHandler(this.comboBoxIstrintiDalyka_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 129);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Istrinti dalyka";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DalykuPanele);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxGroupsCourses);
            this.Controls.Add(this.GrupiuPanele);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdminPanel);
            this.Controls.Add(this.DestytojoPanele);
            this.Controls.Add(this.StudentoPanele);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.PridetiNaudotoja);
            this.Name = "AdminDashboard";
            this.Text = "\\\\";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.StudentoPanele.ResumeLayout(false);
            this.StudentoPanele.PerformLayout();
            this.DestytojoPanele.ResumeLayout(false);
            this.DestytojoPanele.PerformLayout();
            this.AdminPanel.ResumeLayout(false);
            this.AdminPanel.PerformLayout();
            this.GrupiuPanele.ResumeLayout(false);
            this.GrupiuPanele.PerformLayout();
            this.DalykuPanele.ResumeLayout(false);
            this.DalykuPanele.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PridetiNaudotoja;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel StudentoPanele;
        private System.Windows.Forms.ComboBox GrupesPasirinkimas;
        private System.Windows.Forms.TextBox StudentoPavarde;
        private System.Windows.Forms.TextBox StudentoVardas;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button PridetiConfirm;
        private System.Windows.Forms.Button AtsauktiConfirm;
        private System.Windows.Forms.Panel DestytojoPanele;
        private System.Windows.Forms.Button AtsauktiConfirm1;
        private System.Windows.Forms.Button DestytojoPatvirtinimoMygtukas;
        private System.Windows.Forms.TextBox DestytojoPavarde;
        private System.Windows.Forms.TextBox DestytojoVardas;
        private System.Windows.Forms.Panel AdminPanel;
        private System.Windows.Forms.Button AtsauktiConfirm2;
        private System.Windows.Forms.Button AdminoPatvirtinimoMygtukas;
        private System.Windows.Forms.TextBox AdminoPavarde;
        private System.Windows.Forms.TextBox AdminoVardas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel GrupiuPanele;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button GrupiuPaneleAtsaukti;
        private System.Windows.Forms.Button GrupiuPanelePatvirtinti;
        private System.Windows.Forms.ComboBox comboBoxGroupsCourses;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel DalykuPanele;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button DalykuPaneleAtsaukti;
        private System.Windows.Forms.Button DalykuPanelePatvirtinti;
        private System.Windows.Forms.TextBox GrupesPavadinimas;
        private System.Windows.Forms.Button SukurtiGrupe;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button IstrintiGrupe;
        private System.Windows.Forms.ComboBox GrupesPasirinkimas3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button MoveToRedactionForm;
        private System.Windows.Forms.ComboBox DestytojuPasirinkimas;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox DalykoPavadinimas;
        private System.Windows.Forms.Button SukurtiDalyka;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBoxIstrintiDalyka;
        private System.Windows.Forms.Button btnIstrintiDalyka;
    }
}