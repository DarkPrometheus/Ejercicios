using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios.DarkPrometheus.Parte1
{
    public partial class MenuParte1 : Form
    {
        Clases.Varios varios = new Clases.Varios();
        public MenuParte1()
        {
            InitializeComponent();
            OcultarSubMenus();
            lblTitle.Location = new Point(varios.CentrarUnoHorizontalmente(lblTitle.Size.Width, pnlTop.Width));
        }

        void OcultarSubMenus()
        {
            if (pnlSubMenuDisenoAlgoritmos.Visible == true)
                pnlSubMenuDisenoAlgoritmos.Visible = false;
            if (pnlSubMenuCiclos.Visible == true)
                pnlSubMenuCiclos.Visible = false;
            if (pnlSubMenuEstructurasCondicionales.Visible == true)
                pnlSubMenuEstructurasCondicionales.Visible = false;
            if (pnlSubMenuExpreciones.Visible == true)
                pnlSubMenuExpreciones.Visible = false;
            if (pnlSubMenuProgramasSimples.Visible == true)
                pnlSubMenuProgramasSimples.Visible = false;
            if (pnlSubMenuRuteos.Visible == true)
                pnlSubMenuRuteos.Visible = false;
        }

        void MostrarSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                OcultarSubMenus();
                SubMenu.Visible = true;
            }
            else
                SubMenu.Visible = false;
        }

        #region Menus
        #region Expreciones
        private void btnMenuExpreciones_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            DesplegarSubMenu(button.Name);
        }
        private void btnEvaluacion_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Programas simples
        private void btnMenuProgramasSimples_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            DesplegarSubMenu(button.Name);
        }

        private void btnSaludo_Click(object sender, EventArgs e)
        {

        }

        private void btnCirculos_Click(object sender, EventArgs e)
        {
            frmCirculos circulos = new frmCirculos();
            circulos.Dock = DockStyle.Fill;
            AddControl(circulos);
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {

        }

        private void btnConversionDeUnidades_Click(object sender, EventArgs e)
        {

        }

        private void btnNumeroInvertido_Click(object sender, EventArgs e)
        {

        }

        private void btnPitagoras_Click(object sender, EventArgs e)
        {

        }

        private void btnHoraFutura_Click(object sender, EventArgs e)
        {
            frmHoraFutura horaFutura = new frmHoraFutura();
            horaFutura.Dock = DockStyle.Fill;
            AddControl(horaFutura);
        }

        private void btnParteDecimal_Click(object sender, EventArgs e)
        {

        }

        private void btnQueNotaNecesito_Click(object sender, EventArgs e)
        {

        }

        private void btnHuevosALaCopa_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Estructuras condicionales
        private void btnMenuEstructurasCondicionales_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            DesplegarSubMenu(button.Name);
        }

        private void btnDeterminarPar_Click(object sender, EventArgs e)
        {

        }

        private void btnAnosBisiestos_Click(object sender, EventArgs e)
        {

        }

        private void btnDivicion_Click(object sender, EventArgs e)
        {

        }

        private void btnPalabraMasLarga_Click(object sender, EventArgs e)
        {

        }

        private void btnOrdenamiento_Click(object sender, EventArgs e)
        {

        }

        private void btnLetraONumero_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {

        }

        private void btnEdad_Click(object sender, EventArgs e)
        {

        }

        private void btnSetDeTenis_Click(object sender, EventArgs e)
        {

        }

        private void btnTriangulos_Click(object sender, EventArgs e)
        {

        }

        private void btnIndiceDeMasaCorporal_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Ciclos
        private void btnMenuCiclos_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            DesplegarSubMenu(button.Name);
        }

        private void btnMultiplos_Click(object sender, EventArgs e)
        {

        }

        private void btnPotenciasDeDos_Click(object sender, EventArgs e)
        {

        }

        private void btnSumaEntreNumeros_Click(object sender, EventArgs e)
        {

        }

        private void btnTablasDeMultiplicar_Click(object sender, EventArgs e)
        {

        }

        private void btnDivisores_Click(object sender, EventArgs e)
        {

        }

        private void btnTiempoDeViaje_Click(object sender, EventArgs e)
        {

        }

        private void btnDibujosDeAsteriscos_Click(object sender, EventArgs e)
        {

        }

        private void btnPi_Click(object sender, EventArgs e)
        {

        }

        private void btnSumaDeFracciones_Click(object sender, EventArgs e)
        {

        }

        private void btnE_Click(object sender, EventArgs e)
        {

        }

        private void btnSecuenciaDeCollatz_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Ruteos
        private void btnMenuRuteos_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            DesplegarSubMenu(button.Name);
        }

        private void btnOjoConLaIndentacion_Click(object sender, EventArgs e)
        {

        }

        private void btnRuteosVarios_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Diseño de algoritmos
        private void btnMenuDisenoDeAlgoritmos_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            DesplegarSubMenu(button.Name);
        }

        private void btnDigitos_Click(object sender, EventArgs e)
        {

        }

        private void btnDigitoVerificador_Click(object sender, EventArgs e)
        {

        }

        private void btnEcuacionPrimerGrado_Click(object sender, EventArgs e)
        {

        }

        private void btnCaballoDeAjedrez_Click(object sender, EventArgs e)
        {

        }

        private void btnMediaArmonica_Click(object sender, EventArgs e)
        {

        }

        private void btnNumerosPalindromos_Click(object sender, EventArgs e)
        {

        }

        private void btnPalabrasPalindromas_Click(object sender, EventArgs e)
        {

        }

        private void btnChachipun_Click(object sender, EventArgs e)
        {

        }

        private void btnNumerosPrimos_Click(object sender, EventArgs e)
        {

        }

        private void btnElMejorNumero_Click(object sender, EventArgs e)
        {

        }

        private void btnAdivinarElNumero_Click(object sender, EventArgs e)
        {

        }

        private void btnSumaDeTresCubos_Click(object sender, EventArgs e)
        {

        }

        private void btnNumerosDeFibonacci_Click(object sender, EventArgs e)
        {

        }

        private void btnEspiral_Click(object sender, EventArgs e)
        {

        }

        private void btnSumaDeDijitosAlCubo_Click(object sender, EventArgs e)
        {

        }

        private void btnMultiplicacionRusa_Click(object sender, EventArgs e)
        {

        }

        private void btnNumerosAmistosos_Click(object sender, EventArgs e)
        {

        }

        private void btnMetodoDeNewton_Click(object sender, EventArgs e)
        {

        }

        private void btnTrianguloDePascal_Click(object sender, EventArgs e)
        {

        }

        private void btnTorreYAlfil_Click(object sender, EventArgs e)
        {

        }

        private void btnRango_Click(object sender, EventArgs e)
        {

        }

        private void btnValorActualNeto_Click(object sender, EventArgs e)
        {

        }

        private void btnReglamentoDeEvaluaciones_Click(object sender, EventArgs e)
        {

        }

        private void btnVotacionesDeLaCONFECH_Click(object sender, EventArgs e)
        {

        }

        private void btnPromocionConDescuento_Click(object sender, EventArgs e)
        {

        }

        private void btnAlzasDelDolar_Click(object sender, EventArgs e)
        {

        }

        private void btnMaquinaDeAlimentos_Click(object sender, EventArgs e)
        {

        }

        private void btnInterseccionDeCircunferencias_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #endregion

        void DesplegarSubMenu(string nombre)
        {
            switch (nombre)
            {
                case "btnMenuExpreciones":
                    MostrarSubMenu(pnlSubMenuExpreciones);
                    break;
                case "btnMenuProgramasSimples":
                    MostrarSubMenu(pnlSubMenuProgramasSimples);
                    break;
                case "btnMenuEstructurasCondicionales":
                    MostrarSubMenu(pnlSubMenuEstructurasCondicionales);
                    break;
                case "btnMenuCiclos":
                    MostrarSubMenu(pnlSubMenuCiclos);
                    break;
                case "btnMenuRuteos":
                    MostrarSubMenu(pnlSubMenuRuteos);
                    break;
                case "btnMenuDisenoDeAlgoritmos":
                    MostrarSubMenu(pnlSubMenuDisenoAlgoritmos);
                    break;
                default:
                    break;
            }
        }

        private void AddControl(Control control)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(control);
        }

        private void MenuParte1_Resize(object sender, EventArgs e)
        {
            varios.CentrarUnoHorizontalmente(lblTitle.Size.Width, pnlTop.Width);
        }
    }
}
