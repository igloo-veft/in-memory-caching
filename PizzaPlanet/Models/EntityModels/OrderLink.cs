namespace PizzaPlanet.Models.EntityModels
{  
    /// <summary>
    /// Entity model for linking ordered menu items to an order
    /// </summary>
    public class OrderLinks
    {
        /// <summary>
        /// Id of the link
        /// </summary>
        /// <returns></returns>
        public int Id { get; set; }
        /// <summary>
        /// Id of the order
        /// </summary>
        /// <returns></returns>
        public int OrderId { get; set; }
        /// <summary>
        /// Id of the menu item
        /// </summary>
        /// <returns></returns>
        public int MenuItemId { get; set; }
    }
}