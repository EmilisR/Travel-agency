using System;

namespace Travel_Agency
{
    [Serializable]
    abstract class User
    {
        public DateTime RegisterDate { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public abstract override string ToString();
    }
}
