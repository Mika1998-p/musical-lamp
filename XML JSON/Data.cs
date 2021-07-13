using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Json
{
    class Data
    {
        private string conString = "Data Source=10.2.11.101;Initial Catalog=Praktyki_;Integrated Security=True";

        public void DodajJson(string i, string ii, string u, string r, string v, string vi, string vii, string s, string ix, string x, string xi, string xii, string w, string z, string zz, string t)
        {
            string zapytanie = "INSERT INTO HomlessJson (Region, Total_Adults, Male_Adults, Female_Adults, Adults_Aged_18, Adults_Aged_25, Adults_Aged_45, Adults_Aged_65, Number_of_people_who_accessed_Private_Emergency_Accommodation, Number_of_people_who_accessed_Supported_Temporary_Accommodation, Number_of_people_who_accessed_Temporary_Emergency_Accommodation, Number_of_people_who_accessed_Other_Accommodation, Number_of_Families, Number_of_Adults_in_Families, Number_of_SingleParent_families, Number_of_Dependants_in_Families)" +
                $"VALUES('{i}','{ii}','{u}','{r}','{v}','{vi}','{vii}','{s}','{ix}','{x}','{xi}','{xii}','{w}','{z}','{zz}','{t}')";

            ModyfikacjaDanych(zapytanie);
        }


        public void DodajXml(string[] tab1, string[] tab2, string[] tab3, string[] tab4, string[] tab5, string[] tab6, string[] tab7, string[] tab8, string[] tab9, string[] tab10, string[] tab11, string[] tab12, string[] tab13, string[] tab14, string[] tab15, string[] tab16)
        {
            for (int q=0; q<9; q++)
                {

                string zapytanie = "INSERT INTO HomelessXml (Region, Total_Adults, Male_Adults, Female_Adults, Adults_Aged_18, Adults_Aged_25, Adults_Aged_45, Adults_Aged_65, Number_of_people_who_accessed_Private_Emergency_Accommodation, Number_of_people_who_accessed_Supported_Temporary_Accommodation, Number_of_people_who_accessed_Temporary_Emergency_Accommodation, Number_of_people_who_accessed_Other_Accommodation, Number_of_Families, Number_of_Adults_in_Families, Number_of_SingleParent_families, Number_of_Dependants_in_Families)" +
                    $"VALUES('{tab1[q]}','{tab2[q]}','{tab3[q]}','{tab4[q]}','{tab5[q]}','{tab6[q]}','{tab7[q]}','{tab8[q]}','{tab9[q]}','{tab10[q]}','{tab11[q]}','{tab12[q]}','{tab13[q]}','{tab14[q]}','{tab15[q]}','{tab16[q]}')";

                ModyfikacjaDanych(zapytanie);
            }
        }



        private void ModyfikacjaDanych(string zapytanie)
          {

              SqlConnection sCon = new SqlConnection(conString);
              SqlCommand cmd = new SqlCommand(zapytanie, sCon);
              sCon.Open();
              cmd.ExecuteNonQuery();
              sCon.Close();

          }
        
    }
}
