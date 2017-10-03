using System;

namespace PizzaPlanet.Models.EntityModels
{
    /// <summary>
    /// Entity model for an order
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Id of an order
        /// </summary>
        /// <returns></returns>
        public int Id { get; set; }
        /// <summary>
        /// The date of when the order was places
        /// </summary>
        /// <returns></returns>
        public DateTime DateOfOrder { get; set; }
        /// <summary>
        /// The name of the customer that ordered
        /// </summary>
        /// <returns></returns>
        public string CustomerName { get; set; }
        /// <summary>
        /// Whether the order is a pickup or delivery
        /// </summary>
        /// <returns></returns>
        public bool IsPickup { get; set; }
        /// <summary>
        /// The address of where the order is to be delivered to
        /// </summary>
        /// <returns></returns>
        public string Address { get; set; }
        /// <summary>
        /// Whether or not the order has been cancelled
        /// </summary>
        /// <returns></returns>
        public bool IsCancelled { get; set; }
    }
}