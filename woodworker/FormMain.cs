namespace woodworker;
public partial class FormMain : Form {
    public FormMain() {
        InitializeComponent();

        InitControls();
    }

    private void InitControls() {
        tabControlMain.TabPages.Clear();
        tabControlMain.TabPages.Add(new TabPage("Êé×À") { Controls = { new UserControlDesk() } });
        tabControlMain.TabPages.Add(new TabPage("´ý¿ª·Å") { });
    }
}
