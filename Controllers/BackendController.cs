using RestApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestApp
{
    public class BackendController
    {
        private List<TestModelClass> _dataList;

        public List<TestModelClass> DataList { get => _dataList; set => _dataList = value; }

        public BackendController()
        {
            DataList = new List<TestModelClass>();
            DataList.Add(new TestModelClass(1, "Test1"));
            DataList.Add(new TestModelClass(2, "Test2"));
            DataList.Add(new TestModelClass(3, "Test3"));
            DataList.Add(new TestModelClass(4, "Test4"));
            DataList.Add(new TestModelClass(5, "Test5"));

        }
    }
}