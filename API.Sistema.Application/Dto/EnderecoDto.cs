﻿using System;
using System.Collections.Generic;
using System.Text;

namespace API.Sistema.Application.Dto
{
    public class EnderecoDto
    {
        public string Cep { get;  set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get;  set; }
        public string UF { get;  set; }
    }
}
