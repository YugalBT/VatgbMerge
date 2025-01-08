namespace Standing_Order_Vat_App.MvcHelper
{
    public static class CalculationForNetFee
    {
        public static double CalculateNetFee(double transAmt)
        {
            return Math.Round((transAmt / 1.17), 2);
        }
    }
}
