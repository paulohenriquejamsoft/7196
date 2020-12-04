using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Entities;
using Todo.Domain.Queries;

namespace Todo.Domain.Tests.QueryTests
{
    [TestClass]
    public class TodoQueriesTests
    {
        private List<TodoItem> _items;
        public TodoQueriesTests()
        {
            _items = new List<TodoItem>();
            _items.Add(new TodoItem("Tarefa 1", DateTime.Now, "usuarioA"));
            _items.Add(new TodoItem("Tarefa 2", DateTime.Now, "usuarioA"));
            _items.Add(new TodoItem("Tarefa 3", DateTime.Now, "Paulo Henrique"));
            _items.Add(new TodoItem("Tarefa 4", DateTime.Now, "usuarioA"));
            _items.Add(new TodoItem("Tarefa 5", DateTime.Now, "Paulo Henrique"));
        }

        [TestMethod]
        public void Dada_a_consulta_deve_retornar_tarefas_apenas_do_usuario(){
            var result = _items.AsQueryable().Where(TodoQueries.GetAll("Paulo Henrique"));
            Assert.AreEqual(2, result.Count());
        }
        
    }
}