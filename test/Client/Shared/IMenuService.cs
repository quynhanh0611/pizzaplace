namespace PizzaPlace_2022.Shared
{
     public interface IMenuService
    {
        ValueTask<Menu> GetMenu();
    }
}
