using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T_shirt.Models.Models;

namespace T_shirt.Data.Repository.IRepository
{
    public interface IOrderHeaderRepository : IRepository<OrderHeader>
    {

        void Update(OrderHeader obj);

        void UpdateStatus(int id, string orderStatus, string? paymentStatus = null);

        void UpdateStripePaymentID(int id, string sessionId, string paymentIntentId);

    }
}

