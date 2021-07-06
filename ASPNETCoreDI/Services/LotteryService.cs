using System;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ASPNETCoreDI.Services
{
    public class LotteryService : ILotteryService
    {
        private static Random rnd = new Random();
        public string GetWinningNumber()
        {
            string number = "";
            for (int i = 0; i < 7; i++)
                number += rnd.Next(0, 10).ToString();
            return number;
        }
    }
}