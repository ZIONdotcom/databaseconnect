namespace databaseconnect
{
    partial class FrmClubRegistration
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            sid1 = new TextBox();
            ln1 = new TextBox();
            a1 = new TextBox();
            fn1 = new TextBox();
            mn1 = new TextBox();
            p1 = new ComboBox();
            g1 = new ComboBox();
            dataGridView1 = new DataGridView();
            regbtn = new Button();
            updatebtn = new Button();
            refreshbtn = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(9, 9);
            label1.Name = "label1";
            label1.Size = new Size(70, 17);
            label1.TabIndex = 0;
            label1.Text = "Student Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(8, 108);
            label2.Name = "label2";
            label2.Size = new Size(34, 17);
            label2.TabIndex = 1;
            label2.Text = "Age:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(7, 57);
            label3.Name = "label3";
            label3.Size = new Size(70, 17);
            label3.TabIndex = 2;
            label3.Text = "Last name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(333, 59);
            label4.Name = "label4";
            label4.Size = new Size(88, 17);
            label4.TabIndex = 3;
            label4.Text = "Middle name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(333, 9);
            label5.Name = "label5";
            label5.Size = new Size(62, 17);
            label5.TabIndex = 4;
            label5.Text = "Program:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(170, 59);
            label6.Name = "label6";
            label6.Size = new Size(74, 17);
            label6.TabIndex = 5;
            label6.Text = "First Name:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(169, 108);
            label7.Name = "label7";
            label7.Size = new Size(54, 17);
            label7.TabIndex = 6;
            label7.Text = "Gender:";
            // 
            // sid1
            // 
            sid1.Location = new Point(8, 31);
            sid1.Name = "sid1";
            sid1.Size = new Size(137, 23);
            sid1.TabIndex = 7;
            // 
            // ln1
            // 
            ln1.Location = new Point(7, 77);
            ln1.Name = "ln1";
            ln1.Size = new Size(137, 23);
            ln1.TabIndex = 8;
            // 
            // a1
            // 
            a1.Location = new Point(8, 128);
            a1.Name = "a1";
            a1.Size = new Size(137, 23);
            a1.TabIndex = 9;
            // 
            // fn1
            // 
            fn1.Location = new Point(170, 79);
            fn1.Name = "fn1";
            fn1.Size = new Size(137, 23);
            fn1.TabIndex = 10;
            // 
            // mn1
            // 
            mn1.Location = new Point(333, 79);
            mn1.Name = "mn1";
            mn1.Size = new Size(137, 23);
            mn1.TabIndex = 11;
            // 
            // p1
            // 
            p1.FormattingEnabled = true;
            p1.Items.AddRange(new object[] { "BSIT", "BSCS" });
            p1.Location = new Point(334, 31);
            p1.Name = "p1";
            p1.Size = new Size(136, 23);
            p1.TabIndex = 12;
            // 
            // g1
            // 
            g1.FormattingEnabled = true;
            g1.Items.AddRange(new object[] { "FEMALE", "MALE" });
            g1.Location = new Point(170, 128);
            g1.Name = "g1";
            g1.Size = new Size(136, 23);
            g1.TabIndex = 13;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(476, 178);
            dataGridView1.TabIndex = 14;
            // 
            // regbtn
            // 
            regbtn.Location = new Point(513, 15);
            regbtn.Name = "regbtn";
            regbtn.Size = new Size(82, 29);
            regbtn.TabIndex = 15;
            regbtn.Text = "Register";
            regbtn.UseVisualStyleBackColor = true;
            regbtn.Click += regbtn_Click;
            // 
            // updatebtn
            // 
            updatebtn.Location = new Point(513, 50);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(82, 29);
            updatebtn.TabIndex = 16;
            updatebtn.Text = "Update";
            updatebtn.UseVisualStyleBackColor = true;
            // 
            // refreshbtn
            // 
            refreshbtn.Location = new Point(513, 232);
            refreshbtn.Name = "refreshbtn";
            refreshbtn.Size = new Size(82, 29);
            refreshbtn.TabIndex = 17;
            refreshbtn.Text = "Refresh";
            refreshbtn.UseVisualStyleBackColor = true;
            refreshbtn.Click += refreshbtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 198);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(495, 212);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "List of Club members";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(g1);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(p1);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(mn1);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(fn1);
            groupBox2.Controls.Add(sid1);
            groupBox2.Controls.Add(a1);
            groupBox2.Controls.Add(ln1);
            groupBox2.Location = new Point(18, 15);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(489, 177);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            // 
            // FrmClubRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 422);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(refreshbtn);
            Controls.Add(updatebtn);
            Controls.Add(regbtn);
            Name = "FrmClubRegistration";
            Text = "FrmClubRegistration";
            Load += FrmClubRegistration_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox sid1;
        private TextBox ln1;
        private TextBox a1;
        private TextBox fn1;
        private TextBox mn1;
        private ComboBox p1;
        private ComboBox g1;
        private DataGridView dataGridView1;
        private Button regbtn;
        private Button updatebtn;
        private Button refreshbtn;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}