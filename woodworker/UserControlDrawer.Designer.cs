namespace woodworker {
    partial class UserControlDrawer {
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
            label1 = new Label();
            txt净宽 = new TextBox();
            label2 = new Label();
            txt净高 = new TextBox();
            label3 = new Label();
            txt净深 = new TextBox();
            btnStart = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 10);
            label1.Name = "label1";
            label1.Size = new Size(44, 17);
            label1.TabIndex = 4;
            label1.Text = "净宽：";
            // 
            // txt净宽
            // 
            txt净宽.Location = new Point(68, 7);
            txt净宽.Name = "txt净宽";
            txt净宽.Size = new Size(87, 23);
            txt净宽.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(160, 10);
            label2.Name = "label2";
            label2.Size = new Size(44, 17);
            label2.TabIndex = 6;
            label2.Text = "净高：";
            // 
            // txt净高
            // 
            txt净高.Location = new Point(210, 7);
            txt净高.Name = "txt净高";
            txt净高.Size = new Size(87, 23);
            txt净高.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(304, 10);
            label3.Name = "label3";
            label3.Size = new Size(44, 17);
            label3.TabIndex = 8;
            label3.Text = "净深：";
            // 
            // txt净深
            // 
            txt净深.Location = new Point(354, 7);
            txt净深.Name = "txt净深";
            txt净深.Size = new Size(87, 23);
            txt净深.TabIndex = 7;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(447, 4);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 29);
            btnStart.TabIndex = 9;
            btnStart.Text = "计算";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // UserControlDrawer
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnStart);
            Controls.Add(label3);
            Controls.Add(txt净深);
            Controls.Add(label2);
            Controls.Add(txt净高);
            Controls.Add(label1);
            Controls.Add(txt净宽);
            Name = "UserControlDrawer";
            Size = new Size(532, 71);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt净宽;
        private Label label2;
        private TextBox txt净高;
        private Label label3;
        private TextBox txt净深;
        private Button btnStart;
    }
}
