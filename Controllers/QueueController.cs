using Microsoft.AspNetCore.Mvc;
using DataStructuresFinalProjectWebAppVang.Models;
using Microsoft.Extensions.Logging;

namespace DataStructuresFinalProjectWebAppVang.Controllers
{
    public class QueueController : Controller
    {
        private static Queue<Character> queue = new Queue<Character>();
        private static LinkedList<Character> sortChar = new LinkedList<Character>();

        public IActionResult Index(string id)
        {
            if (queue.Count != 0)
            {
                if (id == "Dequeue")
                {
                    Character topChar = queue.First();
                    queue.Dequeue();
                    sortChar.Remove(topChar);

                    return View(queue);
                }
            }
            return View(queue);
        }
        
        public IActionResult Add()
        {
            var model = new LinkedList<Character>();
            model.AddLast(albedo);
            model.AddLast(aloy);
            model.AddLast(ayaka);
            model.AddLast(ayato);
            model.AddLast(cyno);
            model.AddLast(diluc);
            model.AddLast(eula);
            model.AddLast(ganyu);
            model.AddLast(hutao);
            model.AddLast(itto);
            model.AddLast(jean);
            model.AddLast(kazuha);
            model.AddLast(keqing);
            model.AddLast(klee);
            model.AddLast(kokomi);
            model.AddLast(nahida);
            model.AddLast(mona);
            model.AddLast(nilou);
            model.AddLast(qiqi);
            model.AddLast(raiden);
            model.AddLast(shenhe);
            model.AddLast(tartaglia);
            model.AddLast(tighnari);
            model.AddLast(venti);
            model.AddLast(xiao);
            model.AddLast(yaemiko);
            model.AddLast(yoimiya);
            model.AddLast(zhongli);
            ViewBag.Characters = new LinkedList<Character>();
            foreach (var item in model)
            {
                ViewBag.Characters.AddLast(item);
            }
            return View();
        }
        [HttpPost]
        public IActionResult Add(Character character)
        {
            var model = new LinkedList<Character>();
            model.AddLast(albedo);
            model.AddLast(aloy);
            model.AddLast(ayaka);
            model.AddLast(ayato);
            model.AddLast(cyno);
            model.AddLast(diluc);
            model.AddLast(eula);
            model.AddLast(ganyu);
            model.AddLast(hutao);
            model.AddLast(itto);
            model.AddLast(jean);
            model.AddLast(kazuha);
            model.AddLast(keqing);
            model.AddLast(klee);
            model.AddLast(kokomi);
            model.AddLast(nahida);
            model.AddLast(mona);
            model.AddLast(nilou);
            model.AddLast(qiqi);
            model.AddLast(raiden);
            model.AddLast(shenhe);
            model.AddLast(tartaglia);
            model.AddLast(tighnari);
            model.AddLast(venti);
            model.AddLast(xiao);
            model.AddLast(yaemiko);
            model.AddLast(yoimiya);
            model.AddLast(zhongli);
            int? priority = character.Priority;
            foreach (var item in model)
            {
                if (character.SelectChar == item.Name)
                {
                    character = item;
                    character.Priority = priority;
                }
            }
            if (character.Name == "NPC" || character.Priority == null || (character.Priority > 5 || character.Priority < 1))
            {
                ViewBag.Characters = new LinkedList<Character>();
                foreach (var item in model)
                {
                    ViewBag.Characters.AddLast(item);
                }
                return View(character);
            }
            else
            {
                queue.Enqueue(character);
                sortChar.AddLast(character);
                if(queue.Count != 0)
                {
                    queue.Clear();
                    IEnumerable<Character> sortedCharacters = sortChar.OrderBy(c => c.Priority);
                    foreach (Character sortChar in sortedCharacters)
                    {
                        queue.Enqueue(sortChar);
                    }
                }
                return View("Index", queue);
            }
        }

