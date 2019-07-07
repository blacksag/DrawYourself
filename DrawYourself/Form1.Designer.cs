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
            this.SuspendLayout();
            // 
            // tools
            // 
            this.tools.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tools.Dock = System.Windows.Forms.DockStyle.Top;
            this.tools.Location = new System.Drawing.Point(0, 0);
            this.tools.Name = "tools";
            this.tools.Size = new System.Drawing.Size(798, 85);
            this.tools.TabIndex = 0;
            // 
            // canvas
            // 
            this.canvas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.canvas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvas.Location = new System.Drawing.Point(74, 161);
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
            this.frame.Location = new System.Drawing.Point(470, 161);
            this.frame.MaximumSize = new System.Drawing.Size(256, 256);
            this.frame.MinimumSize = new System.Drawing.Size(256, 256);
            this.frame.Name = "frame";
            this.frame.Size = new System.Drawing.Size(256, 256);
            this.frame.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Location = new System.Drawing.Point(353, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(798, 504);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.frame);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.tools);
            this.MinimumSize = new System.Drawing.Size(700, 560);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Draw Doodles";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel tools;
        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.Panel frame;
        private System.Windows.Forms.Button button1;
    }
}

