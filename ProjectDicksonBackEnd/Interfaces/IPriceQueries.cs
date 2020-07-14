﻿using System.Collections.Generic;
using ProjectDicksonBackEnd.Models;

namespace ProjectDicksonBackEnd.Repository
{
    public interface IPriceQueries
    {
        string ConnectionStringBuilder();
        List<Drink> GetDrinkUnderPrice(double price);
        public List<Drink> GetDrinkBetweenPrice(double low, double high);
    }
}