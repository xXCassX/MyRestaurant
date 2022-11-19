using MongoDB.Bson;
using MongoDB.Driver;
using MyRestaurant.Entidades;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.PlatformConfiguration.WindowsSpecific;
using System.Linq.Expressions;
using System.Net;
using Xamarin.Forms.PlatformConfiguration;

namespace MyRestaurant
{
    public class Repositorio<T> where T:BaseDTO
    {
        MongoClient client;
        IMongoDatabase db;
        bool resultado;

        public string Error { get; private set; }
        public Repositorio() 
        {

            client = new MongoClient("mongodb+srv://CASS:<12345SERC>@myrestaurandserc.9ekvpfa.mongodb.net/?retryWrites=true&w=majority");
            db = client.GetDatabase("MyRestaurantSERC");
        }

        private IMongoCollection<T> Collection() => db.GetCollection<T>(typeof(T).Name);
        public T Create(T entidad) 
        {
            entidad.Id = ObjectId.GenerateNewId().ToString();
            entidad.FechaHora = DateTime.Now;
            try 
            {
                Collection().InsertOne(entidad);
                Error = "";
                resultado = true;
            }
            catch (Exception ex) 
            {
                Error = ex.Message;
                resultado = false;
            }
            return resultado ? entidad : null;
        }
        
        public IEnumerable<T> Read
        {
            get 
            {
                try 
                {
                    Error = "";
                    return Collection().AsQueryable();
                }
                catch(Exception ex) 
                {
                    Error = ex.Message;
                    return null;
                }
            }
        }

        public T Update(T entidad)
        {
            entidad.FechaHora = DateTime.Now;
            try
            {
                int r = (int)Collection().ReplaceOne(e => e.Id == entidad.Id, entidad).ModifiedCount;
                Error = r == 1 ? "Elemento Modificado":"No se modifico el elemnto";
                resultado = r == 1;
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                resultado = false;
            }
            return resultado ? entidad : null;
        }

        public bool Delete(T entidad)
        {
            try
            {
                int r = (int)Collection().DeleteOne(e => e.Id == entidad.Id).DeletedCount;
                resultado = r == 1;
                Error = resultado ? "Elemento Eliminado" : "No se pudo eliminar el elemento";
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                resultado = false;
            }
            return resultado;
        }

        public T SearchById(string id)
        {
            return Collection().Find(e => e.Id == id).SingleOrDefault();
        }

        public IEnumerable<T> Query(Expression<Func<T,bool>> predicado)
        {
            return Read.Where(predicado.Compile());
        }
    }
}
