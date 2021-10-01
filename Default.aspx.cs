﻿using RestApp.Controllers;
using RestApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RestApp
{
    public partial class _Default : Page
    {
        private Controller _c;

        public Controller c { get => _c; set => _c = value; }

        protected void Page_Load(object sender, EventArgs e)
        {
            Controller c = new Controller();
            tbl1.DataSource = c.DataList;
            List<TestModelClass> l1 = new List<TestModelClass>();
            l1.Add(c.TestModelClass);
            tbl2.DataSource =l1;
            tbl1.DataBind();
            tbl2.DataBind();
            /*
             * 
            c.GetApiTest();
            c.GetApiTest(2);
            c.PostApiTest(new TestModelClass(1, "example"));
            c.PutApiTest(new TestModelClass(2, "example2"));
            c.DeleteApiTest(2);
            */
        }
        protected void RunGet(object sender, EventArgs e)
        {
            c.GetApiTest();
            tbl1.DataSource = c.DataList;
            tbl1.DataBind();

        }
        protected void RunGetById(object sender, EventArgs e)
        {
           
           c.GetApiTest(Convert.ToInt32(textId.Text));
            List<TestModelClass> l1 = new List<TestModelClass>();
            l1.Add(c.TestModelClass);
            tbl2.DataSource = l1;
            tbl2.DataBind();
        }
        protected void RunPut(object sender, EventArgs e)
        {
            if(textIdField.Text!="") c.PutApiTest(new TestModelClass(Convert.ToInt32(textIdField.Text), textEdit.Text));
            else c.PutApiTest(new TestModelClass(textEdit.Text));

        }
        protected void RunPost(object sender, EventArgs e)
        {
            TestModelClass modelClass = new TestModelClass();
           c.PostApiTest(new TestModelClass(textEdit.Text));
        }
        protected void RunDelete(object sender, EventArgs e)
        {

        }

        protected void Clear(object sender, EventArgs e)
        {
            textId.Text = "";
            textEdit.Text = "";
            tbl1.DataSource = new List<TestModelClass>();
            tbl2.DataSource = new List<TestModelClass>();
            tbl1.DataBind();
            tbl2.DataBind();
        }
    }
}