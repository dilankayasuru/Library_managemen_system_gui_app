using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    internal class QuoteTemplate
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id {  get; set; }
        public string Quote { get; set; }
        public string Author { get; set; }

        public QuoteTemplate(string quote, string author) 
        {
            Quote = quote;
            Author = author;
        }
    }
}
