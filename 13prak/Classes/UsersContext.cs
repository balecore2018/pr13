using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _13prak.Interfaces;
using _13prak.Models;
using System.Collections.Generic;

namespace _13prak.Classes
{
    public class UsersContext : Users, IUsers
    {
        public List<Users> AllUsers;
        public UsersContext() =>
            this.All(out AllUsers);
        public void All(out List<Users> Users)
        {
            Users = new List<Users>();
            AllUsers.Add(new Users(1, "Аликина Ольга"));
            AllUsers.Add(new Users(2, "Бояркин Данил"));
            AllUsers.Add(new Users(3, "Бурмантов Владислав"));
            AllUsers.Add(new Users(4, "Избранное"));
            AllUsers.Add(new Users(5, "ЛП"));
            AllUsers.Add(new Users(6, "Милка"));
            AllUsers.Add(new Users(7, "Богдан"));
            AllUsers.Add(new Users(8, "Вадим Богданов"));
            AllUsers.Add(new Users(9, "Лиза Бартова"));
            AllUsers.Add(new Users(10, "Григор"));
            AllUsers.Add(new Users(11, "Бывшая"));
            AllUsers.Add(new Users(12, "Подруга просто"));
            AllUsers.Add(new Users(13, "Братан"));
            AllUsers.Add(new Users(14, "Сестра"));
            AllUsers.Add(new Users(15, "Жека"));
            AllUsers.Add(new Users(16, "Богдан Вадимов"));
            AllUsers.Add(new Users(17, "Дамир"));
            AllUsers.Add(new Users(18, "Леша Шашин"));
            AllUsers.Add(new Users(19, "Закур Данилин"));
            AllUsers.Add(new Users(20, "Валера"));
        }
    }
}
