﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetricaAlexandruLab11.Models;

namespace PetricaAlexandruLab11.Data
{
    public class ShoppingListDatabase
    {
        IRestService restService;
        public ShoppingListDatabase(IRestService service)
        {
            restService = service;
        }
        public Task<List<ShopList>> GetShopListsAsync()
        {
            return restService.RefreshDataAsync();
        }

        public Task SaveShopListAsync(ShopList item, bool isNewItem = true)
        {
            return restService.SaveShopListAsync(item, isNewItem);
        }

        public Task DeleteShopListAsync(ShopList item)
        {
            return restService.DeleteShopListAsync(item.ID);
        }
    }
}
