using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace AccesDonnees
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class ServiceSalarie : ISalaries
    {

        public Salarie GetEmpById(int empno)

        {

            SqlConnection cn = new SqlConnection();
            //cn.ConnectionString = "Data Source =176.31.114.215; Initial Catalog = user11; Persist Security Info = True; User ID = user11; Password = 147user11";
            cn.ConnectionString = WcfService1.Properties.Resources.ConnectionString;
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "GetEmpById";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter param = cmd.CreateParameter();
            param.ParameterName = "@EMPNO";
            param.Value = empno;
            cmd.Parameters.Add(param);
            cmd.ExecuteNonQuery();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            Salarie salarie = new Salarie();

            foreach (DataRow row in dt.Rows)
            {
                salarie.Empno = (int)row["EMPNO"];
                salarie.Deptno = (int)row["DEPTNO"];
                salarie.Ename = row["ENAME"].ToString();

            }

            return salarie;


        }

        public List<Salarie> GetEmps()
        {
            SqlConnection cn = new SqlConnection();
            //cn.ConnectionString = "Data Source =176.31.114.215; Initial Catalog = user11; Persist Security Info = True; User ID = user11; Password = 147user11";
            cn.ConnectionString = WcfService1.Properties.Resources.ConnectionString;
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "GetEmps";
            cmd.CommandType = CommandType.StoredProcedure;

            //SqlParameter param = cmd.CreateParameter();
            //param.ParameterName = "@DEPTNO";
            ////param.Value = deptno;
            //cmd.Parameters.Add(param);
            cmd.ExecuteNonQuery();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            List<Salarie> listSalarie = new List<Salarie>();
            foreach (DataRow row in dt.Rows)
            {
                Salarie salarie = new Salarie();
                salarie.Deptno = (int)row["DEPTNO"];
                salarie.Ename = row["ENAME"].ToString();
                salarie.Empno = (int)row["EMPNO"];

                listSalarie.Add(salarie);
            }
            return listSalarie;
        }

        public List<Salarie> GetEmpsByDeptno(int deptno)
        {
            SqlConnection cn = new SqlConnection();
            //cn.ConnectionString = "Data Source =176.31.114.215; Initial Catalog = user11; Persist Security Info = True; User ID = user11; Password = 147user11";
            cn.ConnectionString = WcfService1.Properties.Resources.ConnectionString;
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "GetEmpsByDeptno";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter param = cmd.CreateParameter();
            param.ParameterName = "@DEPTNO";
            param.Value = deptno;
            cmd.Parameters.Add(param);
            cmd.ExecuteNonQuery();


            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            List<Salarie> listeSalarie = new List<Salarie>();
            foreach (DataRow row in dt.Rows)
            {
                Salarie salarie = new Salarie();
                salarie.Deptno = (int)row["DEPTNO"];
                salarie.Ename = row["ENAME"].ToString();
                salarie.Empno = (int)row["EMPNO"];
                listeSalarie.Add(salarie);
            }
            return listeSalarie;
        }

        public bool NewEmp(string ename, decimal sal, int deptno, int empno)
        {
            SqlConnection cn = new SqlConnection();
            //cn.ConnectionString = "Data Source =176.31.114.215; Initial Catalog = user11; Persist Security Info = True; User ID = user11; Password = 147user11";
            cn.ConnectionString = WcfService1.Properties.Resources.ConnectionString;
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "NewEmp";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter paramEname = cmd.CreateParameter();
            paramEname.ParameterName = "@ENAME";
            paramEname.Value = ename;
            cmd.Parameters.Add(paramEname);

            SqlParameter paramSal = cmd.CreateParameter();
            paramSal.ParameterName = "@SAL";
            paramSal.Value = sal;
            cmd.Parameters.Add(paramSal);

            SqlParameter paramDeptno = cmd.CreateParameter();
            paramDeptno.ParameterName = "@DEPTNO";
            paramDeptno.Value = deptno;
            cmd.Parameters.Add(paramDeptno);

            SqlParameter paramEmpno = cmd.CreateParameter();
            paramEmpno.ParameterName = "@EMPNO";
            paramEmpno.Value = empno;
            cmd.Parameters.Add(paramEmpno);

            cmd.ExecuteNonQuery();

           return true;
        }

        
    }

}


