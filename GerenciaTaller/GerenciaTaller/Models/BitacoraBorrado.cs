﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GerenciaTaller.Models
{
	public class BitacoraBorrado
	{
		private string identificador;
		private DateTime fechaBorrado;

		public BitacoraBorrado()
		{
		}

		public BitacoraBorrado(string _identificador, DateTime _fechaBorrado)
		{
			this.identificador = _identificador;
			this.fechaBorrado = _fechaBorrado;
		}

		public BitacoraBorrado(string _identificador)
		{
			this.identificador = _identificador;
		}
	}
}