        //Create Characters to be Used in the List
        public Character albedo = new Character("Albedo", "Geo", "Sword", "Update 3.2 Event Banner", "Mondstadt", "albedo.png");
        public Character aloy = new Character("Aloy", "Cryo", "Bow", "Gift from Developer", "Not from Genshin", "aloy.png");
        public Character ayaka = new Character("Ayaka", "Cryo", "Sword", "Update 2.6 Event Banner", "Inazuma", "ayaka.png");
        public Character ayato = new Character("Ayato", "Hydro", "Sword", "Update 2.6 Event Banner", "Inazuma", "ayato.png");
        public Character cyno = new Character("Cyno", "Electro", "Polearm", "Update 3.1 Event Banner", "Sumeru", "cyno.png");
        public Character diluc = new Character("Diluc", "Pyro", "Claymore", "Standard Banner", "Mondstadt", "diluc.png");
        public Character eula = new Character("Eula", "Cryo", "Claymore", "Update 2.3 Event Banner", "Mondstadt", "eula.png");
        public Character ganyu = new Character("Ganyu", "Cryo", "Bow", "Update 3.0 Event Banner", "Liyue", "ganyu.png");
        public Character hutao = new Character("Hu Tao", "Pyro", "Polearm", "Update 2.2 Event Banner", "Liyue", "hutao.png");
        public Character itto = new Character("Itto", "Geo", "Claymore", "Update 2.7 Event Banner", "Inazuma", "itto.png");
        public Character jean = new Character("Jean", "Anemo", "Sword", "Standard Banner", "Mondstadt", "jean.png");
        public Character kazuha = new Character("Kazuha", "Anemo", "Sword", "Update 2.8 Event Banner", "Inazuma", "kazuha.png");
        public Character keqing = new Character("Keqing", "Electro", "Sword", "Standard Banner", "Liyue", "keqing.png");
        public Character klee = new Character("Klee", "Pyro", "Catalyst", "Update 2.8 Event Banner", "Mondstadt", "klee.png");
        public Character kokomi = new Character("Kokomi", "Hydro", "Catalyst", "Update 3.0 Event Banner", "Inazuma", "kokomi.png");
        public Character mona = new Character("Mona", "Hydro", "Catalyst", "Standard Banner", "Mondstadt", "mona.png");
        public Character nahida = new Character("Nahida", "Dendro", "Catalyst", "Avaliable Now", "Sumeru", "nahida.png");
        public Character nilou = new Character("Nilou", "Hydro", "Sword", "Update 3.2 Event Banner", "Sumeru", "nilou.png");
        public Character qiqi = new Character("Qiqi", "Cryo", "Sword", "Standard Banner", "Liyue", "qiqi.png");
        public Character raiden = new Character("Raiden", "Electro", "Polearm", "Update 2.5 Event Banner", "Inazuma", "raiden.png");
        public Character shenhe = new Character("Shenhe", "Cryo", "Polearm", "Update 2.4 Event Banner", "Liyue", "shenhe.png");
        public Character tartaglia = new Character("Tartaglia", "Hydro", "Bow", "Update 2.2 Event Banner", "Snezhnaya", "tartaglia.png");
        public Character tighnari = new Character("Tighnari", "Dendro", "Bow", "Standard Banner", "Sumeru", "tighnari.png");
        public Character venti = new Character("Venti", "Anemo", "Bow", "Update 3.1 Event Banner", "Mondstadt", "venti.png");
        public Character xiao = new Character("Xiao", "Anemo", "Polearm", "Update 2.7 Event Banner", "Liyue", "xiao.png");
        public Character yaemiko = new Character("Yae Miko", "Electro", "Catalyst", "Update 2.5 Event Banner", "Inazuma", "yaemiko.png");
        public Character yoimiya = new Character("Yoimiya", "Pyro", "Bow", "Avaliable Now", "Inazuma", "yoimiya.png");
        public Character zhongli = new Character("Zhongli", "Geo", "Polearm", "Update 3.0 Event Banner", "Liyue", "zhongli.png");
    }
}
