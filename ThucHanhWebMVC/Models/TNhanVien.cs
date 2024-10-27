using System;
using System.Collections.Generic;

namespace ThucHanhWebMVC.Models;

public partial class TNhanVien
{
    public string MaNhanVien { get; set; } = null!;

    public string? Username { get; set; }

    public string? TenNhanVien { get; set; }

    public DateOnly? NgaySinh { get; set; }

    public string? SoDienThoai1 { get; set; }

    public string? SoDienThoai2 { get; set; }

    public string? DiaChi { get; set; }

    public string? ChucVu { get; set; }

    public string? AnhDaiDien { get; set; }

    public string? GhiChu { get; set; }

    public virtual ICollection<THoaDonBan> THoaDonBans { get; set; } = new List<THoaDonBan>();

    public virtual TUser? UsernameNavigation { get; set; }
}
