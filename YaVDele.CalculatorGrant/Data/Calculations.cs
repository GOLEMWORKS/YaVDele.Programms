namespace YaVDele.CalculatorGrant.Data
{
    public class Calculations
    {
        public string init() => "Calculation module initialized";
        public double CalculateSofinans(double grantAmount, double teamHelp) 
            => Math.Round((grantAmount + teamHelp) * 30 / 100, 2);
        public double CalculatePercent(double inputAmount, double inputPercent) 
            => Math.Round(inputAmount * (inputPercent / 100), 2);
        public double CalculatePercentDifference(double inputAmountOne, double inputAmountTwo, double percentFromOne, double percentFromTwo) 
            => Math.Round((inputAmountOne * (percentFromOne / 100)) - (inputAmountTwo / (percentFromTwo / 100)), 2);
        public double CalculateIndexation(double priceBefore, double priceAfter, int quantity = 1)
            => Math.Round((priceAfter - priceBefore) * quantity, 2);
        public double CalculateIndexationPercent(double priceBefore, double indexationPercent, int quantity = 1)
            => Math.Round( (priceBefore * ((indexationPercent + 100) / 100)) * quantity,2);
    }
}
