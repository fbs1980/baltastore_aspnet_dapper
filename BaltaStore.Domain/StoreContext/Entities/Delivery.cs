﻿using BaltaStore.Domain.StoreContext.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaltaStore.Domain.StoreContext.Entities
{
    public class Delivery
    {
        public Delivery(DateTime estimatedDeliveryDate)
        {
            CreateDate = DateTime.Now;
            EstimatedDeliveryDate = estimatedDeliveryDate;
            Status = EDeliveryStatus.Waiting;
        }

        public DateTime CreateDate { get; private set; }
        public DateTime EstimatedDeliveryDate { get; private set; }
        public EDeliveryStatus Status { get; private set; }

        public void Shipp()
        {
            //Se a data estimada de entrega for no passado, não entregar.
            Status = EDeliveryStatus.Shipped;   
        }

        public void Cancel()
        {
            //Se o status já estiver entregue, não pode cancelar.
            Status = EDeliveryStatus.Canceled;
        }
    }
}
