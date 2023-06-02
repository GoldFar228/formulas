

namespace formulas
{
    public static class Formulas
    {
        private static ArgumentException ThrowArgumentException(string paramName, string message) =>
            new(message, paramName);

        public static double DesiredProfitPercantage(double desiredProfit, double productPrice)
        {
            if (productPrice < 0)
                throw ThrowArgumentException(nameof(productPrice), "productPrice has to be positive");
            if (desiredProfit < 0)
                throw ThrowArgumentException(nameof(desiredProfit), "desiredProfit has to be positive");

            return desiredProfit / productPrice;
        }
        
        public static double SellVolume(double fixedCosts, double desiredProfit, double productPrice, double variableCosts)
        {
            if (productPrice < 0)
                throw ThrowArgumentException(nameof(productPrice), "productPrice has to be positive");
            if (desiredProfit < 0)
                throw ThrowArgumentException(nameof(desiredProfit), "desiredProfit has to be positive");
            if (fixedCosts < 0)
                throw ThrowArgumentException(nameof(fixedCosts), "fixedCosts has to be positive");
            if (variableCosts < 0)
                throw ThrowArgumentException(nameof(variableCosts), "variableCosts has to be positive");
            return (fixedCosts + desiredProfit) / (productPrice - variableCosts);
        }

        public static double SellSummary(double productPrice, double sellVolume)
        {
            if (productPrice < 0)
                throw ThrowArgumentException(nameof(productPrice), "productPrice has to be positive");
            if (sellVolume < 0)
                throw ThrowArgumentException(nameof(sellVolume), "sellVolume has to be positive");

            return productPrice * sellVolume;
        }

        public static double Profit(double productPrice, double variableCosts, double sellVolume, double fixedCosts)
        {
            if (productPrice < 0)
                throw ThrowArgumentException(nameof(productPrice), "productPrice has to be positive");
            if (variableCosts < 0)
                throw ThrowArgumentException(nameof(variableCosts), "variableCosts has to be positive");
            if (sellVolume < 0)
                throw ThrowArgumentException(nameof(sellVolume), "fixedCosts has to be positive");
            if (fixedCosts < 0)
                throw ThrowArgumentException(nameof(fixedCosts), "fixedCosts has to be positive");
            return (productPrice - variableCosts) * sellVolume - fixedCosts;
        }

        public static double CostPrice(double variableCosts, double fixedCosts, double volumeOfProduction)
        {
            if (variableCosts < 0)
                throw ThrowArgumentException(nameof(variableCosts), "variableCosts has to be positive");
            if (fixedCosts < 0)
                throw ThrowArgumentException(nameof(fixedCosts), "fixedCosts has to be positive");
            if (volumeOfProduction < 0)
                throw ThrowArgumentException(nameof(volumeOfProduction), "variableCosts has to be positive");
            return variableCosts + (fixedCosts / volumeOfProduction);
        }

        public static double ProductPrice(double costPrice, double desiredProfitPercentage)
        {
            if (costPrice < 0)
                throw ThrowArgumentException(nameof(costPrice), "costPrice has to be positive");
            if (desiredProfitPercentage < 0)
                throw ThrowArgumentException(nameof(desiredProfitPercentage), "desiredProfitPercentage has to be positive");

            return costPrice * (1 + (desiredProfitPercentage / 100));
        }

        public static double QuantityPoint(double fixedCosts, double productPrice, double variableCosts)
        {
            if (fixedCosts < 0)
                throw ThrowArgumentException(nameof(fixedCosts), "fixedCosts has to be positive");
            if (variableCosts < 0)
                throw ThrowArgumentException(nameof(variableCosts), "variableCosts has to be positive");
            if (productPrice < 0)
                throw ThrowArgumentException(nameof(productPrice), "productPrice has to be positive");

            return fixedCosts / (productPrice - variableCosts);
        }

        public static double MoneyPoint(double productPrice, double quantityPoint)
        {
            if (productPrice < 0)
                throw ThrowArgumentException(nameof(productPrice), "productPrice has to be positive");
            if (quantityPoint < 0)
                throw ThrowArgumentException(nameof(quantityPoint), "quantityPoint has to be positive");

            return productPrice * quantityPoint;
        }

        public static double VariableCosts(double productPrice, double variableCostsPercantage)
        {
            if (productPrice < 0)
                throw ThrowArgumentException(nameof(productPrice), "productPrice has to be positive");
            if (variableCostsPercantage < 0 || variableCostsPercantage > 100)
                throw ThrowArgumentException(nameof(variableCostsPercantage), "variableCostsPercantage has to be positive and less than 100");
            return variableCostsPercantage / 100 * productPrice;
        }

        public static double VariableCostsPercantage(double productPrice, double variableCosts)
        {
            if (productPrice < 0)
                throw ThrowArgumentException(nameof(productPrice), "productPrice has to be positive");
            if (variableCosts < 0)
                throw ThrowArgumentException(nameof(variableCosts), "variableCosts has to be positive");
            return variableCosts * 100 / productPrice;
        }

    }
}