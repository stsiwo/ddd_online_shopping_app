using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StsOnlineShopApp.Domain.ProductAggregate
{
    // Entity
    public class Review
    {
        public ReviewId ReviewId { get;  }
        public Author Author { get; set; }
        public Comment Comment { get; set; }
        public ScoreType ScoreType { get; set; }
        public CreationDate CreationDate { get; set; }
    }
}
