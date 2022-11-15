
using System.Data;
using MySql.Data.MySqlClient;

namespace AutoGenCode
{
    internal class ModelGenText
    {
        public ModelGenText(string prj, string server, string uid, string pass) 
        {
            myConn = new Connection(server, uid, pass);
            project = prj;
        }

        private Connection myConn = new Connection();
        private string project;

        internal string GenModel(string sche, string pathc)
        {
            try
            {
                DataTable dtsc = new();
                dtsc = myConn.GetTableName(sche);
                if (dtsc.Rows.Count > 0)
                {
                    for (int i = 0; i < dtsc.Rows.Count; i++)
                    {
                        SaveFile(ModelTemplate(sche, dtsc.Rows[i][0].ToString()), pathc, dtsc.Rows[i][0].ToString());
                    }
                }
                return "Successfully Generated Codes";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        private string ModelTemplate(string schema, string tablename) //Get text for each table
        {
            string text = "namespace " + project + ".Models\r\n{\r\n    internal class " + TextAnalyzing(tablename) + "Model\r\n    {\n" + LoopingTable(schema, tablename) + "    }\r\n}";
            return text;
        }

        private string LoopingTable(string schema, string tablename) //Loop Fields and add text
        {
            string tx = "";
            DataTable dt = myConn.GetField(schema, tablename);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string tee = dt.Rows[i]["data_type"].ToString().Trim();
                tx += "        public " + GetDataType(tee) + " " + TextAnalyzing(dt.Rows[i]["Column_name"].ToString()) + " { get; set; }\n";
            }
            return tx;
        }

        private string GetDataType(string? v) //Filter type of field
        {
            if (v == "int" || v == "float")
                return v;
            if (v == "smallint")
                return "float";
            return "string";
        }

        private void SaveFile(string text, string dr, string name)
        {
            // If directory does not exist, create it
            if (!Directory.Exists(dr))
            {
                Directory.CreateDirectory(dr);
            }
            File.WriteAllText(dr + @"\" + TextAnalyzing(name) + "Model.cs", text); //Write file with Name as table_name, in C# class file
        }

        private string TextAnalyzing(string str)
        {
            if (str.Length == 0)
                return "";
            else if (str.Length == 1)
                return char.ToUpper(str[0]).ToString();
            else
                return char.ToUpper(str[0]) + str.Substring(1);
        }

        ~ModelGenText() { }
    }
}
