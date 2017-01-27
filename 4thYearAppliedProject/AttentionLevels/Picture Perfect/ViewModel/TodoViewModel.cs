using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace _4thYearAppliedProject.AttentionLevels.Picture_Perect.ViewModel
{
    public class TodoViewModel
    {
        private static TodoViewModel _todoViewModel = new TodoViewModel();
        private ObservableCollection<Model.Todo> _allToDos = new ObservableCollection<Model.Todo>();

        public ObservableCollection<Model.Todo> AllTodos
        {
            get
            {
                return _todoViewModel._allToDos;
            }
        }

        public IEnumerable<Model.Todo> GetTodos()
        {
            try
            {
                using (MySqlConnection connection =
                new MySqlConnection("YOUR CONNECTION STRING HERE"))
                {
                    connection.Open();
                    MySqlCommand getCommand = connection.CreateCommand();
                    getCommand.CommandText = "SELECT whatToDO FROM todo";
                    using (MySqlDataReader reader = getCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            _todoViewModel._allToDos.Add
                            (new Model.Todo(reader.GetString("whatToDO")));
                        }
                    }
                }
            }
            catch (MySqlException)
            {
                // Handle it <span class="wp-smiley wp-emoji wp-emoji-smile" title=":)">:)</span>
            }
            return _todoViewModel.AllTodos;
        }

        public bool InsertNewTodo(string what)
        {
            Model.Todo newTodo = new Model.Todo(what);
            // Insert to the collection and update DB
            try
            {
                using (MySqlConnection connection =
                new MySqlConnection("YOUR CONNECTION STRING HERE"))
                {
                    connection.Open();
                    MySqlCommand insertCommand = connection.CreateCommand();
                    insertCommand.CommandText =
                    "INSERT INTO todo(whatToDO)VALUES(@whatToDO)";
                    insertCommand.Parameters.AddWithValue("@whatToDO", newTodo.whatToDO);
                    insertCommand.ExecuteNonQuery();
                    _todoViewModel._allToDos.Add(newTodo);
                    return true;

                }
            }
            catch (MySqlException)
            {
                // Don't forget to handle it
                return false;
            }
        }

        public TodoViewModel()
        { }
    }
