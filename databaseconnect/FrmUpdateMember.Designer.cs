namespace databaseconnect
{
    partial class FrmUpdateMember
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
            gender2 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            prog2 = new ComboBox();
            label6 = new Label();
            mn2 = new TextBox();
            label7 = new Label();
            fn2 = new TextBox();
            ln2 = new TextBox();
            a2 = new TextBox();
            sid2 = new ComboBox();
            confirmbtn = new Button();
            SuspendLayout();
            // 
            // gender2
            // 
            gender2.FormattingEnabled = true;
            gender2.Items.AddRange(new object[] { "FEMALE", "MALE" });
            gender2.Location = new Point(56, 306);
            gender2.Name = "gender2";
            gender2.Size = new Size(190, 23);
            gender2.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(55, 26);
            label1.Name = "label1";
            label1.Size = new Size(70, 17);
            label1.TabIndex = 0;
            label1.Text = "Student Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(55, 231);
            label2.Name = "label2";
            label2.Size = new Size(34, 17);
            label2.TabIndex = 1;
            label2.Text = "Age:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(55, 73);
            label3.Name = "label3";
            label3.Size = new Size(70, 17);
            label3.TabIndex = 2;
            label3.Text = "Last name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(55, 182);
            label4.Name = "label4";
            label4.Size = new Size(88, 17);
            label4.TabIndex = 3;
            label4.Text = "Middle name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(56, 332);
            label5.Name = "label5";
            label5.Size = new Size(62, 17);
            label5.TabIndex = 4;
            label5.Text = "Program:";
            // 
            // prog2
            // 
            prog2.FormattingEnabled = true;
            prog2.Items.AddRange(new object[] { "BSIT", "BSCS" });
            prog2.Location = new Point(55, 352);
            prog2.Name = "prog2";
            prog2.Size = new Size(190, 23);
            prog2.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(55, 123);
            label6.Name = "label6";
            label6.Size = new Size(74, 17);
            label6.TabIndex = 5;
            label6.Text = "First Name:";
            // 
            // mn2
            // 
            mn2.Location = new Point(55, 205);
            mn2.Name = "mn2";
            mn2.Size = new Size(191, 23);
            mn2.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(55, 283);
            label7.Name = "label7";
            label7.Size = new Size(54, 17);
            label7.TabIndex = 6;
            label7.Text = "Gender:";
            // 
            // fn2
            // 
            fn2.Location = new Point(55, 145);
            fn2.Name = "fn2";
            fn2.Size = new Size(191, 23);
            fn2.TabIndex = 10;
            // 
            // ln2
            // 
            ln2.Location = new Point(55, 94);
            ln2.Name = "ln2";
            ln2.Size = new Size(191, 23);
            ln2.TabIndex = 7;
            // 
            // a2
            // 
            a2.Location = new Point(55, 251);
            a2.Name = "a2";
            a2.Size = new Size(191, 23);
            a2.TabIndex = 9;
            // 
            // sid2
            // 
            sid2.FormattingEnabled = true;
            sid2.Location = new Point(56, 47);
            sid2.Name = "sid2";
            sid2.Size = new Size(190, 23);
            sid2.TabIndex = 14;
            sid2.SelectedIndexChanged += sid2_SelectedIndexChanged;
            sid2.SelectionChangeCommitted += sid2_SelectionChangeCommitted;
            sid2.TextUpdate += sid2_TextUpdate;
            sid2.TextChanged += sid2_TextChanged;
            // 
            // confirmbtn
            // 
            confirmbtn.BackColor = SystemColors.ButtonShadow;
            confirmbtn.Location = new Point(99, 393);
            confirmbtn.Name = "confirmbtn";
            confirmbtn.Size = new Size(92, 23);
            confirmbtn.TabIndex = 15;
            confirmbtn.Text = "Confirm";
            confirmbtn.UseVisualStyleBackColor = false;
            confirmbtn.Click += confirmbtn_Click;
            // 
            // FrmUpdateMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(319, 450);
            Controls.Add(confirmbtn);
            Controls.Add(sid2);
            Controls.Add(prog2);
            Controls.Add(label5);
            Controls.Add(gender2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(mn2);
            Controls.Add(a2);
            Controls.Add(ln2);
            Controls.Add(label6);
            Controls.Add(fn2);
            Name = "FrmUpdateMember";
            Text = "FrmUpdateMember";
            Load += FrmUpdateMember_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox gender2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox prog2;
        private Label label6;
        private TextBox mn2;
        private Label label7;
        private TextBox fn2;
        private TextBox ln2;
        private TextBox a2;
        private ComboBox sid2;
        private Button confirmbtn;
    }
}