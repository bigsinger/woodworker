namespace woodworker
{
    partial class FormMain
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
        private void InitializeComponent() {
            tabControlMain = new TabControl();
            tabPageDesk = new TabPage();
            tabPage2 = new TabPage();
            txtResult = new TextBox();
            tabControlMain.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPageDesk);
            tabControlMain.Controls.Add(tabPage2);
            tabControlMain.Dock = DockStyle.Top;
            tabControlMain.Location = new Point(0, 0);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(800, 226);
            tabControlMain.TabIndex = 0;
            // 
            // tabPageDesk
            // 
            tabPageDesk.Location = new Point(4, 26);
            tabPageDesk.Name = "tabPageDesk";
            tabPageDesk.Padding = new Padding(3);
            tabPageDesk.Size = new Size(792, 196);
            tabPageDesk.TabIndex = 0;
            tabPageDesk.Text = "书桌";
            tabPageDesk.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 196);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtResult
            // 
            txtResult.Dock = DockStyle.Bottom;
            txtResult.Location = new Point(0, 228);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(800, 342);
            txtResult.TabIndex = 8;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 570);
            Controls.Add(txtResult);
            Controls.Add(tabControlMain);
            Name = "FormMain";
            Text = "木工计算器";
            tabControlMain.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControlMain;
        private TabPage tabPageDesk;
        private TabPage tabPage2;
        private TextBox txtResult;
    }
}
