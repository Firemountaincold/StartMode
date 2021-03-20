
namespace StartMode
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
            this.buttonwork = new System.Windows.Forms.Button();
            this.buttonrelax = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonexplorer = new System.Windows.Forms.Button();
            this.buttonrelaxdel = new System.Windows.Forms.Button();
            this.buttonworkdel = new System.Windows.Forms.Button();
            this.buttonrelaxjoin = new System.Windows.Forms.Button();
            this.buttonworkjoin = new System.Windows.Forms.Button();
            this.textBoxadd = new System.Windows.Forms.TextBox();
            this.buttonstart = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonwork
            // 
            this.buttonwork.Location = new System.Drawing.Point(16, 50);
            this.buttonwork.Name = "buttonwork";
            this.buttonwork.Size = new System.Drawing.Size(300, 100);
            this.buttonwork.TabIndex = 0;
            this.buttonwork.Text = "工作模式";
            this.buttonwork.UseVisualStyleBackColor = true;
            this.buttonwork.Click += new System.EventHandler(this.buttonwork_Click);
            // 
            // buttonrelax
            // 
            this.buttonrelax.Location = new System.Drawing.Point(16, 160);
            this.buttonrelax.Name = "buttonrelax";
            this.buttonrelax.Size = new System.Drawing.Size(300, 100);
            this.buttonrelax.TabIndex = 1;
            this.buttonrelax.Text = "休闲模式";
            this.buttonrelax.UseVisualStyleBackColor = true;
            this.buttonrelax.Click += new System.EventHandler(this.buttonrelax_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "请选择启动模式";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonexplorer);
            this.groupBox1.Controls.Add(this.buttonrelaxdel);
            this.groupBox1.Controls.Add(this.buttonworkdel);
            this.groupBox1.Controls.Add(this.buttonrelaxjoin);
            this.groupBox1.Controls.Add(this.buttonworkjoin);
            this.groupBox1.Controls.Add(this.textBoxadd);
            this.groupBox1.Location = new System.Drawing.Point(13, 268);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 170);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "编辑启动项";
            // 
            // buttonexplorer
            // 
            this.buttonexplorer.Location = new System.Drawing.Point(210, 26);
            this.buttonexplorer.Name = "buttonexplorer";
            this.buttonexplorer.Size = new System.Drawing.Size(85, 29);
            this.buttonexplorer.TabIndex = 5;
            this.buttonexplorer.Text = "浏览";
            this.buttonexplorer.UseVisualStyleBackColor = true;
            this.buttonexplorer.Click += new System.EventHandler(this.buttonexplorer_Click);
            // 
            // buttonrelaxdel
            // 
            this.buttonrelaxdel.Location = new System.Drawing.Point(156, 111);
            this.buttonrelaxdel.Name = "buttonrelaxdel";
            this.buttonrelaxdel.Size = new System.Drawing.Size(139, 44);
            this.buttonrelaxdel.TabIndex = 4;
            this.buttonrelaxdel.Text = "从休闲模式删除";
            this.buttonrelaxdel.UseVisualStyleBackColor = true;
            this.buttonrelaxdel.Click += new System.EventHandler(this.buttonrelaxdel_Click);
            // 
            // buttonworkdel
            // 
            this.buttonworkdel.Location = new System.Drawing.Point(9, 111);
            this.buttonworkdel.Name = "buttonworkdel";
            this.buttonworkdel.Size = new System.Drawing.Size(134, 44);
            this.buttonworkdel.TabIndex = 3;
            this.buttonworkdel.Text = "从工作模式删除";
            this.buttonworkdel.UseVisualStyleBackColor = true;
            this.buttonworkdel.Click += new System.EventHandler(this.buttonworkdel_Click);
            // 
            // buttonrelaxjoin
            // 
            this.buttonrelaxjoin.Location = new System.Drawing.Point(156, 61);
            this.buttonrelaxjoin.Name = "buttonrelaxjoin";
            this.buttonrelaxjoin.Size = new System.Drawing.Size(139, 44);
            this.buttonrelaxjoin.TabIndex = 2;
            this.buttonrelaxjoin.Text = "加入休闲模式";
            this.buttonrelaxjoin.UseVisualStyleBackColor = true;
            this.buttonrelaxjoin.Click += new System.EventHandler(this.buttonrelaxjoin_Click);
            // 
            // buttonworkjoin
            // 
            this.buttonworkjoin.Location = new System.Drawing.Point(9, 61);
            this.buttonworkjoin.Name = "buttonworkjoin";
            this.buttonworkjoin.Size = new System.Drawing.Size(134, 44);
            this.buttonworkjoin.TabIndex = 1;
            this.buttonworkjoin.Text = "加入工作模式";
            this.buttonworkjoin.UseVisualStyleBackColor = true;
            this.buttonworkjoin.Click += new System.EventHandler(this.buttonworkjoin_Click);
            // 
            // textBoxadd
            // 
            this.textBoxadd.Location = new System.Drawing.Point(7, 27);
            this.textBoxadd.Name = "textBoxadd";
            this.textBoxadd.Size = new System.Drawing.Size(197, 27);
            this.textBoxadd.TabIndex = 0;
            // 
            // buttonstart
            // 
            this.buttonstart.Location = new System.Drawing.Point(208, 9);
            this.buttonstart.Name = "buttonstart";
            this.buttonstart.Size = new System.Drawing.Size(108, 32);
            this.buttonstart.TabIndex = 4;
            this.buttonstart.Text = "自启动";
            this.buttonstart.UseVisualStyleBackColor = true;
            this.buttonstart.Click += new System.EventHandler(this.buttonstart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 450);
            this.Controls.Add(this.buttonstart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonrelax);
            this.Controls.Add(this.buttonwork);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartMode";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonwork;
        private System.Windows.Forms.Button buttonrelax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonexplorer;
        private System.Windows.Forms.Button buttonrelaxdel;
        private System.Windows.Forms.Button buttonworkdel;
        private System.Windows.Forms.Button buttonrelaxjoin;
        private System.Windows.Forms.Button buttonworkjoin;
        private System.Windows.Forms.TextBox textBoxadd;
        private System.Windows.Forms.Button buttonstart;
    }
}

