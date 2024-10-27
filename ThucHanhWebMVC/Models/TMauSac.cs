using System;
using System.Collections.Generic;

namespace ThucHanhWebMVC.Models;

public partial class TMauSac
{
    public string MaMauSac { get; set; } = null!;

    public string? TenMauSac { get; set; }

    public virtual ICollection<TChiTietSanPham> TChiTietSanPhams { get; set; } = new List<TChiTietSanPham>();
}
