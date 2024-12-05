namespace WindowsFormsApp2.Forms
{
    partial class GroupAssigment
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
            this.label1 = new System.Windows.Forms.Label();
            this.GrupesPasirinkimas = new System.Windows.Forms.ComboBox();
            this.dataGridViewAssignedStudents = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewUnassignedStudents = new System.Windows.Forms.DataGridView();
            this.btnUnassign = new System.Windows.Forms.Button();
            this.btnAssign = new System.Windows.Forms.Button();
            this.btnUnassignFromGroup = new System.Windows.Forms.Button();
            this.btnAssignFromAll = new System.Windows.Forms.Button();
            this.dataGridViewAllStudents = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssignedStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnassignedStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Studentu Priskirimas";
            // 
            // GrupesPasirinkimas
            // 
            this.GrupesPasirinkimas.FormattingEnabled = true;
            this.GrupesPasirinkimas.Location = new System.Drawing.Point(17, 69);
            this.GrupesPasirinkimas.Name = "GrupesPasirinkimas";
            this.GrupesPasirinkimas.Size = new System.Drawing.Size(121, 21);
            this.GrupesPasirinkimas.TabIndex = 1;
            this.GrupesPasirinkimas.Text = "Pasirinkite grupe";
            this.GrupesPasirinkimas.SelectedIndexChanged += new System.EventHandler(this.GrupesPasirinkimas_SelectedIndexChanged);
            // 
            // dataGridViewAssignedStudents
            // 
            this.dataGridViewAssignedStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAssignedStudents.Location = new System.Drawing.Point(17, 120);
            this.dataGridViewAssignedStudents.Name = "dataGridViewAssignedStudents";
            this.dataGridViewAssignedStudents.Size = new System.Drawing.Size(240, 318);
            this.dataGridViewAssignedStudents.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Students assigned to selected group";
            // 
            // dataGridViewUnassignedStudents
            // 
            this.dataGridViewUnassignedStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUnassignedStudents.Location = new System.Drawing.Point(344, 120);
            this.dataGridViewUnassignedStudents.Name = "dataGridViewUnassignedStudents";
            this.dataGridViewUnassignedStudents.Size = new System.Drawing.Size(240, 318);
            this.dataGridViewUnassignedStudents.TabIndex = 4;
            // 
            // btnUnassign
            // 
            this.btnUnassign.Location = new System.Drawing.Point(263, 251);
            this.btnUnassign.Name = "btnUnassign";
            this.btnUnassign.Size = new System.Drawing.Size(75, 23);
            this.btnUnassign.TabIndex = 5;
            this.btnUnassign.Text = ">>";
            this.btnUnassign.UseVisualStyleBackColor = true;
            this.btnUnassign.Click += new System.EventHandler(this.btnUnassign_Click);
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(263, 295);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(75, 23);
            this.btnAssign.TabIndex = 6;
            this.btnAssign.Text = "<<";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // btnUnassignFromGroup
            // 
            this.btnUnassignFromGroup.Location = new System.Drawing.Point(590, 251);
            this.btnUnassignFromGroup.Name = "btnUnassignFromGroup";
            this.btnUnassignFromGroup.Size = new System.Drawing.Size(75, 23);
            this.btnUnassignFromGroup.TabIndex = 7;
            this.btnUnassignFromGroup.Text = ">>";
            this.btnUnassignFromGroup.UseVisualStyleBackColor = true;
            this.btnUnassignFromGroup.Click += new System.EventHandler(this.btnUnassignFromGroup_Click);
            // 
            // btnAssignFromAll
            // 
            this.btnAssignFromAll.Location = new System.Drawing.Point(590, 295);
            this.btnAssignFromAll.Name = "btnAssignFromAll";
            this.btnAssignFromAll.Size = new System.Drawing.Size(75, 23);
            this.btnAssignFromAll.TabIndex = 8;
            this.btnAssignFromAll.Text = "<<";
            this.btnAssignFromAll.UseVisualStyleBackColor = true;
            this.btnAssignFromAll.Click += new System.EventHandler(this.btnAssignFromAll_Click);
            // 
            // dataGridViewAllStudents
            // 
            this.dataGridViewAllStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllStudents.Location = new System.Drawing.Point(671, 120);
            this.dataGridViewAllStudents.Name = "dataGridViewAllStudents";
            this.dataGridViewAllStudents.Size = new System.Drawing.Size(240, 318);
            this.dataGridViewAllStudents.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Unassigned Students";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(671, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "All Students";
            // 
            // GroupAssigment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewAllStudents);
            this.Controls.Add(this.btnAssignFromAll);
            this.Controls.Add(this.btnUnassignFromGroup);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.btnUnassign);
            this.Controls.Add(this.dataGridViewUnassignedStudents);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewAssignedStudents);
            this.Controls.Add(this.GrupesPasirinkimas);
            this.Controls.Add(this.label1);
            this.Name = "GroupAssigment";
            this.Text = "GroupAssigment";
            this.Load += new System.EventHandler(this.GroupAssigment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssignedStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnassignedStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox GrupesPasirinkimas;
        private System.Windows.Forms.DataGridView dataGridViewAssignedStudents;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewUnassignedStudents;
        private System.Windows.Forms.Button btnUnassign;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Button btnUnassignFromGroup;
        private System.Windows.Forms.Button btnAssignFromAll;
        private System.Windows.Forms.DataGridView dataGridViewAllStudents;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
    }
}