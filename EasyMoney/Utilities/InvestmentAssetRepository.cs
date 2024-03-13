using EasyMoney.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMoney.Utilities
{
    public static class InvestmentAssetRepository
    {
        public static List<InvestmentAsset> InvestmentAssets = new List<InvestmentAsset>
        {
            new InvestmentAsset
            {
                Name = "Мальчик на цепи",
                MinimalRank = 0,
                PurchaseCost = 0.0099m,
                RepairCost = 0.0083m,
                ProfitPerSecond = 0.0005m,
                Durability = 50
            },
            new InvestmentAsset
            {
                Name = "Старый ноутбук Жени",
                MinimalRank = 0,
                PurchaseCost = 0.0199m,
                RepairCost = 0.0280m,
                ProfitPerSecond = 0.0007m,
                Durability = 120
            },
            new InvestmentAsset
            {
                Name = "Умирающий принтер",
                MinimalRank = 0,
                PurchaseCost = 0.0499m,
                RepairCost = 0.0360m,
                ProfitPerSecond = 0.0009m,
                Durability = 120
            },
            new InvestmentAsset
            {
                Name = "TG-канал",
                MinimalRank = 1,
                PurchaseCost = 0.2499m,
                RepairCost = 0.0440m,
                ProfitPerSecond = 0.0011m,
                Durability = 120
            },
            new InvestmentAsset
            {
                Name = "YT-канал guilty",
                MinimalRank = 1,
                PurchaseCost = 0.7999m,
                RepairCost = 0.1000m,
                ProfitPerSecond = 0.0015m,
                Durability = 200
            },
            new InvestmentAsset
            {
                Name = "Бизнес курс по инвестициям",
                MinimalRank = 2,
                PurchaseCost = 1.7000m,
                RepairCost = 0.1333m,
                ProfitPerSecond = 0.0020m,
                Durability = 200
            },
            new InvestmentAsset
            {
                Name = "Пекарня курников",
                MinimalRank = 3,
                PurchaseCost = 3.4999m,
                RepairCost = 5.333m,
                ProfitPerSecond = 0.0800m,
                Durability = 200
            },
            new InvestmentAsset
            {
                Name = "Цветочный магазин",
                MinimalRank = 4,
                PurchaseCost = 24.9999m,
                RepairCost = 8.5000m,
                ProfitPerSecond = 0.8500m,
                Durability = 300
            },
            new InvestmentAsset
            {
                Name = "Разведение кроликов",
                MinimalRank = 5,
                PurchaseCost = 79.0000m,
                RepairCost = 9.0000m,
                ProfitPerSecond = 0.0900m,
                Durability = 300
            },
            new InvestmentAsset
            {
                Name = "Музыкальный лейбл",
                MinimalRank = 5,
                PurchaseCost = 249.9900m,
                RepairCost = 10.0000m,
                ProfitPerSecond = 0.1000m,
                Durability = 300
            },
            new InvestmentAsset
            {
                Name = "Фит с Моргеном",
                MinimalRank = 6,
                PurchaseCost = 666.0000m,
                RepairCost = 22.5000m,
                ProfitPerSecond = 0.1500m,
                Durability = 450
            },
            new InvestmentAsset
            {
                Name = "Швейцарская сыроварня",
                MinimalRank = 6,
                PurchaseCost = 1199.0000m,
                RepairCost = 31.1667m,
                ProfitPerSecond = 0.1700m,
                Durability = 550
            },
            new InvestmentAsset
            {
                Name = "Изобрести новый вид чипсов",
                MinimalRank = 7,
                PurchaseCost = 2999.0000m,
                RepairCost = 333.0000m,
                ProfitPerSecond = 1.0000m,
                Durability = 999
            }
        };


    }
}
