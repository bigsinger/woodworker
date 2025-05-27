namespace woodworker;

// 切件
internal class CutPiece {
    public CutPiece(string name) { Name = name; }

    // 切件的名称
    public string Name { get; set; }

    // 切件的尺寸
    public int 长度 { get; set; }
    public int 宽度 { get; set; }

    // 切件的数量
    public int Quantity { get; set; }

    // 切件的备注信息
    public string Notes { get; set; } = string.Empty;
}
