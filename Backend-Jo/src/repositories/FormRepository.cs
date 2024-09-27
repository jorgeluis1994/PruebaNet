using Backend_Jo.src.models;
using Dapper;
using Npgsql;

namespace Backend_Jo.src.repositories
{
    public class FormRepository
    {
        private string _conn;
        public FormRepository( IConfiguration configuration )
        {
            _conn=configuration.GetConnectionString("conn");
        }

        public async Task<IEnumerable<Form>> GetAlls()
        {
            using (NpgsqlConnection dbConnection = new NpgsqlConnection(_conn))
            {
                await dbConnection.OpenAsync();
                var resultado = await dbConnection.QueryAsync<Form>("SELECT * FROM form ");
                return resultado;
            }
        }

    }
}