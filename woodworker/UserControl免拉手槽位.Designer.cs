namespace woodworker {
    partial class UserControl免拉手槽 {
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
            txt槽净高 = new TextBox();
            btnStart = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(44, 17);
            label1.TabIndex = 6;
            label1.Text = "净宽：";
            // 
            // txt净宽
            // 
            txt净宽.Location = new Point(62, 8);
            txt净宽.Name = "txt净宽";
            txt净宽.Size = new Size(87, 23);
            txt净宽.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(166, 11);
            label2.Name = "label2";
            label2.Size = new Size(80, 17);
            label2.TabIndex = 8;
            label2.Text = "槽预留净高：";
            // 
            // txt槽净高
            // 
            txt槽净高.Location = new Point(252, 8);
            txt槽净高.Name = "txt槽净高";
            txt槽净高.Size = new Size(74, 23);
            txt槽净高.TabIndex = 7;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(332, 5);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 29);
            btnStart.TabIndex = 10;
            btnStart.Text = "计算";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // UserControl免拉手槽
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnStart);
            Controls.Add(label2);
            Controls.Add(txt槽净高);
            Controls.Add(label1);
            Controls.Add(txt净宽);
            Name = "UserControl免拉手槽";
            Size = new Size(415, 150);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt净宽;
        private Label label2;
        private TextBox txt槽净高;
        private Button btnStart;
    }
}
