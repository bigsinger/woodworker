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
        tabControlMain.TabPages.Add(new TabPage("����") { Controls = { new UserControlDesk() } });
        tabControlMain.TabPages.Add(new TabPage("����") { Controls = { new UserControlDrawer() } });
        tabControlMain.TabPages.Add(new TabPage("������") { });
        txtResult.Multiline = true;
        txtResult.ScrollBars = ScrollBars.Vertical;
    }
}
