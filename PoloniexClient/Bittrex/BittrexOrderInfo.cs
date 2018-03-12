﻿using CryptoMarketClient.Common;
using System;

namespace CryptoMarketClient.Bittrex {
    public class BittrexOrderInfo : OpenedOrderInfo {
        public string MarketName { get; set; }
		public string OrderUuid { get; set; }
		public string Exchange { get; set; }
        public string QuantityRemainingString { get; set; }
        public string LimitString { get; set; }
        public string CommissionPaidString { get; set; }
        public DateTime Opened { get; set; }
        public DateTime Closed { get; set; }
        public bool CancelInitiated { get; set; }
        public bool ImmediateOrCancel { get; set; }
        public bool IsConditional { get; set; }
        public string Condition { get; set; }
        public string ConditionTarget { get; set; }

        protected override DateTime GetOrderDate() {
            return Opened;
        }
    }
}
