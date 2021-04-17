using FoundationStandard.ObjectHydrator;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Prueba01.Helpers;

namespace Prueba01.Model
{
    public class FriendRepository
    {

        public IList<Friend> Friends { get; set; }

        public FriendRepository()
        {
            //install-package objectHydrator
            //Sirve para rellenar de datos clases Default
            Hydrator<Friend> _friendHydrator = new Hydrator<Friend>();

            Friends = _friendHydrator.GetList(50);
        }

        public IList<Friend> GetAll()
        {
            return Friends;
        }

        //Metodo que devuelve una query que ordena el primero nombre por letra
        public IList<Friend> GetAllFirstLetter(string letter)
        {
            var query = from q in Friends
                        where q.firstName.StartsWith(letter)
                        select q;

            return query.ToList();
        }


        //Metodo para por letra, se crea un Helper llamado Grouping que devolvera una coleccion observable que cumpla con el objeto y llave enviada
        public ObservableCollection<Grouping<string, Friend>> GetAllGrouped()
        {
            var sorted = from f in Friends
                         orderby f.firstName
                         group f by f.firstName[0].ToString()
                         into theGroup
                         select new Grouping<string, Friend>(theGroup.Key,theGroup);

            return new ObservableCollection<Grouping<string, Friend>>(sorted);
        }

    }


}
