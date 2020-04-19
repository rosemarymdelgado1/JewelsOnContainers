﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMVC.Infrastructure
{
    public class ApiPaths
    {
        public static class Catalog
        {
            /*public static string GetAllCatalogItems(string baseUri,
                int page, int take, int? brand, int? type)*/
            public static string GetAllCatalogItems(string baseUri,
                int page, int take, int brand, int type)
            {
                var filterQs = string.Empty;
                if (brand != 0 || type != 0)
                /*if (brand.HasValue || type.HasValue)*/
                {
                    var brandQs = (brand != 0) ? "catalogTypeId=" + brand : "";
                    var typeQs = (type != 0) ? "catalogBrandId=" + type : "";
                    filterQs = $"{typeQs}&{brandQs}";
                    /*var brandQs = (brand.HasValue) ? brand.Value.ToString() : "null";
                    var typeQs = (brand.HasValue) ? type.Value.ToString() : "null";
                    filterQs = $"/type/{typeQs}/brand/{brandQs}";*/
                }
                return $"{baseUri}items?{filterQs}&pageIndex={page}&pageSize={take}";
                /*return $"{baseUri}items{filterQs}?pageIndex={page}&pageSize={take}";*/
            }

            public static string GetAllTypes(string baseUri)
            {
                return $"{baseUri}catalogtypes";
            }
            public static string GetAllBrands(string baseUri)
            {
                return $"{baseUri}catalogbrands";
            }
        }
        public static class Basket
        {

        }
    }
}
