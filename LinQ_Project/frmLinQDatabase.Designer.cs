namespace LinQ_Project
{
    partial class frmLinQDatabase
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
            this.dataGridViewResultCourse = new System.Windows.Forms.DataGridView();
            this.comboBoxCourses = new System.Windows.Forms.ComboBox();
            this.labelCourse = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewResultCourse
            // 
            this.dataGridViewResultCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultCourse.Location = new System.Drawing.Point(124, 190);
            this.dataGridViewResultCourse.Name = "dataGridViewResultCourse";
            this.dataGridViewResultCourse.RowHeadersWidth = 72;
            this.dataGridViewResultCourse.RowTemplate.Height = 31;
            this.dataGridViewResultCourse.Size = new System.Drawing.Size(853, 439);
            this.dataGridViewResultCourse.TabIndex = 5;
            // 
            // comboBoxCourses
            // 
            this.comboBoxCourses.FormattingEnabled = true;
            this.comboBoxCourses.Location = new System.Drawing.Point(357, 76);
            this.comboBoxCourses.Name = "comboBoxCourses";
            this.comboBoxCourses.Size = new System.Drawing.Size(384, 32);
            this.comboBoxCourses.TabIndex = 4;
            // 
            // labelCourse
            // 
            this.labelCourse.AutoSize = true;
            this.labelCourse.Location = new System.Drawing.Point(118, 79);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(152, 25);
            this.labelCourse.TabIndex = 3;
            this.labelCourse.Text = "Select a Course";
            // 
            // frmLinQDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 757);
            this.Controls.Add(this.dataGridViewResultCourse);
            this.Controls.Add(this.comboBoxCourses);
            this.Controls.Add(this.labelCourse);
            this.Name = "frmLinQDatabase";
            this.Text = "frmLinQDatatable";
            this.Load += new System.EventHandler(this.frmLinQDatabase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewResultCourse;
        private System.Windows.Forms.ComboBox comboBoxCourses;
        private System.Windows.Forms.Label labelCourse;
    }
}