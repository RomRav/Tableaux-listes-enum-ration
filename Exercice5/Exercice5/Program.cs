using System;

namespace Exercice5
{
    class Program
    {
        static void Main(string[] args)
        {
            Tornado[] tornadoes = 
            {
                    new Tornado("F0", "Dégâts légers : certains dommages sont subis par les cheminées, les antennes de télévision, les bardeaux, les arbres, les enseignes et les fenêtres."), 
                    new Tornado("F1", "Dégâts modérés : les automobiles sont renversées, les abris pour automobiles détruits et les arbres déracinés."), 
                    new Tornado("F2", "Dégâts importants : les toits sont arrachés par le vent, les hangars et les dépendances sont démolies et les maisons mobiles sont renversées."), 
                    new Tornado("F3", "Dégâts considérables : les murs extérieurs et les toits sont projetés dans les airs, les maisons et les bâtiments de métal s'effondrent ou subissent des dégâts| importants, les forêts et les récoltes sont abattues."), 
                    new Tornado("F4", "Dégâts dévastateurs : même dans les habitations solides, l'essentiel des murs, sinon tous, s'effondrent ; tels des missiles, de gros objets en acier ou en béton sont projetés à grandes distances."),
                    new Tornado("F5", "Dégâts incroyables : les maisons sont rasées ou projetées sur de grandes distances. Les tornades F5 peuvent causer des dommages très importants à de grosses structures telles que les écoles et les motels et peuvent arracher les murs extérieurs et les toits (parfois surnommé « le doigt de Dieu »")
            };
            string inputType;
            Console.WriteLine("Saisissez un type de tornade (F0, F1, F2, F3, F4, F5):");
            inputType = Console.ReadLine().ToLower();
            foreach (Tornado tornado in tornadoes)
            {
                if (tornado.type.ToLower() == inputType)
                {
                    Console.WriteLine($"Les tornades de type {tornado.type} font des {Environment.NewLine}{tornado.damage}");
                }
            }
        }
    }
    public class Tornado
    {
        public string type { get; set; }
        public string damage { get; set; }

        public Tornado(string tornadoType, string tornadoDamage) 
        {
            type = tornadoType;
            damage = tornadoDamage;
        }
    }
}
