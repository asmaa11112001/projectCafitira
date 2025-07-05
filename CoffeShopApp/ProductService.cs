using DAL;

namespace CoffeShopApp
{
    internal class ProductService
    {
        private Context context;

        public ProductService(Context context)
        {
            this.context = context;
        }
    }
}