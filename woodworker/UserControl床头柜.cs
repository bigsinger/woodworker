namespace woodworker;
public partial class UserControl床头柜 : UserControl {
    const int 木板厚度 = 18;                        // 木板厚度为18mm
    const int 面板之间缝隙 = 2;                       //2mm 
    const int 单个封边条厚度 = 2;                      //2mm 准确的话是1.5mm，取整数2mm
    const int 两个封边条厚度 = 3;                      //3mm
    const int 背板厚度 = 6;                         // 背板厚度为6mm


    public UserControl床头柜() {
        InitializeComponent();
        InitControls();
    }


    void InitControls() {
        this.Dock = DockStyle.Fill;

        txt悬空高度.Text = 木板厚度.ToString();
        txt左右立板凸出高度.Text = 木板厚度.ToString();

        txt总高.Text = "470";
        txt总宽.Text = "400";
        txt总深.Text = "360";
    }

    private void btnStart_Click(object sender, EventArgs e) {
        int 总高 = Int32.Parse(txt总高.Text);
        int 总宽 = Int32.Parse(txt总宽.Text);
        int 总深 = Int32.Parse(txt总深.Text);
        int 悬空高度 = Int32.Parse(txt悬空高度.Text);
        int 抽屉净高 = 160;

        int 净深 = 总深 - 背板厚度 - 木板厚度;
        int 净宽 = 总宽 - 木板厚度 * 2;
        int 净高 = 总高 - 悬空高度;
        ///////////////////////////////////////////

        List<CutPiece> cutPieces = new();

        var 左右立板 = new CutPiece("左右立板");
        左右立板.长度 = 净高 - 木板厚度 - 木板厚度;
        左右立板.宽度 = 净深;
        左右立板.Quantity = 2;
        左右立板.Notes = "被顶板和底板夹，外侧单边封边；";
        cutPieces.Add(左右立板);

        var 顶板 = new CutPiece("顶板");
        顶板.长度 = 总宽;    // 这里不减封边的厚度了
        顶板.宽度 = 总深;    // 这里不减封边的厚度了
        顶板.Quantity = 1;
        顶板.Notes = "顶板压左右立板、背板、抽屉面板，四边封边；";
        cutPieces.Add(顶板);

        var 底板 = new CutPiece("底板");
        底板.长度 = 总宽;
        底板.宽度 = 净深;
        底板.Quantity = 1;
        底板.Notes = "底板托左右立板，左右前封边；";
        cutPieces.Add(底板);

        var 层板 = new CutPiece("层板");
        层板.长度 = 总宽 - 木板厚度 - 木板厚度;
        层板.宽度 = 净深;
        层板.Quantity = 1;
        层板.Notes = "外侧封边；";
        cutPieces.Add(层板);


        var 上抽面板 = new CutPiece("上抽面板");
        上抽面板.长度 = 总宽;
        上抽面板.宽度 = 抽屉净高 + 木板厚度 + (木板厚度 / 2) - 两个封边条厚度 - 1; // 与下柜的柜门让1mm
        上抽面板.Quantity = 1;
        上抽面板.Notes = "四边封边；";
        cutPieces.Add(上抽面板);

        var 上抽左右围板 = new CutPiece("上抽左右围板");
        上抽左右围板.长度 = 净深 - 5;
        上抽左右围板.宽度 = 抽屉净高 - 10;
        上抽左右围板.Quantity = 2;
        上抽左右围板.Notes = "顶边封边；";
        cutPieces.Add(上抽左右围板);

        var 上抽前后围板 = new CutPiece("上抽前后围板");
        上抽前后围板.长度 = 层板.长度 - 木板厚度 - 木板厚度 - 15;    // 预留一点卡块的空间
        上抽前后围板.宽度 = 上抽左右围板.宽度;
        上抽前后围板.Quantity = 2;
        上抽前后围板.Notes = "顶边封边；";
        cutPieces.Add(上抽前后围板);

        var 上抽底板 = new CutPiece("上抽底板");
        上抽底板.长度 = 上抽左右围板.长度;
        上抽底板.宽度 = 上抽前后围板.长度 + 木板厚度 + 木板厚度;
        上抽底板.Quantity = 1;
        上抽底板.Notes = "使用背板材料（6mm）；";
        cutPieces.Add(上抽底板);


        var 下柜柜门 = new CutPiece("下柜柜门");
        下柜柜门.长度 = 总宽;
        下柜柜门.宽度 = 总高 - 悬空高度 - 木板厚度 - 抽屉净高 - (木板厚度 / 2) - 两个封边条厚度 - 1;// 与上抽面板让1mm
        下柜柜门.Quantity = 1;
        下柜柜门.Notes = "四边封边；";
        cutPieces.Add(下柜柜门);


        var 背板 = new CutPiece("背板");
        背板.长度 = 总高 - 悬空高度 - 木板厚度; // 不到顶（不压顶板）
        背板.宽度 = 总宽;
        背板.Quantity = 1;
        背板.Notes = "不压顶板；6mm背板；";
        cutPieces.Add(背板);

        ///////////////////////////////////////////
        string result = string.Empty;
        result += $"【床头柜】：\r\n总高: {总高}mm, 总宽: {总宽}mm, 总深: {总深}mm, 悬空高度: {悬空高度}mm\r\n\r\n";
        result += $"方案：上抽下柜；\r\n";
        result += $"抽屉面板、柜门面板压侧板，不做拉手，从两边抠开；\r\n";
        result += $"顶板压左右立板、背板、抽屉面板，四边封边；\r\n";
        result += $"底板托左右立板，左右前封边；\r\n";
        result += $"背板覆盖左右立板、底板，不覆盖顶板；\r\n";
        result += $"底板四角粘滑轮或者固定木片，防潮；\r\n";
        result += $"抽屉不用滑轨，固定钉子防止掉出来；\r\n\r\n";

        int index = 1;
        foreach (var cutPiece in cutPieces) {
            result += $"{index}. {cutPiece.Name} - 长度: {cutPiece.长度}mm, 宽度: {cutPiece.宽度}mm, 数量: {cutPiece.Quantity}, 备注: {cutPiece.Notes}\r\n";
            index++;
        }
        FormMain.Log(result);
    }
}
