using SQL_Server_SetUp;

SqlUtillity sqlUtillity = new SqlUtillity();
string connectionString = "Server=DESKTOP-L3O82F7\\SQLEXPRESS;Database=DemoDataBase;User Id=DemoUser;Password=123456;TrustServerCertificate=True";


#region Insert Example

string insertQuery = "INSERT INTO Students (Name, Cgpa, DateOfBirth, IsActice) VALUES (@name, @cgpa, @dob, @active)";

Dictionary<string, object> parameters = new Dictionary<string, object>
{
    { "@name", "John Doe" },
    { "@cgpa", 3.5 },
    { "@dob", new DateTime(2000, 1, 1) },
    { "@active", true }
};

//sqlUtillity.ExecutesSqlCommand(connectionString, insertQuery, parameters);
#endregion


#region Select Example

string selectQuery = "SELECT * FROM Students where cgpa > @mincgpa";

Dictionary<string, object> selectParameters = new Dictionary<string, object>
{
    { "@mincgpa", 3.0 }
};

List<Dictionary<string,object>> results = sqlUtillity.ExecuteSqlQuery(connectionString, selectQuery, selectParameters);
foreach (var row in results)
{
    foreach (var column in row)
    {
        Console.Write(column.Value + "\t");
    }
    Console.WriteLine();
}

#endregion
