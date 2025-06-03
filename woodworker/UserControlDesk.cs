namespace woodworker;
public partial class UserControlDesk : UserControl {
    const int 木板厚度 = 18;                    // 木板厚度为18mm
    const int 踢脚板厚度 = 30;                   // 踢脚线厚度为30mm
    const int 排线孔宽 = 50;                    // 50mm
    const int 面板之间缝隙 = 2;                //2mm 
    const int 单个封边条厚度 = 2;                //2mm 准确的话是1.5mm，取整数2mm
    const int 两个封边条厚度 = 3;                //3mm
    const int 滑轨预留空间 = 30;              // 滑轨实际需要>=26mm
    const int 底板厚度 = 6;                         // 背板厚度为6mm

    public UserControlDesk() {
        InitializeComponent();
        InitControls();
    }

    void InitControls() {
        this.Dock = DockStyle.Fill;
        txtLong.Text = "1425";
        txtWidth.Text = "450";
        txtHeight.Text = "750";
        txt抽屉数量.Text = "3";
        txt抽屉高度.Text = "130";
        txt左脚腿桌边距.Text = 踢脚板厚度.ToString();
        txt右脚腿桌边距.Text = 踢脚板厚度.ToString();
    }

    private void btnStart_Click(object sender, EventArgs e) {
        int 总长 = Int32.Parse(txtLong.Text);
        int 总宽 = Int32.Parse(txtWidth.Text);
        int 总高 = Int32.Parse(txtHeight.Text);
        int 抽屉数量 = Int32.Parse(txt抽屉数量.Text);
        int 抽屉高度 = Int32.Parse(txt抽屉高度.Text);
        int 左脚腿桌边距 = Int32.Parse(txt左脚腿桌边距.Text);
        int 右脚腿桌边距 = Int32.Parse(txt右脚腿桌边距.Text);

        List<CutPiece> cutPieces = new();

        ///////////////////////////////////////////
        var 面板 = new CutPiece("桌面面板");
        面板.Notes = "桌面面板外侧需要封边";
        面板.长度 = 总长;
        面板.宽度 = 总宽;
        面板.Quantity = 1;
        cutPieces.Add(面板);
        ///////////////////////////////////////////

        ///////////////////////////////////////////
        var 侧板 = new CutPiece("桌子侧板");
        侧板.Notes = "长度 = 总高 - 木板厚度; 宽度 = 总宽 - 踢脚线厚度; 侧板底部和外侧需要封边；";
        侧板.长度 = 总高 - 木板厚度;
        侧板.宽度 = 总宽 - 踢脚板厚度;
        侧板.Quantity = 2;
        cutPieces.Add(侧板);
        ///////////////////////////////////////////

        ///////////////////////////////////////////
        var 隔板 = new CutPiece("桌子隔板");
        隔板.Notes = "内缩一个板厚度做免拉手抽屉";
        隔板.长度 = 总长 - 左脚腿桌边距 - 右脚腿桌边距 - 木板厚度 * 2;
        隔板.宽度 = 总宽 - 排线孔宽 - 木板厚度 - 木板厚度;
        隔板.Quantity = 1;
        cutPieces.Add(隔板);
        ///////////////////////////////////////////

        var 立板 = new CutPiece("桌子小立板");
        立板.Notes = "";
        立板.长度 = 隔板.宽度;
        立板.宽度 = 抽屉高度;
        立板.Quantity = 抽屉数量 - 1;
        cutPieces.Add(立板);

        ///////////////////////////////////////////

        var 支撑 = new CutPiece("桌子支撑");
        支撑.长度 = 隔板.长度;
        支撑.宽度 = 50;
        支撑.Quantity = 1;
        支撑.Notes = "组装时建议离地高8-10cm，宽度5~10cm，使用边角料即可，无须单独开料。若桌子两侧有依靠物稳定可以不用支撑，若无需要增加支撑否则摇晃不稳。";
        cutPieces.Add(支撑);

        ///////////////////////////////////////////

        var 抽屉背板 = new CutPiece("桌子抽屉背板");
        抽屉背板.Notes = "";
        抽屉背板.长度 = 隔板.长度;
        抽屉背板.宽度 = 抽屉高度 + 木板厚度;
        抽屉背板.Quantity = 1;
        cutPieces.Add(抽屉背板);


        var 抽屉面板 = new CutPiece("桌子抽屉面板");
        抽屉面板.Notes = "抽屉面板宽 = 小立板高 + 板厚 + 1.2cm (免拉手)";
        抽屉面板.长度 = (隔板.长度 - (抽屉数量 + 1) * 面板之间缝隙) / 抽屉数量 - 两个封边条厚度;
        抽屉面板.宽度 = 抽屉高度 + 木板厚度 + 12;
        抽屉面板.Quantity = 抽屉数量;
        cutPieces.Add(抽屉面板);

        var 抽屉底板 = new CutPiece("桌子抽屉底板");
        抽屉底板.Notes = "底板用背板材料（6mm）";
        抽屉底板.长度 = 隔板.宽度 - 5; // 预留5mm空间，以免推不进去
        抽屉底板.宽度 = (隔板.长度 - (抽屉数量 - 1) * 木板厚度) / 抽屉数量 - 滑轨预留空间;
        抽屉底板.Quantity = 抽屉数量;
        cutPieces.Add(抽屉底板);

        var 抽屉围板前后 = new CutPiece("桌子抽屉围板前后");
        抽屉围板前后.长度 = 抽屉底板.宽度 - 木板厚度 * 2;
        抽屉围板前后.宽度 = 抽屉高度 - 底板厚度 - 10;   // 上下预留10mm空间，以免推不进去
        抽屉围板前后.Quantity = 抽屉数量 * 2;
        cutPieces.Add(抽屉围板前后);

        var 抽屉围板左右 = new CutPiece("桌子抽屉围板左右");
        抽屉围板左右.长度 = 抽屉底板.长度;
        抽屉围板左右.宽度 = 抽屉围板前后.宽度;
        抽屉围板左右.Quantity = 抽屉数量 * 2;
        cutPieces.Add(抽屉围板左右);


        ///////////////////////////////////////////
        string result = string.Empty;
        result += $"【书桌设计】：\r\n总长: {总长}mm, 总宽: {总宽}mm, 总高: {总高}mm, 左脚腿桌边距: {左脚腿桌边距}mm, 右脚腿桌边距: {右脚腿桌边距}mm\r\n";
        result += $"踢脚板厚度: {踢脚板厚度}mm, 排线孔宽: {排线孔宽}mm\r\n";
        result += $"抽屉数量: {抽屉数量} 个, 抽屉高度: {抽屉高度}mm\r\n";
        result += $"抽屉组装方式：抽屉底板托四个围板，左右围板夹前后围板。\r\n\n";

        int index = 1;
        foreach (var cutPiece in cutPieces) {
            result += $"{index}. {cutPiece.Name} - 长度: {cutPiece.长度}mm, 宽度: {cutPiece.宽度}mm, 数量: {cutPiece.Quantity}, 备注: {cutPiece.Notes}\r\n";
            index++;
        }
        FormMain.Log(result);
    }

}
