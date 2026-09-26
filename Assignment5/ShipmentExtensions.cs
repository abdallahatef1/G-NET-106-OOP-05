using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    internal static class ShipmentExtensions
    {
        public static string GetSummary(this Shipment shipment)
        {
            if (shipment == null)
                return string.Empty;

            string type = shipment.GetType().Name.Replace("Shipment", "");
            if (string.IsNullOrEmpty(type))
                type = "Shipment";

            return $"{shipment.TrackingCode} | {type} | {shipment.Weight} KG | {shipment.GetTrackingStatus()}";
        }

        public static bool IsDelivered(this Shipment shipment)
        {
            if (shipment == null)
                return false;

            return shipment.GetTrackingStatus() == "Delivered";
        }
    }
}
