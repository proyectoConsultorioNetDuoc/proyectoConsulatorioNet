﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteca.Clases;
using Biblioteca;

namespace Biblioteca.ClasesExterior
{
    public class Desvinculado
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private Usuario usuario;

        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private TipoDesvinculado tipoDesvinculado;

        public TipoDesvinculado TipoDesvinculado
        {
            get { return tipoDesvinculado; }
            set { tipoDesvinculado = value; }
        }
        private String glosa;

        public String Glosa
        {
            get { return glosa; }
            set { glosa = value; }
        }

        public Desvinculado() {
            Init();
        }

        private void Init() {
            id = 0;
            usuario = null;
            fecha = DateTime.Now;
            tipoDesvinculado = null;
            glosa = String.Empty;
        }

        public bool Create() 
        {
            try 
            { 
                
                Consultiorios.DALC.Desvinculado desvinculado = new Consultiorios.DALC.Desvinculado();
                //parte BD                     //parte clase 
                desvinculado.id_desvinculado = this.Id;
                desvinculado.id_usuario = this.Usuario.Id;
                desvinculado.fecha = this.Fecha;
                desvinculado.id_tipo_desvin = this.TipoDesvinculado.Id;
                desvinculado.glosa = this.Glosa;

                CommonBC.ModeloConsultorio.AddToDesvinculado(desvinculado);
                CommonBC.ModeloConsultorio.SaveChanges();


                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public bool Read() 
        {
            try 
            {
                Consultiorios.DALC.Desvinculado desvinculado =
                    CommonBC.ModeloConsultorio.Desvinculado.First
                        (
                            des => des.id_desvinculado == this.Id
                        );

                this.Usuario.Id = desvinculado.id_usuario;
                this.Fecha = (DateTime)desvinculado.fecha;
                this.TipoDesvinculado.Id = desvinculado.id_tipo_desvin;
                this.Glosa = desvinculado.glosa;

                return true;
            }
            catch(Exception ex)
            {
                return false;   
            }
        }

        public bool Update()
        {
            try
            {
                Consultiorios.DALC.Desvinculado desvinculado =
                    CommonBC.ModeloConsultorio.Desvinculado.First
                        (
                            des => des.id_desvinculado == this.Id
                        );

                desvinculado.id_usuario = this.Usuario.Id;
                desvinculado.fecha = this.Fecha;
                desvinculado.id_tipo_desvin = this.TipoDesvinculado.Id;
                desvinculado.glosa = this.Glosa;

                CommonBC.ModeloConsultorio.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete()
        {
            try
            {
                Consultiorios.DALC.Desvinculado desvinculado =
                    CommonBC.ModeloConsultorio.Desvinculado.First
                        (
                            des => des.id_desvinculado == this.Id
                        );


                CommonBC.ModeloConsultorio.DeleteObject(desvinculado);
                CommonBC.ModeloConsultorio.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    
    
    
    }
}