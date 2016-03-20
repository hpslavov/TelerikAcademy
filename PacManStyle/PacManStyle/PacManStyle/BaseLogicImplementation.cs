﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;

namespace TankWars
{
    class Program
    {
        static int matrixHeight = 20;
        static int matrixWidth = 20;
        static int botsCount = 4;
        static Random randomIntGenerator = new Random();
        static Position[] directions = GetDirections();

        static void Main()
        {
            string[] botsSymbols = new string[]
            {
                "@",
                "$",
                "*",
                "#"
            };

            int score = 0;
            Console.BufferHeight = Console.WindowHeight;
            Position player = InitializePlayer();
            List<Position> bots = GenerateBots();
            Position target = GenerateTarget();
         
            DrawBots(bots, botsSymbols);
            //game loop logic.
            bool gamerunning = true;

            while (gamerunning)
            {
                bool targetAcquired = false;
                if (Console.KeyAvailable)
                {
                    player = MovePlayer(player);
                }

                bots = BotCrashTests(bots);
                bots = MoveBotsPosition(bots);
                targetAcquired = IsTargetAcquired(player, target);
                if (targetAcquired)
                {
                    target = GenerateNewTarget();
                    score++;
                }

                DrawConsoleLayout();
                DrawPlayer(player);
                DrawPlayerScore(score);
                DrawTarget(target);
                DrawBots(bots, botsSymbols);

                Thread.Sleep(200);
                //check if dead.
                gamerunning = CheckIfBotHitPlayer(bots, player, score);

            }
        }

        static Position InitializePlayer()
        {
            Position player = new Position(0, 0, 0);
            Console.SetCursorPosition(player.X, player.Y);
            Console.Write("(0)");

            return player;
        }

        static Position MovePlayer(Position player)
        {
            int direction = 0;

            ConsoleKeyInfo userInput = Console.ReadKey();
            if (userInput.Key == ConsoleKey.RightArrow)
            {
                direction = 0;

            }
            else if (userInput.Key == ConsoleKey.LeftArrow)
            {
                direction = 1;

            }
            else if (userInput.Key == ConsoleKey.UpArrow)
            {
                direction = 2;
            }
            else
            {
                direction = 3;
            }
            player = new Position(player.X + directions[direction].X, player.Y - directions[direction].Y, 0);

            return player;
        }

        static List<Position> BotCrashTests(List<Position> bots)
        {
            int crashedBotCoordinateX = 0;
            int crashedBotCoordinateY = 0;
            int crashedBotCurrentDirection = 0;
            for (int bot = 0; bot < botsCount; bot++)
            {
                if (bots[bot].X <= 3

                    )
                {
                    crashedBotCoordinateX = bots[bot].X;
                    crashedBotCoordinateY = bots[bot].Y;
                    crashedBotCurrentDirection = 0;
                    bots.RemoveAt(bot);
                    bots.Add(new Position(crashedBotCoordinateX, crashedBotCoordinateY, crashedBotCurrentDirection));

                }
                if (bots[bot].X > matrixWidth - 3)
                {
                    crashedBotCoordinateX = bots[bot].X;
                    crashedBotCoordinateY = bots[bot].Y;
                    crashedBotCurrentDirection = 1;
                    bots.RemoveAt(bot);
                    bots.Add(new Position(crashedBotCoordinateX, crashedBotCoordinateY, crashedBotCurrentDirection));
                }
                if (bots[bot].Y < 3)
                {
                    crashedBotCoordinateX = bots[bot].X;
                    crashedBotCoordinateY = bots[bot].Y;
                    crashedBotCurrentDirection = 3;
                    bots.RemoveAt(bot);
                    bots.Add(new Position(crashedBotCoordinateX, crashedBotCoordinateY, crashedBotCurrentDirection));
                }
                if (bots[bot].Y > matrixHeight - 3)
                {
                    crashedBotCoordinateX = bots[bot].X;
                    crashedBotCoordinateY = bots[bot].Y;
                    crashedBotCurrentDirection = 2;
                    bots.RemoveAt(bot);
                    bots.Add(new Position(crashedBotCoordinateX, crashedBotCoordinateY, crashedBotCurrentDirection));
                }
            }

            return bots;
        }

        static List<Position> MoveBotsPosition(List<Position> bots)
        {
            int randomDirection = 0;

            List<Position> CopyBots = new List<Position>(bots);
            bots.Clear();
            for (int i = 0; i < botsCount; i++)
            {
                randomDirection = CopyBots[i].CurrentDirectionBot;
                bots.Add(new Position(CopyBots[i].X + directions[randomDirection].X, CopyBots[i].Y - directions[randomDirection].Y, randomDirection));
            }

            return bots;
        }

        static Position[] GetDirections()
        {

            Position[] directions = new Position[] 
            {
                new Position(1,0,0), //right;
                new Position(-1,0,0),  //left
                new Position(0,1,0 ), //up
                new Position(0,-1,0) //down
            };

            return directions;
        }

        static List<Position> GenerateBots()
        {
            List<Position> bots = new List<Position>();

            for (int i = 0; i < botsCount; i++)
            {
                bots.Add(new Position(randomIntGenerator.Next(3, matrixWidth), randomIntGenerator.Next(3, matrixHeight), randomIntGenerator.Next(0, 3)));
            }

            return bots;
        }

        static Position GenerateTarget()
        {
            Position target = new Position(randomIntGenerator.Next(5, matrixWidth - 5), randomIntGenerator.Next(4, matrixHeight - 4), 0);
            return target;
        }

        static void DrawBots(List<Position> bots, string[] botsSymbols)
        {
              Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 0; i < bots.Count; i++)
            {
                Console.SetCursorPosition(bots[i].X, bots[i].Y);
                Console.Write(botsSymbols[i]);
            }
        }

        static void DrawConsoleLayout()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
        }

        static void DrawPlayer(Position player)
        {
            Console.SetCursorPosition(player.X, player.Y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("(0)");
        }

        static void DrawPlayerScore(int score)
        {
            Console.SetCursorPosition(50, 10);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Your score is ... : {0}", score);
        }

        static void DrawTarget(Position target)
        {
            Console.SetCursorPosition(target.X, target.Y);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("T");
        }

        static bool CheckIfBotHitPlayer(List<Position> bots, Position player, int score)
        {
            bool gamerunning = true;

            for (int i = 0; i < bots.Count; i++)
            {
                if (bots[i].X == player.X && bots[i].Y == player.Y)
                {
                    Console.Clear();
                    Console.SetCursorPosition(0, 0);
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Game OVER ! Your score is ... {0} ", score);
                    gamerunning = false;
                }
            }

            return gamerunning;
        }

        static bool IsTargetAcquired(Position player, Position target)
        {
            bool targetAcquired = false;
            if (player.X == target.X && player.Y == target.Y)
            {
                targetAcquired = true;
            }

            return targetAcquired;
        }

        static Position GenerateNewTarget()
        {
            Position target = new Position(randomIntGenerator.Next(5, matrixWidth - 5), randomIntGenerator.Next(4, matrixHeight - 4), 0);
            return target;
        }
    }
}