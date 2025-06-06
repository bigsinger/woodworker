﻿namespace woodworker;
public partial class UserControlDrawer : UserControl {
    const int 木板厚度 = 18;                        // 木板厚度为18mm
    const int 底板厚度 = 6;                         // 背板厚度为6mm
    const int 滑轨预留空间 = 26;                      // 滑轨实际需要>=25mm 再预留1mm


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
        方案1底板不内嵌();
        //方案2底板内嵌式();
    }

    void 方案1底板不内嵌() {
        const int 抽屉数量 = 1;
        int 净高 = Int32.Parse(txt净高.Text);
        int 净宽 = Int32.Parse(txt净宽.Text);
        int 净深 = Int32.Parse(txt净深.Text);
        List<CutPiece> cutPieces = new();

        var 底板 = new CutPiece("抽屉底板");
        底板.长度 = 净深 - 5; // 预留5mm空间，以免推不进去
        底板.宽度 = 净宽 - 滑轨预留空间;
        底板.Quantity = 抽屉数量 * 1;
        底板.Notes = "底板用背板材料（6mm）";
        cutPieces.Add(底板);

        var 前后围板 = new CutPiece("前后围板");
        前后围板.长度 = 底板.宽度 - 木板厚度 * 2;
        前后围板.宽度 = 净高 - 底板厚度 - 15;   // 上下预留15mm空间，以免推不进去，滑轨安装好后默认底部会悬空1cm高
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
        result += $"抽屉组装方式：底板背板式，左右夹前后，底在四围下。面板暂不考虑，请自行设计。\r\n\r\n";

        int index = 1;
        foreach (var cutPiece in cutPieces) {
            result += $"{index}. {cutPiece.Name} - 长度: {cutPiece.长度}mm, 宽度: {cutPiece.宽度}mm, 数量: {cutPiece.Quantity}, 备注: {cutPiece.Notes}\r\n";
            index++;
        }
        FormMain.Log(result);
    }


    void 方案2底板内嵌式() {
        const int 抽屉数量 = 1;
        int 净高 = Int32.Parse(txt净高.Text);
        int 净宽 = Int32.Parse(txt净宽.Text);
        int 净深 = Int32.Parse(txt净深.Text);
        List<CutPiece> cutPieces = new();

        var 左右围板 = new CutPiece("左右围板");
        左右围板.长度 = 净深 - 5;
        左右围板.宽度 = 净高 - 5;
        左右围板.Quantity = 抽屉数量 * 2;
        左右围板.Notes = "需开槽内嵌底板";
        cutPieces.Add(左右围板);

        var 底板 = new CutPiece("抽屉底板");
        底板.长度 = 左右围板.长度 - 2 * 木板厚度;
        底板.宽度 = 净宽 - 2 * 木板厚度 - 滑轨预留空间;
        底板.Quantity = 抽屉数量 * 1;
        底板.Notes = "底板用背板材料";
        cutPieces.Add(底板);

        var 前后围板 = new CutPiece("前后围板");
        前后围板.长度 = 左右围板.宽度;
        前后围板.宽度 = 底板.宽度;
        前后围板.Quantity = 抽屉数量 * 2;
        前后围板.Notes = "需开槽内嵌底板";
        cutPieces.Add(前后围板);

        // 修正底板尺寸，使其内嵌在围板开槽中
        ///////////////////////////////////////////
        底板.长度 += 木板厚度;
        底板.宽度 += 木板厚度;
        ///////////////////////////////////////////
        string result = string.Empty;
        result += $"【抽屉设计】：\r\n净高: {净高}mm, 净宽: {净宽}mm, 净深: {净深}mm, 滑轨预留空间: {滑轨预留空间}mm\r\n";
        result += $"抽屉组装方式：底板内嵌式，左右夹前后，底被四围夹。面板暂不考虑，请自行设计。\r\n\r\n";

        int index = 1;
        foreach (var cutPiece in cutPieces) {
            result += $"{index}. {cutPiece.Name} - 长度: {cutPiece.长度}mm, 宽度: {cutPiece.宽度}mm, 数量: {cutPiece.Quantity}, 备注: {cutPiece.Notes}\r\n";
            index++;
        }
        FormMain.Log(result);
    }
}
