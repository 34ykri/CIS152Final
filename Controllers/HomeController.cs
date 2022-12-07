using DataStructuresFinalProjectWebAppVang.Controllers;
using DataStructuresFinalProjectWebAppVang.Models;

using Microsoft.AspNetCore.Mvc;
namespace DataStructuresFinalProjectWebAppVang.Controllers
{
    public class HomeController : Controller
    {
        //Static list to hold every character in all characters list
        private static LinkedList<Character> allCharacters = new LinkedList<Character>();
        private LinkedList<Character> characterList = new LinkedList<Character>();
        //Static queue to keep added characters in queue
        private static Queue<Character> queue = new Queue<Character>();
        //Static linked list to sort characters by priority
        private static LinkedList<Character> sortChar = new LinkedList<Character>();

        //Default id is all to get every character
        public IActionResult Index(string id = "all")
        {
            //Add characters to model
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
            model.AddLast(wanderer);
            model.AddLast(xiao);
            model.AddLast(yaemiko);
            model.AddLast(yoimiya);
            model.AddLast(zhongli);

            //Add every character in model to the static allCharacters list to reuse in other functions
            foreach (var item in model)
            {
                allCharacters.AddLast(item);
            }

            //Insertion sort 
            if (id != "all")
            {
                //When Id is not all
                //Foreach character in the model, if the id matches the vision/weapon/region insert it into the character list
                //and return the sorted view
                foreach (var character in model)
                {
                    if (id == character.Vision)
                    {
                        characterList.AddLast(character);
                    }
                    else if (id == character.Weapon)
                    {
                        characterList.AddLast(character);
                    }
                    else if (id == character.Region)
                    {
                        characterList.AddLast(character);
                    }
                }
                return View(characterList);
            }
            //Otherwise return model with all characters
            return View(model);
        }
        //Queue page
        //Takes a parameter called id
        public IActionResult Queue(string id)
        {
            //If the queue is not empty
            if (queue.Count != 0)
            {
                //and if id equals Dequeue
                if (id == "Dequeue")
                {
                    //assign the character at the top of the queue to topChar
                    Character topChar = queue.First();
                    //Dequeue the character at the top of the queue
                    queue.Dequeue();
                    //Also remove it from the sorted queue LinkedList
                    sortChar.Remove(topChar);
                    //Return the queue back to user
                    return View(queue);
                }
            }
            //Otherwise return the queue
            return View(queue);
        }

