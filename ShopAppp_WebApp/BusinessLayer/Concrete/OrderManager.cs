using BusinessLayer.Abstract;
using DataLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class OrderManager : IOrderService
    {
        private readonly IUnitofWork _unitofWork;
        public OrderManager(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
        }

        public void Create(Order entity)
        {
            _unitofWork.Orders.Create(entity);
            _unitofWork.Save();
        }
    }
}
