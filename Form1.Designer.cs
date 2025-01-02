namespace Assignment_3_PC_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnNewNote = new Button();
            listBoxName = new ListBox();
            groupBox1 = new GroupBox();
            BtnRmvePblm = new Button();
            BtnDeleteNote = new Button();
            BtnUpdateNote = new Button();
            BtnAddNote = new Button();
            richTextBox1 = new RichTextBox();
            label7 = new Label();
            BtnAdd = new Button();
            listBoxVitals = new ListBox();
            listBoxProblems = new ListBox();
            label6 = new Label();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            txtBoxName = new TextBox();
            txtBoxNewProblem = new TextBox();
            txtboxNoteID = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblError = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnNewNote
            // 
            BtnNewNote.Location = new Point(12, 12);
            BtnNewNote.Name = "BtnNewNote";
            BtnNewNote.Size = new Size(124, 29);
            BtnNewNote.TabIndex = 0;
            BtnNewNote.Text = "Start New Note";
            BtnNewNote.UseVisualStyleBackColor = true;
            BtnNewNote.Click += BtnNewNote_Click;
            // 
            // listBoxName
            // 
            listBoxName.FormattingEnabled = true;
            listBoxName.Location = new Point(12, 47);
            listBoxName.Name = "listBoxName";
            listBoxName.Size = new Size(150, 444);
            listBoxName.TabIndex = 1;
            listBoxName.SelectedIndexChanged += listBoxName_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnRmvePblm);
            groupBox1.Controls.Add(BtnDeleteNote);
            groupBox1.Controls.Add(BtnUpdateNote);
            groupBox1.Controls.Add(BtnAddNote);
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(BtnAdd);
            groupBox1.Controls.Add(listBoxVitals);
            groupBox1.Controls.Add(listBoxProblems);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(txtBoxName);
            groupBox1.Controls.Add(txtBoxNewProblem);
            groupBox1.Controls.Add(txtboxNoteID);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(168, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(726, 493);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add/Edit/Delete Encounter Note";
            // 
            // BtnRmvePblm
            // 
            BtnRmvePblm.Location = new Point(365, 199);
            BtnRmvePblm.Name = "BtnRmvePblm";
            BtnRmvePblm.Size = new Size(150, 29);
            BtnRmvePblm.TabIndex = 18;
            BtnRmvePblm.Text = "Remove Problem";
            BtnRmvePblm.UseVisualStyleBackColor = true;
            BtnRmvePblm.Click += BtnRmvePblm_Click;
            // 
            // BtnDeleteNote
            // 
            BtnDeleteNote.Location = new Point(236, 458);
            BtnDeleteNote.Name = "BtnDeleteNote";
            BtnDeleteNote.Size = new Size(102, 29);
            BtnDeleteNote.TabIndex = 17;
            BtnDeleteNote.Text = "Delete Note";
            BtnDeleteNote.UseVisualStyleBackColor = true;
            BtnDeleteNote.Click += BtnDeleteNote_Click;
            // 
            // BtnUpdateNote
            // 
            BtnUpdateNote.Location = new Point(118, 458);
            BtnUpdateNote.Name = "BtnUpdateNote";
            BtnUpdateNote.Size = new Size(103, 29);
            BtnUpdateNote.TabIndex = 16;
            BtnUpdateNote.Text = "Update Note";
            BtnUpdateNote.UseVisualStyleBackColor = true;
            BtnUpdateNote.Click += button2_Click;
            // 
            // BtnAddNote
            // 
            BtnAddNote.Location = new Point(6, 458);
            BtnAddNote.Name = "BtnAddNote";
            BtnAddNote.Size = new Size(94, 29);
            BtnAddNote.TabIndex = 15;
            BtnAddNote.Text = "Add Note";
            BtnAddNote.UseVisualStyleBackColor = true;
            BtnAddNote.Click += BtnAddNote_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(6, 255);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(708, 197);
            richTextBox1.TabIndex = 14;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 232);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 13;
            label7.Text = "Notes:";
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(283, 126);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(68, 27);
            BtnAdd.TabIndex = 12;
            BtnAdd.Text = "Add";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // listBoxVitals
            // 
            listBoxVitals.FormattingEnabled = true;
            listBoxVitals.Location = new Point(537, 49);
            listBoxVitals.Name = "listBoxVitals";
            listBoxVitals.Size = new Size(183, 184);
            listBoxVitals.TabIndex = 11;
            // 
            // listBoxProblems
            // 
            listBoxProblems.FormattingEnabled = true;
            listBoxProblems.Location = new Point(365, 49);
            listBoxProblems.Name = "listBoxProblems";
            listBoxProblems.Size = new Size(150, 144);
            listBoxProblems.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(537, 23);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 9;
            label6.Text = "Vitals:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(365, 23);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 8;
            label5.Text = "Problems:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(118, 94);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(159, 27);
            dateTimePicker1.TabIndex = 7;
            // 
            // txtBoxName
            // 
            txtBoxName.Location = new Point(118, 62);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(159, 27);
            txtBoxName.TabIndex = 6;
            // 
            // txtBoxNewProblem
            // 
            txtBoxNewProblem.Location = new Point(118, 126);
            txtBoxNewProblem.Name = "txtBoxNewProblem";
            txtBoxNewProblem.Size = new Size(159, 27);
            txtBoxNewProblem.TabIndex = 5;
            // 
            // txtboxNoteID
            // 
            txtboxNoteID.Location = new Point(118, 29);
            txtboxNoteID.Name = "txtboxNoteID";
            txtboxNoteID.ScrollBars = ScrollBars.Horizontal;
            txtboxNoteID.Size = new Size(159, 27);
            txtboxNoteID.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 126);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 3;
            label4.Text = "New Problem:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 94);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 2;
            label3.Text = "Date Of Birth:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 64);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 1;
            label2.Text = "Patient Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 35);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Note ID:";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(12, 516);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 20);
            lblError.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 545);
            Controls.Add(lblError);
            Controls.Add(groupBox1);
            Controls.Add(listBoxName);
            Controls.Add(BtnNewNote);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnNewNote;
        private ListBox listBoxName;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private TextBox txtBoxName;
        private TextBox txtBoxNewProblem;
        private TextBox txtboxNoteID;
        private Label label5;
        private Label label7;
        private Button BtnAdd;
        private ListBox listBoxVitals;
        private ListBox listBoxProblems;
        private Label label6;
        private Button BtnDeleteNote;
        private Button BtnUpdateNote;
        private Button BtnAddNote;
        private RichTextBox richTextBox1;
        private Button BtnRmvePblm;
        private Label lblError;
    }
}
