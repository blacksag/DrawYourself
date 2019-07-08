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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tools
            // 
            this.tools.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tools.Dock = System.Windows.Forms.DockStyle.Top;
            this.tools.Location = new System.Drawing.Point(0, 0);
            this.tools.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tools.Name = "tools";
            this.tools.Size = new System.Drawing.Size(1064, 57);
            this.tools.TabIndex = 0;
            // 
            // canvas
            // 
            this.canvas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.canvas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvas.Location = new System.Drawing.Point(99, 201);
            this.canvas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.canvas.MaximumSize = new System.Drawing.Size(341, 320);
            this.canvas.MinimumSize = new System.Drawing.Size(341, 320);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(341, 320);
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
            this.frame.Location = new System.Drawing.Point(627, 201);
            this.frame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.frame.MaximumSize = new System.Drawing.Size(341, 320);
            this.frame.MinimumSize = new System.Drawing.Size(341, 320);
            this.frame.Name = "frame";
            this.frame.Size = new System.Drawing.Size(341, 320);
            this.frame.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Location = new System.Drawing.Point(469, 229);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 56);
            this.button1.TabIndex = 3;
            this.button1.Text = "doodle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(469, 433);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 53);
            this.button2.TabIndex = 4;
            this.button2.Text = "clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 136);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(341, 31);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(627, 136);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(341, 31);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1064, 630);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.frame);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.tools);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(925, 682);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Draw Doodles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel tools;
        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.Panel frame;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

