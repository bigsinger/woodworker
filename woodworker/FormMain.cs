namespace woodworker;
public partial class FormMain : Form {
    public FormMain() {
        InitializeComponent();

        InitControls();
    }

    private void InitControls() {
        tabControlMain.TabPages.Clear();
        tabControlMain.TabPages.Add(new TabPage("����") { Controls = { new UserControlDesk() } });
        tabControlMain.TabPages.Add(new TabPage("������") { });
    }
}
