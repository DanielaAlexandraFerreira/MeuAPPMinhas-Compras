﻿using MeuAPPMinhas_Compras.Models;
using SQLite;

namespace MeuAPPMinhas_Compras.Helpers
{
    public class SQliteDatabaseHelper
    {
       readonly SQLiteAsyncConnection _conn;

       

       public SQliteDatabaseHelper(string path)
        { 
          _conn = new SQLiteAsyncConnection(path);
          _conn.CreateTableAsync<Produto>().Wait();
        }

    public Task <int> Insert(Produto p) 
     {

            return _conn.InsertAsync(p);
        
     }

    public Task<List<Produto>> Update(Produto p) 
     {
            string sql = "UPDATE Produto SET Descricao=?, Quantidade=?, Preco=? WHERE id=?";

            return _conn.QueryAsync<Produto>(sql, p.Descricao, p.Quantidade, p.Preço, p.Id);
     }

    public Task<int> Delete(int id) 
     {

            return _conn.Table<Produto>().DeleteAsync(i => i.Id == id);
        
     }

    public Task<List<Produto>> GetAll()     
        
     {
            return _conn.Table<Produto>().ToListAsync();  
        
     }

    public Task<List<Produto>> Search(string q) 
        
     {
            string sql = "SELECT * WHERE DESCRICAO like '%%" + q + "%'";

            return _conn.QueryAsync<Produto>(sql);
      }


    }
}
