﻿namespace Pindaro.Services.OrderAPI.Models.Dto
{
    public class StripeRequestDto
    {
        public string? StripeSessionUrl { get; set; }
        public string? StripeSessionSecret { get; set; }
        public string ApprovedUrl { get; set; }
        public string CancelUrl { get; set; }
        public OrderHeaderDto OrderHeader { get; set; }
    }
}