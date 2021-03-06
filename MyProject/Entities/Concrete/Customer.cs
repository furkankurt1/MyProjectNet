﻿using Entities.Abstract;

namespace Entities.Concrete
{

    public class Customer : IEntity
    {

        public string CustomerId { get; set; }
        public string ContactName { get; set; }
        public string Company { get; set; }
        public string City { get; set; }

    }

}
