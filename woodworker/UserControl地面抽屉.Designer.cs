namespace woodworker {
    partial class UserControl地面抽屉 {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            btnStart = new Button();
            label3 = new Label();
            txt总长 = new TextBox();
            label2 = new Label();
            txt净深 = new TextBox();
            label1 = new Label();
            txt总宽 = new TextBox();
            label4 = new Label();
            txt数量 = new TextBox();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(523, 18);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 29);
            btnStart.TabIndex = 16;
            btnStart.Text = "计算";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 24);
            label3.Name = "label3";
            label3.Size = new Size(44, 17);
            label3.TabIndex = 15;
            label3.Text = "总长：";
            // 
            // txt总长
            // 
            txt总长.Location = new Point(77, 21);
            txt总长.Name = "txt总长";
            txt总长.Size = new Size(56, 23);
            txt总长.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(264, 24);
            label2.Name = "label2";
            label2.Size = new Size(44, 17);
            label2.TabIndex = 13;
            label2.Text = "净深：";
            // 
            // txt净深
            // 
            txt净深.Location = new Point(314, 21);
            txt净深.Name = "txt净深";
            txt净深.Size = new Size(65, 23);
            txt净深.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(143, 24);
            label1.Name = "label1";
            label1.Size = new Size(44, 17);
            label1.TabIndex = 11;
            label1.Text = "总宽：";
            // 
            // txt总宽
            // 
            txt总宽.Location = new Point(193, 21);
            txt总宽.Name = "txt总宽";
            txt总宽.Size = new Size(61, 23);
            txt总宽.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(414, 24);
            label4.Name = "label4";
            label4.Size = new Size(44, 17);
            label4.TabIndex = 18;
            label4.Text = "数量：";
            // 
            // txt数量
            // 
            txt数量.Location = new Point(453, 21);
            txt数量.Name = "txt数量";
            txt数量.Size = new Size(49, 23);
            txt数量.TabIndex = 17;
            // 
            // UserControl地面抽屉
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(txt数量);
            Controls.Add(btnStart);
            Controls.Add(label3);
            Controls.Add(txt总长);
            Controls.Add(label2);
            Controls.Add(txt净深);
            Controls.Add(label1);
            Controls.Add(txt总宽);
            Name = "UserControl地面抽屉";
            Size = new Size(628, 150);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private Label label3;
        private TextBox txt总长;
        private Label label2;
        private TextBox txt净深;
        private Label label1;
        private TextBox txt总宽;
        private Label label4;
        private TextBox txt数量;
    }
}
