using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//섯다게임 구현하기~
namespace Shutta
{
    class Program
    {
        static void Main(string[] args)
        {
            //딜러
            Dealer dealer = new Dealer();

            //보드
            Board board = new Board();

            //스코럴
            Scorer scorer = new Scorer();

            //플레이어
            //List는 동적배열
            List<Player> players = new List<Player>();
            players.Add(new Player(0));
            players.Add(new Player(1));

            // 둘 중 한 명이 올인 날 때까지..
            while (CanGoRound(players))
            {
                // 라운드 진행

                // 딜러가 카드를 섞는다.
                dealer.Shuffle();

                // 판돈 내기
                for (int i = 0; i < players.Count; i++)
                {
                    players[i].Money -= 100;
                    board.Money += 100;
                }

                // 카드 나눠주기(각 플레이어에게 2장씩 준다)
                for (int i = 0; i < players.Count; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        Card card = dealer.GetCard();
                        players[i].TakeCard(card); 
                    }
                }

                // 승자를 찾는다.
                Player winner = scorer.GetWinner(players[0], players[1]);

                // 무승부면 루프의 처음으로 다시 돌아가서 실행.
                if (winner == null)
                    continue;

                // 판돈을 승자에게 준다.
                winner.Money += board.Money;
                // 보드는 금액을 0으로 초기화.
                board.Money = 0;

                // 플레리어가 가진 카드와 소지금, 승자를 출력한다.
                PrintRoundResult(players, winner);

            }// end of while()
        }//end of main()

        static void PrintRoundResult(List<Player> players, Player winner)
        {
            for (int i = 0; i < players.Count; i++)
            {
                Console.WriteLine($"P{players[i].No} : {players[i].Money}");

                for (int j = 0; j < 2; j++)
                    Console.Write(players[i].cards[j].ToText() + " / ");
            }

            Console.WriteLine($"승자는 {winner.No}.");

        }

        // 라운드 실행이 가능한지 판단하는 메서드
        static bool CanGoRound(List<Player> players)
        {
            if (players[0].Money > 0 && players[1].Money > 0)
                return true;

            return false;
        }
    }
}
