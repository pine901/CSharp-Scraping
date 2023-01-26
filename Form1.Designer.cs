namespace Scraping
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
            this.start = new System.Windows.Forms.Button();
            this.btn_input = new System.Windows.Forms.Button();
            this.btn_output = new System.Windows.Forms.Button();
            this.input_text = new System.Windows.Forms.TextBox();
            this.output_text = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.webView23 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView23)).BeginInit();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(390, 355);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(376, 37);
            this.start.TabIndex = 1;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // btn_input
            // 
            this.btn_input.Location = new System.Drawing.Point(16, 27);
            this.btn_input.Name = "btn_input";
            this.btn_input.Size = new System.Drawing.Size(85, 23);
            this.btn_input.TabIndex = 2;
            this.btn_input.Text = "Input File :";
            this.btn_input.UseVisualStyleBackColor = true;
            this.btn_input.Click += new System.EventHandler(this.btn_input_Click);
            // 
            // btn_output
            // 
            this.btn_output.Location = new System.Drawing.Point(16, 57);
            this.btn_output.Name = "btn_output";
            this.btn_output.Size = new System.Drawing.Size(85, 23);
            this.btn_output.TabIndex = 3;
            this.btn_output.Text = "Output File :";
            this.btn_output.UseVisualStyleBackColor = true;
            this.btn_output.Click += new System.EventHandler(this.btn_output_Click);
            // 
            // input_text
            // 
            this.input_text.Location = new System.Drawing.Point(152, 27);
            this.input_text.Name = "input_text";
            this.input_text.Size = new System.Drawing.Size(207, 23);
            this.input_text.TabIndex = 4;
            // 
            // output_text
            // 
            this.output_text.Location = new System.Drawing.Point(152, 57);
            this.output_text.Name = "output_text";
            this.output_text.Size = new System.Drawing.Size(207, 23);
            this.output_text.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.output_text);
            this.groupBox1.Controls.Add(this.input_text);
            this.groupBox1.Controls.Add(this.btn_output);
            this.groupBox1.Controls.Add(this.btn_input);
            this.groupBox1.Location = new System.Drawing.Point(390, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 91);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "britishairways";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(390, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 91);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "radissonhotels";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(152, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 23);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(152, 27);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(207, 23);
            this.textBox2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Output File :";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Input File :";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Location = new System.Drawing.Point(390, 218);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(376, 93);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "hilton";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(152, 57);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(207, 23);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(152, 27);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(207, 23);
            this.textBox4.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 57);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Output File :";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(16, 27);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Input File :";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // webView23
            // 
            this.webView23.AllowExternalDrop = true;
            this.webView23.CreationProperties = null;
            this.webView23.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView23.Location = new System.Drawing.Point(12, 14);
            this.webView23.Name = "webView23";
            this.webView23.Size = new System.Drawing.Size(359, 428);
            this.webView23.Source = new System.Uri("https://www.hilton.com/", System.UriKind.Absolute);
            this.webView23.TabIndex = 11;
            this.webView23.ZoomFactor = 1D;
            this.webView23.Click += new System.EventHandler(this.webView23_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 465);
            this.Controls.Add(this.webView23);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView23)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button start;
        private Button btn_input;
        private Button btn_output;
        private TextBox input_text;
        private TextBox output_text;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private GroupBox groupBox3;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button3;
        private Button button4;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView23;
    }
}