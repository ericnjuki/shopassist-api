﻿using System;
using System.Collections.Generic;
using ShopAssist2.Common.DataTransferObjects;

namespace ShopAssist2.Business.Interfaces {
    public interface ITransactionService {
        IEnumerable<TransactionDto> GetAll(bool includeItems = false);

        TransactionDto GetByTransactionId(int transactionId);

        List<TransactionStatistics> GetStats(DateTime date);

        void RecordTransaction(TransactionDto transaction);
    }
}