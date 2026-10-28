using System.Collections.Generic;
using System.Configuration;
using Microsoft.Data.SqlClient;
using RepoDb;

public class RepositorioGenerico
{
    private readonly string connectionString = ConfigurationManager.ConnectionStrings["SQLServer"]?.ConnectionString 
        ?? "Server=NANY\\SQLEXPRESS;Database=RegistroNotasPOE;Trusted_Connection=True;TrustServerCertificate=True;";

    static RepositorioGenerico()
    {
        // Configurar RepoDB para que trabaje con SQL Server
        GlobalConfiguration.Setup().UseSqlServer();
    }

    private SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }

    // Consultar todos los registros
    public IEnumerable<EstudianteNota> ObtenerTodos()
    {
        using (var connection = GetConnection())
        {
            return connection.QueryAll<EstudianteNota>();
        }
    }

    // Insertar un nuevo estudiante
    public void InsertarEstudiante(EstudianteNota estudiante)
    {
        using (var connection = GetConnection())
        {
            connection.Insert<EstudianteNota>(estudiante);
        }
    }

    // Actualizar un estudiante existente
    public void ActualizarEstudiante(EstudianteNota estudiante)
    {
        using (var connection = GetConnection())
        {
            connection.Update<EstudianteNota>(estudiante);
        }
    }

    // Eliminar un estudiante por su Id
    public void EliminarEstudiante(int id)
    {
        using (var connection = GetConnection())
        {
            connection.Delete<EstudianteNota>(id);
        }
    }
}