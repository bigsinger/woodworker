namespace woodworker;
public partial class FormMain : Form {

    private static TextBox txtLog;
    public static void Log(string msg) {
        txtLog.AppendText(msg + "\r\n");
    }

    public FormMain() {
        InitializeComponent();
        InitControls();
    }

    private void InitControls() {
        txtLog = txtResult;
        tabControlMain.TabPages.Clear();
        tabControlMain.TabPages.Add(new TabPage("书桌") { Controls = { new UserControlDesk() } });
        tabControlMain.TabPages.Add(new TabPage("一般抽屉") { Controls = { new UserControlDrawer() } });
        tabControlMain.TabPages.Add(new TabPage("地面抽屉") { Controls = { new UserControl地面抽屉() } });
        tabControlMain.TabPages.Add(new TabPage("床头柜") { Controls = { new UserControl床头柜() } });
        tabControlMain.TabPages.Add(new TabPage("免拉手槽") { Controls = { new UserControl免拉手槽() } });
        tabControlMain.TabPages.Add(new TabPage("待开放") { });
        txtResult.Multiline = true;
        txtResult.ScrollBars = ScrollBars.Vertical;
    }
}
