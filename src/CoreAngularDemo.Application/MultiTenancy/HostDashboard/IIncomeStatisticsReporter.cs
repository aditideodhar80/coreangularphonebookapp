using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CoreAngularDemo.MultiTenancy.HostDashboard.Dto;

namespace CoreAngularDemo.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}