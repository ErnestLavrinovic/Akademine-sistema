namespace WindowsFormsApp2.Forms
{
    partial class LecturerDashboard
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
            this.labelGreeting = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxGrupe = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxDalykas = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxStudent = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxAssignAGroup = new System.Windows.Forms.ComboBox();
            this.btnAssignGroupToCourse = new System.Windows.Forms.Button();
            this.labelDalykas = new System.Windows.Forms.Label();
            this.labelGrupe = new System.Windows.Forms.Label();
            this.GradingPanel = new System.Windows.Forms.Panel();
            this.labelStudentas = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownGrade = new System.Windows.Forms.NumericUpDown();
            this.buttonPaskirtiPazymi = new System.Windows.Forms.Button();
            this.dataGridViewGrades = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.GradingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrades)).BeginInit();
            this.SuspendLayout();
            // 
            // labelGreeting
            // 
            this.labelGreeting.AutoSize = true;
            this.labelGreeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGreeting.Location = new System.Drawing.Point(12, 9);
            this.labelGreeting.Name = "labelGreeting";
            this.labelGreeting.Size = new System.Drawing.Size(91, 29);
            this.labelGreeting.TabIndex = 9;
            this.labelGreeting.Text = "Sveiki!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Destytojas";
            // 
            // comboBoxGrupe
            // 
            this.comboBoxGrupe.FormattingEnabled = true;
            this.comboBoxGrupe.Location = new System.Drawing.Point(177, 87);
            this.comboBoxGrupe.Name = "comboBoxGrupe";
            this.comboBoxGrupe.Size = new System.Drawing.Size(151, 21);
            this.comboBoxGrupe.TabIndex = 11;
            this.comboBoxGrupe.Text = "Grupe";
            this.comboBoxGrupe.SelectedIndexChanged += new System.EventHandler(this.comboBoxGrupe_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Dalyko pasirinkimas";
            // 
            // comboBoxDalykas
            // 
            this.comboBoxDalykas.FormattingEnabled = true;
            this.comboBoxDalykas.Location = new System.Drawing.Point(20, 87);
            this.comboBoxDalykas.Name = "comboBoxDalykas";
            this.comboBoxDalykas.Size = new System.Drawing.Size(151, 21);
            this.comboBoxDalykas.TabIndex = 13;
            this.comboBoxDalykas.Text = "Dalykas";
            this.comboBoxDalykas.SelectedIndexChanged += new System.EventHandler(this.comboBoxDalykas_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Grupes pasirinkimas";
            // 
            // comboBoxStudent
            // 
            this.comboBoxStudent.FormattingEnabled = true;
            this.comboBoxStudent.Location = new System.Drawing.Point(334, 87);
            this.comboBoxStudent.Name = "comboBoxStudent";
            this.comboBoxStudent.Size = new System.Drawing.Size(151, 21);
            this.comboBoxStudent.TabIndex = 15;
            this.comboBoxStudent.Text = "Studentas";
            this.comboBoxStudent.SelectedIndexChanged += new System.EventHandler(this.comboBoxStudent_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Studento pasirinkimas";
            // 
            // comboBoxAssignAGroup
            // 
            this.comboBoxAssignAGroup.FormattingEnabled = true;
            this.comboBoxAssignAGroup.Location = new System.Drawing.Point(20, 127);
            this.comboBoxAssignAGroup.Name = "comboBoxAssignAGroup";
            this.comboBoxAssignAGroup.Size = new System.Drawing.Size(151, 21);
            this.comboBoxAssignAGroup.TabIndex = 17;
            this.comboBoxAssignAGroup.Text = "Priskirti grupe";
            this.comboBoxAssignAGroup.SelectedIndexChanged += new System.EventHandler(this.comboBoxAssignAGroup_SelectedIndexChanged);
            // 
            // btnAssignGroupToCourse
            // 
            this.btnAssignGroupToCourse.Location = new System.Drawing.Point(73, 154);
            this.btnAssignGroupToCourse.Name = "btnAssignGroupToCourse";
            this.btnAssignGroupToCourse.Size = new System.Drawing.Size(98, 23);
            this.btnAssignGroupToCourse.TabIndex = 18;
            this.btnAssignGroupToCourse.Text = "Priskirti Dalyka";
            this.btnAssignGroupToCourse.UseVisualStyleBackColor = true;
            this.btnAssignGroupToCourse.Click += new System.EventHandler(this.btnAssignGroupToCourse_Click);
            // 
            // labelDalykas
            // 
            this.labelDalykas.AutoSize = true;
            this.labelDalykas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDalykas.Location = new System.Drawing.Point(5, 11);
            this.labelDalykas.Name = "labelDalykas";
            this.labelDalykas.Size = new System.Drawing.Size(73, 20);
            this.labelDalykas.TabIndex = 20;
            this.labelDalykas.Text = "Dalykas: ";
            // 
            // labelGrupe
            // 
            this.labelGrupe.AutoSize = true;
            this.labelGrupe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrupe.Location = new System.Drawing.Point(5, 31);
            this.labelGrupe.Name = "labelGrupe";
            this.labelGrupe.Size = new System.Drawing.Size(58, 20);
            this.labelGrupe.TabIndex = 21;
            this.labelGrupe.Text = "Grupe:";
            // 
            // GradingPanel
            // 
            this.GradingPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.GradingPanel.Controls.Add(this.label6);
            this.GradingPanel.Controls.Add(this.dataGridViewGrades);
            this.GradingPanel.Controls.Add(this.buttonPaskirtiPazymi);
            this.GradingPanel.Controls.Add(this.numericUpDownGrade);
            this.GradingPanel.Controls.Add(this.label5);
            this.GradingPanel.Controls.Add(this.labelStudentas);
            this.GradingPanel.Controls.Add(this.labelGrupe);
            this.GradingPanel.Controls.Add(this.labelDalykas);
            this.GradingPanel.Location = new System.Drawing.Point(12, 183);
            this.GradingPanel.Name = "GradingPanel";
            this.GradingPanel.Size = new System.Drawing.Size(487, 255);
            this.GradingPanel.TabIndex = 22;
            // 
            // labelStudentas
            // 
            this.labelStudentas.AutoSize = true;
            this.labelStudentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentas.Location = new System.Drawing.Point(5, 51);
            this.labelStudentas.Name = "labelStudentas";
            this.labelStudentas.Size = new System.Drawing.Size(87, 20);
            this.labelStudentas.TabIndex = 22;
            this.labelStudentas.Text = "Studentas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(371, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Paskirti pazymi";
            // 
            // numericUpDownGrade
            // 
            this.numericUpDownGrade.Location = new System.Drawing.Point(375, 34);
            this.numericUpDownGrade.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownGrade.Name = "numericUpDownGrade";
            this.numericUpDownGrade.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownGrade.TabIndex = 24;
            this.numericUpDownGrade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonPaskirtiPazymi
            // 
            this.buttonPaskirtiPazymi.Location = new System.Drawing.Point(421, 31);
            this.buttonPaskirtiPazymi.Name = "buttonPaskirtiPazymi";
            this.buttonPaskirtiPazymi.Size = new System.Drawing.Size(63, 23);
            this.buttonPaskirtiPazymi.TabIndex = 25;
            this.buttonPaskirtiPazymi.Text = "Paskirti";
            this.buttonPaskirtiPazymi.UseVisualStyleBackColor = true;
            this.buttonPaskirtiPazymi.Click += new System.EventHandler(this.buttonPaskirtiPazymi_Click);
            // 
            // dataGridViewGrades
            // 
            this.dataGridViewGrades.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGrades.Location = new System.Drawing.Point(3, 102);
            this.dataGridViewGrades.Name = "dataGridViewGrades";
            this.dataGridViewGrades.Size = new System.Drawing.Size(481, 150);
            this.dataGridViewGrades.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Pazymiu istorija";
            // 
            // LecturerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 450);
            this.Controls.Add(this.GradingPanel);
            this.Controls.Add(this.btnAssignGroupToCourse);
            this.Controls.Add(this.comboBoxAssignAGroup);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxStudent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxDalykas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxGrupe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelGreeting);
            this.Name = "LecturerDashboard";
            this.Text = "Destytojo Langas";
            this.GradingPanel.ResumeLayout(false);
            this.GradingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGreeting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxGrupe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxDalykas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxStudent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxAssignAGroup;
        private System.Windows.Forms.Button btnAssignGroupToCourse;
        private System.Windows.Forms.Label labelDalykas;
        private System.Windows.Forms.Label labelGrupe;
        private System.Windows.Forms.Panel GradingPanel;
        private System.Windows.Forms.Label labelStudentas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewGrades;
        private System.Windows.Forms.Button buttonPaskirtiPazymi;
        private System.Windows.Forms.NumericUpDown numericUpDownGrade;
        private System.Windows.Forms.Label label5;
    }
}