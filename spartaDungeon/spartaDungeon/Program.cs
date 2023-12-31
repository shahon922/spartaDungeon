﻿

using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using static spartaDungeon.Program;

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
        //static int idx = 0;
        static List<Item> itemList = new List<Item>();
        static List<Item> invenList = new List<Item>();
        

        /*public class Player //캐릭터 클래스
        {
            public int lv;
            public string nickName;
            public int at;
            public int df;
            public int hp;
            public int gold;

            public Player(string nickName,int at, int df, int hp, int gold)
            { 
                this.lv = 1;
                this.nickName = nickName;
                this.at = at;
                this.df = df;
                this.hp = hp;
                this.gold = gold;
            }

            public Player(Player player)
            {
                this.lv= player.lv;
                this.nickName = player.nickName;
                this.at = player.at;
                this.df = player.df;
                this.hp = player.hp;
                this.gold = player.gold;
            }
        }*/


        public class Item
        {
            public string mount;
            public int idx;
            public string name;
            public int count;
            public string type; //  공격력  방어력
            public int value;
            public string options;
            public string price;

            public Item(string mount,int idx, string name, string type, int value, string options, string price)
            {
                this.mount = mount;
                this.idx = idx;
                this.name = name;
                this.count = 1;
                this.type = type;
                this.value = value;
                this.options = options;
                this.price = price;
            }

            public Item(Item item)
            {
                this.mount = item.mount;
                this.idx = item.idx;
                this.name = item.name;
                count = 1;
                this.value = item.value;
                this.options = item.options;
                this.price = item.price;
            }

        }

        static void Main(string[] args)
        {
            Console.Write("이름을 입력하세요 : ");
            name = Console.ReadLine();

            //itemList = new List<Item>();
            itemList.Add(new Item("", 1, "수련자의 갑옷", "방어력", 5, "수련에 도움을 주는 갑옷입니다.", "1000"));
            itemList.Add(new Item("", 2, "무쇠갑옷", "방어력", 9, "무쇠로 만들어져 튼튼한 갑옷입니다.", "350"));
            itemList.Add(new Item("", 3, "스파르타의 갑옷", "방어력", 15, "스파르타의 전사들이 사용했다는 전설의 갑옷입니다.", "3500"));
            itemList.Add(new Item("", 4, "낡은 검", "공격력", 2, "쉽게 볼 수 있는 낡은 검 입니다.", "600"));
            itemList.Add(new Item("", 5, "청동 도끼", "공격력", 5, "어디선가 사용됐던거 같은 도끼입니다.", "1500"));
            itemList.Add(new Item("", 6, "스파르타의 창", "공격력", 7, "스파르타의 전사들이 사용했다는 전설의 창입니다.", "350"));


            village();
            
        }

        static void village()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
                Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.");
                //Console.WriteLine("상태창에 (+능력치)추가하는 기능을 구현하지 못했습니다.");

                Console.WriteLine();

                Console.WriteLine("1. 상태 보기");
                Console.WriteLine("2. 인벤토리");
                Console.WriteLine("3. 상점");

                Console.WriteLine();

                Console.WriteLine("원하시는 행동을 입력해주세요.");
                Console.Write(">> ");
                int input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    charater();
                }
                else if (input == 2)
                {
                    inventory();
                }
                else if (input == 3)
                {
                    store();
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");
                }
            }
        }

        static void charater()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("상태 보기");
                Console.WriteLine("캐릭터의 정보가 표시됩니다.");

                Console.WriteLine("Lv. {0:D2}", level);
                Console.WriteLine("Chad : {0} ( 전사 )", name);
                Console.WriteLine("공격력 : {0} (+{1})", attack);
                Console.WriteLine("방어력 : {0} (+{1})", defense);
                Console.WriteLine("체 력 : {0}", hp);
                Console.WriteLine("Gold : {0} G", gold);

                Console.WriteLine("0. 나가기");

                Console.WriteLine("원하시는 행동을 입력해주세요.");
                Console.Write(">> ");
                int input = int.Parse(Console.ReadLine());

                if (input == 0)
                {
                    village();
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");

                }
            }

        }

        static void inventory()
        {
            Console.Clear();
            Console.WriteLine("인벤토리");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
            Console.WriteLine("[아이템 목록]");
            foreach (Item item in invenList)
            {
                Console.WriteLine(" - {0} {1} | {2} +{3} | {4}", item.mount, item.name, item.type, item.value, item.options);
            }
            Console.WriteLine("1. 장착 관리");
            Console.WriteLine("0. 나가기");

            while (true)
            {
                Console.WriteLine("원하시는 행동을 입력해주세요.");
                Console.Write(">> ");
                int input = int.Parse(Console.ReadLine());
            
                if (input == 0)
                {
                    village();
                }
                else if (input == 1)
                {
                    mounting(invenList);
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");

                }
            }

        }

        static void mounting(List<Item> invenList)
        {

            Console.Clear();
            Console.WriteLine("인벤토리 - 장착 관리");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");

            Console.WriteLine("[아이템 목록]");

            int listIdx = 1;
            
            foreach (Item item in invenList)
            {
                Console.WriteLine(" - {0}. {1} {2} | {3} +{4} | {5}", listIdx++, item.mount, item.name, item.type, item.value, item.options);
            }

            Console.WriteLine("1. 장착하기");
            Console.WriteLine("0. 나가기");
            while (true)
            {
                Console.WriteLine("원하시는 행동을 입력해주세요.");
                Console.Write(">> ");
                int input = int.Parse(Console.ReadLine());

                if (input == 0)
                {
                    inventory();
                }
                else if(input == 1)
                {
                    // 상점에서 인벤토리로 넘김받음
                    // input으로 받은 번호와 idx의 번호 비교
                    // item.type의 string을 비교해서 능력치 추가
                    // 같으면 [E] 출력 / [E]가 있을 때 누르면 [E] 사라짐
                    // charate에 능력치 증가/감소
                    Console.WriteLine("장착할 아이템의 번호를 입력하세요");
                    Console.Write(">> ");
                    int invenNum = int.Parse(Console.ReadLine());
                    int num = itemList.FindIndex(a => a.idx == invenNum);

                    if (invenNum == (num + 1))
                    {
                        if(invenList[num].mount == "")
                        {
                            if (invenList[num].type == "공격력")
                            {
                                Console.WriteLine("무기가 장착되었습니다.");
                                attack += invenList[num].value;
                                invenList[num].mount = "[E]";
                            }
                            else if (invenList[num].type == "방어력")
                            {
                                Console.WriteLine("방어구가 장착되었습니다.");
                                defense += invenList[num].value;
                                invenList[num].mount = "[E]";
                            }
                        }
                        else if(invenList[num].mount == "[E]")
                        {
                            if (invenList[num].type == "공격력")
                            {
                                Console.WriteLine("무기가 해제되었습니다.");
                                attack -= invenList[num].value;
                                invenList[num].mount = "";
                            }
                            else if (invenList[num].type == "방어력")
                            {
                                Console.WriteLine("방어구가 해제되었습니다.");
                                defense -= invenList[num].value;
                                invenList[num].mount = "";
                            }
                        }
                        while (true)
                        {   
                            Console.WriteLine("0. 나가기");
                            Console.WriteLine("원하시는 행동을 입력해주세요.");
                            Console.Write(">> ");

                            input = int.Parse(Console.ReadLine());

                            if (input == 0)
                            {
                                inventory();
                            }
                            else
                            {
                                Console.WriteLine("잘못된 입력입니다.");
                            }
                        }
                    }
                    
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");
                }
            }
        }

        

        static void store()
        {
            Console.Clear();
            Console.WriteLine("상점");
            Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");

            Console.WriteLine("[보유 골드]");
            Console.WriteLine("{0} G", gold);
            Console.WriteLine("[아이템 목록]");


            foreach (Item item in itemList)
            {
                Console.WriteLine(" - {0} | {1} +{2} | {3} | {4} G", item.name, item.type, item.value, item.options, item.price);
            }

            Console.WriteLine("1. 아이템 구매");
            Console.WriteLine("0. 나가기");

            while (true)
            {
                Console.WriteLine("원하시는 행동을 입력해주세요.");
                Console.Write(">> ");

                int input = int.Parse(Console.ReadLine());

                if (input == 0)
                {
                    village();
                }

                if (input == 1)
                {
                    BuyItem(itemList);
                }

                else
                {
                    Console.WriteLine("잘못된 입력입니다.");

                }
            }
        }

        static void BuyItem(List<Item> itemList)
        {
            Console.Clear();
            Console.WriteLine("상점");
            Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");

            Console.WriteLine("[보유 골드]");
            Console.WriteLine("{0} G", gold);
            Console.WriteLine("[아이템 목록]");

            foreach (Item item in itemList)
            {
                Console.WriteLine(" - {0}. {1} | {2} +{3} | {4} | {5} G", item.idx, item.name, item.type, item.value, item.options, item.price);

            }


            Console.WriteLine("1. 구매");
            Console.WriteLine("0. 나가기");

            while (true)
            {
                Console.WriteLine("원하시는 행동을 입력해주세요.");
                Console.Write(">> ");

                int input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    Console.WriteLine("구매하고 싶은 번호를 입력하세요");
                    Console.Write(">> ");

                    int listNum = int.Parse(Console.ReadLine());

                    int num = itemList.FindIndex(a => a.idx == listNum); // itemList에 있는 idx와 listNum이 같은 수가 있는 곳을 알려줌
                    int priceInt = int.Parse(itemList[num].price);
                    

                    if (listNum == (num + 1))
                    {
                        //Console.WriteLine(itemList[num]);
                        if (gold >= priceInt)
                        {
                            Console.WriteLine("구매완료");
                            gold -= priceInt;
                            // 인벤토리로 아이템 이동 - 인벤토리 리스트를 만들어 사용
                            invenList.Add(itemList[num]);
                            // 구매한 아이템 구매완료로 변경
                            itemList[num].price = "구매완료";
                            // 재구매를 방지하기 위해 카운트 0으로 변경
                            itemList[num].count = 0;
                            Console.WriteLine("0. 나가기");

                            while (true)
                            {
                                Console.WriteLine("원하시는 행동을 입력해주세요.");
                                Console.Write(">> ");

                                input = int.Parse(Console.ReadLine());

                                if (input == 0)
                                {
                                    store();
                                }
                                else
                                {
                                    Console.WriteLine("잘못된 입력입니다.");
                                }
                            }

                        }
                        else if (itemList[num].count == 0)
                        {
                            Console.WriteLine("이미 구매한 상품입니다.");
                            while (true)
                            {
                                Console.WriteLine("원하시는 행동을 입력해주세요.");
                                Console.Write(">> ");

                                input = int.Parse(Console.ReadLine());

                                if (input == 0)
                                {
                                    store();
                                }
                                else
                                {
                                    Console.WriteLine("잘못된 입력입니다.");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Gold가 부족합니다.");
                            Console.WriteLine("0. 나가기");

                            while (true)
                            {
                                Console.WriteLine("원하시는 행동을 입력해주세요.");
                                Console.Write(">> ");

                                input = int.Parse(Console.ReadLine());

                                if (input == 0)
                                {
                                    store();
                                }
                                else
                                {
                                    Console.WriteLine("잘못된 입력입니다.");
                                }
                            }
                        }

                    }

                }
                else if (input == 0)
                {
                    store();
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");

                }
            }

        }

    }
}
