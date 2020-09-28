/* Author: Roy Fernandez
 * Class: EventHandlerSelector.cs
 * Purpose: Allows access for the WPF to the Data Solution 
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;

namespace PointOfSale
{
    public class EventHandlerSelector : EventArgs
    {
        public IOrderItem item;
    }
}
