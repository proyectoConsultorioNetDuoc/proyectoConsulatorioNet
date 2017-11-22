﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using capaDatos;
using System.Data.Entity;

namespace capaNegocio.Control
{
    public class Contadores
    {
        public static int contadorIdPaciente(){
            int max = 0;
            List<capaNegocio.Paciente> pacientes = new List<Paciente>();
            pacientes = PacienteColeccion.GenerarListado();

            foreach (Paciente xx in pacientes.ToList())
            {
                max = xx.Id;
            }

            return max;          
        }

        public static int contadorIdUsuario()
        {
            int max = 0;
            List<capaNegocio.Usuario> usuarios = new List<Usuario>();
            usuarios = UsuarioColeccion.ReadAll();

            foreach (Usuario xx in usuarios.ToList())
            {
                max = xx.Id;
            }
            return max;
        }

        public static int contadorIdSecretaria()
        {
            int max = 0;
            List<capaNegocio.Secretaria> secretarias = new List<Secretaria>();
            secretarias = SecretariaColeccion.ReadAll();

            foreach (Secretaria xx in secretarias.ToList())
            {
                max = xx.Id;
            }
            return max;
        }


        public static int contadorIdFichaPaciente()
        {
            int max = 0;
            List<capaNegocio.FichaPaciente> fichas = new List<FichaPaciente>();
            fichas = FichaPacienteColeccion.ReadAll();

            foreach (FichaPaciente xx in fichas.ToList())
            {
                max = xx.Id_ficha_paciente;
            }
            return max;
        }

        public static int contadoridEnfemera()
        {
            int max = 0;
            List<capaNegocio.FichaPaciente> fichas = new List<FichaPaciente>();
            fichas = FichaPacienteColeccion.ReadAll();

            foreach (FichaPaciente xx in fichas.ToList())
            {
                max = xx.Id_ficha_paciente;
            }
            return max;
        }

    }
}
