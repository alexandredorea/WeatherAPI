using System;

namespace WeatherAPI.Dominio.Entidades.Base
{
    /// <summary>
    /// Classe abastrata que será herdada pelas demais classes
    /// </summary>
    public abstract class Identificadores
    {
        /// <summary>
        /// Get e Set do campo identidade de todas as tabelas
        /// </summary>
        public Guid Id { get; set; }
    }
}
