using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
   public static class Messages
    {
        //************Car
        public static string CarAdded = "Araba eklendi";

        public static string DescriptionError = "Model adı iki karakterden fazla olmalı";


        public static string CarListed = "Arabalar Listelendi.";
        public static string MaintenanceTime = "Sistem Bakımda.";

        //***********Brand******************

        public static string BrandAdded = "Marka eklendi.";

        public static string BrandDeleted = "Marka silindi";

        public static string BrandsListed = "Markalar Listelendi.";

        //**********Color******************


        public static string ColorAdded = "Renk Eklendi.";
        public static string ColorDeleted = "Renk silindi.";

        public static string ColorListed = "Renkler Listelendi.";

        //**********Rental********************

        public static string RentalNotAdded = "Bu kiralamayı yapamazsınız çünkü araba teslim edilmemiş.";

        public static string RentalAdded = "Araba kiralama yapılmıştır";

        public static string RentalUpdated = "Kiralama bilgileri güncellenmiştir.";
        public static string RentalListed= "Kiralanan arabalar listelenmiştir.";

        //************User****************
        public static string UserAdded = "Kullanıcı Eklendi";

        public static string UserDeleted = "Kullanıcı Silindi";

        public static string UserUpdated = "Kullanıcı Güncellendi.";

        public static string UsersListed = "Kullanıcılar Listelendi.";

        //************Customer**************

        public static string CustomerAdded = "Müşteri başarıyla eklendi.";
        public static string CustomerNotAdded = "Müşteri ismi 5 harften az olamaz !!";

        public static string CustomerUpdated = "Müşteri bilgileri başarıyla güncellendi.";

        public static string CustomerListed = "Müşteriler Listelendi.";

        public static string CustomerRemoved = "Müşteri bilgileri silindi.";
    }
}
