using Basket.Data.Entity;

namespace Basket.Repo
{
    public interface IBasketRepo
    {
        Task AddItemToBasketAsync(int id);
        Task<List<BasketItem>> GetBasketItems();
        Task UpdateQuantityAsync(int quantity);

        //Task DeleteBasket(int BasketId); //deleting all products in basket
        //Task DeleteBasketItem(int BasketItemId);

        //Task<int> GetBasketCount();
        //Task<int> GetBasketSingleProd(int prodId);

        //Task<int> GetProductQuantity(int productId);

    }
}
