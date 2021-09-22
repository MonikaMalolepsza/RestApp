using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestApp.Models
{
    [Serializable]
    public class TestModelClass
    {
        #region Attributes
        private int _id;
        private string _name;
        #endregion
        #region Properties
        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        #endregion
        #region Constructors
        public TestModelClass()
        {
            Id = 0;
            Name = "";
        }
        public TestModelClass(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public TestModelClass(TestModelClass tmc)
        {
            Id = tmc.Id;
            Name = tmc.Name;
        }
        #endregion
        #region Methods
        public void Kopieren(TestModelClass tmc)
        {
            Id = tmc.Id;
            Name = tmc.Name;
        }
        #endregion
    }
}