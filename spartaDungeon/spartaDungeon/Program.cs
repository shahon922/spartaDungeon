

namespace spartaDungeon
{
    internal class Program
    {
        static int flag;

        static void Main(string[] args)
        {
            do
            {
                // 게임 시작 화면
                //Console.Clear();
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

               if(num == 1)
                {
                    charater();
                }
               else if(num == 2)
                {
                    inventory();
                }
               else if(num == 3)
                {
                    store();
                }
               else if(num == 0)
                {
                    flag = 0;
                }
               else
                {
                    Console.WriteLine("잘못된 입력입니다.");
                }
            }
            while(flag == 0);
        }

        static void charater()
        {
            Console.WriteLine("상태 보기");
            Console.WriteLine("캐릭터의 정보가 표시됩니다.");

            Console.WriteLine("Lv. ");
            Console.WriteLine("Chad : ");
            Console.WriteLine("공격력 : ");
            Console.WriteLine("방어력 : ");
            Console.WriteLine("체 력 : ");
            Console.WriteLine("Gold : " + "G");

            Console.WriteLine("0. 나가기");

            
        }

        static void inventory()
        {
            Console.WriteLine("인벤토리");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");

            Console.WriteLine("[아이템 목록]");

            Console.WriteLine("1. 장착 관리");
            Console.WriteLine("0. 나가기");
            
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
        }

        static void store_purchase()
        {
            Console.WriteLine("상점 - 아이템 구매");
        }
    }
}
