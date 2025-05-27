namespace woodworker {
    partial class UserControlDesk {
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
            txtLong = new TextBox();
            btnStart = new Button();
            label1 = new Label();
            label2 = new Label();
            txtWidth = new TextBox();
            label3 = new Label();
            txtHeight = new TextBox();
            label4 = new Label();
            txt抽屉数量 = new TextBox();
            label5 = new Label();
            txt抽屉高度 = new TextBox();
            txt左脚腿桌边距 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txt右脚腿桌边距 = new TextBox();
            SuspendLayout();
            // 
            // txtLong
            // 
            txtLong.Location = new Point(49, 15);
            txtLong.Name = "txtLong";
            txtLong.Size = new Size(100, 23);
            txtLong.TabIndex = 0;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(492, 12);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 29);
            btnStart.TabIndex = 1;
            btnStart.Text = "计算";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 18);
            label1.Name = "label1";
            label1.Size = new Size(32, 17);
            label1.TabIndex = 2;
            label1.Text = "长：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(165, 21);
            label2.Name = "label2";
            label2.Size = new Size(32, 17);
            label2.TabIndex = 4;
            label2.Text = "宽：";
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(203, 18);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(100, 23);
            txtWidth.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(315, 21);
            label3.Name = "label3";
            label3.Size = new Size(32, 17);
            label3.TabIndex = 6;
            label3.Text = "高：";
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(353, 18);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(100, 23);
            txtHeight.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 70);
            label4.Name = "label4";
            label4.Size = new Size(68, 17);
            label4.TabIndex = 9;
            label4.Text = "抽屉数量：";
            // 
            // txt抽屉数量
            // 
            txt抽屉数量.Location = new Point(109, 70);
            txt抽屉数量.Name = "txt抽屉数量";
            txt抽屉数量.Size = new Size(72, 23);
            txt抽屉数量.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(237, 76);
            label5.Name = "label5";
            label5.Size = new Size(68, 17);
            label5.TabIndex = 11;
            label5.Text = "抽屉高度：";
            // 
            // txt抽屉高度
            // 
            txt抽屉高度.Location = new Point(303, 73);
            txt抽屉高度.Name = "txt抽屉高度";
            txt抽屉高度.Size = new Size(72, 23);
            txt抽屉高度.TabIndex = 10;
            // 
            // txt左脚腿桌边距
            // 
            txt左脚腿桌边距.Location = new Point(109, 44);
            txt左脚腿桌边距.Name = "txt左脚腿桌边距";
            txt左脚腿桌边距.Size = new Size(72, 23);
            txt左脚腿桌边距.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 47);
            label6.Name = "label6";
            label6.Size = new Size(92, 17);
            label6.TabIndex = 11;
            label6.Text = "左脚腿桌边距：";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(211, 50);
            label7.Name = "label7";
            label7.Size = new Size(92, 17);
            label7.TabIndex = 13;
            label7.Text = "右脚腿桌边距：";
            // 
            // txt右脚腿桌边距
            // 
            txt右脚腿桌边距.Location = new Point(303, 47);
            txt右脚腿桌边距.Name = "txt右脚腿桌边距";
            txt右脚腿桌边距.Size = new Size(72, 23);
            txt右脚腿桌边距.TabIndex = 12;
            // 
            // UserControlDesk
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label7);
            Controls.Add(txt右脚腿桌边距);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txt左脚腿桌边距);
            Controls.Add(txt抽屉高度);
            Controls.Add(label4);
            Controls.Add(txt抽屉数量);
            Controls.Add(label3);
            Controls.Add(txtHeight);
            Controls.Add(label2);
            Controls.Add(txtWidth);
            Controls.Add(label1);
            Controls.Add(btnStart);
            Controls.Add(txtLong);
            Name = "UserControlDesk";
            Size = new Size(572, 124);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLong;
        private Button btnStart;
        private Label label1;
        private Label label2;
        private TextBox txtWidth;
        private Label label3;
        private TextBox txtHeight;
        private Label label4;
        private TextBox txt抽屉数量;
        private Label label5;
        private TextBox txt抽屉高度;
        private TextBox txt左脚腿桌边距;
        private Label label6;
        private Label label7;
        private TextBox txt右脚腿桌边距;
    }
}
