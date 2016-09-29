using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace AccesDonnees
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface ISalaries
    {

        [OperationContract]
        Salarie GetEmpById(int empno);

        [OperationContract]
        List<Salarie> GetEmps();

        [OperationContract]
        List<Salarie> GetEmpsByDeptno(int deptno);

        [OperationContract]
        bool NewEmp(string ename, decimal sal, int deptno, int empno);

        [OperationContract]
        bool UpDateEmp(string emane, string job, int mgr, decimal sal, decimal comm, int deptno);

        // TODO: ajoutez vos opérations de service ici
    }

    // Utilisez un contrat de données comme indiqué dans l'exemple ci-après pour ajouter les types composites aux opérations de service.

    [DataContract]
    public class Salarie

    {
        [DataMember]
        public int Empno
        {
            get;
            set;
        }

        [DataMember]
        public int Deptno
        {
            get;
            set;
        }

        [DataMember]
        public string Ename
        {
            get;
            set;
        }

        [DataMember]
        public string Dname
        {
            get;
            set;
        }

        [DataMember]
        public decimal Sal
        {
            get;
            set;
        }
        
    }
}
