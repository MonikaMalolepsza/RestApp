using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestApp.Models
{
    public class TestModelClass
    {
        #region Attributes

        private int _id;
        private string _name;

        #endregion Attributes

        #region Properties

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }

        #endregion Properties

        #region Constructors

        public TestModelClass()
        {
            Id = 0;
            Name = "";
        }

        public TestModelClass(string name)
        {
            var rand = new Random();
            Id = rand.Next();
            Name = name;
        }

        public TestModelClass(int id, string name)
        {
            Id = id;
            Name = name;
        }

        #endregion Constructors

        #region Methods

        public void Copy(TestModelClass tmc)
        {
            Id = tmc.Id;
            Name = tmc.Name;
        }

        #endregion Methods
    }
}