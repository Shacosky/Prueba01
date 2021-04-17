using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Prueba01.Views
{
    public class Users : INotifyPropertyChanged
    {
        #region Attributes
        private Int64 userId;
        private string userName;
        private string password;
        private string firstName;
        private string phone;
        private string aboutMe;
        private string errMsj = "";

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Properties
        public Int64 UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
   
        public string FirstName
        {
            get { return firstName; }
            set { 
                firstName = value;
                OnPropertyChanged();
            }
        }
        
        public string Phone
        {
            get { return phone; }
            set 
            { 
                phone = value;
                OnPropertyChanged();
            }
        }

        public string AboutMe
        {
           get => aboutMe;
            set
            {
                aboutMe = value;
                OnPropertyChanged();
            }
        }
        

        public string ErrMsj
        {
            get { return errMsj; }
        }

        #endregion

        #region Constructor
        public Users()
        {
            this.FirstName = "Daniel Perez";
            this.aboutMe = "DevOps";
            this.phone = "942867168";
          
        }
        #endregion

        #region Methods

       
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

    }

}
