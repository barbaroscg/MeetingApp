using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingApp.Models
{
    public static class Repository
    {
        static Repository(){
            Users.Add(new UserInfo(){
                Id=1,
                Name="Erkin",
                Email="et@gmail.com",
                Phone="9546245",
                WillAttend=true,
            });
            Users.Add(new UserInfo(){
                Id=2,
                Name="Aylin",
                Email="ae@gmail.com",
                Phone="954asd6245",
                WillAttend=false,
            });
             Users.Add(new UserInfo(){
                Id=3,
                Name="Ronmoon",
                Email="raa@gmail.com",
                Phone="923245",
                WillAttend=true,
            });
        }
        public static List<UserInfo> Users { get; set; } = new();

        public static void CreateUser(UserInfo user){
            user.Id = Users.Count+1;
            Users.Add(user);
        }

        public static UserInfo? GetById(int id){
            return Users.FirstOrDefault(u => u.Id == id);
        }

    }
}