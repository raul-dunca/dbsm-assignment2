using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Lab2
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlDataAdapter dateams;
        SqlDataAdapter daplayers;
        DataSet ds;
        BindingSource bsteams;
        BindingSource bsplayers;

        SqlCommandBuilder cmdBuilder;

        string queryTeams;
        string queryPlayers;


        public Form1()
        {
            InitializeComponent();
            FillData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                daplayers.Update(ds, ConfigurationManager.AppSettings.Get("Child_Table"));
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
        }
        string getConnectionString()
        {
            return  "Data Source=DESKTOP-PDRHPCB;" + "Initial Catalog=League of Legends Competition;Integrated Security=true";

        }
        void FillData()
        {
            conn = new SqlConnection(getConnectionString());

            queryPlayers = "Select * From " + ConfigurationManager.AppSettings.Get("Child_Table");
            queryTeams = "Select * From "+ ConfigurationManager.AppSettings.Get("Parent_Table"); ;

            daplayers = new SqlDataAdapter(queryPlayers, conn);
            dateams= new SqlDataAdapter(queryTeams, conn);

            ds=new DataSet();

            dateams.Fill(ds, ConfigurationManager.AppSettings.Get("Parent_Table"));   
            daplayers.Fill(ds, ConfigurationManager.AppSettings.Get("Child_Table"));


            cmdBuilder = new SqlCommandBuilder(daplayers);
             ds.Relations.Add("Relation", ds.Tables[ConfigurationManager.AppSettings.Get("Parent_Table")].Columns[ConfigurationManager.AppSettings.Get("Parent_Table_PK")], 
                ds.Tables[ConfigurationManager.AppSettings.Get("Child_Table")].Columns[ConfigurationManager.AppSettings.Get("Child_Table_FK")]);
            


            bsteams = new BindingSource();
            bsteams.DataSource = ds.Tables[ConfigurationManager.AppSettings.Get("Parent_Table")];



            bsplayers = new BindingSource(bsteams, "Relation");
            // bsplayers = new BindingSource(bsteams, "TeamsPlayer");


            this.teams_gridview.DataSource= bsteams;
            this.palyers_gridview.DataSource= bsplayers;

            cmdBuilder.GetUpdateCommand();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Teams_label.Text = ConfigurationManager.AppSettings["Parent_Table"];
            Players_label.Text = ConfigurationManager.AppSettings["Child_Table"];

        }
    }
}
