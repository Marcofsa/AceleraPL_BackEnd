using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlLivraria.DTOs
{
    internal class UsuarioDTO
    {
        [JsonProperty("ID")]
        public int Id { get; set; }

        [JsonProperty("Nome")]
        public string Nome { get; set; }

        [JsonProperty("Login")]
        public string login { get; set; }

        [JsonProperty("Senha")]
        public string password { get; set; }    


    }
}
