﻿using System;
using ExpensePrediction.DataAccessLayer.Entities.Users;

namespace ExpensePrediction.DataAccessLayer.Entities.Expenses
{
    public class Transaction<T> : IEntity where T : Category
    {
        public string Id { get; set; }
        public virtual User User { get; set; }
        public double Value { get; set; }
        public virtual T Category { get; set; }
        public DateTime Date { get; set; }
    }
}