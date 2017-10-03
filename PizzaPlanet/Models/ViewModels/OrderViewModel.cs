using System;
using System.Collections.Generic;

namespace PizzaPlanet.Models.ViewModels
{
    /// <summary>
    /// View model for an order
    /// </summary>
    public class OrderViewModel
    {
        /// <summary>
        /// Date of when the order was placed
        /// </summary>
        /// <returns></returns>
        public DateTime DateOfOrder { get; set; }        
        /// <summary>
        /// Name of the customer that placed the order
        /// </summary>
        /// <returns></returns>
        public string CustomerName { get; set; }
        /// <summary>
        /// Whether the order is a pickup or delivery
        /// </summary>
        /// <returns></returns>
        public bool IsPickup { get; set; }
        /// <summary>
        /// Address of customer (in case of delivery)
        /// </summary>
        /// <returns></returns>
        public string Address { get; set; }
        /// <summary>
        /// A list of ids of the items on the menu being ordered
        /// </summary>
        /// <returns></returns>
        public List<int> OrderItemsIds { get; set; }
    }
}