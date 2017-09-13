namespace GenericSample
{
    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        /// <summary>
        /// 透過 where 限制 TProduct 是 Product，方法傳入的 TProduct 參數就可以使用 Product 的屬性
        /// </summary>

        public float CalculatorDiscount(TProduct product)
        {
            return product.Price;
        }
    }
}