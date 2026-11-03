namespace CalculaCarlos
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
            textBoxnumero01 = new TextBox();
            textBoxnumero02 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            labelResultado = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // textBoxnumero01
            // 
            textBoxnumero01.Location = new Point(576, 255);
            textBoxnumero01.Name = "textBoxnumero01";
            textBoxnumero01.Size = new Size(286, 23);
            textBoxnumero01.TabIndex = 0;
            textBoxnumero01.TextChanged += textBox1_TextChanged;
            // 
            // textBoxnumero02
            // 
            textBoxnumero02.Location = new Point(576, 362);
            textBoxnumero02.Name = "textBoxnumero02";
            textBoxnumero02.Size = new Size(286, 23);
            textBoxnumero02.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(576, 198);
            label1.Name = "label1";
            label1.Size = new Size(251, 30);
            label1.TabIndex = 2;
            label1.Text = "Insira o primeiro Numero:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(576, 305);
            label2.Name = "label2";
            label2.Size = new Size(254, 30);
            label2.TabIndex = 3;
            label2.Text = "Insira o segundo Numero:";
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(436, 480);
            button1.Name = "button1";
            button1.Size = new Size(286, 53);
            button1.TabIndex = 4;
            button1.Text = "Somar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelResultado.Location = new Point(722, 423);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(0, 30);
            labelResultado.TabIndex = 5;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(750, 480);
            button2.Name = "button2";
            button2.Size = new Size(286, 53);
            button2.TabIndex = 6;
            button2.Text = "Subtrair";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DeepSkyBlue;
            button3.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(436, 555);
            button3.Name = "button3";
            button3.Size = new Size(286, 53);
            button3.TabIndex = 7;
            button3.Text = "Vezes";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Yellow;
            button4.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(750, 555);
            button4.Name = "button4";
            button4.Size = new Size(286, 53);
            button4.TabIndex = 8;
            button4.Text = "Dividir";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkOrange;
            button5.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(750, 639);
            button5.Name = "button5";
            button5.Size = new Size(286, 53);
            button5.TabIndex = 9;
            button5.Text = "Logaritmo";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.DarkViolet;
            button6.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(436, 639);
            button6.Name = "button6";
            button6.Size = new Size(286, 53);
            button6.TabIndex = 10;
            button6.Text = "Exponenciação";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(1430, 817);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(labelResultado);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxnumero02);
            Controls.Add(textBoxnumero01);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxnumero01;
        private TextBox textBoxnumero02;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label labelResultado;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}
