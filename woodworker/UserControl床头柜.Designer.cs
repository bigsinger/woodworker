namespace woodworker {
    partial class UserControl床头柜 {
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
            label3 = new Label();
            txt总深 = new TextBox();
            label1 = new Label();
            txt总宽 = new TextBox();
            label2 = new Label();
            txt总高 = new TextBox();
            btnStart = new Button();
            label4 = new Label();
            txt悬空高度 = new TextBox();
            label5 = new Label();
            txt左右立板凸出高度 = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 15);
            label3.Name = "label3";
            label3.Size = new Size(44, 17);
            label3.TabIndex = 19;
            label3.Text = "总深：";
            // 
            // txt总深
            // 
            txt总深.Location = new Point(63, 12);
            txt总深.Name = "txt总深";
            txt总深.Size = new Size(56, 23);
            txt总深.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 15);
            label1.Name = "label1";
            label1.Size = new Size(44, 17);
            label1.TabIndex = 17;
            label1.Text = "总宽：";
            // 
            // txt总宽
            // 
            txt总宽.Location = new Point(179, 12);
            txt总宽.Name = "txt总宽";
            txt总宽.Size = new Size(61, 23);
            txt总宽.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(257, 15);
            label2.Name = "label2";
            label2.Size = new Size(44, 17);
            label2.TabIndex = 21;
            label2.Text = "总高：";
            // 
            // txt总高
            // 
            txt总高.Location = new Point(307, 12);
            txt总高.Name = "txt总高";
            txt总高.Size = new Size(61, 23);
            txt总高.TabIndex = 20;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(417, 9);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 29);
            btnStart.TabIndex = 22;
            btnStart.Text = "计算";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 55);
            label4.Name = "label4";
            label4.Size = new Size(68, 17);
            label4.TabIndex = 24;
            label4.Text = "悬空高度：";
            // 
            // txt悬空高度
            // 
            txt悬空高度.Location = new Point(87, 52);
            txt悬空高度.Name = "txt悬空高度";
            txt悬空高度.Size = new Size(86, 23);
            txt悬空高度.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(185, 55);
            label5.Name = "label5";
            label5.Size = new Size(116, 17);
            label5.TabIndex = 26;
            label5.Text = "左右立板凸出高度：";
            // 
            // txt左右立板凸出高度
            // 
            txt左右立板凸出高度.Location = new Point(307, 52);
            txt左右立板凸出高度.Name = "txt左右立板凸出高度";
            txt左右立板凸出高度.Size = new Size(56, 23);
            txt左右立板凸出高度.TabIndex = 25;
            // 
            // UserControl床头柜
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label5);
            Controls.Add(txt左右立板凸出高度);
            Controls.Add(label4);
            Controls.Add(txt悬空高度);
            Controls.Add(btnStart);
            Controls.Add(label2);
            Controls.Add(txt总高);
            Controls.Add(label3);
            Controls.Add(txt总深);
            Controls.Add(label1);
            Controls.Add(txt总宽);
            Name = "UserControl床头柜";
            Size = new Size(626, 150);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox txt总深;
        private Label label1;
        private TextBox txt总宽;
        private Label label2;
        private TextBox txt总高;
        private Button btnStart;
        private Label label4;
        private TextBox txt悬空高度;
        private Label label5;
        private TextBox txt左右立板凸出高度;
    }
}
