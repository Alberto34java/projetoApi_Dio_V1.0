using System.Diagnostics;

using MongoDB.Bson.Seralization.Attribute;
using  System;

namespace Uni.Servicos
{
    public class Formacao
    {
       
       [BsonId]
        public int Id { get; set; }
        public string Nome { get; set; }
        
        
    }
}