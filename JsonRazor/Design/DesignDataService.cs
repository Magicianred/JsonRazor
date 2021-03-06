﻿using System;
using JsonRazor.Model;

namespace JsonRazor.Design
{
    public class DesignDataService : IDataService
    {
        public void GetData(Action<DataItem, Exception> callback)
        {
            // Use this to create design time data

            var item = new DataItem("{'FirstName':'ABC'}", "First Name: @Model[\"FirstName\"]");
            callback(item, null);
        }
    }
}