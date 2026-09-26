using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    internal abstract partial class Shipment
    {
        private string trackingStatus;
        private void InitializeTracking()
        {
            trackingStatus = "In Transit";
        }
        public string GetTrackingStatus()
        {
            return trackingStatus;
        }

        public void UpdateTrackingStatus(string newStatus)
        {
            if (string.IsNullOrWhiteSpace(newStatus))
                return;

            trackingStatus = newStatus;
            OnTrackingStatusChanged(newStatus);   
        }

        partial void OnTrackingStatusChanged(string newStatus);
        partial void OnTrackingStatusChanged(string newStatus)
        {
            Console.WriteLine($"Tracking status changed to: {newStatus}");
        }



    }
}
