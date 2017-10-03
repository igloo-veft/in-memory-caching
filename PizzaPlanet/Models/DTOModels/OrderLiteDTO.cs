using System;

namespace PizzaPlanet.Models.DTOModels
{
    /// <summary>
    /// A minimalized version of an order for using as a list of all orders
    /// </summary>
    public class OrderLiteDTO
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
        /// Name of the customer of the order
        /// </summary>
        /// <returns></returns>
        public string CustomerName { get; set; }
        /// <summary>
        /// Whether the order is a pickup or delivery
        /// </summary>
        /// <returns></returns>
        public bool IsPickup { get; set; }
        /// <summary>
        /// Address of the customer
        /// </summary>
        /// <returns></returns>
        public string Address { get; set; }
    }
}