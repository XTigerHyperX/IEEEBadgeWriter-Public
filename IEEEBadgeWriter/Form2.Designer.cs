namespace IEEEBadgeWriter
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            textBox3 = new TextBox();
            Font_txtbox = new Button();
            Template_txtbox = new TextBox();
            Load_Temp = new Button();
            Output_txtbox = new TextBox();
            Textfile_txtbox = new TextBox();
            Output = new Button();
            Load_Text = new Button();
            Gen_btn = new Button();
            label2 = new Label();
            Sample_Txt = new TextBox();
            label3 = new Label();
            label4 = new Label();
            Plustext_btn = new Button();
            negativetxt_btn = new Button();
            groupBox1 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.IEEE_ESPRIT_SB_LOGO_White;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(23, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(491, 328);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 5;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(422, 51);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(807, 600);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.DragDrop += pictureBox2_DragDrop;
            pictureBox2.DragEnter += pictureBox2_DragEnter;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(23, 328);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(215, 23);
            textBox3.TabIndex = 8;
            // 
            // Font_txtbox
            // 
            Font_txtbox.Location = new Point(23, 299);
            Font_txtbox.Name = "Font_txtbox";
            Font_txtbox.Size = new Size(103, 23);
            Font_txtbox.TabIndex = 7;
            Font_txtbox.Text = "Load Font";
            Font_txtbox.UseVisualStyleBackColor = true;
            Font_txtbox.Click += button3_Click;
            // 
            // Template_txtbox
            // 
            Template_txtbox.Location = new Point(23, 151);
            Template_txtbox.Name = "Template_txtbox";
            Template_txtbox.Size = new Size(215, 23);
            Template_txtbox.TabIndex = 10;
            // 
            // Load_Temp
            // 
            Load_Temp.Location = new Point(23, 122);
            Load_Temp.Name = "Load_Temp";
            Load_Temp.Size = new Size(103, 23);
            Load_Temp.TabIndex = 9;
            Load_Temp.Text = "Load Template";
            Load_Temp.UseVisualStyleBackColor = true;
            Load_Temp.Click += button2_Click;
            // 
            // Output_txtbox
            // 
            Output_txtbox.Location = new Point(23, 268);
            Output_txtbox.Name = "Output_txtbox";
            Output_txtbox.Size = new Size(215, 23);
            Output_txtbox.TabIndex = 13;
            // 
            // Textfile_txtbox
            // 
            Textfile_txtbox.Location = new Point(23, 210);
            Textfile_txtbox.Name = "Textfile_txtbox";
            Textfile_txtbox.Size = new Size(215, 23);
            Textfile_txtbox.TabIndex = 14;
            // 
            // Output
            // 
            Output.Location = new Point(23, 239);
            Output.Name = "Output";
            Output.Size = new Size(103, 23);
            Output.TabIndex = 11;
            Output.Text = "Output folder";
            Output.UseVisualStyleBackColor = true;
            Output.Click += Output_Click;
            // 
            // Load_Text
            // 
            Load_Text.Location = new Point(23, 181);
            Load_Text.Name = "Load_Text";
            Load_Text.Size = new Size(103, 23);
            Load_Text.TabIndex = 12;
            Load_Text.Text = "Load Text File";
            Load_Text.UseVisualStyleBackColor = true;
            Load_Text.Click += Load_Text_Click;
            // 
            // Gen_btn
            // 
            Gen_btn.Location = new Point(23, 651);
            Gen_btn.Name = "Gen_btn";
            Gen_btn.Size = new Size(149, 23);
            Gen_btn.TabIndex = 15;
            Gen_btn.Text = "Generate";
            Gen_btn.UseVisualStyleBackColor = true;
            Gen_btn.Click += Gen_btn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gray;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(83, 580);
            label2.Name = "label2";
            label2.Size = new Size(81, 21);
            label2.TabIndex = 17;
            label2.Text = "Move Me";
            label2.MouseDown += label2_MouseDown;
            label2.MouseMove += label2_MouseMove;
            label2.MouseUp += label2_MouseUp;
            // 
            // Sample_Txt
            // 
            Sample_Txt.Location = new Point(42, 33);
            Sample_Txt.Name = "Sample_Txt";
            Sample_Txt.Size = new Size(149, 23);
            Sample_Txt.TabIndex = 18;
            Sample_Txt.TextChanged += Sample_Txt_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 36);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 20;
            label3.Text = "Text :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 73);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 21;
            label4.Text = "Text Size :";
            // 
            // Plustext_btn
            // 
            Plustext_btn.ForeColor = Color.Black;
            Plustext_btn.Location = new Point(71, 69);
            Plustext_btn.Name = "Plustext_btn";
            Plustext_btn.Size = new Size(32, 23);
            Plustext_btn.TabIndex = 20;
            Plustext_btn.Text = "+";
            Plustext_btn.UseVisualStyleBackColor = true;
            Plustext_btn.Click += Plustext_btn_Click;
            // 
            // negativetxt_btn
            // 
            negativetxt_btn.ForeColor = Color.Black;
            negativetxt_btn.Location = new Point(109, 69);
            negativetxt_btn.Name = "negativetxt_btn";
            negativetxt_btn.Size = new Size(32, 23);
            negativetxt_btn.TabIndex = 22;
            negativetxt_btn.Text = "-";
            negativetxt_btn.UseVisualStyleBackColor = true;
            negativetxt_btn.Click += negativetxt_btn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(negativetxt_btn);
            groupBox1.Controls.Add(Plustext_btn);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(Sample_Txt);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(23, 371);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(215, 195);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customize Text";
            // 
            // button1
            // 
            button1.ForeColor = Color.Black;
            button1.Location = new Point(109, 107);
            button1.Name = "button1";
            button1.Size = new Size(52, 23);
            button1.TabIndex = 26;
            button1.Text = "White";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.ForeColor = Color.Black;
            button2.Location = new Point(56, 107);
            button2.Name = "button2";
            button2.Size = new Size(47, 23);
            button2.TabIndex = 25;
            button2.Text = "Black";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 115);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 24;
            label5.Text = "Color :";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 19, 28);
            ClientSize = new Size(1256, 686);
            Controls.Add(groupBox1);
            Controls.Add(Gen_btn);
            Controls.Add(Output_txtbox);
            Controls.Add(Textfile_txtbox);
            Controls.Add(Output);
            Controls.Add(label2);
            Controls.Add(Load_Text);
            Controls.Add(Template_txtbox);
            Controls.Add(Load_Temp);
            Controls.Add(textBox3);
            Controls.Add(Font_txtbox);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form2";
            Text = "IEEEBadgeWriter";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private TextBox textBox3;
        private Button Font_txtbox;
        private TextBox Template_txtbox;
        private Button Load_Temp;
        private TextBox Output_txtbox;
        private TextBox Textfile_txtbox;
        private Button Output;
        private Button Load_Text;
        private Button Gen_btn;
        private Label label2;
        private TextBox Sample_Txt;
        private Label label3;
        private Label label4;
        private Button Plustext_btn;
        private Button negativetxt_btn;
        private GroupBox groupBox1;
        private Button button1;
        private Button button2;
        private Label label5;
    }
}
