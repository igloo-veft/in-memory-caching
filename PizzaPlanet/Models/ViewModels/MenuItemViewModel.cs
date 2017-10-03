namespace PizzaPlanet.Models.ViewModels
{
    /// <summary>
    /// View model for an item on the menu
    /// </summary>
    public class MenuItemViewModel
    {
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
        /// A description of the item
        /// </summary>
        /// <returns></returns>
        public string Description { get; set; }
        /// <summary>
        /// Price of the item
        /// </summary>
        /// <returns></returns>
        public double Price { get; set; }
    }
}