using Microsoft.Data.SqlClient;
using System.Data;

namespace PruebaPro.DAO
{
    public static class ClassVariables 
    {

        public static string consultaFuncionario = "select f.id_funcionarios,td.documento, f.numeroIdentificacion,f.telefono,f.fax,f.email,\r\ndp.nombrePais, d.nombreDepartamento, f.paginaWeb\r\nfrom funcionarios f \r\ninner join DepartamentoPais dp ON f.id_ubicacion = dp.id_paisDepartamento \r\ninner join Departamento d ON dp.id_departamento = d.id_departamento\r\ninner join TipoDocumento td ON f.id_tipoDocumento = td.id_tipoDocumento";

        public static string buscar = "select f.id_funcionarios,td.documento, f.numeroIdentificacion,f.telefono,f.fax,f.email,\r\ndp.nombrePais, d.nombreDepartamento, f.paginaWeb\r\nfrom funcionarios f \r\ninner join DepartamentoPais dp ON f.id_ubicacion = dp.id_paisDepartamento \r\ninner join Departamento d ON dp.id_departamento = d.id_departamento\r\ninner join TipoDocumento td ON f.id_tipoDocumento = td.id_tipoDocumento\r\nWHERE f.id_funcionarios ";

        public static string Cadena()
        {
            //IConfigurationBuilder configuration = new ConfigurationBuilder();
            //configuration.AddJsonFile(Path.Combine(Directory.GetCurrentDirectory(),"appsetting.json"));
            //var root = configuration.Build();
            //var cadena = root.GetConnectionString("cn");
            //return cadena;

            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();

            // Acceder a los valores del archivo appsettings.json
            string valor1 = configuration["ConnectionString:cn"];

            return valor1;

        }

        

    }
}
