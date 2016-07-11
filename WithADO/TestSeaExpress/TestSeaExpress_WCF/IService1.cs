using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

using DataBase;
using System.ComponentModel.DataAnnotations;
using System.Collections;

namespace TestSeaExpress_WCF
{
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        List<Person> GetUsers();

        [OperationContract]
        Person GetNewUser();

        [OperationContract]
        void AddUser(Person user);

        [OperationContract]
        void RemoveUser(int idUser);

        [OperationContract]
        void UpdateUser(Person user);

        [OperationContract]
        Person GetuserOnId(int id);

    }

    //[DataContract]
    //public class User
    //{
    //    [Key]
    //    public int UserID { get; set; }

    //    [Required(ErrorMessage = "Фамилия не должна быть пустой")]
    //    [Display(Name = "Фамилия")]
    //    public string FirstName { get; set; }

    //    [Required(ErrorMessage = "Имя не должно быть пустым")]
    //    [Display(Name = "Имя")]
    //    public string LastName { get; set; }

    //    [Display(Name = "Отчество")]
    //    public string MiddleName { get; set; }

    //    [Display(Name = "E-mail")]
    //    public string Email { get; set; }

    //}

}
