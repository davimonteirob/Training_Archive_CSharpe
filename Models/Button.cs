using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Training_Archive_Csharp.Models
{
    public class Button
    {
        public enum CoresBotao
        {
            Azul,
            Vermelho,
            Verde
        }
        public string Texto { get; set; }
        public CoresBotao Cor { get; set; }
    }
}