using Prueba01.Helpers;
using Prueba01.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;


namespace Prueba01.ViewModels
{
    public class ListViewViewModel
    {
        public List<Friend> Friends { get; set; }
        public ObservableCollection<Grouping<string, Friend>> FriendsObservableCollection { get; set; }

        public ListViewViewModel()
        {
            FriendRepository repository = new FriendRepository();

            Friends = repository.GetAll().ToList();

            FriendsObservableCollection = repository.GetAllGrouped();
        }
    }
}
