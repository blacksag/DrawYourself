namespace DrawYourself
{
    partial class Form1
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
            this.tools = new System.Windows.Forms.Panel();
            this.canvas = new System.Windows.Forms.Panel();
            this.frame = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tools
            // 
            this.tools.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tools.Dock = System.Windows.Forms.DockStyle.Top;
            this.tools.Location = new System.Drawing.Point(0, 0);
            this.tools.Name = "tools";
            this.tools.Size = new System.Drawing.Size(798, 46);
            this.tools.TabIndex = 0;
            // 
            // canvas
            // 
            this.canvas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.canvas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvas.Location = new System.Drawing.Point(35, 22);
            this.canvas.MaximumSize = new System.Drawing.Size(256, 256);
            this.canvas.MinimumSize = new System.Drawing.Size(256, 256);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(256, 256);
            this.canvas.TabIndex = 1;
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // frame
            // 
            this.frame.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.frame.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.frame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frame.Location = new System.Drawing.Point(431, 22);
            this.frame.MaximumSize = new System.Drawing.Size(256, 256);
            this.frame.MinimumSize = new System.Drawing.Size(256, 256);
            this.frame.Name = "frame";
            this.frame.Size = new System.Drawing.Size(256, 256);
            this.frame.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(314, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "doodle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(314, 284);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 42);
            this.button2.TabIndex = 4;
            this.button2.Text = "clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(190, 343);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(257, 26);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(468, 330);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 53);
            this.button3.TabIndex = 7;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.frame);
            this.panel1.Controls.Add(this.canvas);
            this.panel1.Location = new System.Drawing.Point(39, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 401);
            this.panel1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(798, 504);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tools);
            this.MinimumSize = new System.Drawing.Size(699, 557);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Draw Doodles";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel tools;
        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.Panel frame;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
    }
}

