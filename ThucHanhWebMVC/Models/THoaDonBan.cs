using System;
using System.Collections.Generic;

namespace ThucHanhWebMVC.Models;

public partial class THoaDonBan
{
    public string MaHoaDon { get; set; } = null!;

    public DateTime? NgayHoaDon { get; set; }

    public string? MaKhachHang { get; set; }

    public string? MaNhanVien { get; set; }

    public decimal? TongTienHd { get; set; }

    public double? GiamGiaHd { get; set; }

    public byte? PhuongThucThanhToan { get; set; }

    public string? MaSoThue { get; set; }

    public string? ThongTinThue { get; set; }

    public string? GhiChu { get; set; }

    public virtual TKhachHang? MaKhachHangNavigation { get; set; }

    public virtual TNhanVien? MaNhanVienNavigation { get; set; }

    public virtual ICollection<TChiTietHdb> TChiTietHdbs { get; set; } = new List<TChiTietHdb>();
}
