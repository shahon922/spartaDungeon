

namespace spartaDungeon
{
    internal class Program
    {
        static string name;
        static int level = 1;
        static int attack = 10;
        static int defense = 5;
        static int hp = 100;
        static int gold = 1500;

        static void Main(string[] args)
        {
            Console.Write("이름을 입력하세요 : ");
            name = Console.ReadLine();
            mainScene();

        }

        static void mainScene()
        {
            Console.Clear();
            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
            Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.");

            Console.WriteLine();

            Console.WriteLine("1. 상태 보기");
            Console.WriteLine("2. 인벤토리");
            Console.WriteLine("3. 상점");
            Console.WriteLine("0. 게임종료");

            Console.WriteLine();

            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.Write(">> ");
            int num = int.Parse(Console.ReadLine());

            if (num == 1)
            {
                charater();
            }
            else if (num == 2)
            {
                inventory();
            }
            else if (num == 3)
            {
                store();
            }
            else
            {
                Console.WriteLine("잘못된 입력입니다.");
            }
        }

        static void charater()
        {
            Console.WriteLine("상태 보기");
            Console.WriteLine("캐릭터의 정보가 표시됩니다.");

            Console.WriteLine("Lv. " + "{0:D2}",level);
            Console.WriteLine("Chad : " + name);
            Console.WriteLine("공격력 : " + attack);
            Console.WriteLine("방어력 : " + defense);
            Console.WriteLine("체 력 : " + hp);
            Console.WriteLine("Gold : " + gold + "G");

            Console.WriteLine("0. 나가기");
            int charater_num = int.Parse(Console.ReadLine());

            if (charater_num == 0)
            {
                mainScene();
            }
            else
            {
                Console.WriteLine("잘못된 입력입니다.");
                Console.ReadLine();
            }

        }

        static void inventory()
        {
            Console.WriteLine("인벤토리");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");

            Console.WriteLine("[아이템 목록]");

            Console.WriteLine("1. 장착 관리");
            Console.WriteLine("0. 나가기");

            int inventory_num = int.Parse(Console.ReadLine());

            if (inventory_num == 0)
            {
                mainScene();
            }
            else if (inventory_num == 1)
            {
                inventory_mounting();
            }
            else
            {
                Console.WriteLine("잘못된 입력입니다.");
                Console.ReadLine();
            }

        }

        static void inventory_mounting()
        {
            Console.WriteLine("인벤토리 - 장착 관리");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
        }

        static void store()
        {
            Console.WriteLine("상점");
            Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");

            Console.WriteLine("[보유 골드]");
            Console.WriteLine("[아이템 목록]");

            Console.WriteLine("1. 아이템 구매");
            Console.WriteLine("0. 나가기");

            int store_num = int.Parse(Console.ReadLine());

            if (store_num == 0)
            {
                mainScene();
            }
            else if (store_num == 1)
            {
                store_purchase();
            }
            else
            {
                Console.WriteLine("잘못된 입력입니다.");
                Console.ReadLine();
            }
        }

        static void store_purchase()
        {
            Console.WriteLine("상점 - 아이템 구매");
        }
    }
}
