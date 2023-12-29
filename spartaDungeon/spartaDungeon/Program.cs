namespace spartaDungeon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 게임 시작 화면
            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
            Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.");

            Console.WriteLine();

            Console.WriteLine("1. 상태 보기");
            Console.WriteLine("2. 인벤토리");
            Console.WriteLine("3. 상점");

            Console.WriteLine();

            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.Write(">> ");
            int num = int.Parse(Console.ReadLine());

            if(num > 3 || num < 1)
            {
                Console.WriteLine("잘못된 입력입니다.");
            }
        }
    }
}
