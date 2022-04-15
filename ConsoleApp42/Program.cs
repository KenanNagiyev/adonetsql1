using System;
using System.Data.SqlClient;

namespace ConsoleApp42
{
    class Program
    {
        private static string connectionString = @"Server = LAPTOP-NRGGF91I\SQLEXPRESS; Database=Cinema;Trusted_Connection=True;";
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            //CreateCustomers("Serxan","Huseynov",24);
            //CreateActors("Nahid", "Mirzeyev", 30);
            //CreateHalls("Nesimi", 60);
            //CreateFilms("Dune", "2022-04-25");
            //CreateGenres("Normal");
            //CreateFilmGenres(2, 2);
            //CreateSessions("12:00");
            //CreatefulmActors(2, 1);
            //CreateTickets("2022-02-30",3,62,1,1,1,1);
            //DeleteSessions(4);
            //DeleteHalls(5);
            //DeleteCustomers(11);
            //DeleteActors(6);
            //DeleteFilms(3);
            //DeleteGenres(3);
            //DeleteFilmGenres(4);
            //DeletefulmActors(5);
            //DeleteTickets(2);
        }
        #region Create_Customers
        static void CreateCustomers(string name, string surname, int age)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"INSERT INTO Customers values(N'{name}',N'{surname}',{age})";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    
                        if (comm.ExecuteNonQuery()>0)
                        {
                            Console.WriteLine("Customer created");
                        }
                        else
                        {
                            Console.WriteLine("Something went wrong");
                        }
                    
                }
            }

        }
        #endregion
        #region Create_Sessionss
        static void CreateSessions(string time)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"INSERT INTO Sessionss values(N'{time}')";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {

                    if (comm.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("Session created");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }

                }
            }

        }
        #endregion
        #region Create_Actors
        static void CreateActors(string name, string surname, int age)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"insert into actors values(n'{name}',n'{surname}',{age})";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    if (comm.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("Actor created");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }
                }
            }

        }
        #endregion
        #region Create_Halls
        static void CreateHalls(string name, int seatcount)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"insert into Halls values(N'{name}',{seatcount})";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    if (comm.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("Hall created");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }
                }
            }

        }
        #endregion
        #region Create_Films
        static void CreateFilms(string name,  string releasedate)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"insert into Films values(N'{name}',N'{releasedate}')";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    if (comm.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("Film created");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }
                }
            }

        }
        #endregion
        #region Create_FilmGenres
        static void CreateFilmGenres(int FilmId, int GenreId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"insert into FilmGenres values({FilmId},{GenreId})";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    if (comm.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("FilmGenres created");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }
                }
            }

        }
        #endregion
        #region Create_Genres
        static void CreateGenres(string name)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"insert into Genres values(N'{name}')";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    if (comm.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("Genres created");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }
                }
            }

        }
        #endregion
        #region Create_fulmActors
        static void CreatefulmActors(int filmid,int actorid)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"insert into fulmActors values({filmid},{actorid})";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    if (comm.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("fulmActors created");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }
                }
            }

        }
        #endregion
        #region Create_Tickets
        static void CreateTickets(string solddate,decimal price,int place,int customerid,int hallid,int filmid,int sessionid)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"insert into Tickets values('{solddate}',{price},{place},{customerid},{hallid},{filmid},{sessionid})";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    if (comm.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("Ticket created");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }
                }
            }

        }
        #endregion
        #region Delete_Customers
        static void DeleteCustomers(int Id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"DELETE Customers WHERE Id = {Id}";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    
                        if (comm.ExecuteNonQuery() > 0)
                        {
                            Console.WriteLine("Customer deleted");
                        }
                        else
                        {
                            Console.WriteLine("Something went wrong");
                        }
                    
                }
            }
        }
        #endregion
        #region Delete_Actors
        static void DeleteActors(int Id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"DELETE Actors WHERE Id = {Id}";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {

                    if (comm.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("Actor deleted");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }

                }
            }
        }
        #endregion
        #region Delete_Halls
        static void DeleteHalls(int Id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"DELETE Halls WHERE Id = {Id}";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {

                    if (comm.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("Hall deleted");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }

                }
            }
        }
        #endregion
        #region Delete_Films
        static void DeleteFilms(int Id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"DELETE Films WHERE Id = {Id}";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {

                    if (comm.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("Film deleted");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }

                }
            }
        }
        #endregion
        #region Delete_Films
        static void DeleteFilmGenres(int Id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"DELETE FilmGenres WHERE Id = {Id}";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {

                    if (comm.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("FilmGenres deleted");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }

                }
            }
        }
        #endregion
        #region Delete_Genres
        static void DeleteGenres(int Id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"DELETE Genres WHERE Id = {Id}";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {

                    if (comm.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("Genres deleted");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }

                }
            }
        }
        #endregion
        #region Delete_Sessions
        static void DeleteSessions(int Id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"DELETE Sessionss WHERE Id = {Id}";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {

                    if (comm.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("Session deleted");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }

                }
            }
        }
        #endregion
        #region Delete_fulmActors
        static void DeletefulmActors(int Id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"DELETE fulmActors WHERE Id = {Id}";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {

                    if (comm.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("fulmActors deleted");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }

                }
            }
        }
        #endregion
        #region Delete_Tickets
        static void DeleteTickets(int Id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"DELETE Tickets WHERE Id = {Id}";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {

                    if (comm.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("Tickets deleted");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }

                }
            }
        }
        #endregion
    }
}
