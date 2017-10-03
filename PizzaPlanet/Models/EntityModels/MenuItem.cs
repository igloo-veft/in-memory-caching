namespace PizzaPlanet.Models.EntityModels
{
    /// <summary>
    /// Entity model for an item on the menu
    /// </summary>
    public class MenuItem
    {
        /// <summary>
        /// Id of the item
        /// </summary>
        /// <returns></returns>
        public int Id { get; set; }
        /// <summary>
        /// Name of the item
        /// </summary>
        /// <returns></returns>
        public string Name { get; set; }
        /// <summary>
        /// How spicy the item is
        /// </summary>
        /// <returns></returns>
        public int SpicyLevel { get; set; }
        /// <summary>
        /// Description of the item
        /// </summary>
        /// <returns></returns>
        public string Description { get; set; }
        /// <summary>
        /// The price of the item
        /// </summary>
        /// <returns></returns>
        public double Price { get; set; }
        /// <summary>
        /// Whether or not the item has been removed from the menu
        /// </summary>
        /// <returns></returns>
        public bool isDeleted { get; set; }
    }
}