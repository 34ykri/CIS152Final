using DataStructuresFinalProjectWebAppVang.Controllers;
using DataStructuresFinalProjectWebAppVang.unused;
using Microsoft.AspNetCore.Mvc;
namespace DataStructuresFinalProjectWebAppVang.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new LinkedList<Character>();
            model.AddLast(new Character { Name = "Albedo", Vision = "Geo", Weapon = "Sword", LastSeen = "Avaliable Now", Region = "Mondstadt", ImageName = "albedo.png" });
            model.AddLast(new Character { Name = "Aloy", Vision = "Cryo", Weapon = "Bow", LastSeen = "Gift from Developer", Region = "Not from Genshin", ImageName = "aloy.png" });
            model.AddLast(new Character { Name = "Ayaka", Vision = "Cryo", Weapon = "Sword", LastSeen = "Update 2.6 Event Banner", Region = "Inazuma", ImageName = "ayaka.png" });
            model.AddLast(new Character { Name = "Ayato", Vision = "Hydro", Weapon = "Sword", LastSeen = "Update 2.6 Event Banner", Region = "Inazuma", ImageName = "ayato.png" });
            model.AddLast(new Character { Name = "Cyno", Vision = "Electro", Weapon = "Polearm", LastSeen = "Update 3.1 Event Banner", Region = "Sumeru", ImageName = "cyno.png" });
            model.AddLast(new Character { Name = "Diluc", Vision = "Pyro", Weapon = "Claymore", LastSeen = "Standard Banner", Region = "Mondstadt", ImageName = "diluc.png" });
            model.AddLast(new Character { Name = "Eula", Vision = "Cryo", Weapon = "Claymore", LastSeen = "Update 2.3 Event Banner", Region = "Mondstadt", ImageName = "eula.png" });
            model.AddLast(new Character { Name = "Ganyu", Vision = "Cryo", Weapon = "Bow", LastSeen = "Update 3.0 Event Banner", Region = "Liyue", ImageName = "ganyu.png" });
            model.AddLast(new Character { Name = "Hu Tao", Vision = "Pyro", Weapon = "Polearm", LastSeen = "Update 2.2 Event Banner", Region = "Liyue", ImageName = "hutao.png" });
            model.AddLast(new Character { Name = "Itto", Vision = "Geo", Weapon = "Claymore", LastSeen = "Update 2.7 Event Banner", Region = "Inazuma", ImageName = "itto.png" });
            model.AddLast(new Character { Name = "Jean", Vision = "Anemo", Weapon = "Sword", LastSeen = "Standard Banner", Region = "Mondstadt", ImageName = "jean.png" });
            model.AddLast(new Character { Name = "Kazuha", Vision = "Anemo", Weapon = "Sword", LastSeen = "Update 2.8 Event Banner", Region = "Inazuma", ImageName = "kazuha.png" });
            model.AddLast(new Character { Name = "Keqing", Vision = "Electro", Weapon = "Sword", LastSeen = "Standard Banner", Region = "Liyue", ImageName = "keqing.png" });
            model.AddLast(new Character { Name = "Klee", Vision = "Pyro", Weapon = "Catalyst", LastSeen = "Update 2.8 Event Banner", Region = "Mondstadt", ImageName = "klee.png" });
            model.AddLast(new Character { Name = "Kokomi", Vision = "Hydro", Weapon = "Catalyst", LastSeen = "Update 3.0 Event Banner", Region = "Inazuma", ImageName = "kokomi.png" });
            model.AddLast(new Character { Name = "Mona", Vision = "Hydro", Weapon = "Catalyst", LastSeen = "Standard Banner", Region = "Mondstadt", ImageName = "mona.png" });
            model.AddLast(new Character { Name = "Nilou", Vision = "Hydro", Weapon = "Sword", LastSeen = "Avaliable Now", Region = "Sumeru", ImageName = "nilou.png" });
            model.AddLast(new Character { Name = "Qiqi", Vision = "Cryo", Weapon = "Sword", LastSeen = "Standard Banner", Region = "Liyue", ImageName = "qiqi.png" });
            model.AddLast(new Character { Name = "Raiden", Vision = "Electro", Weapon = "Polearm", LastSeen = "Update 2.5 Event Banner", Region = "Inazuma", ImageName = "raiden.png" });
            model.AddLast(new Character { Name = "Shenhe", Vision = "Cryo", Weapon = "Polearm", LastSeen = "Update 2.4 Event Banner", Region = "Liyue", ImageName = "shenhe.png" });
            model.AddLast(new Character { Name = "Tartaglia", Vision = "Hydro", Weapon = "Bow", LastSeen = "Update 2.2 Event Banner", Region = "Snezhnaya", ImageName = "tartaglia.png" });
            model.AddLast(new Character { Name = "Tighnari", Vision = "Dendro", Weapon = "Bow", LastSeen = "Standard Banner", Region = "Sumeru", ImageName = "tighnari.png" });
            model.AddLast(new Character { Name = "Venti", Vision = "Anemo", Weapon = "Bow", LastSeen = "Update 3.1 Event Banner", Region = "Mondstadt", ImageName = "venti.png" });
            model.AddLast(new Character { Name = "Xiao", Vision = "Anemo", Weapon = "Polearm", LastSeen = "Update 2.7 Event Banner", Region = "Liyue", ImageName = "xiao.png" });
            model.AddLast(new Character { Name = "Yae Miko", Vision = "Electro", Weapon = "Catalyst", LastSeen = "Update 2.5 Event Banner", Region = "Inazuma", ImageName = "yaemiko.png" });
            model.AddLast(new Character { Name = "Yoimiya", Vision = "Pyro", Weapon = "Bow", LastSeen = "Update 2.8 Event Banner", Region = "Inazuma", ImageName = "yoimiya.png" });
            model.AddLast(new Character { Name = "Zhongli", Vision = "Geo", Weapon = "Polearm", LastSeen = "Update 3.0 Event Banner", Region = "Liyue", ImageName = "zhongli.png" });
            return View(model);
        }
        public IActionResult Element()
        {
            return View();
        }
    }
}
