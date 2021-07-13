﻿using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using JsonConverter = Newtonsoft.Json.JsonConverter;
using System.Dynamic;
using System.Xml;
using System.Data;

namespace Json
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Wybierz Json");
            Console.WriteLine("2. Wybierz  XML");
            string choose = Console.ReadLine();

            if (choose == "1")
            {

                string json = @"{'Table1': [
                                {'Region':'Dublin','Total Adults':'4,054','Male Adults':'2,654','Female Adults':'1,400','Adults Aged 18-24':500,'Adults Aged 25-44':'2,357','Adults Aged 45-64':'1,136','Adults Aged 65+':61,'Number of people who accessed Private Emergency Accommodation':'2,196','Number of people who accessed Supported Temporary Accommodation':'1,914','Number of people who accessed Temporary Emergency Accommodation':26,'Number of people who accessed Other Accommodation':0,'Number of Families':688,'Number of Adults in Families':'1,025','Number of Single-Parent families':351,'Number of Dependants in Families':'1,659'},
                               {'Region':'Mid-East','Total Adults':'327','Male Adults':'223','Female Adults':'104','Adults Aged 18-24':53,'Adults Aged 25-44':'172','Adults Aged 45-64':'91','Adults Aged 65+':11,'Number of people who accessed Private Emergency Accommodation':'197','Number of people who accessed Supported Temporary Accommodation':'127','Number of people who accessed Temporary Emergency Accommodation':3,'Number of people who accessed Other Accommodation':0,'Number of Families':49,'Number of Adults in Families':'68','Number of Single-Parent families':30,'Number of Dependants in Families':'110'},
                                {'Region':'Midlands','Total Adults':'80','Male Adults':'51','Female Adults':'29','Adults Aged 18-24':20,'Adults Aged 25-44':'44','Adults Aged 45-64':'15','Adults Aged 65+':1,'Number of people who accessed Private Emergency Accommodation':'54','Number of people who accessed Supported Temporary Accommodation':'10','Number of people who accessed Temporary Emergency Accommodation':16,'Number of people who accessed Other Accommodation':0,'Number of Families':13,'Number of Adults in Families':'14','Number of Single-Parent families':12,'Number of Dependants in Families':'24'},
                               {'Region':'Mid-West','Total Adults':'286','Male Adults':'198','Female Adults':'88','Adults Aged 18-24':35,'Adults Aged 25-44':'173','Adults Aged 45-64':'73','Adults Aged 65+':5,'Number of people who accessed Private Emergency Accommodation':'51','Number of people who accessed Supported Temporary Accommodation':'202','Number of people who accessed Temporary Emergency Accommodation':33,'Number of people who accessed Other Accommodation':0,'Number of Families':32,'Number of Adults in Families':'38','Number of Single-Parent families':26,'Number of Dependants in Families':'47'},
                                {'Region':'North-East','Total Adults':'91','Male Adults':'67','Female Adults':'24','Adults Aged 18-24':13,'Adults Aged 25-44':'46','Adults Aged 45-64':'22','Adults Aged 65+':10,'Number of people who accessed Private Emergency Accommodation':'22','Number of people who accessed Supported Temporary Accommodation':'50','Number of people who accessed Temporary Emergency Accommodation':19,'Number of people who accessed Other Accommodation':0,'Number of Families':8,'Number of Adults in Families':'10','Number of Single-Parent families':6,'Number of Dependants in Families':'19'},
                               {'Region':'North-West','Total Adults':'83','Male Adults':'55','Female Adults':'28','Adults Aged 18-24':17,'Adults Aged 25-44':'44','Adults Aged 45-64':'21','Adults Aged 65+':1,'Number of people who accessed Private Emergency Accommodation':'38','Number of people who accessed Supported Temporary Accommodation':'29','Number of people who accessed Temporary Emergency Accommodation':13,'Number of people who accessed Other Accommodation':3,'Number of Families':9,'Number of Adults in Families':'10','Number of Single-Parent families':8,'Number of Dependants in Families':'17'},
                                {'Region':'South-East','Total Adults':'178','Male Adults':'132','Female Adults':'46','Adults Aged 18-24':33,'Adults Aged 25-44':'98','Adults Aged 45-64':'41','Adults Aged 65+':6,'Number of people who accessed Private Emergency Accommodation':'40','Number of people who accessed Supported Temporary Accommodation':'138','Number of people who accessed Temporary Emergency Accommodation':0,'Number of people who accessed Other Accommodation':0,'Number of Families':16,'Number of Adults in Families':'23','Number of Single-Parent families':9,'Number of Dependants in Families':'31'},
                               {'Region':'South-West','Total Adults':'495','Male Adults':'348','Female Adults':'147','Adults Aged 18-24':65,'Adults Aged 25-44':'279','Adults Aged 45-64':'135','Adults Aged 65+':16,'Number of people who accessed Private Emergency Accommodation':'324','Number of people who accessed Supported Temporary Accommodation':'175','Number of people who accessed Temporary Emergency Accommodation':0,'Number of people who accessed Other Accommodation':0,'Number of Families':51,'Number of Adults in Families':'60','Number of Single-Parent families':42,'Number of Dependants in Families':'100'},
                                {'Region':'West','Total Adults':'249','Male Adults':'145','Female Adults':'104','Adults Aged 18-24':44,'Adults Aged 25-44':'127','Adults Aged 45-64':'70','Adults Aged 65+':8,'Number of people who accessed Private Emergency Accommodation':'119','Number of people who accessed Supported Temporary Accommodation':'130','Number of people who accessed Temporary Emergency Accommodation':0,'Number of people who accessed Other Accommodation':0,'Number of Families':62,'Number of Adults in Families':'93','Number of Single-Parent families':31,'Number of Dependants in Families':'141'} ] }";

                DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(json);

                DataTable dataTable = dataSet.Tables["Table1"];

                Console.WriteLine(dataTable.Rows.Count);


                foreach (DataRow row in dataTable.Rows)
                {
                    string i = row["Region"].ToString();
                    string ii = row["Total Adults"].ToString();
                    string u = row["Male Adults"].ToString();
                    string r = row["Female Adults"].ToString();
                    string v = row["Adults Aged 18-24"].ToString();
                    string vi = row["Adults aged 25-44"].ToString();
                    string vii = row["Adults Aged 45-64"].ToString();
                    string s = row["Adults Aged 65+"].ToString();
                    string ix = row["Number of people who accessed Private Emergency Accommodation"].ToString();
                    string x = row["Number of people who accessed Supported Temporary Accommodation"].ToString();
                    string xi = row["Number of people who accessed Temporary Emergency Accommodation"].ToString();
                    string xii = row["Number of people who accessed Other Accommodation"].ToString();
                    string w = row["Number of Families"].ToString();
                    string z = row["Number of Adults in Families"].ToString();
                    string zz = row["Number of Single-Parent families"].ToString();
                    string t = row["Number of Dependants in Families"].ToString();

                    Console.WriteLine(i + "-" + ii + "-" + u + "-" + r + "-" + v + "-" + vi + "-" + vii + "-" + s + "-" + ix + "-" + x + "-" + xi + "-" + xii + "-" + w + "-" + z + "-" + zz + "-" + t);
                    Data data = new Data();
                    data.DodajJson(i, ii, u, r, v, vi, vii, s, ix, x, xi, xii, w, z, zz, t);

                    Console.WriteLine("Dodano wiersz");

                }
            } 

            else if(choose =="2")
            {
                int a = 0, b=0, c=0, d=0, e=0, f=0, g=0, h=0, i=0, j=0, k=0, l=0, m=0, n=0, o=0, p=0;
                string[] tab1 = new string[10];
                string[] tab2 = new string[10];
                string[] tab3 = new string[10];
                string[] tab4 = new string[10];
                string[] tab5 = new string[10];
                string[] tab6 = new string[10];
                string[] tab7 = new string[10];
                string[] tab8 = new string[10];
                string[] tab9 = new string[10];
                string[] tab10 = new string[10];
                string[] tab11 = new string[10];
                string[] tab12 = new string[10];
                string[] tab13 = new string[10];
                string[] tab14 = new string[10];
                string[] tab15 = new string[10];
                string[] tab16 = new string[10];

                

                XmlTextReader xtr = new XmlTextReader(@"C:\Users\mkoziatek\Desktop\Projekty\Plik XML JSON\Home.xml");  
                while (xtr.Read())
                {
                    
                     if(xtr.NodeType == XmlNodeType.Element && xtr.Name == "Region")
                    {
                         string a1 = xtr.ReadElementString();
                        Console.WriteLine("Region: " + a1);

                        tab1[a] = a1;
                        a++;
                        
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "Total_Adults")
                    {
                        string a2 = xtr.ReadElementString();
                        Console.WriteLine("Total_Adults :" + a2);

                        tab2[b] = a2;
                        b++;


                        
                        
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "Male_Adults")
                    {
                        string a3 = xtr.ReadElementString();
                        Console.WriteLine("Male_Adults :" + a3);

                        tab3[c] = a3;
                        c++;
                        
                        
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "FeMale_Adults")
                    {
                        string a4 = xtr.ReadElementString();
                        Console.WriteLine("Female_Adults :" + a4);

                        tab4[d] = a4;
                        d++;
                       
                        
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "Adults_Aged_18-24")
                    {
                        string a5 = xtr.ReadElementString();
                        Console.WriteLine("Adults_Aged_18 :" + a5);

                        tab5[e] = a5;
                        e++;
                       
                        
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "Adults_Aged_25-44")
                    {
                        string a6 = xtr.ReadElementString();
                        Console.WriteLine("Adults_Aged_25 :" + a6);

                        tab6[f] = a6;
                        f++;
                        
                        
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "Adults_Aged_45-64")
                    {
                        string a7 = xtr.ReadElementString();
                        Console.WriteLine("Adults_Aged_45 :" + a7);

                        tab7[g] = a7;
                        g++;
                       
                        
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "Adults_Aged_65")
                    {
                        string a8 = xtr.ReadElementString();
                        Console.WriteLine("Adults_Aged_65 :" + a8);

                        tab8[h] = a8;
                        h++;
                       
                        
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "Number_of_people_who_accessed_Private_Emergency_Accommodation")
                    {
                        string a9 = xtr.ReadElementString();
                        Console.WriteLine("Number_of_people_who_accessed_Private_Emergency_Accommodation :" + a9);

                        tab9[i] = a9;
                        i++;
                        
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "Number_of_people_who_accessed_Supported_Temporary_Accommodation")
                    {
                        string a10 = xtr.ReadElementString();
                        Console.WriteLine("Number_of_people_who_accessed_Supported_Temporary_Accommodation :" + a10);

                        tab10[j] = a10;
                        j++;
                        
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "Number_of_people_who_accessed_Temporary_Emergency_Accommodation")
                    {
                        string a11 = xtr.ReadElementString();
                        Console.WriteLine("Number_of_people_who_accessed_Temporary_Emergency_Accommodation :" + a11);

                        tab11[k] = a11;
                        k++;

                        
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "Number_of_people_who_accessed_Other_Accommodation")
                    {
                        string a12 = xtr.ReadElementString();
                        Console.WriteLine("Number_of_people_who_accessed_Other_Accommodation :" + a12);

                        tab12[l] = a12;
                        l++;
                        
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "Number_of_Families")
                    {
                        string a13 = xtr.ReadElementString();
                        Console.WriteLine("Number_of_Families :" + a13);

                        tab13[m] = a13;
                        m++;
                      
                        
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "Number_of_Adults_in_Families")
                    {
                        string a14 = xtr.ReadElementString();
                        Console.WriteLine("Number_of_Adults_in_Families :" + a14);

                        tab14[n] = a14;
                        n++;
                      
                        
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "Number_of_Single-Parent_families")
                    {
                        string a15 = xtr.ReadElementString();
                        Console.WriteLine("Number_of_SingleParent_families :" + a15);

                        tab15[o] = a15;
                        o++;
                        
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "Number_of_Dependants_in_Families")
                    {
                        string a16 = xtr.ReadElementString();
                        Console.WriteLine("Number_of_Dependants_in_Families :" + a16);

                        tab16[p] = a16;
                        p++;
                        
                        
                        
                        Console.WriteLine();
                    }   
                }
                Data data = new Data();
                data.DodajXml(tab1, tab2, tab3, tab4, tab5, tab6, tab7, tab8, tab9, tab10, tab11, tab12, tab13, tab14, tab15, tab16);

                Console.WriteLine("Dodano do bazy");



            }
            Console.ReadKey();

            
        }
    }
}
