using Logica.Models;
using P620223_JosueVargasAlvarez.Formularios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P620223_JosueVargasAlvarez
{
    public static class Globales
    {

        public static Form MiFromPrincipal = new Formularios.FrmPrincipalMDI();
        public static Form MiFormMantenimientoUsuarios = new Formularios.FrmUsuariosGestion();
        public static FrmFacturacion MiFormFacturacion = new Formularios.FrmFacturacion();


        public static Usuario MiUsuario = new Usuario();

    }
}
