namespace PizzaPlanet.Models.DTOModels
{
    /// <summary>
    /// Model of a single menu item
    /// </summary>
    public class MenuItemDTO
    {
        /// <summary>
        /// Id of the menu item
        /// </summary>
        /// <returns></returns>
        public int Id { get; set; }
        /// <summary>
        /// Name of the menu item
        /// </summary>
        /// <returns></returns>
        public string Name { get; set; }
        /// <summary>
        /// Price of the menu item
        /// </summary>
        /// <returns></returns>
        public double Price { get; set; }
    }
}