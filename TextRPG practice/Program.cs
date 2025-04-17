﻿using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;
Console.OutputEncoding = Encoding.UTF8; // 아스키코드에 사용된 문자출력을 위한 


//무기 인스턴스
Weapon spoon = new Weapon()
{
    itemName = "숟가락",
    damage = -5,
    price = 2000,
    isEquip = true,
};
User.Inventory.Add(spoon);
Weapon shavel = new Weapon()
{
    itemName = "삽",
    damage = 20,
    price = 5000,
    isEquip = false,
};
Weapon sickle = new Weapon()
{
    itemName = "낫",
    damage = 15,
    price = 3000,
    isEquip = false,
};
Weapon stick = new Weapon()
{
    itemName = "할머니의 지팡이",
    damage = 30,
    price = 50000,
    isEquip = false,
};
Weapon hyojason = new Weapon()
{
    itemName = "효자손",
    damage = 1,
    price = 10000,
    isEquip = false,
};
Weapon chainSaw = new Weapon()
{
    itemName = "전기톱",
    damage = 500,
    price = 150000,
    isEquip = false,
};
//방어구 인스턴스
Armour momppae = new Armour()
{
    itemName = "몸빼",
    defense = 1,
    price = 1500,
    isEquip = true,
};
User.Inventory.Add(momppae);
Armour smock  = new Armour()
{
    itemName = "작업복",
    defense = 15,
    price = 5000,
    isEquip = false,
};

Armour raincoat = new Armour()
{
    itemName = "우의",
    defense = 12,
    price = 4500,
    isEquip = false,
};

Armour hanbok  = new Armour()
{
    itemName = "개량한복",
    defense = 2,
    price = 20000,
    isEquip = false,
};

Armour sweats = new Armour()
{
    itemName = "츄리닝",
    defense = 10,
    price = 3500,
    isEquip = false,
};










bool GameIsRunning = true; // 전체 게임흐름 제어
bool FistScene = true; // 게임 intro 씬 제어




