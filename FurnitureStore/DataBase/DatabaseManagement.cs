using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.IO;

namespace FurnitureStore
{
    public class DatabaseManagement
    {
        public UsersRepository usersRepository { get; private set; }
        public ProductsRepository productsRepository { get; private set; }
        static MySqlDataAdapter adapter;
        static DataSet dataSet;
        string connectionString;
        MySqlConnection connection;
        string SQLrequest;
        public bool activeUser;
        public bool activeProduct;
        public bool activeBasket;

        public DatabaseManagement() 
        {
            activeUser = false;
            activeProduct = false;
            activeBasket = false;
            usersRepository = new UsersRepository();
            productsRepository = new ProductsRepository();
        }

        public void ConectTable(string nameTable, ref bool active)
        {
            connectionString = "Data Source=26.138.38.112;Port = 3306;Initial Catalog=mydb;User ID=root;";
            connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                adapter = new MySqlDataAdapter(connection.CreateCommand());
                // выполнение операций с базой данных
                if (!active)
                {
                    SQLrequest = $"SELECT * FROM {nameTable}";
                    adapter.SelectCommand.CommandText = SQLrequest;
                    dataSet = new DataSet();
                    adapter.Fill(dataSet, nameTable);

                    foreach (DataRow row in dataSet.Tables[nameTable].Rows)
                    {
                        switch (nameTable)
                        {
                            case "users":
                                usersRepository.Add(new User(
                                    int.Parse(row[0].ToString()),
                                    row[1].ToString(),
                                    row[2].ToString(), row[3].ToString()));
                                break;

                            case "basket":
                                for (int i = 0; i < usersRepository.GetIdLastUser(); i++)
                                {
                                    if (int.Parse(row[0].ToString()) == usersRepository.GetUser(i + 1).UserId)
                                    {
                                        usersRepository.GetUser(i + 1).basketList.Add(new Basket(
                                            int.Parse(row[1].ToString()),
                                            int.Parse(row[2].ToString())));
                                    }
                                }
                                break;

                            case "products":
                                if (row[4].ToString() == "")
                                {
                                    productsRepository.Add(new Product(
                                    int.Parse(row[0].ToString()),
                                    row[1].ToString(),
                                    row[2].ToString(),
                                    decimal.Parse(row[3].ToString()),
                                    null));
                                }
                                else
                                {
                                    productsRepository.Add(new Product(
                                    int.Parse(row[0].ToString()),
                                    row[1].ToString(),
                                    row[2].ToString(),
                                    decimal.Parse(row[3].ToString()),
                                    (byte[]?)row[4]));
                                }
                                break;
                        }
                    }
                    dataSet.Dispose();
                    //MessageBox.Show("данные успешно получены");
                    active = true;
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
                // обработка ошибок подключения
            }
            finally
            {
                connection.Close();
            }
        }

        public void UpdateTables(string nameTable)
        {
            connectionString = "Data Source=26.138.38.112;Port = 3306;Initial Catalog=mydb;User ID=root;";
            connection = new MySqlConnection(connectionString);
            
            try
            {

                connection.Open();
                adapter = new MySqlDataAdapter(connection.CreateCommand());
                // выполнение операций с базой данных
                if(nameTable == "products" || nameTable == "users")
                {
                    dataSet = new DataSet();
                    SQLrequest = $"DELETE FROM mydb.basket";
                    adapter.SelectCommand.CommandText = SQLrequest;
                    adapter.Fill(dataSet, nameTable);
                    SQLrequest = $"DELETE FROM mydb.{nameTable}";
                    adapter.SelectCommand.CommandText = SQLrequest;
                    adapter.Fill(dataSet, nameTable);
                    FillingInTables(nameTable);
                    FillingInTables("basket");
                }
                else
                {
                    SQLrequest = $"DELETE FROM mydb.{nameTable}";
                    adapter.SelectCommand.CommandText = SQLrequest;
                    dataSet = new DataSet();
                    adapter.Fill(dataSet, nameTable);
                    FillingInTables(nameTable);
                }
                dataSet.Dispose();
               
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
                // обработка ошибок подключения
            }
            finally
            {
                connection.Close();
            }
        }
        
        private void FillingInTables(string nameTable)
        {
            MySqlCommand SQLcommand;
            switch (nameTable)
            {
                case "users":
                    List<User> userList = usersRepository.GetAll();
                    for (int i = 0; i < userList.Count; i++)
                    {
                        SQLcommand = new MySqlCommand($"INSERT INTO mydb.users (user_id, login, password_user, admin_user) " +
                                            $@"VALUES({userList[i].UserId}, " +
                                            $"{'"' + userList[i].Login + '"'}, " +
                                            $"{'"' + userList[i].PaswordUser + '"'}, " +
                                            $"{userList[i].IsAdmin});", connection);
                        SQLcommand.ExecuteScalar();
                    }
                    //MessageBox.Show("данные пользователей успешно заполнены ");
                    break;
                case "products":
                    List<Product> productList = productsRepository.GetAll();
                    for (int i = 0; i < productList.Count; i++)
                    {

                        SQLcommand = new MySqlCommand($"INSERT INTO mydb.products (product_id, product_name, type_furniture, price) " +
                                            $@"VALUES({productList[i].ProductId}, " +
                                            $"{'"' + productList[i].ProductName + '"'}, " +
                                            $"{'"' + productList[i].TypeFurniture + '"'}, " +
                                            $"{productList[i].Price});", connection);
                        SQLcommand.ExecuteScalar();
                        string insertQuery = $"UPDATE `mydb`.`products` SET `Image` = @Image WHERE (`product_id` = {productList[i].ProductId})";
                        MySqlCommand command = new MySqlCommand(insertQuery, connection);
                        command.Parameters.Add("@Image", MySqlDbType.MediumBlob);
                        command.Parameters["@Image"].Value = productList[i].Image;
                        command.ExecuteScalar();

                    }
                   // MessageBox.Show("данные о товарах успешно заполнены ");
                    break;
                case "basket":
                    List<User> users = usersRepository.GetAll();
                    for (int i = 0; i < users.Count; i++)
                    {
                        foreach (var element in users[i].basketList)
                        {
                            SQLcommand = new MySqlCommand($"INSERT INTO mydb.basket " +
                                            $@"VALUES({users[i].UserId}, " +
                                            $"{element.ProductId}, " +
                                            $"{element.Count});", connection);
                            SQLcommand.ExecuteScalar();
                        }

                    }
                    //MessageBox.Show("данные корзины успешно заполнены ");
                    break;
            }
        }

    }
}
