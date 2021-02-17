using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class GamerManager : IGamerService
    {
        IGamerDal _gamerDal;
        public GamerManager(IGamerDal gamerDal)
        {
            _gamerDal = gamerDal;
        }
        public void Add(Gamer gamer)
        {
           var result= _gamerDal.Get(gamer);
            foreach (var item in result)
            {
                if (item.IdentityNumber == gamer.IdentityNumber)
                {
                    Console.WriteLine("This user already exist in database");
                }
                else
                {
                    _gamerDal.Add(gamer);
                    Console.WriteLine(gamer.Name + " " + gamer.LastName + " added successfully");
                }
            }
            
        }

        public void Delete(Gamer gamer)
        {
            _gamerDal.Delete(gamer);
            Console.WriteLine(gamer.Name + " " + gamer.LastName + " deleted successfully");
        }

        public List<Gamer> GetAll()
        {
            return _gamerDal.GetAll();
        }

        public void Update(Gamer gamer)
        {
            _gamerDal.Update(gamer);
            Console.WriteLine(gamer.Name + " " + gamer.LastName + " updated successfully");
        }
    }
}
