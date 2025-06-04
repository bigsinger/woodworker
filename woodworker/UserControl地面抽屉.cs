namespace woodworker {
    public partial class UserControl地面抽屉 : UserControl {
        const int 木板厚度 = 18;                        // 木板厚度为18mm

        public UserControl地面抽屉() {
            InitializeComponent();
            InitControls();
        }

        void InitControls() {
            this.Dock = DockStyle.Fill;
            txt数量.Text = "1";
        }

        private void btnStart_Click(object sender, EventArgs e) {
            int 总长 = Int32.Parse(txt总长.Text.Trim());
            int 总宽 = Int32.Parse(txt总宽.Text.Trim());
            int 净深 = Int32.Parse(txt净深.Text.Trim());
            int 数量 = Int32.Parse(txt数量.Text.Trim());

            List<CutPiece> cutPieces = new();

            var 底板 = new CutPiece("底板");
            底板.长度 = 总长;
            底板.宽度 = 总宽;
            底板.Quantity = 数量 * 1;
            底板.Notes = "底板用木板材料（18mm），底板托四围；四边须封闭；";
            cutPieces.Add(底板);

            var 左右侧板 = new CutPiece("左右侧板");
            左右侧板.长度 = 底板.长度;
            左右侧板.宽度 = 净深;
            左右侧板.Quantity = 数量 * 2;
            左右侧板.Notes = "左右夹前后；前后顶三边封边；";
            cutPieces.Add(左右侧板);

            var 前后侧板 = new CutPiece("前后侧板");
            前后侧板.长度 = 底板.宽度 - 2 * 木板厚度;
            前后侧板.宽度 = 净深;
            前后侧板.Quantity = 数量 * 2;
            前后侧板.Notes = "左右夹前后；顶边须封边；";
            cutPieces.Add(前后侧板);

            ///////////////////////////////////////////
            string result = string.Empty;
            result += $"【地面抽屉】：\r\n总长: {总长}mm, 总宽: {总宽}mm, 净深: {净深}mm\r\n";
            result += $"组装方式：底板托四围，左右夹前后。\r\n\r\n";

            int index = 1;
            foreach (var cutPiece in cutPieces) {
                result += $"{index}. {cutPiece.Name} - 长度: {cutPiece.长度}mm, 宽度: {cutPiece.宽度}mm, 数量: {cutPiece.Quantity}, 备注: {cutPiece.Notes}\r\n";
                index++;
            }
            FormMain.Log(result);
        }
    }
}
