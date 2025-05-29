namespace woodworker;
public partial class UserControl免拉手槽 : UserControl {
    const int 面板外延尺寸 = 10;      // 面板外延尺寸，单位mm
    const int 槽深 = 20;          // 单位mm
    const int 木板厚度 = 18;                        // 木板厚度为18mm

    public UserControl免拉手槽() {
        InitializeComponent();
        InitControls();
    }

    void InitControls() {
        this.Dock = DockStyle.Fill;
        txt槽净高.Text = "20";
    }

    private void btnStart_Click(object sender, EventArgs e) {
        int 槽净高 = int.Parse(txt槽净高.Text.Trim());
        int 槽总高 = 槽净高 + 面板外延尺寸 * 2; // 上下各延伸10mm
        int 槽宽 = int.Parse(txt净宽.Text.Trim());

        List<CutPiece> cutPieces = new();

        var 横条 = new CutPiece("横条");
        横条.长度 = 槽宽;
        横条.宽度 = 槽深 + 木板厚度 + 木板厚度;
        横条.Quantity = 1;
        横条.Notes = "横条压竖条，外边层板齐，内侧多一板，好做无钉眼";
        cutPieces.Add(横条);

        var 竖条 = new CutPiece("竖条");
        竖条.长度 = 槽宽;
        竖条.宽度 = 槽总高;
        竖条.Quantity = 1;
        竖条.Notes = "横条压竖条，竖条与层板固定";
        cutPieces.Add(竖条);


        ///////////////////////////////////////////
        string result = string.Empty;
        result += $"【免拉手槽】：\r\n槽净高: {槽净高}mm, 槽宽: {槽宽}mm\r\n";
        result += $"组装方式：横条压竖条，外边层板齐，内侧多一板，好做无钉眼；竖条钉层板，可在层板上，可在层板下。\r\n\r\n";

        int index = 1;
        foreach (var cutPiece in cutPieces) {
            result += $"{index}. {cutPiece.Name} - 长度: {cutPiece.长度}mm, 宽度: {cutPiece.宽度}mm, 数量: {cutPiece.Quantity}, 备注: {cutPiece.Notes}\r\n";
            index++;
        }
        FormMain.Log(result);
    }
}
