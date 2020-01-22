using System;
using System.Collections.Generic;

namespace UnitTestSample.Domain.Contracts
{
    public interface IBookRepository
    {
         List<DateTime> GetByDate(DateTime startDate, DateTime endDate);
    }
}