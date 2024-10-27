using ThucHanhWebMVC.Models;
using Microsoft.AspNetCore.Mvc;
using ThucHanhWebMVC.Repository;
namespace ThucHanhWebMVC.ViewComponents
{
    [ViewComponent(Name = "LoaiSpMenu")]
    public class LoaiSpMenuViewComponents: ViewComponent
    {
        private readonly ILoaiSpRepository _loaiSp;
        public LoaiSpMenuViewComponents(ILoaiSpRepository loaiSpRepository)
        {
            _loaiSp = loaiSpRepository;
        }
        public IViewComponentResult Invoke()
        {
            var loaisp = _loaiSp.GetAllLoaiSp().OrderBy(x => x.Loai);
            return View(loaisp);
        }
    }
}