while (GameIsRunning)// 전체 게임흐름
{



    bool Enter = false;
    while (!Enter)
    {
        Start.GameStart();

        string GameStart = Console.ReadLine();
        if (GameStart == "")
        {
            Console.CursorVisible = true;
            Console.Clear();

            while (true)
            {
                Console.SetCursorPosition(50, 10);
                Console.WriteLine("무엇을 하시겠습니까?");
                Console.SetCursorPosition(43, 15);
                Console.WriteLine("1.게임 시작 2.시작 화면 3.게임종료");
                Console.SetCursorPosition(60, 20);
                string Choice = Console.ReadLine();
                if (Choice == "1")
                {
                    Enter = true;
                    break;
                }
                else if (Choice == "2")
                {
                    Console.Clear();
                    break;
                }
                else if (Choice == "3")
                {
                    return;
                }
                else;
                {
                    Console.Clear();

                }
            }
        }
        else
        {
            Console.Clear();

        }
    }
   


    while (FistScene)
    {
        Console.Clear();
        Console.WriteLine("당신은 귀농을 계획합니다. \n귀농 장소를 물색하기 위해, 생소한 시골 던전읍 던전면 던전리에 도착하였습니다.\nEnter");
        Console.ReadLine();
        Console.Clear();
        

        bool nameChoice1 = true;
        while (nameChoice1)
        {
            Console.WriteLine("이곳에 온 당신의 이름은?");

            string nickName = Console.ReadLine();
            User.name = nickName;
            Console.Clear();
            if (nickName == "")
            {
                Console.Clear();
                Console.WriteLine("내 이름이... 뭐였더라...?\nEnter");
                Console.ReadLine();
                Console.Clear();
                continue;
            }
            bool nameChoice3 = true;
            while (nameChoice3)
            {
                
                
                Console.WriteLine($"당신의 이름은\"{nickName}\"입니다.");
                Console.WriteLine("1.확정\t2.다시짓기");
                string nameChoice2 = Console.ReadLine();


                switch (nameChoice2)
                {
                    case "1":
                        nameChoice1 = false;
                        nameChoice3 = false;
                        break;
                    case "2":
                        nameChoice3 = false;
                        Console.Clear(); break;

                    default: Console.Clear(); break;



                }

            }
        }
        Console.Clear();
        Console.WriteLine("당신은 갑자기 눈앞이 깜깜해 집니다.  \n잠시 후 정신을 차린 당신은 몸빼 차림으로 논두렁에 누워있습니다.\nEnter");
        Console.ReadLine();
        Console.Clear();


        Console.WriteLine(@"
  ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀     ⠀                         ⠀⠀⠀     ⠀⠀⣠⡴⠖⠛⠊⠉⠉⠉⠵⠛⠲⢦⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀                         ⠀⠀⠀     ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⠞⠍⠀⡈⠤⠄⠀⠀⠀⠀⠀⠀⠩⢘⠓⢄⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣀⣀⣀⣀⣀⠀⠀⠀⠀⠀⠀⠀
⠀                         ⠀⠀⠀     ⠀⠀⠀⠀⠀⠀⠀⣠⠤⠒⠚⠉⢉⣉⠵⠶⠄⠀⠀⠀⢰⣁⣊⠤⠔⣒⡒⠊⠭⠭⠍⠑⢒⣒⠦⠤⣎⡈⢆⠀⠀⠀⠀⠀⠐⠚⠻⠷⣄⡤⠄⡀⠈⠉⠲⣄⠀⠀⠀⠀
⠀                         ⠀⠀⠀     ⠀⠀⠀⠀⢀⠔⠉⠀⣀⢠⡶⠟⠉⠀⠀⠀⠀⣀⡤⣖⠩⠁⠠⣉⣒⡤⠬⠭⠤⠤⡤⠤⠤⢄⣀⣉⠄⣈⠩⢲⢤⣀⠀⠀⠀⠀⠀⠀⠀⠉⠓⢤⡁⠢⡀⠈⠳⣄⠀⠀
⠀                         ⠀⠀⠀     ⠀⠀⠀⡴⠁⠀⣠⢞⡵⠋⠀⠀⠀⠀⢀⡴⣻⠇⠩⠀⢀⣴⠚⠉⠀⠀⠀⠈⠿⠿⠏⠀⠀⠀⠀⠉⠛⣦⣀⠂⠁⠫⠳⣤⠀⠀⠀⠀⠀⠀⠀⠀⠙⢷⡄⠢⠀⠹⡄⠀
⠀                         ⠀⠀⠀     ⠀⠀⡞⠀⢀⣌⡵⠋⠀⠀⠀⠀⠀⡰⢫⠊⢀⢀⡒⣰⠏⡅⠀⢀⣤⠴⠤⠀⠀⠀⠀⠀⠴⠶⣤⡀⠀⢩⠝⢦⠀⠐⠄⠪⠑⡄⠀⠀⠀⠀⠀⠀⠀⠀⠙⣆⠡⠀⢱⠀
⠀                         ⠀⠀⠀     ⠀⠸⡀⠀⢒⡎⠀⠀⠀⠀⠀⠀⢠⠃⡀⠀⠆⠀⠀⢀⢠⡄⠀⠋⠀⠀⠀⠠⠀⠀⠀⠀⠀⠀⠀⠁⠀⢰⠀⢸⠃⠒⠈⠀⠃⢸⠀⠀⠀⠀⠀⠀⠀⠀⠀⠸⠇⡄⢸⠀
⠀                         ⠀⠀⠀     ⠀⠀⢸⡾⠿⡇⠀⠀⠀⠀⠀⠀⠀⢧⠡⠀⢃⠀⣢⢼⣶⠀⡄⢠⠶⠒⠲⠀⠃⠀⠀⠰⢒⠒⠦⢠⡀⠈⣴⣚⣦⠀⡰⠀⠆⡸⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣅⢁⠇⠀
⠀                         ⠀⠀⠀     ⠀⠀⠈⣧⣀⣳⠀⠀⠀⠀⠀⠀⠀⠈⠳⢦⣀⠀⣿⢫⡞⠀⠁⠀⠀⠀⠁⠀⠃⠀⠀⣀⠈⠈⠀⠀⠀⠀⡿⠍⢋⠀⢀⣠⠞⠁⠀⠀⠀⠀⠀⠀⠀⠀⢠⠏⢉⡿⠀⠀
⠀                         ⠀⠀⠀     ⠀⠀⠀⠈⣯⠈⡆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠉⢻⡴⡇⠀⠀⠀⠀⣠⠾⠡⠄⠀⠤⠈⠢⣄⠀⠀⠀⠀⡧⠂⡿⠚⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⠟⢦⡾⠁⠀⠀
⠀                         ⠀⠀⠀     ⠀⠀⠀⠀⠸⡆⠘⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢳⣸⠀⠀⠀⡔⣁⠀⠀⠀⠀⠀⠀⠀⣈⠓⠀⠀⢀⣇⡔⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⠎⢠⡟⠀⠀⠀⠀
⠀                         ⠀⠀⠀     ⠀⠀⠀⠀⠀⢳⠀⢱⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⣆⠀⢄⠀⠘⠿⣭⢉⣀⢉⣭⠟⠋⠂⡐⠀⡼⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⠎⢀⡞⠀⠀⠀⠀⠀
⠀                         ⠀⠀⠀     ⠀⠀⠀⠀⠀⠈⢇⠀⢧⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⣦⡈⢆⠀⠀⠐⠎⠍⠲⠆⠀⠀⠰⢁⡼⣇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⠏⢀⠞⠀⠀⠀⠀⠀⠀
⠀                         ⠀⠀⠀     ⠀⠀⠀⠀⠀⠀⠘⡄⠈⣆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡠⡞⠀⡿⡦⠄⣀⠀⠀⠀⠀⠀⣠⠤⠔⡟⡄⠈⣦⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⡏⢀⠎⠀⠀⠀⠀⠀⠀⠀
⠀                         ⠀⠀⠀     ⠀⠀⠀⠀⠀⠀⠀⢱⢀⡼⠖⠲⢤⠤⢄⠀⠀⣀⣠⡼⢡⠃⠀⢳⢇⠀⢈⡉⠒⠒⠒⠈⠁⠀⣠⡇⠃⠀⢸⢱⣄⡀⠀⠀⢀⣀⡠⠤⣠⡟⢀⠎⠀⠀⠀⠀⠀⠀⠀⠀
⠀                         ⠀⠀⠀     ⠀⠀⠀⠀⠀⠀⢀⡴⠋⢀⣠⠴⠈⠳⣼⠞⠋⠁⣼⠃⠘⠀⠀⢸⠈⠣⡀⠈⡄⠚⠃⠈⢀⠔⠁⡇⢰⠀⠀⠀⣷⠉⠙⢲⣡⠿⠆⣄⡈⠙⢯⡀⠀⠀⠀⠀⠀⠀⠀⠀
⠀                         ⠀⠀⠀     ⠀⠀⠀⠀⠀⠀⡸⠀⠀⠉⢀⡤⠔⠶⢇⠀⠀⢠⡏⠀⠀⠀⠀⢸⠤⠲⣌⠢⣄⢀⡤⠚⡷⠶⢄⡇⢸⠀⠀⠀⢸⡆⠀⢸⠥⠤⣄⡀⠉⠀⠀⠙⡄⠀⠀⠀⠀⠀⠀⠀
⠀                         ⠀⠀⠀     ⠀⠀⠀⠀⠀⠀⢡⣂⠀⠀⠁⣀⡤⠤⢼⠀⠀⣼⠁⠀⠀⠀⠀⢸⠀⠀⠀⠙⡶⠡⢲⠉⠀⠀⢠⠁⠸⠀⠀⠀⠘⣇⠀⡧⠤⣀⠀⠉⠀⠀⠀⠀⡇⠀⠀⠀⠀⠀⠀⠀
⠀                         ⠀⠀⠀     ⠀⠀⠀⠀⠀⠀⢸⠄⠂⠀⠀⠀⠀⣀⣀⠇⠀⡟⠀⠀⠀⠀⠀⢸⠀⠀⠀⢰⢐⢢⠈⠀⠀⠀⢸⡇⠀⠀⠀⠀⠀⣿⢸⣀⣀⠀⠉⠀⠀⠀⠀⢠⠃⠀⠀⠀⠀⠀⠀⠀
⠀                         ⠀⠀⠀     ⠀⠀⠀⠀⠀⠀⢸⢀⠂⠀⠀⠀⡿⠘⡏⡄⠀⡇⠀⠀⠀⠀⠀⢸⠀⠀⠀⢸⠀⠀⠀⠀⠀⠀⠸⠁⠀⠀⠀⠀⠀⣿⠀⡹⠉⡹⠀⠀⠀⠀⠇⢸⣆⠀⠀⠀⠀⠀⠀⠀
⠀                         ⠀⠀⠀     ⠀⠀⠀⠀⠀⢀⡏⢊⢀⢄⠠⠠⣷⠀⠹⡇⢸⠀⠀⠀⠀⠀⠀⠀⡄⠀⠀⢸⠀⠀⡇⠀⠀⠀⣷⠀⠀⠀⠀⠀⠀⣿⣴⠁⣰⢃⠀⠂⠨⢄⠌⠻⢟⡄⠀⠀⠀⠀⠀⠀
⠀                         ⠀⠀⠀     ⠀⠀⠀⠀⠰⠋⠱⡀⠄⡄⡀⠐⡺⡆⠀⢣⢸⠀⣀⣀⣀⠀⠀⠀⡇⠀⠀⡌⣀⡀⡇⠀⠀⠀⠟⠀⠀⠀⠀⠀⣀⣿⠂⣰⠉⡆⡈⠐⠒⢁⢁⢁⠎⢺⡄⠀⠀⠀⠀⠀
⠀                         ⠀⠀⠀     ⠀⠀⠀⣠⣷⠀⠀⠈⠑⠒⠀⠒⣿⠸⡀⠈⡟⠛⠒⠒⠦⢍⣴⡾⠃⠀⠀⣿⠑⠃⠃⠀⠀⠰⣦⣤⣤⣴⣮⠥⣼⠃⡰⢹⠀⢹⢤⣭⣉⣅⠔⠋⠀⢸⠻⡀⠀
⠀                         ⠀ ⠀⠀    ⠀⠀⣤⣤⡤⢠⠄⠀⢤⡤⠄⢠⠀⢀⡤⠤⢤⠀⠀⠀⣠⣤⡤⢀⡄⠀⢤⡤⠄⢠⠄⢀⣤⣤⣀⡤⠀⠀⢠⣤⣤⠀⡄⠀⠤⡤⠤⢠⠄⢀⣤⣤⠀⡄⠀⠀⠀
⠀                             ⠀⠀⠀⠀⢰⡧⠤⠉⡟⠀⡠⠾⡦⢹⠇⢠⣬⣷⣶⣭⠄⠀⢠⡧⠤⠍⡿⠀⡠⠞⠧⢉⡏⠀⠯⠤⠟⢺⠃⠀⠀⣯⠤⠌⣹⠁⣠⠜⢧⠈⡟⠀⡴⠒⠚⢰⠃⠀⠀⠀
⠀                         ⠀⠀⠀     ⢠⣇⣀⣈⠁⠀⣸⣀⣀⡈⠀⢰⣓⣒⣺⠁⠀⠀⢀⣏⣀⣀⠁⠀⣸⣃⣀⡈⠀⠀⣞⣀⣀⡁⠀⠀⠀⣞⣀⣀⡁⠀⢰⣇⣀⣈⠁⠐⠓⠒⢂⡏⠀⠀⠀
        ");
        
        
        Console.SetCursorPosition(10, 14);
        Console.WriteLine($"{User.name} in at dungeon-ri");
        Console.SetCursorPosition(48, 0);
        Console.WriteLine("던전읍 던전면 던전리 v1.01");


        Thread.Sleep(3000);
        Console.Clear();
        
        
        
        bool crossroads = true;// 게임 조작 씬
        while (crossroads)

        {
            Console.WriteLine("당신은 비틀거리며 일어납니다.\nEnter");
            Console.ReadLine();
            Console.Clear();
            
            Console.WriteLine("주위를 둘러봐도 산과 숲으로 둘러 쌓여 있습니다.\n다른 것이라곤 저 멀리에 구멍가게 하나만 보입니다.");
            bool pickupmoney = false;
            int maxevent = 0;
            while (true) 
            {   
                Console.WriteLine("어떻게 하시겠습니까 ? ");
                Console.WriteLine();
                Console.WriteLine("1.내 상태 확인\n2.소지품 확인\n3.구멍가게로 향하기\n4.산으로 들어가기\n5.바닥을 살펴본다.");
                Console.WriteLine();
                Console.WriteLine("원하는 선택지를 입력하세요\n>>");
                string choice = Console.ReadLine();

                bool quitAnswer = true;

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        User.statusinfo();
                        
                        while (quitAnswer)
                        {
                            Console.WriteLine("0.나가기");
                            string quit = Console.ReadLine();
                            switch (quit)
                            {
                                case "0":
                                    Console.Clear();
                                    quitAnswer = false;
                                    break;

                                default:
                                    Console.Clear();
                                    Console.WriteLine("잘못 된 입력입니다.");

                                    continue;

                            }
                        }
                        break;
                   
                    case "2":
                        
                        
                        break;
                   
                    case "3":
                        Console.Clear();
                        User.statusinfo();
                        Console.WriteLine("나가기 - Enter Key");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                   
                    case "4":
                        Console.Clear();
                        User.statusinfo();
                        Console.WriteLine("나가기 - Enter Key");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "5":
                        if (!pickupmoney)
                        {
                            Console.Clear();
                            Console.WriteLine("신난다. 만원짜리 지폐를 주웠다.");
                            User.money += 10000;
                            pickupmoney = true;
                            Console.WriteLine("나가기 - Enter Key");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else if (maxevent >= 6 && maxevent < 10)
                        {
                            maxevent += 1;
                            Console.Clear();
                            Console.WriteLine("이제 땅은 그만보고 어디든 가보자...");
                            Console.WriteLine("나가기 - Enter Key");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else if (maxevent >= 10 && maxevent < 13)
                        {
                            maxevent += 1;
                            Console.Clear();
                            Console.WriteLine("그만하자니까?");
                            Console.WriteLine("나가기 - Enter Key");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else if (maxevent == 13)
                        {
                            maxevent += 1;
                            Console.Clear();
                            Console.WriteLine("저기요?");
                            Console.WriteLine("나가기 - Enter Key");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else if (maxevent ==14)
                        {
                            maxevent += 1;
                            Console.Clear();
                            Console.WriteLine("뛣?");
                            Console.WriteLine("나가기 - Enter Key");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else if (maxevent >=15)
                        {
                            Console.Clear();
                            Console.WriteLine(@"소갈비찜 레시피

재료
물 적당량, 설탕 3큰술, 소갈비(찜용) 1.5kg, 
양념(간장 7큰술, 맛술, 올리고당 3큰술씩, 설탕, 참기름 1큰술씩, 다진 마늘 2큰술, 배즙 양파즙 1포씩), 
당근 ½개, 무 4개. 표고버섯 6개, 대파 2개, 쪽파 1개

만드는법

1볼에 소갈비가 잠길 정도로 물을 부어 설탕을 넣고 완전히 녹인 다음 소갈비를 넣고 30분간담가 핏물을 뺀다.

2 ①의 갈비는 냄비에 넣고 한 번 끓인다.

3 볼에 분량의 양념을 넣고 섞는다.

4 당근과 무는 3~4cm 크기로 깍둑썰고, 표고버섯은 밑동을 제거한다. 대파는 5cm 길이로 자르고 쪽파는 다진다.

5 전기 압력솥에 ②의 갈비, ④의 채소를 모두 넣고 찜 모드로 40분간 조리한다.

6완성된 갈비찜을 그릇에 담고 다진 쪽파를 뿌려 완성한다.");
                            Console.WriteLine("나가기 - Enter Key");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else if(maxevent<6)
                        {
                            Console.Clear();
                            Random random = new Random();
                            int number = random.Next(0, 3);

                            switch (number)
                            {
                                case 0:
                                    Console.WriteLine("어. 지렁이");
                                    break;
                                case 1:
                                    Console.WriteLine("소똥이다.밟지 않게 조심하자.");
                                    break;
                                case 2:
                                    Console.WriteLine("동전인줄 알고 주웠지만 납작하게 눌린 똥이었다.");
                                    break;

                            }

                            maxevent += 1;

                            Console.WriteLine("나가기 - Enter Key");
                            Console.ReadLine();
                            Console.Clear();

                        }
                        break;

                    default: Console.Clear();
                        Console.WriteLine("잘못 된 입력입니다.");
                        break;
                }



            }

        }
























    }












}










 static public class Start

{
    static public void GameStart()
    {   //@""는 문자열을 작성한 모양 그대로 출력해줍니다
        Console.WriteLine(@"
  ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀     ⠀                         ⠀⠀⠀     ⠀⠀⣠⡴⠖⠛⠊⠉⠉⠉⠵⠛⠲⢦⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀                         ⠀⠀⠀     ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⠞⠍⠀⡈⠤⠄⠀⠀⠀⠀⠀⠀⠩⢘⠓⢄⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣀⣀⣀⣀⣀⠀⠀⠀⠀⠀⠀⠀
⠀                         ⠀⠀⠀     ⠀⠀⠀⠀⠀⠀⠀⣠⠤⠒⠚⠉⢉⣉⠵⠶⠄⠀⠀⠀⢰⣁⣊⠤⠔⣒⡒⠊⠭⠭⠍⠑⢒⣒⠦⠤⣎⡈⢆⠀⠀⠀⠀⠀⠐⠚⠻⠷⣄⡤⠄⡀⠈⠉⠲⣄⠀⠀⠀⠀
⠀                         ⠀⠀⠀     ⠀⠀⠀⠀⢀⠔⠉⠀⣀⢠⡶⠟⠉⠀⠀⠀⠀⣀⡤⣖⠩⠁⠠⣉⣒⡤⠬⠭⠤⠤⡤⠤⠤⢄⣀⣉⠄⣈⠩⢲⢤⣀⠀⠀⠀⠀⠀⠀⠀⠉⠓⢤⡁⠢⡀⠈⠳⣄⠀⠀
⠀                         ⠀⠀⠀     ⠀⠀⠀⡴⠁⠀⣠⢞⡵⠋⠀⠀⠀⠀⢀⡴⣻⠇⠩⠀⢀⣴⠚⠉⠀⠀⠀⠈⠿⠿⠏⠀⠀⠀⠀⠉⠛⣦⣀⠂⠁⠫⠳⣤⠀⠀⠀⠀⠀⠀⠀⠀⠙⢷⡄⠢⠀⠹⡄⠀
⠀                         ⠀⠀⠀     ⠀⠀⡞⠀⢀⣌⡵⠋⠀⠀⠀⠀⠀⡰⢫⠊⢀⢀⡒⣰⠏⡅⠀⢀⣤⠴⠤⠀⠀⠀⠀⠀⠴⠶⣤⡀⠀⢩⠝⢦⠀⠐⠄⠪⠑⡄⠀⠀⠀⠀⠀⠀⠀⠀⠙⣆⠡⠀⢱⠀
⠀                         ⠀⠀⠀     ⠀⠸⡀⠀⢒⡎⠀⠀⠀⠀⠀⠀⢠⠃⡀⠀⠆⠀⠀⢀⢠⡄⠀⠋⠀⠀⠀⠠⠀⠀⠀⠀⠀⠀⠀⠁⠀⢰⠀⢸⠃⠒⠈⠀⠃⢸⠀⠀⠀⠀⠀⠀⠀⠀⠀⠸⠇⡄⢸⠀
⠀                         ⠀⠀⠀     ⠀⠀⢸⡾⠿⡇⠀⠀⠀⠀⠀⠀⠀⢧⠡⠀⢃⠀⣢⢼⣶⠀⡄⢠⠶⠒⠲⠀⠃⠀⠀⠰⢒⠒⠦⢠⡀⠈⣴⣚⣦⠀⡰⠀⠆⡸⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣅⢁⠇⠀
⠀                         ⠀⠀⠀     ⠀⠀⠈⣧⣀⣳⠀⠀⠀⠀⠀⠀⠀⠈⠳⢦⣀⠀⣿⢫⡞⠀⠁⠀⠀⠀⠁⠀⠃⠀⠀⣀⠈⠈⠀⠀⠀⠀⡿⠍⢋⠀⢀⣠⠞⠁⠀⠀⠀⠀⠀⠀⠀⠀⢠⠏⢉⡿⠀⠀
⠀                         ⠀⠀⠀     ⠀⠀⠀⠈⣯⠈⡆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠉⢻⡴⡇⠀⠀⠀⠀⣠⠾⠡⠄⠀⠤⠈⠢⣄⠀⠀⠀⠀⡧⠂⡿⠚⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⠟⢦⡾⠁⠀⠀
⠀                         ⠀⠀⠀     ⠀⠀⠀⠀⠸⡆⠘⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢳⣸⠀⠀⠀⡔⣁⠀⠀⠀⠀⠀⠀⠀⣈⠓⠀⠀⢀⣇⡔⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⠎⢠⡟⠀⠀⠀⠀
⠀                         ⠀⠀⠀     ⠀⠀⠀⠀⠀⢳⠀⢱⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⣆⠀⢄⠀⠘⠿⣭⢉⣀⢉⣭⠟⠋⠂⡐⠀⡼⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⠎⢀⡞⠀⠀⠀⠀⠀
⠀                         ⠀⠀⠀     ⠀⠀⠀⠀⠀⠈⢇⠀⢧⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⣦⡈⢆⠀⠀⠐⠎⠍⠲⠆⠀⠀⠰⢁⡼⣇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⠏⢀⠞⠀⠀⠀⠀⠀⠀
⠀                         ⠀⠀⠀     ⠀⠀⠀⠀⠀⠀⠘⡄⠈⣆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡠⡞⠀⡿⡦⠄⣀⠀⠀⠀⠀⠀⣠⠤⠔⡟⡄⠈⣦⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⡏⢀⠎⠀⠀⠀⠀⠀⠀⠀
⠀                         ⠀⠀⠀     ⠀⠀⠀⠀⠀⠀⠀⢱⢀⡼⠖⠲⢤⠤⢄⠀⠀⣀⣠⡼⢡⠃⠀⢳⢇⠀⢈⡉⠒⠒⠒⠈⠁⠀⣠⡇⠃⠀⢸⢱⣄⡀⠀⠀⢀⣀⡠⠤⣠⡟⢀⠎⠀⠀⠀⠀⠀⠀⠀⠀
⠀                         ⠀⠀⠀     ⠀⠀⠀⠀⠀⠀⢀⡴⠋⢀⣠⠴⠈⠳⣼⠞⠋⠁⣼⠃⠘⠀⠀⢸⠈⠣⡀⠈⡄⠚⠃⠈⢀⠔⠁⡇⢰⠀⠀⠀⣷⠉⠙⢲⣡⠿⠆⣄⡈⠙⢯⡀⠀⠀⠀⠀⠀⠀⠀⠀
⠀                         ⠀⠀⠀     ⠀⠀⠀⠀⠀⠀⡸⠀⠀⠉⢀⡤⠔⠶⢇⠀⠀⢠⡏⠀⠀⠀⠀⢸⠤⠲⣌⠢⣄⢀⡤⠚⡷⠶⢄⡇⢸⠀⠀⠀⢸⡆⠀⢸⠥⠤⣄⡀⠉⠀⠀⠙⡄⠀⠀⠀⠀⠀⠀⠀
⠀                         ⠀⠀⠀     ⠀⠀⠀⠀⠀⠀⢡⣂⠀⠀⠁⣀⡤⠤⢼⠀⠀⣼⠁⠀⠀⠀⠀⢸⠀⠀⠀⠙⡶⠡⢲⠉⠀⠀⢠⠁⠸⠀⠀⠀⠘⣇⠀⡧⠤⣀⠀⠉⠀⠀⠀⠀⡇⠀⠀⠀⠀⠀⠀⠀
⠀                         ⠀⠀⠀     ⠀⠀⠀⠀⠀⠀⢸⠄⠂⠀⠀⠀⠀⣀⣀⠇⠀⡟⠀⠀⠀⠀⠀⢸⠀⠀⠀⢰⢐⢢⠈⠀⠀⠀⢸⡇⠀⠀⠀⠀⠀⣿⢸⣀⣀⠀⠉⠀⠀⠀⠀⢠⠃⠀⠀⠀⠀⠀⠀⠀
⠀                         ⠀⠀⠀     ⠀⠀⠀⠀⠀⠀⢸⢀⠂⠀⠀⠀⡿⠘⡏⡄⠀⡇⠀⠀⠀⠀⠀⢸⠀⠀⠀⢸⠀⠀⠀⠀⠀⠀⠸⠁⠀⠀⠀⠀⠀⣿⠀⡹⠉⡹⠀⠀⠀⠀⠇⢸⣆⠀⠀⠀⠀⠀⠀⠀
⠀                         ⠀⠀⠀     ⠀⠀⠀⠀⠀⢀⡏⢊⢀⢄⠠⠠⣷⠀⠹⡇⢸⠀⠀⠀⠀⠀⠀⠀⡄⠀⠀⢸⠀⠀⡇⠀⠀⠀⣷⠀⠀⠀⠀⠀⠀⣿⣴⠁⣰⢃⠀⠂⠨⢄⠌⠻⢟⡄⠀⠀⠀⠀⠀⠀
⠀                         ⠀⠀⠀     ⠀⠀⠀⠀⠰⠋⠱⡀⠄⡄⡀⠐⡺⡆⠀⢣⢸⠀⣀⣀⣀⠀⠀⠀⡇⠀⠀⡌⣀⡀⡇⠀⠀⠀⠟⠀⠀⠀⠀⠀⣀⣿⠂⣰⠉⡆⡈⠐⠒⢁⢁⢁⠎⢺⡄⠀⠀⠀⠀⠀
⠀                         ⠀⠀⠀     ⠀⠀⠀⣠⣷⠀⠀⠈⠑⠒⠀⠒⣿⠸⡀⠈⡟⠛⠒⠒⠦⢍⣴⡾⠃⠀⠀⣿⠑⠃⠃⠀⠀⠰⣦⣤⣤⣴⣮⠥⣼⠃⡰⢹⠀⢹⢤⣭⣉⣅⠔⠋⠀⢸⠻⡀⠀
⠀                         ⠀ ⠀⠀    ⠀⠀⣤⣤⡤⢠⠄⠀⢤⡤⠄⢠⠀⢀⡤⠤⢤⠀⠀⠀⣠⣤⡤⢀⡄⠀⢤⡤⠄⢠⠄⢀⣤⣤⣀⡤⠀⠀⢠⣤⣤⠀⡄⠀⠤⡤⠤⢠⠄⢀⣤⣤⠀⡄⠀⠀⠀
⠀                             ⠀⠀⠀⠀⢰⡧⠤⠉⡟⠀⡠⠾⡦⢹⠇⢠⣬⣷⣶⣭⠄⠀⢠⡧⠤⠍⡿⠀⡠⠞⠧⢉⡏⠀⠯⠤⠟⢺⠃⠀⠀⣯⠤⠌⣹⠁⣠⠜⢧⠈⡟⠀⡴⠒⠚⢰⠃⠀⠀⠀
⠀                         ⠀⠀⠀     ⢠⣇⣀⣈⠁⠀⣸⣀⣀⡈⠀⢰⣓⣒⣺⠁⠀⠀⢀⣏⣀⣀⠁⠀⣸⣃⣀⡈⠀⠀⣞⣀⣀⡁⠀⠀⠀⣞⣀⣀⡁⠀⢰⣇⣀⣈⠁⠐⠓⠒⢂⡏⠀⠀⠀⠀
");
        Console.SetCursorPosition(55, 28);
        Console.WriteLine("Please Enter");
        Console.SetCursorPosition(48, 0);
        Console.WriteLine("던전읍 던전면 던전리 v1.01");
    }
}


public static class User  //플레이어 클래스
{
    public static int level { get; set; } = 1;
    public static int exp { get; set; } = 0;
    public static string name { get; set; }
    public static string job { get; set; } = "농부";
    public static int damage { get; set; } = 10;
    public static int defence { get; set; } = 0;
    public static int hp { get; set; } = 100;
    public static int money { get; set; } = 500;
    public static void statusinfo()
    {
        Console.WriteLine($"Lv.{level}\n{name}({job})\n공격력 : {damage}\n방어력 : {defence}\n체력 : {hp}\n소지금 : {money}원");
    }
    public static List<Item> Inventory { get; set; } = new List<Item>();

}



public class EndGame //종료하는 키워드를 사용자 입력을 저장해서 사용해 보려고 만든 클래스 - 사용자 커스텀 기능
{
    string endGame { get; set; }
    public void quit()
    {

    }
}




public class Monster //몬스터 클래스
{
    public string name { get; set; }
    public int hp { get; set; }
    public int damage { get; set; }

    public void attack(int damage)
    {

    }

    public void death(int hp)
    {
        if (hp <= 0)
        {

        }
    }
    public void dropItem(string itemName)
    {
        Console.WriteLine($"{name}{itemName}을 흘렸습니다.");
    }

}

public class Shop //가게 씬을 위한 클래스
{
    public string shopName = "구멍가게";
    public List<Item> stash { get; set; } = new List<Item>();
    public void DisplayItems()
    {
        Console.WriteLine($"[{shopName}]의 판매목록");

        foreach (Item item in stash)
        {
            item.explanation("삽입니다.삽질할 때 사용합니다.");
        }
    }

}
//아이템 클래스
public abstract class Item
{
    public string itemName { get; set; }
    public int price { get; set; }

    public int conut { get; set; } = 1;
    public void explanation(string input)
    {

    }
}

//무기 : 아이템
public class Weapon : Item
{
    public string type = "무기";
    public int damage { get; set; } = 0;
    public bool isEquip { get; set; } = false;
    public void explanation(string input)
    {
        Console.WriteLine($"{itemName}({type})|공격력+{damage}|{input}|{price}");
    }
    public void equipText()
    {
        Console.WriteLine($"{itemName}을(를) 장착 하였습니다.");
    }
}



//방어구 : 아이템
public class Armour : Item
{
    public string type = "방어구";
    public int defense { get; set; } = 0;
    public bool isEquip { get; set; } = false;
    public void explanation(string input)
    {
        Console.WriteLine($"{itemName}({type})|방어력+{defense}|{input}|{price}");
    }
    public void equipText()
    {
        Console.WriteLine($"{itemName}을(를) 장착 하였습니다.");
    }

}
//소비 아이템 클래스
public class ConsumableItem : Item
{
    public virtual string itemName { get; set; } = string.Empty;
    public void Isusing()
    {
        User.hp += 30;
        Console.WriteLine($"{itemName}를(을) 사용하였습니다.");

    }

}

//부엌 클래스
public class Kitchen
{
    public void cook()
    {

    }
}