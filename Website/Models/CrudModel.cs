using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using MySql.Data.MySqlClient;
using System.Data;
using Website.Models.Database;

namespace Website.Models
{
    public class CrudModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Autor { get; set; }
        public string Actores { get; set; }
        public string Año { get; set; }
        public string Sipnosis { get; set; }

        public List<CrudModel> Consulta(int? id= null)
        {
            using(MySqlConnection cn = db.dbConnect()) {
                string sql = "SELECT * FROM peliculas ";
                if (id != null)
                {
                    sql += "WHERE id = '" + id + "'";
                }
                return cn.Query<CrudModel>(sql).ToList();
            }
        }

        public bool Insertar(CrudModel model)
        {
            using (MySqlConnection cn = db.dbConnect())
            {
                string sql = "INSERT INTO peliculas (nombre, autor, actores, año, sipnosis) VALUES ('"+ model.Nombre+ "','" + model.Autor + "','" + model.Actores + "','" + model.Año + "','" + model.Sipnosis + "')";
                if (cn.Execute(sql, model) > 0)
                {
                    return true;
                }
                return false;
            }
        }

        public bool Actualizar(CrudModel model)
        {
            using (MySqlConnection cn = db.dbConnect())
            {
                string sql = "UPDATE peliculas SET nombre='" + model.Nombre + "', autor='" + model.Autor + "', actores= '" + model.Actores + "', año='" + model.Año + "', sipnosis = '" + model.Sipnosis + "' WHERE id='"+model.Id+"'  ";
                if (cn.Execute(sql, model) > 0)
                {
                    return true;
                }
                return false;
            }
        }

        public bool Eliminar(int id)
        {
            using (MySqlConnection cn = db.dbConnect())
            {
                string sql = "DELETE FROM peliculas WHERE id='" + id + "'  ";
                if (cn.Execute(sql, cn) > 0)
                {
                    return true;
                }
                return false;
            }
        }
    }
}