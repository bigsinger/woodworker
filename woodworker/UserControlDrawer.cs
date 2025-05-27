namespace woodworker;
public partial class UserControlDrawer : UserControl {
    const int 木板厚度 = 18;                    // 木板厚度为18mm
    const int 滑轨预留空间 = 30;                  // 滑轨实际需要>=26mm

    public UserControlDrawer() {
        InitializeComponent();
        InitControls();
        txt净高.Text = "130";
        txt净宽.Text = "300";
        txt净深.Text = "400";
    }

    void InitControls() {
        this.Dock = DockStyle.Fill;
    }

    private void btnStart_Click(object sender, EventArgs e) {
        const int 抽屉数量 = 1;
        int 净高 = Int32.Parse(txt净高.Text);
        int 净宽 = Int32.Parse(txt净宽.Text);
        int 净深 = Int32.Parse(txt净深.Text);
        List<CutPiece> cutPieces = new();

        var 底板 = new CutPiece("抽屉底板");
        底板.长度 = 净深 - 5; // 预留5mm空间，以免推不进去
        底板.宽度 = 净宽 - 滑轨预留空间;
        底板.Quantity = 抽屉数量 * 1;
        底板.Notes = "底板左右侧边最好封边";
        cutPieces.Add(底板);

        var 前后围板 = new CutPiece("前后围板");
        前后围板.长度 = 底板.宽度 - 木板厚度 * 2;
        前后围板.宽度 = 净高 - 木板厚度 - 10;   // 上下预留10mm空间，以免推不进去
        前后围板.Quantity = 抽屉数量 * 2;
        前后围板.Notes = "前后围板顶边最好封边";
        cutPieces.Add(前后围板);

        var 左右围板 = new CutPiece("左右围板");
        左右围板.长度 = 底板.长度;
        左右围板.宽度 = 前后围板.宽度;
        左右围板.Quantity = 抽屉数量 * 2;
        左右围板.Notes = "左右围板顶边最好封边";
        cutPieces.Add(左右围板);


        ///////////////////////////////////////////
        string result = string.Empty;
        result += $"【抽屉设计】：\r\n净高: {净高}mm, 净宽: {净宽}mm, 净深: {净深}mm, 滑轨预留空间: {滑轨预留空间}mm\r\n";
        result += $"抽屉组装方式：抽屉底板托四个围板，左右围板夹前后围板。面板暂不考虑，请自行设计。\r\n\r\n";

        int index = 1;
        foreach (var cutPiece in cutPieces) {
            result += $"{index}. {cutPiece.Name} - 长度: {cutPiece.长度}mm, 宽度: {cutPiece.宽度}mm, 数量: {cutPiece.Quantity}, 备注: {cutPiece.Notes}\r\n";
            index++;
        }
        FormMain.Log(result);
    }
}
