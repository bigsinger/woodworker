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
        tabControlMain.TabPages.Add(new TabPage("Êé×À") { Controls = { new UserControlDesk() } });
        tabControlMain.TabPages.Add(new TabPage("³éÌë") { Controls = { new UserControlDrawer() } });
        tabControlMain.TabPages.Add(new TabPage("´ý¿ª·Å") { });
        txtResult.Multiline = true;
        txtResult.ScrollBars = ScrollBars.Vertical;
    }
}
