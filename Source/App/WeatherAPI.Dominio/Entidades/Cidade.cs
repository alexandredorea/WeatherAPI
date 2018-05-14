using WeatherAPI.Dominio.Entidades.Base;

namespace WeatherAPI.Dominio.Entidades
{
    /// <summary>
    /// Entidade que representa a Cidade
    /// </summary>
    public class Cidade : Identificadores
    {
        /// <summary>
        /// Get e Set do campo Nome da Cidade
        /// </summary>
        public string Nome { get; set; }
    }
}
