﻿using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace Rehber_EL
{
    public class Kisi : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        string id, ad, soy, tel, mail, resim, adres;
        public string ID
        {
            get
            {
                if (id == null)
                    id = Guid.NewGuid().ToString();
                return id;
            }
            set { id = value; }
        }

        //public string Resim  => "person.png";

        public string Resim
        {
            get { return resim; }
            set
            {
                resim = value;
                NotifyPropertyChanged();
            }
        }

        public string Ad
        {
            get => ad;
            set
            {
                ad = value;
                NotifyPropertyChanged();
                NotifyPropertyChanged("AdSoyad");
            }
        }
        public string Soyad
        {
            get => soy;
            set
            {
                soy = value;
                NotifyPropertyChanged();
                NotifyPropertyChanged("AdSoyad");
            }
        }

        [JsonIgnore]
        public string AdSoyad => Ad + " " + Soyad;

        public string Telefon
        {
            get => tel;
            set
            {
                tel = value;
                NotifyPropertyChanged();
            }
        }
        public string Mail
        {
            get => mail;
            set
            {
                mail = value;
                NotifyPropertyChanged();
            }
        }

        public string Adres
        {
            get => adres;
            set
            {
                adres = value;
                NotifyPropertyChanged();
            }
        }


    }
}