        [HttpGet]
        //Default page for Add to put every character into a ViewBag
        //When in the ViewBag it uses a SelectList so you can select characters
        public IActionResult Add()
        {
            //Model is equal to static allCharacters List to retrieve the characters
            var model = allCharacters;
            ViewBag.Characters = allCharacters;
            return View();
        }
        [HttpPost]
        public IActionResult Add(Character character)
        {
            //Model is equal to static allCharacters List to retrieve the characters
            var model = allCharacters;
            //When priority is entered it is stored into an int
            int? priority = character.Priority;
            //Foreach to find character to add to queue
            foreach (var item in model)
            {
                //If the Selected Characters name is equal to the character in the model
                if (character.SelectChar == item.Name)
                {
                    //Assign character to that item and priority
                    character = item;
                    character.Priority = priority;
                }
            }
            //If the data is invalid give an error and return the SelectList
            if (character.Name == "NPC" || character.Priority == null || (character.Priority > 5 || character.Priority < 1))
            {
                ViewBag.Characters = new LinkedList<Character>();
                foreach (var item in model)
                {
                    ViewBag.Characters.AddLast(item);
                }
                return View(character);
            }
            //Otherwise data is valid add the character to the queue and the LinkedList to be sorted
            else
            {
                queue.Enqueue(character);
                sortChar.AddLast(character);
                //If the queue is not empty
                if (queue.Count != 0)
                {
                    //Clear the queue
                    queue.Clear();
                    //IEnumerable to sort the queue by Priority
                    IEnumerable<Character> sortedCharacters = sortChar.OrderBy(c => c.Priority);
                    //Once sorted foreach character in the sorted list add it back to the queue
                    foreach (Character sortChar in sortedCharacters)
                    {
                        queue.Enqueue(sortChar);
                    }
                }
                //Return queue
                return View("Queue", queue);
            }
        }
        //Create Characters to be Used in the List
        //Character(Name,Vision,Weapon,Last Seen, Region, Image Name)
        public Character albedo = new Character("Albedo", "Geo", "Sword", "Update 3.1 Event Banner", "Mondstadt", "albedo.png");
        public Character aloy = new Character("Aloy", "Cryo", "Bow", "Gift from Developer", "Not from Genshin", "aloy.png");
        public Character ayaka = new Character("Ayaka", "Cryo", "Sword", "Update 2.6 Event Banner", "Inazuma", "ayaka.png");
        public Character ayato = new Character("Ayato", "Hydro", "Sword", "Update 2.6 Event Banner", "Inazuma", "ayato.png");
        public Character cyno = new Character("Cyno", "Electro", "Polearm", "Update 3.1 Event Banner", "Sumeru", "cyno.png");
        public Character diluc = new Character("Diluc", "Pyro", "Claymore", "Standard Banner", "Mondstadt", "diluc.png");
        public Character eula = new Character("Eula", "Cryo", "Claymore", "Update 2.3 Event Banner", "Mondstadt", "eula.png");
        public Character ganyu = new Character("Ganyu", "Cryo", "Bow", "Update 3.0 Event Banner", "Liyue", "ganyu.png");
        public Character hutao = new Character("Hu Tao", "Pyro", "Polearm", "Update 2.2 Event Banner", "Liyue", "hutao.png");
        public Character itto = new Character("Itto", "Geo", "Claymore", "Available Now", "Inazuma", "itto.png");
        public Character jean = new Character("Jean", "Anemo", "Sword", "Standard Banner", "Mondstadt", "jean.png");
        public Character kazuha = new Character("Kazuha", "Anemo", "Sword", "Update 2.8 Event Banner", "Inazuma", "kazuha.png");
        public Character keqing = new Character("Keqing", "Electro", "Sword", "Standard Banner", "Liyue", "keqing.png");
        public Character klee = new Character("Klee", "Pyro", "Catalyst", "Update 2.8 Event Banner", "Mondstadt", "klee.png");
        public Character kokomi = new Character("Kokomi", "Hydro", "Catalyst", "Update 3.0 Event Banner", "Inazuma", "kokomi.png");
        public Character mona = new Character("Mona", "Hydro", "Catalyst", "Standard Banner", "Mondstadt", "mona.png");
        public Character nahida = new Character("Nahida", "Dendro", "Catalyst", "Update 3.2 Event Banner", "Sumeru", "nahida.png");
        public Character nilou = new Character("Nilou", "Hydro", "Sword", "Update 3.1 Event Banner", "Sumeru", "nilou.png");
        public Character qiqi = new Character("Qiqi", "Cryo", "Sword", "Standard Banner", "Liyue", "qiqi.png");
        public Character raiden = new Character("Raiden", "Electro", "Polearm", "Update 2.5 Event Banner", "Inazuma", "raiden.png");
        public Character shenhe = new Character("Shenhe", "Cryo", "Polearm", "Update 2.4 Event Banner", "Liyue", "shenhe.png");
        public Character tartaglia = new Character("Tartaglia", "Hydro", "Bow", "Update 3.2 Event Banner", "Snezhnaya", "tartaglia.png");
        public Character tighnari = new Character("Tighnari", "Dendro", "Bow", "Standard Banner", "Sumeru", "tighnari.png");
        public Character venti = new Character("Venti", "Anemo", "Bow", "Update 3.1 Event Banner", "Mondstadt", "venti.png");
        public Character wanderer = new Character("Wanderer", "Anemo", "Catalyst", "Available Now", "Inazuma", "wandererc.png");
        public Character xiao = new Character("Xiao", "Anemo", "Polearm", "Update 2.7 Event Banner", "Liyue", "xiao.png");
        public Character yaemiko = new Character("Yae Miko", "Electro", "Catalyst", "Update 3.2 Event Banner", "Inazuma", "yaemiko.png");
        public Character yoimiya = new Character("Yoimiya", "Pyro", "Bow", "Update 3.2 Event Banner", "Inazuma", "yoimiya.png");
        public Character zhongli = new Character("Zhongli", "Geo", "Polearm", "Update 3.0 Event Banner", "Liyue", "zhongli.png");

    }
}
