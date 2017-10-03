using System;
using System.Collections.Generic;

namespace PizzaPlanet.Models.DTOModels
{
    /// <summary>
    /// When requesting a single order OrderDTO is returned
    /// </summary>
    public class OrderDTO
    {
        /// <summary>
        /// Id of the order
        /// </summary>
        /// <returns></returns>
        public int Id { get; set; }
        /// <summary>
        /// Date of order placement
        /// </summary>
        /// <returns></returns>
        public DateTime DateOfOrder { get; set; }
        /// <summary>
        /// Name of the customer for the order
        /// </summary>
        /// <returns></returns>
        public string CustomerName { get; set; }
        /// <summary>
        /// Whether the order is a pickup or delivery
        /// </summary>
        /// <returns></returns>
        public bool IsPickup { get; set; }
        /// <summary>
        /// The address of the customer (intended for delivery)
        /// </summary>
        /// <returns></returns>
        public string Address { get; set; }
        /// <summary>
        /// A list of ordered items
        /// </summary>
        /// <returns></returns>
        List<MenuItemDTO> OrderedItems { get; set; }
    }
}