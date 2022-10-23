using EntityLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface IOrderService
    {
        void Create(Order entity);
    }
}
