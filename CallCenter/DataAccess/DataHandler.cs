using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Configuration;
using System.Data.Sql;
using System.Data.SqlClient;



namespace CallCenter
{
    class DataHandler
    {


       
        public  static string conString;
        public static List<Contract> ct = new List<Contract>();
        public static List<Business_Layer.Issues> issue = new List<Business_Layer.Issues>();
        public static DataTable dt;
        public static SqlDataAdapter da;
        public static SqlConnection conn;
        public  static SqlCommandBuilder cb;
        public  void connect()
        {

            conString = ConfigurationManager.ConnectionStrings["Path"].ConnectionString;
            conn = new SqlConnection(conString);
          
            try
            {
                conn.Open();
            }
            catch (Exception)
            {

                throw;
            }

            conn.Close();
        }//first initialized when programm starts

        #region Methods for database
      

        public static void InsertClientInforation(string PersonName, string PersonSurname, int PersonAge, string PhoneNumber, string ClientContract ,string issue)//will insert the  ew client onto the database
        {


            //added for test purposes
            try
            {
               
                int issueID = 0;
                int clientContractid = 0;
                conn.Open();
                string Comm = "SELECT  contractID FROM Contracts WHERE contractDescription= '" + ClientContract + " '";

                SqlCommand comm = new SqlCommand(Comm, conn);
                clientContractid = int.Parse(comm.ExecuteScalar().ToString());
                conn.Close();


                conn.Open();
                Comm = "SELECT  issueID FROM Issues WHERE Issue ='" + issue + "'";

                comm = new SqlCommand(Comm, conn);
                issueID = (int)comm.ExecuteScalar();
                conn.Close();



                conn.Open();
                Comm = "INSERT INTO  Client  (clientName,clientSurname,clientAge,phone,clientContractid,issueid)  VALUES('" + PersonName + "','" + PersonSurname + "'," + PersonAge + ",'" + PhoneNumber + "'," + clientContractid + "," + issueID + ")";
                comm = new SqlCommand(Comm, conn);
                comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {

                Client.FailedInsert();
            }
          

            Client.Inserted();
          


        }
        
      
     
        #endregion

        public void DeleteClient(string name) 
        {
            conn.Open();
            string Comm = "DELETE table  WHERE Name= '" + name + "'";
            SqlCommand comm = new SqlCommand(Comm, conn);
            comm.ExecuteNonQuery();
            conn.Close();
        }//will preform the delete function
        public List<string> GetClientInformation(string phoneNumber) 
        {
            List<string> information = new List<string>();
            dt = new DataTable();
          

            conn.Open();
            string Comm = "SELECT  * FROM Clients ";
            da = new SqlDataAdapter(Comm, conn);
            da.Fill(dt);
            conn.Close();

            foreach (DataRow item in dt.Rows)
            {
                //will procede to creating the client object.
            }
            
            return information;
        }
        public static string GetClientName(string phoneNumber) 
        {
            string name;
            
            dt = new DataTable();
            SqlCommand comm;
           
            
            conn.Open();
            string Comm = "SELECT clientName FROM Client  WHERE phone='"+phoneNumber+"'";
            comm = new SqlCommand(Comm, conn);
            name=(string)comm.ExecuteScalar();
           
         
            conn.Close();
            return name;
        }///
        public static int GetAvailableEmployeeID()
        {

            int id;
            dt = new DataTable();
            SqlCommand comm;
            conn.Open();
            string Comm = "SELECT StaffMemberID FROM StaffMember  WHERE staffAvailable='TRUE' AND staffmemberJobid= (SELECT staffMemberJobID FROM StaffMemberJobs WHERE staffMemberJobName ='Call Assistant')";

            comm = new SqlCommand(Comm, conn);
            id = (int)comm.ExecuteScalar();
            conn.Close();
            return id;
        }//will get the employee id of an emplyee that is free
        public static void GetIssues() 
        {
            
            dt = new DataTable();


            conn.Open();
            string Comm = "SELECT  * FROM Issues ";
            da = new SqlDataAdapter(Comm, conn);
            da.Fill(dt);
            conn.Close();

            foreach (DataRow item in dt.Rows)
            {
                issue.Add(new Business_Layer.Issues((item["Issue"].ToString())));
            }

            
        }
        private string GetContract(string contract) //will get the id for the field that is required
        {
            string iD;
            conn.Open();
            iD= "SELECT  contractID WHERE  contractDescription = '" + contract + "'FROM Contracts ";
            SqlCommand comm = new SqlCommand(iD, conn);
            comm.ExecuteNonQuery();
            
            conn.Close();
            return iD;


        }
        private List<string> Issues() 
        {
            List<string> problems = new List<string>();
            dt = new DataTable();
            

            conn.Open();
            string Comm = "SELECT  issue FROM Issues ";
            da = new SqlDataAdapter(Comm, conn);
            da.Fill(dt);
            conn.Close();

            foreach (DataRow item in dt.Rows)
            {
                problems.Add(item["Issue"].ToString());
            }
            return problems;
        }//gets problems


        private int GetDepartmentid(string departent) //returns the actual id of the department
        {
            int iD;
            string Comm;

            conn.Open();
            Comm = "SELECT  departementID WHERE  departmentID = '" + departent + "'FROM Departments ";
            SqlCommand comm = new SqlCommand(Comm, conn);
            iD = (int)comm.ExecuteScalar();

            conn.Close();
            return iD;

        }
       
        private List<string> GetAvailbeContracts() 
        {
            List<string> contracts = new List<string>();
            dt = new DataTable();
           

            conn.Open();
            string Comm = "SELECT  contractDescription FROM Contracts ";
            da = new SqlDataAdapter(Comm, conn);
            da.Fill(dt);
            conn.Close();

            foreach (DataRow item in dt.Rows)
            {
                contracts.Add(item["contractDescription"].ToString());
            }
            return contracts;
        }//will get the availble contracts
        private List<string> GetJobs() //will get the id for the field that is required
        {
            List<string> jobs = new List<string>();
            dt = new DataTable();
            conn.Open();
            string Comm = "SELECT  staffMemberjobName FROM satffMemberJobs ";
            da=new SqlDataAdapter(Comm,conn);
            da.Fill(dt);  
            conn.Close();

            foreach (DataRow item in dt.Rows)
            {
                jobs.Add(item["staffMemberJobName"].ToString());
            }
            return jobs;

        }
        private List<string> GetPackageServices(int ServiceID) 
        {
            List<string> Services = new List<string>();
            dt = new DataTable();
           

            conn.Open();
            string Comm = "SELECT  serviceName FROM Services WHERE serviceID=',"+ServiceID+"'";
            da = new SqlDataAdapter(Comm, conn);
            da.Fill(dt);
            conn.Close();

            foreach (DataRow item in dt.Rows)
            {
                Services.Add(item["serviceName"].ToString());
            }
            return Services;
        }

        public static  void GetAllcontracts()
        {
           
            dt = new DataTable();


            conn.Open();
            string Comm = "SELECT *FROM Contracts ";
            da = new SqlDataAdapter(Comm, conn);
            da.Fill(dt);
            conn.Close();

            foreach (DataRow item in dt.Rows)
            {
                ct.Add(new Contract(item["contractDescription"].ToString(),decimal.Parse(item["contractPrice"].ToString())));
            }
            
        }
        private List<string> GetAllServices() 
        {
            List<string> Services = new List<string>();
            dt = new DataTable();
           

            conn.Open();
            string Comm = "SELECT  serviceName FROM Services";
            da = new SqlDataAdapter(Comm, conn);
            da.Fill(dt);
            conn.Close();

            foreach (DataRow item in dt.Rows)
            {
                Services.Add(item["serviceName"].ToString());
            }
            return Services;
        }
        private List<string> GetAllPackages()
        {
            List<string> Packages = new List<string>();
            dt = new DataTable();
           

            conn.Open();
            string Comm = "SELECT  packageName FROM packages";
            da = new SqlDataAdapter(Comm, conn);
            da.Fill(dt);
            conn.Close();

            foreach (DataRow item in dt.Rows)
            {
                Packages.Add(item["packageName"].ToString());
            }
            return Packages;
        }
        private List<string> GetAlldepartemnts() 
        {
            List<string> Deprt = new List<string>();
            dt = new DataTable();
            

            conn.Open();
            string Comm = "SELECT  departmentName FROM Departments";
            da = new SqlDataAdapter(Comm, conn);
            da.Fill(dt);
            conn.Close();

            foreach (DataRow item in dt.Rows)
            {
                Deprt.Add(item["packageName"].ToString());
            }
            return Deprt;
        }

      
        private List<string> GetClientType() 
        {

            List<string> types = new List<string>();
            dt = new DataTable();
        
            conn.Open();
            string Comm = "SELECT  clientTypeName FROM ClientType ";
            da = new SqlDataAdapter(Comm, conn);
            da.Fill(dt);
            conn.Close();

            foreach (DataRow item in dt.Rows)
            {
                types.Add(item["TypeName"].ToString());
            }
            return types;
        }//will return the client types that are availble

        public static void SetStaffStatusToFalse(int StaffID) 
        {
           
          

            conn.Open();
            string Comm = "UPDATE  StaffMember SET StaffAvailable='FALSE ' WHERE staffMemberID = " + StaffID;
            SqlCommand comm = new SqlCommand(Comm, conn);
            comm.ExecuteNonQuery();
            conn.Close();

          
           
        }
     


    
      
     
        
    }
}
